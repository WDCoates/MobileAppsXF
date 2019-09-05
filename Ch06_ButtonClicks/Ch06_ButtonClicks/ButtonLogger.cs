using System;
using Xamarin.Forms;

namespace Ch06_ButtonClicks
{
	public class ButtonLogger : ContentPage
    {
        private StackLayout loggerLayout = new StackLayout();

		public ButtonLogger ()
        {
            //Create the button and attach handler
            Button button = new Button
            {
                Text = $"Log the Click and Time",
                CornerRadius = 10
            };
            button.Clicked += OnButtonClicked;
            loggerLayout.ChildAdded += GetOnChildAdded;

            this.Padding = new Thickness(5, 10);

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Button Logger in Xamarin.Forms!" },
                    button,
                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = loggerLayout
                    }

                }
            };
        }

        private void GetOnChildAdded(object sender, ElementEventArgs e)
        {
            var StackL = (Layout)sender;
            ((Label) ((Layout) sender).Children[StackL.Children.Count-1]).Text += $"!";

        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            loggerLayout.Children.Add(new Label
            {
                Text = $"Button clicked at {DateTime.Now:T}"
            });

            //When loggerLayout is not already defined...
            Button button = (Button)sender;
            
            //Get Parent i.e. the StackLayout
            StackLayout sLayout = (StackLayout) button.Parent;

            //Second Child is the Scroll View
            ScrollView sView = (ScrollView) sLayout.Children[1];

            //The loggerLayout aslong as the layout has not changed not a recommended approach!
            StackLayout sLayout2 = (StackLayout) sView.Content;

        }
    }
}