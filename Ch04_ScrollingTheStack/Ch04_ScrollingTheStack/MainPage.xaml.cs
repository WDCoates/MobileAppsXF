using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ch04_ScrollingTheStack
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var colours = new[]
            {
                new {value = Color.AliceBlue, name = "AliceBlue"},
                new {value = Color.AntiqueWhite, name = "AntiqueWhite"},
                new {value = Color.Aqua, name = "Aqua"},
                new {value = Color.Aquamarine, name = "Aquamarine"},
                new {value = Color.Azure, name = "Azure"},
                new {value = Color.Beige, name = "Beige"},
                new {value = Color.Bisque, name = "Bisque"},
                new {value = Color.Black, name = "Black"},
                new {value = Color.BlanchedAlmond, name = "BlanchedAlmond"},
                new {value = Color.Blue, name = "Blue"},
                new {value = Color.BlueViolet, name = "BlueViolet"},
                new {value = Color.Brown, name = "Brown"},
                new {value = Color.BurlyWood, name = "BurlyWood"}
            };

            StackLayout sLayout = new StackLayout();

            foreach (var c in colours)
            {
                sLayout.Children.Add(
                    new Label
                    {
                        Text = c.name,
                        TextColor = c.value
                    });
            }

            sLayout.Spacing = 100;

            Content = sLayout;
            BackgroundColor = Color.Gray;
        }

    }
}
