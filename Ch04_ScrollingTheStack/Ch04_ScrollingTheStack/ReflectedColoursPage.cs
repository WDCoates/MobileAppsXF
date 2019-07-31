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

            };

			var sLayout = new StackLayout();

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


            tStack.Children.Add(new ScrollView {Content = sLayout});

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