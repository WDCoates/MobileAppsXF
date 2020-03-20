using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch14_AbsoluteLayout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S3_ChessboardDynamic : ContentPage
    {
        
		public S3_ChessboardDynamic ()
		{
			InitializeComponent ();

            for (var i=0; i<32; i++)
            {
                BoxView bView = new BoxView
                {
                    Color = Color.FromRgb(0, 64, 0)
                };
                
                ALayout.Children.Add(bView);
            }

            ConView1.SizeChanged += OnConViewSizeChanged;


		}

        private void OnConViewSizeChanged(object sender, EventArgs e)
        {
            var conView = (ContentView)sender;
            double squSize = Math.Min(conView.Width, conView.Height) / 8;
            var idx = 0;

            for (var row = 0; row < 8; row++)
            {
                for (var col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 0) continue;

                    View view = ALayout.Children[idx];

                    var rect = new Rectangle(col * squSize, row * squSize, squSize, squSize);

                    AbsoluteLayout.SetLayoutBounds(view, rect);
                    idx++;
                }
            }
        }
    }
}