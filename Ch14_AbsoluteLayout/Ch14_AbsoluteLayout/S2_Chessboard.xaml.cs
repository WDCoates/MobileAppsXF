using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch14_AbsoluteLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class S2_Chessboard : ContentPage
    {
        public S2_Chessboard()
        {
            InitializeComponent();

            const double squareSize = 35;

            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.FromRgb(240, 220, 130),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            for (var row = 0; row < 8; row++)
            {
                for (var col = 0; col < 8; col++)
                {
                    Debug.WriteLine($"row: {Convert.ToString(row, toBase: 2)} ^ {Convert.ToString(col, toBase: 2)}");
                    if ((row + col) % 2 == 0) continue;
                    //Skip every other square ;-)
                    //if (((row ^ col) & 1) == 0)
                    //    continue;

                    var boxView = new BoxView
                    {
                        Color = Color.FromRgb(0, 64, 0)
                    };

                    var rect = new Rectangle(col * squareSize, row * squareSize, squareSize, squareSize);

                    absoluteLayout.Children.Add(boxView, rect);
                }
            }

            this.Content = absoluteLayout;
        }
    }
}