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
        private bool _awaitTap;
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
            if (gameEnded)
                return;

            if (!_awaitTap)
            {
                EndGame();
                return;
            }

            BoxView tappedBoxView = (BoxView)sender;
            int i = Array.IndexOf(boxViews, tappedBoxView);

            if (i != seq[seqIndex])
            {
                EndGame();
                return;
            }

            FlashBox(i);

            seqIndex++;
            _awaitTap = seqIndex < seq.Count;

            if (!_awaitTap)
            {
                StartSequence();
            }

        }

        protected virtual void EndGame()
        {
            gameEnded = true;

            for (int i = 0; i < 4; i++)
            {
                boxViews[i].Color = Color.Gray;
            }

            bStart.Text = $"Failed @{seq.Count}. Try Again?";
            bStart.IsVisible = true;

        }

        private void OnbStartClicked(object sender, EventArgs e)
        {
            gameEnded = false;
            bStart.IsVisible = false;
            InitBoxViewColours();
            seq.Clear();
            StartSequence();
        }

        private void StartSequence()
        {
            seq.Add(rnd.Next(4));
            seqIndex = 0;
            Device.StartTimer(TimeSpan.FromMilliseconds(seqTime), OnTimerTick);

        }

        private bool OnTimerTick()
        {
            if(gameEnded)
                return false;

            FlashBox(seq[seqIndex]);
            seqIndex++;
            _awaitTap = seqIndex == seq.Count;
            seqIndex = _awaitTap ? 0 : seqIndex;
            return !_awaitTap;
        }

        private void FlashBox(int i)
        {
            boxViews[i].Color = colours[i].WithLuminosity(onLum);
            Device.StartTimer(TimeSpan.FromMilliseconds(flashDuration), () => { 
                if (gameEnded) return false;
                boxViews[i].Color = colours[i].WithLuminosity(offLum);
                    return false;
                });

        }
    }
}