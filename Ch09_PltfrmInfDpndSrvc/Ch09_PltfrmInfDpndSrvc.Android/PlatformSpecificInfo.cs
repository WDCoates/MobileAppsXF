using Android.OS;
using Ch09_PltfrmInfDpndSrvc;
using Xamarin.Forms;

[assembly: Dependency(typeof(Ch09_PlatformSpecificAPICalls.PlatformSpecificInfo))]

namespace Ch09_PlatformSpecificAPICalls
{
    class PlatformSpecificInfo : IPlatformInfo
    {
        public string GetModel()
        {
            return $"{Build.Manufacturer}, {Build.Model}";
        }

        public string GetVersion()
        {
            return $"{Build.VERSION.Release.ToString()}";
        }
    }
}