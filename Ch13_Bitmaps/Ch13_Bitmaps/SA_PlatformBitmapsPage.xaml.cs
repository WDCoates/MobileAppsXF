using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SA_PlatformBitmapsPage : ContentPage
    {
        public SA_PlatformBitmapsPage()
        {
            InitializeComponent();

            var dec = 0.0123456789m;
            var test = $" https://docs.microsoft.com/en-us/dotnet/standard/base-types/formatting-types Dec => {dec:G4};";

            Label labelDec = new Label
            {
                Text = test,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Image image = new Image
            {
                Source = new FileImageSource
                {
                    File = AssetFile()
                },
                Aspect = Aspect.Fill,
                BackgroundColor = Color.Blue,
                HorizontalOptions = LayoutOptions.CenterAndExpand, VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label label = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.CenterAndExpand
            };

            image.SizeChanged += (sender, args) => { label.Text = $"Rendered size = {image.Width} x {image.Height}"; };

            Content = new StackLayout
            {
                Children =
                {
                    labelDec,
                    image,
                    label
                }
            };
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
    }
}