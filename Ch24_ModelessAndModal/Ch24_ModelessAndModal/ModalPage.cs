using Xamarin.Forms;

namespace Ch24_ModelessAndModal
{
    internal class ModalPage : ContentPage
    {
        internal ModalPage()
        {
            Title = "Modal Page";

            var goBackButton = new Button
            {
                Text = "Back to Main",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.End
            };

            goBackButton.Clicked += async (s, a) => { await Navigation.PopModalAsync().ConfigureAwait(true); };

            Content = goBackButton;
        }
    }
}