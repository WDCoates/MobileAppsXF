using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch02_Labels
{
	public class GreetingsPage : ContentPage
	{
        public GreetingsPage() => Content = new StackLayout
        {
            Children = {
                    new Label { Text = "Welcome to Dave's Xamarin.Forms Chapter Two!"},
                    new Label { Text = "Centered", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center}
                },
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 10))

        };
    }
}