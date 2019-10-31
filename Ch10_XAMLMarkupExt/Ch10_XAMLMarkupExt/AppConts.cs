using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ch10_XAMLMarkupExt
{
    public static class AppConstant
    {
        public static Color LightBackground = Color.Yellow;
        public static Color DarkForeground = Color.Blue;

        public static double NormalFontSize = DeviceFontSize();
        public static double TitleFontSize = 1.4 * NormalFontSize;
        public static double ParagraphSpacing = 10;

        public const FontAttributes Emphasis = FontAttributes.Italic;
        public const FontAttributes SupperEmphasis = FontAttributes.Bold | FontAttributes.Italic;
        public const FontAttributes TitleAttribute = FontAttributes.Bold;

        public const TextAlignment TitleAlignment = TextAlignment.Center;

        private static double DeviceFontSize()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    return 10d;
                case Device.Android:
                    return 18d;
                default:
                    return 10d;
            }
        }
    }
}
