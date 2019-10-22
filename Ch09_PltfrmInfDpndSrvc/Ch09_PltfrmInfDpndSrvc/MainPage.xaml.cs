using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
