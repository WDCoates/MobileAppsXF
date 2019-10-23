using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ch09_PltfrmInfDpndSrvc
{
    class SoundPlayer
    {
        private const int _samplingRate = 22050;

        public static void PlaySound(double freq = 440, int dur = 250)
        {
            short[] shortBuffer = new short[_samplingRate + dur / 1000];
            double angleInc = freq / _samplingRate;
            double angle = 0;

            for (int i=0; i<shortBuffer.Length; i++)
            {
                double sample;
                if (angle < 0.25)
                    sample = 4 * angle;
                else if (angle < 0.75)
                    sample = 4 * (0.5 - angle);
                else
                    sample = 4 * (angle - 1);

                shortBuffer[i] = (short) (32767 * sample);
                angle += angleInc;

                while (angle > 1)
                    angle -= 1;
            }

            byte[] byteBuffer = new byte[2 * shortBuffer.Length];
            Buffer.BlockCopy(shortBuffer, 0, byteBuffer, 0, byteBuffer.Length);

            DependencyService.Get<IPlatformSoundPlayer>().PlaySound(_samplingRate, byteBuffer);

        }
    }
}
