using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch12_Styles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S7_DynamicStylesInheritance : ContentPage
	{
		public S7_DynamicStylesInheritance ()
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