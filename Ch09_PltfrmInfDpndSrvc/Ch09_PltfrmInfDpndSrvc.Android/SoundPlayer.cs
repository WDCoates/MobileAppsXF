using Android.Media;
using Xamarin.Forms;

[assembly: Dependency(typeof(Ch09_PltfrmInfDpndSrvc.SoundPlayer))]

namespace Ch09_PltfrmInfDpndSrvc
{
    public class SoundPlayer : IPlatformSoundPlayer
    {
        AudioTrack prevAudioTrack;
        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            if (prevAudioTrack != null)
            {
                prevAudioTrack.Stop();
                prevAudioTrack.Release();
            }

            var audioTrack = new AudioTrack(Stream.Music, samplingRate, ChannelOut.Mono,
                Android.Media.Encoding.Pcm16bit, pcmData.Length * sizeof(short), AudioTrackMode.Static);

            audioTrack.Write(pcmData, 0, pcmData.Length);
            audioTrack.Play();

            prevAudioTrack = audioTrack;
        }

    }
}
