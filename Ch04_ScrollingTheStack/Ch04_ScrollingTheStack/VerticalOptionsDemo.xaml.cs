using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch04_ScrollingTheStack
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerticalOptionsDemo
    {
		public VerticalOptionsDemo ()
		{
			InitializeComponent ();

            Color[] colors = {Color.Yellow, Color.Green};
            int yGIdx = 0;

            IEnumerable<Label> labels = from field in typeof(LayoutOptions).GetRuntimeFields()
                where field.IsPublic && field.IsStatic
                orderby ((LayoutOptions) field.GetValue(null)).Alignment
                select new Label
                {
                    Text = $"VerticalOptions = {field.Name}",
                    VerticalOptions = (LayoutOptions) field.GetValue(null),
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    TextColor = colors[yGIdx],
                    BackgroundColor = colors[yGIdx = 1 - yGIdx]
                };

            StackLayout sLayout = new StackLayout();

            //foreach (var l in labels.Select((value, i) => new { i, value }).OrderByDescending(v => v.i))
            foreach (var l in labels.Select((value, i) => new {i, value}))
            {
                //if (l.i < 2) continue;
                l.value.Text = $"{l.i}  {l.value.Text}";
                sLayout.Children.Add(l.value);
                //if (l.i >= 2) break;
            }

            Content = sLayout;
        }
	}
}