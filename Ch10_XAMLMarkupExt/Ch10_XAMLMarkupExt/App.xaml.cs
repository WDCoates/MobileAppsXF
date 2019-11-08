﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ch10_XAMLMarkupExt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Resources = new ResourceDictionary();     //This needs to be commented out if using the App.xaml file to instantiate the Resource object
            Resources.Add("borderWidth", 2.0);
            Resources.Add("brdRad", 10);

            MainPage = new
                    //MainPage()
                    //S2_SharedStatics()
                    //S3_StaticResource()
                    //S4_ResourceSharing()
                    S5_ResourceTree()
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
