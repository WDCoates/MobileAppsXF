using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch12_Styles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S2_StylesInCode : ContentPage
	{
		public S2_StylesInCode ()
		{
			InitializeComponent ();

            Resources = new ResourceDictionary
            {
                {
                    "ButtonStyle", new Style(typeof(Style))
                    {
                        Setters =
                        {
                            new Setter
                            {
                                //Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.Center // One could use Button but View is the base type.
                                Property = View.HorizontalOptionsProperty, Value = LayoutOptions.Center
                            },
                            new Setter
                            {
                                Property = View.VerticalOptionsProperty, Value = LayoutOptions.CenterAndExpand
                            },
                            new Setter
                            {
                                Property = Button.BorderWidthProperty, Value = 4
                            },
                            new Setter
                            {
                                Property = Button.TextColorProperty, Value = Color.Red
                            },
                            new Setter
                            {
                                Property = Button.FontSizeProperty, Value = Device.GetNamedSize(NamedSize.Large, typeof(Button))
                            },
                            new Setter
                            {
                                Property = BackgroundColorProperty, 
                                //Value = Device.OnPlatform(Color.Default,Color.FromRgb(40d, 40d, 40d),Color.Default)
                                Value = Device.RuntimePlatform == Device.Android ? Color.Green : Color.Blue
                            }
                        }
                    }
                }
            };

            Content = new StackLayout
            {
                Children =
                {
                    new Button
                    {
                        Text = " Carpe diem ",
                        Style = (Style) Resources["ButtonStyle"]
                    },

                    new Button
                    {
                        Text = " Sapere aude ",
                        Style = (Style) Resources["ButtonStyle"]
                    },

                    new Button
                    {
                        Text = " Discere faciendo ",
                        Style = (Style) Resources["ButtonStyle"]
                    }
                }
            };
        }
	}
}