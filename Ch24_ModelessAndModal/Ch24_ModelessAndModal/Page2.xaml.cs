using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch24_ModelessAndModal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();

            Title = "Page 2";

            Button goBackButton = new Button
            {
                Text = "Back to Main",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            goBackButton.Clicked += async (s, a) => { await Navigation.PopAsync().ConfigureAwait(true); };

            S2.Children.Add(goBackButton);
        }
	}
}