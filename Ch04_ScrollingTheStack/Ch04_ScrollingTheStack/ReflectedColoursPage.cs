using System;
using System.Reflection;

using Xamarin.Forms;

namespace Ch04_ScrollingTheStack
{
	public class ReflectedColoursPage : ContentPage
	{
		public ReflectedColoursPage ()
        {
            var tStack = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to the Reflected Colours Page", HorizontalOptions = LayoutOptions.Center }
                },
                BackgroundColor = Color.LightBlue
            };

			var sLayout = new StackLayout
            {
                BackgroundColor = Color.Green,
                Margin = new Thickness(5),
                HorizontalOptions = LayoutOptions.Start,
                Orientation = StackOrientation.Horizontal

            };

            foreach (var info in typeof(Color).GetRuntimeFields())
            {
                if (info.GetCustomAttribute<ObsoleteAttribute>() != null)
                {
                    continue;   //Next
                }

                if (info.IsPublic && info.IsStatic && info.FieldType == typeof(Color))
                {
                    sLayout.Children.Add(CreateColorLabel((Color) info.GetValue(null), info.Name));
                }

            }

            foreach (var info in typeof(Color).GetRuntimeProperties())
            {
                var mInfo = info.GetMethod;

                if (mInfo.IsPublic && mInfo.IsStatic && mInfo.ReturnType == typeof(Color))
                {
                    sLayout.Children.Add(
                        CreateColorLabel((Color)info.GetValue(null), info.Name));
                }
            }


            tStack.Children.Add(new ScrollView {Content = sLayout, 
                BackgroundColor = Color.Yellow, Margin = new Thickness(5)
                , Orientation = ScrollOrientation.Horizontal
            });

            tStack.Children.Add(new ScrollView
            {
                Content = new Label { Text = "This hasn't a hope in hell!" + Environment.NewLine +
                                             "aas" + Environment.NewLine +
                                             "asas" + Environment.NewLine +
                                             "asasasasas" + Environment.NewLine +
                                             "asasasasa" + Environment.NewLine +
                                             "asasasssssssssssssssss" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "assssssssssssssssssssssssss" + Environment.NewLine +
                                             "asasasa" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "as" + Environment.NewLine +
                                             "asasas" + Environment.NewLine + Environment.NewLine +
                                             "as" + Environment.NewLine +
                                             "asasasas " + Environment.NewLine +
                                             "asasasas " + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "asasa " + Environment.NewLine +
                                             "asasa " + Environment.NewLine +
                                             "asasas " + Environment.NewLine +
                                             "aas" + Environment.NewLine +
                                             "asas" + Environment.NewLine +
                                             "asasasasas" + Environment.NewLine +
                                             "asasasasa" + Environment.NewLine +
                                             "asasasssssssssssssssss" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "assssssssssssssssssssssssss" + Environment.NewLine +
                                             "asasasa" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "as" + Environment.NewLine +
                                             "asasas" + Environment.NewLine + Environment.NewLine +
                                             "as" + Environment.NewLine +
                                             "asasasas " + Environment.NewLine +
                                             "asasasas " + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "asasa " + Environment.NewLine +
                                             "asasa " + Environment.NewLine +
                                             "asasas " + Environment.NewLine +
                                             "aas" + Environment.NewLine +
                                             "asas" + Environment.NewLine +
                                             "asasasasas" + Environment.NewLine +
                                             "asasasasa" + Environment.NewLine +
                                             "asasasssssssssssssssss" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "assssssssssssssssssssssssss" + Environment.NewLine +
                                             "asasasa" + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "as" + Environment.NewLine +
                                             "asasas" + Environment.NewLine + Environment.NewLine +
                                             "as" + Environment.NewLine +
                                             "asasasas " + Environment.NewLine +
                                             "asasasas " + Environment.NewLine +
                                             "asasas" + Environment.NewLine +
                                             "asasa " + Environment.NewLine +
                                             "asasa " + Environment.NewLine +
                                             "asasas " + Environment.NewLine +
                                             "assssssssssssssssss" },
                BackgroundColor = Color.Pink,
                Margin = new Thickness(5),
                VerticalOptions = LayoutOptions.Start
            });

            tStack.Children.Add(new Label
            {
                Text = "Last but not least!"
                , VerticalOptions = LayoutOptions.EndAndExpand
            });

            Content = tStack;
            
        }

        private Label CreateColorLabel(Color getValue, string infoName)
        {
            Color backgroundColour = Color.Default;

            if (getValue != Color.Default)
            {
                double luminance = 0.30 * getValue.R + 0.59 * getValue.G + 0.11 * getValue.B;
                backgroundColour = luminance > 0.5 ? Color.Black : Color.White;
            }

            return new Label {Text = infoName, TextColor = getValue, BackgroundColor = backgroundColour};
        }
    }
}