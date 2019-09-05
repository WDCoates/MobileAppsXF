﻿using System;
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
                Text = $"Log the Click and Time"
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
        }
    }
}