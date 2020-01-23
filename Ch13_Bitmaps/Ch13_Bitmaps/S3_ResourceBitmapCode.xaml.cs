using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S3_ResourceBitmapCode : ContentPage
	{
		public S3_ResourceBitmapCode ()
		{
			InitializeComponent ();

            //\Ch13_Bitmaps\Images\

            Content = new Image
            {
                Source = ImageSource.FromResource("Ch13_Bitmaps.Images.DSC_0285_256x256.jpg"),  //Watch-out these are case sensitive even for the .ext
                VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center
                //Aspect = Aspect.Fill
            };
        }
    }
}