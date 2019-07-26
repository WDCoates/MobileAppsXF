using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch03_DeeperIntoText
{
    public class WelcomePage : ContentPage
    {
        public WelcomePage() => Content = new StackLayout
        {
            Children = {
                    new Label
                    {
                        Text = "Welcome to Xamarin.Forms!",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        //HorizontalTextAlignment = TextAlignment.Center,
                        //VerticalTextAlignment = TextAlignment.Center,
                        BackgroundColor = Color.Yellow,
                        TextColor = Color.Red
                    }
                }
        };
    }
}