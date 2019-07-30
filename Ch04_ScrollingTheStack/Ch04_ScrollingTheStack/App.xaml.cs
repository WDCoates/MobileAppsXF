using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ch04_ScrollingTheStack
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage
            {
                Padding = new Thickness(10, TTop(), right: 10, bottom: 5)
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        private double TTop()
        {
            double top = 0.0d;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    top = 20d;
                    break;
                case Device.Android:
                    top = 10d;
                    break;
                case Device.UWP:
                    top = 40d;
                    break;
            }

            return top;
        }
    }
}
