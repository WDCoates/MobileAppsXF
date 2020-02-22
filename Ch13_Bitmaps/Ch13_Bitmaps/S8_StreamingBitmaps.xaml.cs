using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class S8_StreamingBitmaps : ContentPage
    {
        public S8_StreamingBitmaps()
        {
            InitializeComponent();

            //Load embedded resource to image1
            string resourceID = "Ch13_Bitmaps.Images.DSC_0285_1200x900.jpg";
            Image1.Source = ImageSource.FromStream(() =>
            {
                Assembly assembly = GetType().GetTypeInfo().Assembly;
                var names = assembly.GetManifestResourceNames();
                Stream stream = assembly.GetManifestResourceStream(resourceID);
                return stream;
            });

            //Load web image
            Uri uri = new Uri("https://live.staticflickr.com//65535//49544359511_896b80bdb4_m.jpg");
            WebRequest request = WebRequest.Create(uri);
            request.BeginGetResponse((IAsyncResult arg) =>
            {
                Stream stream = request.EndGetResponse(arg).GetResponseStream();

                if (Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows)
                {
                    MemoryStream memStream = new MemoryStream();
                    stream.CopyTo(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);
                    stream = memStream;
                }

                ImageSource imageSource = ImageSource.FromStream(() => stream);
                Device.BeginInvokeOnMainThread(() => Image2.Source = imageSource);
            }, null);

        }
    }
}