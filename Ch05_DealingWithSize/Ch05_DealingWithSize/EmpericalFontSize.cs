using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            
            
            
            Content = new StackLayout
            {
                Children = {
                }
            };
        }
    }
}