using System;
using Xamarin.Forms;

#if __ANDROID__
using Android.OS;

#elif WINDOWS_APP || WINDOWS_UWP
using Windows.Security.ExchangeActiveSyncProvisioning;
#endif


namespace Ch09_PlatformSpecificAPICalls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        
#if __ANDROID__

            lDeviceModel.Text = $"{Build.Manufacturer}, {Build.Model}";
            lVersion.Text = $"{Build.VERSION.Release.ToString()}";
            
#elif WINDOWS_APP || WINDOWS_UWP

            var devInfo = new EasClientDeviceInformation();
            lDeviceModel.Text = $"{devInfo.SystemManufacturer}, {devInfo.SystemProductName}";
            lVersion.Text = devInfo.OperatingSystem;
#endif

            PlatformSpecificInfo pInfo = new PlatformSpecificInfo();
            lDeviceModel2.Text = pInfo.GetModel();
            lVersion2.Text = pInfo.GetVersion();

        }
    }
}
