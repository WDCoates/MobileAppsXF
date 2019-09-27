using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch07_XAMLvsCode
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackViewPage1 : ContentPage
	{
		public StackViewPage1 ()
		{
			InitializeComponent ();

            Label label = new Label
            {
                Text = "Label added in code!",
                IsVisible = true,
                Opacity = 0.75,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Blue,
                BackgroundColor = Color.FromRgb(255, 128, 128),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };
            
            ((StackLayout)Content).Children.Insert(0, label);
            
            Label label2 = new Label
            {
                Text = "Label added in code! No easy way to copy an object in c#!",
                IsVisible = true,
                Opacity = 0.75,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Blue,
                BackgroundColor = Color.FromRgb(255, 128, 128),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var c = ((StackLayout)Content).Children.Count;
            ((StackLayout) Content).Children.Insert(c, label2);
        }
	}
}