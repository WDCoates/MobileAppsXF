using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Media.Core;
using Windows.Media.MediaProperties;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls;


namespace WinRuntimeShared
{
    public class SharedSoundPlayer
    {
        private MediaElement mediaEl = new MediaElement();
        private TimeSpan duration;

        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            AudioEncodingProperties audioProps = AudioEncodingProperties.CreatePcm((uint)samplingRate, 1, 16);
            AudioStreamDescriptor audioDesc = new AudioStreamDescriptor(audioProps);
            MediaStreamSource mss = new MediaStreamSource(audioDesc);

            bool samplePLayed = false;
            mss.SampleRequested += (sender, args) =>
            {
                if (samplePLayed)
                    return;

                IBuffer iBuffer = pcmData.AsBuffer();

                MediaStreamSample sample = MediaStreamSample.CreateFromBuffer(iBuffer, TimeSpan.Zero);
                sample.Duration = TimeSpan.FromSeconds(pcmData.Length / 2.0 / samplingRate);
                args.Request.Sample = sample;

                samplePLayed = true;
            };

            mediaEl.SetMediaStreamSource(mss);
        }
    }
}
