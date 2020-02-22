using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class S4_UsingImgResExt : ContentPage
    {
        public S4_UsingImgResExt()
        {
            InitializeComponent();
        }

        private void OnImageSizeChanged(object sender, EventArgs e)
        {
            var image = (Image)sender;
            BLabel.Text = $"Render size = {image.Width:F0} x {image.Height:F0}";
        }
    }
}