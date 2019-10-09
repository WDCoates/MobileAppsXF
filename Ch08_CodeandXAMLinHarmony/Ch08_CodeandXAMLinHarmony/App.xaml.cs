﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ch08_CodeandXAMLinHarmony
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new
                    //MainPage()
                    //
                    //S1ParamsConstructor()
                    //S2FactoryMethod()
                    //S3XamlClock()
                    S3PlatformSpecfText()
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
