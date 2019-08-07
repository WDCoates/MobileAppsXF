using System;
using System.Reflection;

using Xamarin.Forms;

namespace Ch04_ScrollingTheStack
{
    public class ColouredBlocks : ContentPage
    {
        public ColouredBlocks()
        {
            var tStack = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to the Reflected Colours Views In Boxes", HorizontalOptions = LayoutOptions.Center }
                },
                BackgroundColor = Color.LightBlue
            };

            var sLayout = new StackLayout
            {
                BackgroundColor = Color.Green,
                Margin = new Thickness(5)
            };

            foreach (var info in typeof(Color).GetRuntimeFields())
            {
                if (info.GetCustomAttribute<ObsoleteAttribute>() != null)
                {
                    continue;   //Next
                }

                if (info.IsPublic && info.IsStatic && info.FieldType == typeof(Color))
                {
                    sLayout.Children.Add(CreateColourView((Color)info.GetValue(null), info.Name));
                }

            }

            tStack.Children.Add(new ScrollView
            {
                Content = sLayout,
                BackgroundColor = Color.Yellow,
                Margin = new Thickness(5)
            });

            Content = tStack;
        }

        View CreateColourView(Color color, string name)
        {
            return new Frame
            {
                BorderColor = Color.Accent,
                Padding = new Thickness(5),
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15,
                    Children =
                    {
                        new BoxView
                        {
                            Color = color
                        },
                        new Label
                        {
                            Text = name,
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            FontAttributes = FontAttributes.Bold,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        },
                        new StackLayout
                        {
                            Children =
                            {
                                new Label
                                {
                                    Text = $"{(int)(255 * color.R):X2}--{(int)(255 * color.G):X2}--{(int)(255 * color.B):X2}",
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    IsVisible = color != Color.Default
                                },
                                new Label
                                {
                                    Text = $"{color.Hue:F2}, {color.Saturation:f2}, {color.Luminosity:F2}",
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    IsVisible = color != Color.Default
                                }
                            },
                            HorizontalOptions = LayoutOptions.End
                        }
                    },
                }
            };
        }
    }
}