using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch08_CodeandXAMLinHarmony
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S6TapGestures : ContentPage
    {
        private const int seqTime = 750;    // milliseconds
        protected const int flashDuration = 250;

        private const double offLum = 0.4;
        private const double onLum = 0.75;

        private BoxView[] boxViews;
        private Color[] colours = {Color.Red, Color.Green, Color.Blue, Color.Purple};
        private List<int> seq = new List<int>();
        private int seqIndex;
        private bool awaitTaps;
        private bool gameEnded;
        private Random rnd = new Random();

        public S6TapGestures ()
		{
			InitializeComponent ();
            boxViews = new BoxView[] {boxV0, boxV1, boxV2, boxV3};
            InitBoxViewColours();
        }

        private void InitBoxViewColours()
        {
            for (int i = 0; i < 4; i++)
            {
                boxViews[i].Color = colours[i].WithLuminosity(offLum);
            }

        }

        private void OnBoxViewTapped(object sender, EventArgs e)
        {
            
        }

        private void OnbStartClicked(object sender, EventArgs e)
        {
            

        }
    }
}