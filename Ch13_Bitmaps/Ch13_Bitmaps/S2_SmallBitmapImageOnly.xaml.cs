using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ch13_Bitmaps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class S2_SmallBitmapImageOnly : ContentPage
	{
		public S2_SmallBitmapImageOnly ()
		{
			InitializeComponent ();

            S1.Children.Add(new Image
            {
                Source = "https://cdn.pixabay.com/photo/2015/05/15/14/27/eiffel-tower-768501_960_720.jpg",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Black,
                Aspect = Aspect.AspectFill
            });
        }
	}
}