using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(Ch09_PltfrmInfDpndSrvc.UWP.SoundPlayer))]

namespace Ch09_PltfrmInfDpndSrvc.UWP
{
    public class SoundPlayer : IPlatformSoundPlayer
    {
        WinRuntimeShared.SharedSoundPlayer sSoundPlayer;

        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            if (sSoundPlayer == null)
            {
                sSoundPlayer = new WinRuntimeShared.SharedSoundPlayer();
            }

            sSoundPlayer.PlaySound(samplingRate, pcmData);
        }
    }
}
