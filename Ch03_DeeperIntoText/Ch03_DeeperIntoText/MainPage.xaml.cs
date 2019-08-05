using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ch03_DeeperIntoText
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Label1.Text = $"Screen siren Gina Lollobrigida, 92, was 'conned out of 3m euros, houses, and jewellery' by ex-chauffeur-turned-manager, 32, who 'raided her fortune to buy Ferraris and motorcycles after he gained control of the ''narcissistic'' former actress's estate' ";
            Label1.HorizontalOptions = LayoutOptions.CenterAndExpand;
            Label1.HorizontalTextAlignment = TextAlignment.Center;
            Label1.VerticalOptions = LayoutOptions.Start;
            Label1.VerticalTextAlignment = TextAlignment.End;   //NonSerializedAttribute Effect!
            Label1.LineBreakMode = LineBreakMode.WordWrap;
            Label1.BackgroundColor = Color.Yellow;
            Label1.TextColor = Color.DarkMagenta;
            Padding = new Thickness(10, Device.OnPlatform(20, 10, 50), 10, 5);

        }
    }
}
