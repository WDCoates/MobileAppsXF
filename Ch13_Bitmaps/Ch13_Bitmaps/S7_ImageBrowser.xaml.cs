using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S7_ImageBrowser : ContentPage
	{
		public S7_ImageBrowser ()
		{
			InitializeComponent ();
		}

        private void OnImagePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            LFileName.Text = "Ready";
        }

        private void OnPrevButClicked(object sender, EventArgs e)
        {
            ActivityInd1.IsEnabled = false;
            ActivityInd1.IsRunning = false;

            NextButton.IsEnabled = true;
            PrevButton.IsEnabled = false;
        }

        private void OnNextButClicked(object sender, EventArgs e)
        {
            ActivityInd1.IsEnabled = true;
            ActivityInd1.IsRunning = true;

            PrevButton.IsEnabled = true;
            NextButton.IsEnabled = false;


        }
    }
}