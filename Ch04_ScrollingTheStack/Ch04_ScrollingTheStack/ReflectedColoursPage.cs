using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using Xamarin.Forms;

namespace Ch04_ScrollingTheStack
{
	public class ReflectedColoursPage : ContentPage
	{
		public ReflectedColoursPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to the Reflected Colours Page", HorizontalOptions = LayoutOptions.Center }
				}
			};

            foreach (var info in typeof(Color).GetRuntimeFields())
            {

            }
		}
	}
}