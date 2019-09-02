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

            Content = cView;
        }

        private void OnContentViewSizeChanged(object sender, EventArgs e)
        {
            View view = (View)sender;

            if (view.Width <= 0 || view.Height <= 0)
                return;

            label.Text = $"This is just some text to try and illustrate how best to fit text to a screen....View Width !!; Font Size is ??";

            FontCalc lFontCalc = new FontCalc(label, 10, view.Width);
            FontCalc uFontCalc = new FontCalc(label, 100, view.Width);

            while (uFontCalc.FontSize - lFontCalc.FontSize > 1)
            {
                // Get the average font size
                var fontSize = (lFontCalc.FontSize + uFontCalc.FontSize) / 2;
                // Check the new text height against the container height.
                FontCalc newFontCalc = new FontCalc(label, fontSize, view.Width);

                if (newFontCalc.TextHeight > view.Height)
                {
                    uFontCalc = newFontCalc;
                }
                else
                {
                    lFontCalc = newFontCalc;
                }
            }

            //Set the final font size
            label.FontSize = lFontCalc.FontSize;
            label.Text = label.Text.Replace("!!", view.Width.ToString("F0"));
            label.Text = label.Text.Replace("??", label.FontSize.ToString("F0"));
        }
    }
}