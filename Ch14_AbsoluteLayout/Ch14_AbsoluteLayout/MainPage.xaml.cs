using Xamarin.Forms;

namespace Ch14_AbsoluteLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //S3_ResourceBitmapCode ()
            ButtonS1.Clicked += (sender, args) => { Navigation.PushAsync(new S1_AbsoluteDemo()); };
        }
    }
}
