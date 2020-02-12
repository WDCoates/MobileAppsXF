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
            throw new NotImplementedException();
        }

        private void OnPrevButClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnNextButClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}