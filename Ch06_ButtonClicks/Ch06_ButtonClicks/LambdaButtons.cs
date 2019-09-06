using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch06_ButtonClicks
{
	public class LambdaButtons : ContentPage
	{
		public LambdaButtons ()
        {
            double number = 1;

            //Create Label for display
            Label label = new Label
            {
                Text = number.ToString(CultureInfo.InvariantCulture),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            //Create first button and click handler
            Button timesButton = new Button
            {
                Text = "Double it",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            timesButton.Clicked += (sender, args) => { number *= 2;
                label.Text = number.ToString(CultureInfo.InvariantCulture);
            };

            //Create second button and click handler
            Button divideButton = new Button
            {
                Text = "Half it",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            divideButton.Clicked += (sender, args) => {
                number /= 2;
                label.Text = number.ToString("N", CultureInfo.InvariantCulture);
            };

            Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Lambda Buttons in Xamarin.Forms!" },
                    label,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children =
                        {
                            timesButton,
                            divideButton
                        }
                    }

				}
			};
		}
	}
}