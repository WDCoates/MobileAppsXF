using System;
using Android.OS;

namespace Ch09_PlatformSpecificAPICalls
{
    class PlatformSpecificInfo
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