using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch14_AbsoluteLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class S4_ChessboardProportional : ContentPage
    {
        AbsoluteLayout aLayout;

        public S4_ChessboardProportional()
        {
            InitializeComponent();

            aLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.FromRgb(240, 220, 130),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            for (var row = 0; row < 8; row++)
            {
                for (var col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 0) continue;

                    var boxView = new BoxView
                    {
                        Color = Color.FromRgb(0, 64, 0)
                    };

                    var rect = new Rectangle(col / 7.0,     //x
                                             row / 7.0,     //y
                                             1 / 8.0,       //width
                                             1 / 8.0);       //height

                    aLayout.Children.Add(boxView, rect, AbsoluteLayoutFlags.All);
                }
            }

            ContentView cView = new ContentView
            {
                Content = aLayout
            };

            cView.SizeChanged += OnContentViewSizeChanged;

            this.Content = cView;
        }

        void OnContentViewSizeChanged(object sender, EventArgs args)
        {
            ContentView cView = (ContentView)sender;
            double bSize = Math.Min(cView.Width, cView.Height);
            aLayout.WidthRequest = bSize;
            aLayout.HeightRequest = bSize;
        }
    }
}