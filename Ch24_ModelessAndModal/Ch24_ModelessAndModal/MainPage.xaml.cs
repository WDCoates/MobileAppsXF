using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ch24_ModelessAndModal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Main Page";

            Button gotoModelessButton = new Button
            {
                Text = "Go to Modeless Page",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            gotoModelessButton.Clicked += async (sender, args) => { await Navigation.PushAsync(new ModelessPage()).ConfigureAwait(true); };

            Button gotoModalButton = new Button
            {
                Text = "Go to Modal Page",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            gotoModalButton.Clicked += async (sender, args) => { await Navigation.PushModalAsync(new ModalPage(), true).ConfigureAwait(true); };

            Button gotoPage1Button = new Button
            {
                Text = "Go to Modeless Page 1 with backing XAML!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            gotoPage1Button.Clicked += async (sender, args) => { await Navigation.PushAsync(new Page1(), true).ConfigureAwait(true); };

            Stack_1.Children.Add(gotoModelessButton);
            Stack_1.Children.Add(gotoModalButton);
            Stack_1.Children.Add(gotoPage1Button);
        }
    }

}
