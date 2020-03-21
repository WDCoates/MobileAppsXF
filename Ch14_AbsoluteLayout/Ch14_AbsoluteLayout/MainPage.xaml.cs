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

            ButtonS2.Clicked += (sender, args) => { Navigation.PushAsync(new S2_Chessboard()); };

            ButtonS3.Clicked += (sender, args) => { Navigation.PushAsync(new S3_ChessboardDynamic()); };

            ButtonS4.Clicked += (sender, args) => { Navigation.PushAsync(new S4_ChessboardProportional()); };
        }
    }
}
