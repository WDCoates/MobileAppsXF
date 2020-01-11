using Xamarin.Forms;

namespace Ch24_ModelessAndModal
{
    internal class ModelessPage : ContentPage
    {
        internal ModelessPage()
        {
            Title = "Modeless Page";

            Button goBackButton = new Button
            {
                Text = "Back to Main",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            goBackButton.Clicked += async (s, a) => { await Navigation.PopAsync().ConfigureAwait(true); };

            Content = goBackButton;
        }
    }
}