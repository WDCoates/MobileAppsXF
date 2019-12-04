using System;
using System.Globalization;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch11_BindableInfrastructure
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S3_DynamicVsStatic : ContentPage
	{
		public S3_DynamicVsStatic ()
		{
			InitializeComponent ();

            Padding = new Thickness(5, 0);

            //Create resource dictionary and add line.
            Resources = new ResourceDictionary
            {
                {"curDateTime", "Not actually a DateTime"}
            };

            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "StaticResource on Label.Text:",
                        VerticalOptions = LayoutOptions.EndAndExpand,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    },

                    new Label
                    {
                        Text = (string) Resources["curDateTime"],
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    },

                    new Label
                    {
                        Text = "DynamicResource on Label.Text",
                        VerticalOptions = LayoutOptions.EndAndExpand,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                    }
                }
            };

            //
            // Create the final label with dynamic resource.
            Label label = new Label
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            label.SetDynamicResource(Label.TextProperty, "curDateTime");

            ((StackLayout) Content).Children.Add(label);

            // Start the timer going.
            Device.StartTimer(TimeSpan.FromSeconds(1),
                () =>
                {
                    Resources["curDateTime"] = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                    return true;
                });
        }
	}
}