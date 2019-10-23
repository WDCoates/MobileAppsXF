using System;
using System.Collections.Generic;
using System.Text;

namespace Ch09_PltfrmInfDpndSrvc
{
    public interface IPlatformSoundPlayer
    {
        void PlaySound(int samplingRate, byte[] pcmData);
    }
}
