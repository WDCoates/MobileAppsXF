using System;
using Xamarin.Forms;

namespace Ch05_DealingWithSize
{
    public struct FontCalc
    {
        public double FontSize { private set; get;}
        public double TextHeight { private set; get; }
        public FontCalc(Label label, double fSize, double cWidth) : this()
        {
            //Save the font size for ref.
            FontSize = fSize;

            //Recalculate the Label height.
            label.FontSize = fSize;
            SizeRequest sizeReq = label.GetSizeRequest(cWidth, Double.PositiveInfinity);

            //Save this height
            TextHeight = sizeReq.Request.Height;
        }

    }
}
