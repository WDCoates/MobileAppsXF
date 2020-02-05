using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S5_DeviceIndBitmapSize : ContentPage
	{
		public S5_DeviceIndBitmapSize ()
		{
			InitializeComponent ();
		}

        private void Image_SizeChanged(object sender, EventArgs e)
        {
            var image = (Image)sender;
            label.Text = $"Render size = {image.Width:F0} x {image.Height:F0}";
        }
    }
}