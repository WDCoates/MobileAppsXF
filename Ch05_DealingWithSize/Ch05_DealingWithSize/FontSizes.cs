using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch05_DealingWithSize
{
	public class FontSizes : ContentPage
	{
		public FontSizes ()
		{
            BackgroundColor = Color.White;

			StackLayout topStack = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
			};


            //NameSize Values
            NamedSize[] nSizes =
            {
                NamedSize.Default, NamedSize.Large, NamedSize.Medium, NamedSize.Small, NamedSize.Micro
            };

            foreach (var n in nSizes)
            {
                var fontSize = Device.GetNamedSize(n, typeof(Label));
                topStack.Children.Add(new Label
                {
                    Text = $"Named Size is {n} ({fontSize:F2})",
                    FontSize = fontSize,
                    TextColor = Color.Black
                });
            }

            //Draw horizontal seperator line!
            topStack.Children.Add(new BoxView
            {
                Color = Color.Accent,
                HeightRequest = 2
            });

            //Do some numeric shit with point sizes.
            int[] pSizes = {4, 6, 8, 10, 12, 14, 16};
            foreach (var p in pSizes)
            {
                var fontSize = 160 * p / 72;

                topStack.Children.Add(new Label
                {
                    Text = $"Point Size is {p} ({fontSize:F2})",
                    FontSize = fontSize,
                    TextColor = Color.Black
                });
            }

            Content = topStack;
        }
	}
}