using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch05_DealingWithSize
{
    public class FontSizesEstimated : ContentPage
    {
        private Label _label;
        
        public FontSizesEstimated()
        {
            _label = new Label();
            Padding = new Thickness(0, TTop(), 0, 0);
            ContentView cView = new ContentView
            {
                Content = _label
            };

        }

        double TTop()
        {
            double top = 0.0d;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    top = 20d;
                    break;
                case Device.Android:
                    top = 10d;
                    break;
                case Device.UWP:
                    top = 20d;
                    break;
            }

            return top;
        }
    }

}