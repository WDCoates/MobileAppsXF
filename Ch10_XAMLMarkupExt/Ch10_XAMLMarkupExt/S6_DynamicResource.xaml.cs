using System;
using System.Globalization;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch10_XAMLMarkupExt
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S6_DynamicResource : ContentPage
	{
		public S6_DynamicResource ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromSeconds(1), () => { Resources["curDateTime"] = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                return true;
            });
        }
	}
}