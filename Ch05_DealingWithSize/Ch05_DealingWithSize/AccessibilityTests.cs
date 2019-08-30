using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch05_DealingWithSize
{
    public class AccessibilityTests : ContentPage
    {
        public AccessibilityTests()
        {
            Label testLabel = new Label
            {
                Text = $"FontSize of 20 " + Environment.NewLine + "20 characters across",
                FontSize = 20,
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label displayLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            testLabel.SizeChanged += (sender, args) => { displayLabel.Text = $"{testLabel.Width:f0} \u00D7 {testLabel.Height:f0}";};

            Content = new StackLayout
            {
                Children = {
                    testLabel, displayLabel
                }
            };
        }
    }
}