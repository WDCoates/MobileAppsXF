using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch06_ButtonClicks
{
    public class KeyPad : ContentPage
    {
        private Label displayLabel;
        private Button backspaceButton;
        public KeyPad()
        {

            StackLayout mainStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            
            //First row is the Label
            displayLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.End
            };

            mainStack.Children.Add(displayLabel);

            //Second Row is the backspace button
            backspaceButton = new Button
            {
                Text = "\u21E6",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                IsEnabled = false
            };
            backspaceButton.Clicked += OnBackspaceButtonClicked;
            mainStack.Children.Add(backspaceButton);

            //Get Saved Data
            IDictionary<string, object> appProps = Application.Current.Properties;
            if (appProps.ContainsKey("displayLabelText"))
            {
                displayLabel.Text = appProps["displayLabelText"] as string;
                backspaceButton.IsEnabled = displayLabel.Text?.Length > 0;
            }


            //Next the 10 number keys
            StackLayout numberStack = null;

            for (int num = 9; num > -1; num--)
            {
                if ((num) % 3 == 0)
                {
                    numberStack = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal
                    };
                    mainStack.Children.Add(numberStack);
                }

                Button nButton = new Button
                {
                    Text = (num).ToString(),
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                    StyleId = num.ToString()
                };
                nButton.Clicked += OnNumButtonClicked;

                if (num == 0)
                {
                    nButton.HorizontalOptions = LayoutOptions.FillAndExpand;
                }

                numberStack?.Children.Add(nButton);
            }

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to KeyPad - Xamarin.Forms!", HorizontalOptions = LayoutOptions.Center },
                    mainStack
                },
                Padding = new Thickness(10)
            };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void OnNumButtonClicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text == "0" ? "" : displayLabel.Text;
            Button but = (Button)sender;
            displayLabel.Text += (string) but.StyleId;
            backspaceButton.IsEnabled = true;
            Application.Current.Properties["displayLabelText"] = displayLabel.Text;
        }

        private void OnBackspaceButtonClicked(object sender, EventArgs e)
        {
            string text = displayLabel.Text;
            displayLabel.Text = text.Substring(0, text.Length - 1);
            backspaceButton.IsEnabled = displayLabel.Text.Length > 0;
            Application.Current.Properties["displayLabelText"] = displayLabel.Text;
        }
    }
}