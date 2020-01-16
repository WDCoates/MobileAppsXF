using Xamarin.Forms;

namespace Ch13_Bitmaps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Chapter 13 Bitmaps";

            Button1.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new S1_PlatformIndependentBitmaps());
            };
        }
    }
}
