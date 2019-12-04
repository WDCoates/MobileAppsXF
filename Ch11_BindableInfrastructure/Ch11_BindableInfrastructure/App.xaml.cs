using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ch11_BindableInfrastructure
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new
                //MainPage()
                //S1_ClassHierarchy()
                //S2_PropSettings()
                //S3_DynamicVsStatic()
                S4_AltLabelPointSize()
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
