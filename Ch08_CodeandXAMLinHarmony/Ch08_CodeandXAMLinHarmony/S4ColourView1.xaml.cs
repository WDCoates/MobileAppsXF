using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch08_CodeandXAMLinHarmony
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S4ColourView1 : ContentView
    {
        private string colourName;
        private ColorTypeConverter colourTypeConv = new ColorTypeConverter();

		public S4ColourView1 ()
		{
			InitializeComponent ();
		}

        public string ColourName
        {
            set
            {
                //Set the name.
                colourName = value;
                lColourName.Text = value;

                //Set the actual Color
                Color colour = (Color) colourTypeConv.ConvertFromInvariantString(colourName);
                boxView1.Color = colour;
                lColourValue.Text =
                    $"{(int) (255 * colour.R):X2}-{(int) (255 * colour.G):X2}-{(int) (255 * colour.B):X2}";

            }
            get => colourName;
        }
	}
}