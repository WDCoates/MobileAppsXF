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

            Button2.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new S2_SmallBitmapImageOnly());
            };

            //S3_ResourceBitmapCode ()
            Button3.Clicked += (sender, args) => { Navigation.PushAsync(new S3_ResourceBitmapCode());  };

            //S4_UsingImgResExt()
            Button4.Clicked += (sender, args) => { Navigation.PushAsync(new S4_UsingImgResExt());      };

            //S5_DeviceIndBitmapSize()
            Button5.Clicked += (sender, args) => { Navigation.PushAsync(new S5_DeviceIndBitmapSize()); };

            //S6_MadStJamesPark()
            Button6.Clicked += (sender, args) => { Navigation.PushAsync(new S6_MadStJamesPark()); };
            
            //S7_ImageBrowser()
            Button7.Clicked += (sender, args) => { Navigation.PushAsync(new S7_ImageBrowser()); };

            //S8_Streaming Bitmaps
            Button8.Clicked += (sender, args) => { Navigation.PushAsync(new S8_StreamingBitmaps()); };

            //S9_BitmapMaker ()
            Button9.Clicked += (sender, args) => { Navigation.PushAsync(new S9_BitmapMaker()); };

            //SA_PlatformBitmapsPage()
            ButtonA.Clicked += (sender, args) => { Navigation.PushAsync(new SA_PlatformBitmapsPage()); };
        }
    }
}
