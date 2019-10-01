﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ch07_XAMLvsCode
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            MainPage = new //MainPage();
                //StackViewPage1();
                StacksAndFramesCleanLook();
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
