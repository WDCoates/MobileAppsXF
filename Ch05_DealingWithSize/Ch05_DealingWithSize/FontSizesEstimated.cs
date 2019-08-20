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

            cView.SizeChanged += OnContentViewSizeChanged;

            Content = cView;

        }

        void OnContentViewSizeChanged(object sender, EventArgs eArgs)
        {

            // Get the 'View' that is changing
            View view = (View)sender;

            var lineHeight = LineHeight();
            var charWidth = 0.5;

            var text = $"A system font created by specifying a size of S has a line height of about ({lineHeight:F1} * S) and " +
                            $"an average character width of about ({charWidth:F1} * S). " +
                            $"On this page, which has a width of {view.Width:F0} and " +
                            $"a height of {view.Height:F0}, a font size of ?1 should comfortably render the ??2 characters in this " +
                            "paragraph with ?3 lines and about ?4 characters per line. Does it work?";

            var charCount = text.Length;
            var fontSize = (int) Math.Sqrt(view.Width * view.Height / (charCount * lineHeight * charWidth));

            var lineCount = (int) (view.Height / (lineHeight * fontSize));
            var charsPerLine = (int) (view.Height / (charWidth * fontSize));

            text = text.Replace("?1", fontSize.ToString());
            text = text.Replace("??2", charCount.ToString());
            text = text.Replace("?3", lineCount.ToString());
            text = text.Replace("?4", charsPerLine.ToString());

            _label.Text = text;
            _label.FontSize = fontSize;

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

        double LineHeight()
        {
            double lineHeight = 1.2d;
            switch (Device.RuntimePlatform)
            {
                case Device.UWP:
                    lineHeight = 1.3d;
                    break;
            }
            return lineHeight;
        }
    }

}