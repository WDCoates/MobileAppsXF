using System;
using Xamarin.Forms;

namespace Ch09_PltfrmInfDpndSrvc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            IPlatformInfo platformInfo = DependencyService.Get<IPlatformInfo>();
            lDeviceModel.Text = platformInfo.GetModel();
            lVersion.Text = platformInfo.GetVersion();
        }

        private void OnPushed(object sender, EventArgs e)
        {
            //ToDo AddSound
        }
    }
}
