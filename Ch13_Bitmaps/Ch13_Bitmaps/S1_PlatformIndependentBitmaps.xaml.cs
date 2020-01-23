using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class S1_PlatformIndependentBitmaps : ContentPage
    {
        public S1_PlatformIndependentBitmaps()
        {
            InitializeComponent();

            string uri = "https://image.shutterstock.com/image-photo/bolide-driving-high-speed-empty-260nw-74982253.jpg";

            S1St1.Children.Add(
                new Image
                {
                    Source = "https://image.shutterstock.com/image-photo/bolide-driving-high-speed-empty-260nw-74982253.jpg"
                }
            );

            S1St1.Children.Add(
                new Image
                {
                    Source = ImageSource.FromUri(new Uri(uri))
                }
            );
            S1St1.Children.Add(
                new Image
                {
                    Source = new UriImageSource
                    {
                            Uri = new Uri("https://image.shutterstock.com/image-photo/bolide-driving-high-speed-empty-260nw-74982253.jpg"),
                            CachingEnabled = false
                    },
                    HorizontalOptions = LayoutOptions.StartAndExpand
                }
            );

        }
    }
}