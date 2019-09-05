using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch06_ButtonClicks
{
	public class TwoButs : ContentPage
	{
        Button addBut, removeBut;
        private StackLayout sLayout = new StackLayout();

		public TwoButs ()
        {

            addBut = new Button
            {
                Text = "Add",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            addBut.Clicked += OnButClick;
            
            removeBut = new Button
            {
                Text = "Remove",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            removeBut.Clicked += OnButClick;

            Padding = new Thickness(5, 5);

            Content = new StackLayout {
				Children = {
			        new Label { Text = "Welcome to TwoBut in Xamarin.Forms!" },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            addBut, removeBut
                        }
                    },

                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = sLayout
                    }
                }
			};
		}

        private void OnButClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button == addBut)
            {
                sLayout.Children.Add(new Label { Text = $"Add Button clicked at {DateTime.Now:T}" });
            }
            else
            {
                sLayout.Children.RemoveAt(0);
            }

            removeBut.IsEnabled = sLayout.Children.Count > 0;
        }
    }
}