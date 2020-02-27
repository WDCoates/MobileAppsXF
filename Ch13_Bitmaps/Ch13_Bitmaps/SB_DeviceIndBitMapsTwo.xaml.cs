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
	public partial class SB_DeviceIndBitMapsTwo : ContentPage
	{
		public SB_DeviceIndBitMapsTwo ()
		{
			InitializeComponent ();
		}

        private string AssetFile()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    return "icon.png";
                case Device.UWP:
                    return "Assets/LargeTile.png";
            }

            return null;
        }

        private void OnImageTapper(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            image.Opacity = 0.75;

            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                image.Opacity = 1;
                return false;
            });

            Label1.Text = $"Rendered Image is {image.Width} x {image.Height}";
        }
    }
}