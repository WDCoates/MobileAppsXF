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
	public partial class S3XamlClock : ContentPage
	{
		public S3XamlClock ()
		{
			InitializeComponent ();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }

        private bool OnTimerTick()
        {
            DateTime dateTime = DateTime.Now;
            timeLabel.Text = $"{dateTime:T}";
            dateLabel.Text = $"{dateTime:dd-MMM-yyyy}";
            return true;
        }
    }
}