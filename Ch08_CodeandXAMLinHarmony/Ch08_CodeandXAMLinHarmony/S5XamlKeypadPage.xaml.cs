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
	public partial class S5XamlKeypadPage : ContentPage
	{
        App app = Application.Current as App;

		public S5XamlKeypadPage ()
		{
			InitializeComponent ();

            lDisplay.Text = app.DisplayLabelText;
            bBackSpace.IsEnabled = !string.IsNullOrEmpty(lDisplay.Text);
        }

        private void OnBackSpaceClicked(object sender, EventArgs e)
        {
            string text = lDisplay.Text;
            lDisplay.Text = text.Substring(0, text.Length - 1);
            bBackSpace.IsEnabled = lDisplay.Text.Length > 0;

            app.DisplayLabelText = lDisplay.Text;
        }

        private void OnDigitButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lDisplay.Text += (string)btn.StyleId;
            bBackSpace.IsEnabled = true;

            app.DisplayLabelText = lDisplay.Text;
        }
    }
}