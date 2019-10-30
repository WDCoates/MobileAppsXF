using Windows.Security.ExchangeActiveSyncProvisioning;

namespace Ch09_PlatformSpecificAPICalls
{
    class PlatformSpecificInfo
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