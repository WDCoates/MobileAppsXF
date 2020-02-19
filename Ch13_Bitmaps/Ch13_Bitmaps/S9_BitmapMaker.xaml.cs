using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S9_BitmapMaker : ContentPage
	{
		public S9_BitmapMaker ()
		{
			InitializeComponent ();

            var rows = 128;
            var cols = 64;

            BmpMaker bmpMaker = new BmpMaker(cols, rows);

            for (int row = 0; row < rows; row++)
                for(int col=0; col < cols; col++)
                {
                    bmpMaker.SetPixel(row, col, 2 * row, 0, 2 * (128 - row), 0);
                }

            Image.Source = bmpMaker.Generate();
        }
	}
}