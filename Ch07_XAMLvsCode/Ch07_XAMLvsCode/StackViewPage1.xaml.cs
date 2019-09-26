using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch07_XAMLvsCode
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackViewPage1 : ContentPage
	{
		public StackViewPage1 ()
		{
			InitializeComponent ();
		}
	}
}