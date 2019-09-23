using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ch06_ButtonClicks
{
    public partial class App : Application
    {
        //For the KepPadPersisted project...
        private const string dspLabelText = "displayLabelText";
        public string DisplayLabelText { get; set;}

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey(dspLabelText))
            {
                DisplayLabelText = (string) Properties[dspLabelText];
            }

            MainPage = new //MainPage();
                           //ButtonLogger ();
                           //TwoButs();
                           //LambdaButtons();
                           //KeyPad();
                           KeyPadPersisted();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Properties[dspLabelText] = DisplayLabelText;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
