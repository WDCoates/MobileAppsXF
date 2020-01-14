using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch24_ModelessAndModal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            Title = "Page 1";

            //NavigationPage.SetHasBackButton(this, false); //Can also be done through XAML
            
            //NavigationPage.SetTitleIcon()     //Complete when finished chapter 13....

            Button goBackButton = new Button
            {
                Text = "Back to Main",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            goBackButton.Clicked += async (s, a) => { await Navigation.PopAsync().ConfigureAwait(true); };

            S1.Children.Add(goBackButton);
        }
	}
}