using Xamarin.Forms;

namespace Ch05_DealingWithSize
{
    public class Helper
    {
        public Helper()
        {
        }

        public static double TTop()
        {
            double top = 0.0d;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    top = 20d;
                    break;
                case Device.Android:
                    top = 10d;
                    break;
                case Device.UWP:
                    top = 20d;
                    break;
            }

            return top;
        }
    }
}