using System;

using Xamarin.Forms;

namespace Ch05_DealingWithSize
{
    public class EmpericalFontSize : ContentPage
    {
        private Label label;
        public EmpericalFontSize()
        {

            label = new Label();

            Padding = new Thickness(0, Helper.TTop());
            ContentView cView = new ContentView
            {
                Content = label
            };

            cView.SizeChanged += OnContentViewSizeChanged;
            
            Content = new StackLayout
            {
                Children = {
                    cView
                }
            };
        }

        private void OnContentViewSizeChanged(object sender, EventArgs e)
        {
            View view = (View)sender;

            if (view.Width <= 0 || view.Height <= 0)
                return;

            label.Text = $"This is just some text to try and illustrate how best to fit text to a screen....";

            FontCalc lFontCalc = new FontCalc(label, 10, view.Width);
            FontCalc uFontCalc = new FontCalc(label, 100, view.Width);

            while (uFontCalc.FontSize - lFontCalc.FontSize > 1)
            {
                // Get the average font size
            }

        }
    }
}