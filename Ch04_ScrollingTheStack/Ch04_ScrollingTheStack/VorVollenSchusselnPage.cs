using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace Ch04_ScrollingTheStack
{
	public class VorVollenSchusselnPage : ContentPage
	{
		public VorVollenSchusselnPage ()
        {
            StackLayout mainStack = new StackLayout();
            StackLayout textStack = new StackLayout
            {
                Padding = new Thickness(5),
                Spacing = 10
            };

            //Get the document
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            var resourceIDs = assembly.GetManifestResourceNames();

            var resource = "Ch04_ScrollingTheStack.Documents.VorVollenSchusseln.txt";
            
            using(var stream = assembly.GetManifestResourceStream(resource))
            {

                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        bool gotTitle = false;
                        string line;

                        //Read in line or paragraph.
                        while (null != (line = reader.ReadLine()))
                        {
                            Label label = new Label
                            {
                                Text = line,
                                TextColor = Color.Black
                            };
                            if (!gotTitle)
                            {
                                //First Line is the title.
                                label.HorizontalOptions = LayoutOptions.Center;
                                label.FontSize = Device.GetNamedSize(NamedSize.Large, label);
                                label.FontAttributes = FontAttributes.Bold;
                                mainStack.Children.Add(label);
                                gotTitle = true;
                            }
                            else
                            {
                                textStack.Children.Add(label);
                            }
                        }
                    } 
                }
            };

            //Put textStack in a ScrollView
            ScrollView sView = new ScrollView
            {
                Content = textStack,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 0)
            };

            mainStack.Children.Add(sView);

            Content = mainStack;
            BackgroundColor = Color.White;

        }
	}
}