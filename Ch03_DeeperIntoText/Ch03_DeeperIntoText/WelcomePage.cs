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
                        FormattedText = FString(),
                        //Can't use Text and FormattedText at the sometime.
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    },
                    new Label
                    {
                        FormattedText = new FormattedString
                        {
                            Spans =
                            {
                                new Span
                                {
                                    Text = "What the..."
                                },
                                new Span
                                {
                                    Text = "Hell is going on here?",
                                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                    FontAttributes = FontAttributes.Bold
                                }
                            }
                        },

                        HorizontalOptions = LayoutOptions.Center
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
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            });

            fString.Spans.Add(new Span
            {
                Text = "Xamarin.Forms..."
            });


            return fString;
        }
    }
}