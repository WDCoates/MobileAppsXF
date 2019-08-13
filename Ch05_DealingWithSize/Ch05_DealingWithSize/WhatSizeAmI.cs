using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch05_DealingWithSize
{
	public class WhatSizeAmI : ContentPage
    {
        private readonly Label WidthXHight;
        
		public WhatSizeAmI ()
        {

            WidthXHight = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            WidthXHight = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };



            Content = WidthXHight;

            SizeChanged += OnPageSizeChanged;
		}

        void OnPageSizeChanged(object sender, EventArgs args)
        {
            WidthXHight.Text = $"{Width} \u00D7 {Height}";
        }
	}
}