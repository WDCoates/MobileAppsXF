using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ch12_Styles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new
                //MainPage()
                //S1_BasicStylePage ()
                //S2_StylesInCode()
                //S3_StyleInheritance()
                //S4_ImplicitStyle()
                //S5_StyleHierarchy()
                S6_DynamicStyles()
                ;
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
    }
}
