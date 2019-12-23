using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch12_Styles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S6_DynamicStyles : ContentPage
	{
		public S6_DynamicStyles ()
		{
			InitializeComponent ();
		}

        private void OnButton1Clicked(object sender, EventArgs e)
        {
            Resources["ButtonStyle"] = Resources["ButtonStyle1"];
        }
        private void OnButton2Clicked(object sender, EventArgs e)
        {
            Resources["ButtonStyle"] = Resources["ButtonStyle2"];
        }
        private void OnButton3Clicked(object sender, EventArgs e)
        {
            Resources["ButtonStyle"] = Resources["ButtonStyle3"];
        }
        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            Resources["ButtonStyle"] = null;
        }
    }
}