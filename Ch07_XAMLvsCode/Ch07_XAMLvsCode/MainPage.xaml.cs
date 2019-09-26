using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ch07_XAMLvsCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var cTc = new ColorTypeConverter();
            var res = cTc.ConvertFromInvariantString("Blue");
            LblSpace.BackgroundColor = Color.Yellow;

        }
    }
}
