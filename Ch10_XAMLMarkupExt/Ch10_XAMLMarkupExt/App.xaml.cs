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

            Resources = new ResourceDictionary();
            Resources.Add("borderWidth", 5.0d);
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
