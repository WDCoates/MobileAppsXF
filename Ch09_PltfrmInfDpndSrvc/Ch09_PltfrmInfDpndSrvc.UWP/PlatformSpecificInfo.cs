using Windows.Security.ExchangeActiveSyncProvisioning;
using Ch09_PltfrmInfDpndSrvc;
using Xamarin.Forms;

[assembly: Dependency(typeof(Ch09_PlatformSpecificAPICalls.PlatformSpecificInfo))]

namespace Ch09_PlatformSpecificAPICalls
{
    class PlatformSpecificInfo : IPlatformInfo
    {
        internal EasClientDeviceInformation _devInfo = new EasClientDeviceInformation();

        public string GetModel()
        {
            return $"{_devInfo.SystemManufacturer}, {_devInfo.SystemProductName}";
        }

        public string GetVersion()
        {
            return _devInfo.OperatingSystem;
        }
    }
}