using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ch08_CodeandXAMLinHarmony
{
    public partial class App : Application
    {
        private const string dspLblTxt = "DisplayLabelText";
        public string DisplayLabelText { get; set; }

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey(dspLblTxt))
            {
                DisplayLabelText = (string) Properties[dspLblTxt];
            }

            MainPage = new
                //MainPage()
                //
                //S1ParamsConstructor()
                //S2FactoryMethod()
                //S3XamlClock()
                //S3PlatformSpecfText()
                //S4ColourPage1withCustomView()
                //S5XamlKeypadPage()
                S6TapGestures()
                ;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Properties[dspLblTxt] = DisplayLabelText;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
