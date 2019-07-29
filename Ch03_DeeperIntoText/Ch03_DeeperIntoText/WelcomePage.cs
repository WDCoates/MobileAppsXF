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
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        //HorizontalTextAlignment = TextAlignment.Center,
                        //VerticalTextAlignment = TextAlignment.Center,
                        BackgroundColor = Color.Yellow,
                        TextColor = Color.Red
                        
                    }, 
                    new Label
                    {
                        Text = "Playing With Fonts etc!",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic
                    },
                    new Label
                    {
                        Text = "Text",
                        FormattedText = FString()
                        //Can't use Text and FormattedText at the sometime.
                    }
                }
        };

        static FormattedString FString()
        {
            FormattedString fString = new FormattedString();

            fString.Spans.Add(new Span
            {
                Text = "I "
            });

            fString.Spans.Add(new Span
            {
                Text = "Love ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            });

            fString.Spans.Add(new Span
            {
                Text = "Xamarin.Forms..."
            });


            return fString;
        }
    }
}