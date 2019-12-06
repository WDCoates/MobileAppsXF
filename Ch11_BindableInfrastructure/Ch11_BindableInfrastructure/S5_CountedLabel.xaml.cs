using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch11_BindableInfrastructure
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S5_CountedLabel : ContentPage
	{
		public S5_CountedLabel ()
		{
			InitializeComponent ();

            CountedLabel.Text += " And I love you-so....";

            int wCount = CountedLabel.WordCount;
            WordCountLabel.Text = $"There are {wCount} words!";
        }
	}
}