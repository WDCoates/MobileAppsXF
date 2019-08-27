using System;
using Xamarin.Forms;

namespace Ch05_DealingWithSize
{
    public class ClockFitToSizeLambda : ContentPage
    {
        public ClockFitToSizeLambda()
        {
            Label lClock = new Label
            {
               HorizontalOptions = LayoutOptions.Center,
               VerticalOptions = LayoutOptions.Center
        };

            //SizeChanged event handler
            SizeChanged += (sender, args) =>
            {
                if (this.Width > 0)
                    lClock.FontSize = this.Width / 6;
            };

            Device.StartTimer(TimeSpan.FromSeconds(1), () => { lClock.Text = DateTime.Now.ToString("h:mm:ss tt");
                return true;
            });


            Content = new StackLayout
            {
                Children =
                {
                    lClock
                    
                },
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            
        }
    }
}