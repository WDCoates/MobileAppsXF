using System;
using System.Collections.Generic;
using System.Text;

namespace Ch09_PltfrmInfDpndSrvc
{
    public interface IPlatformInfo
    {
        string GetModel();

        string GetVersion();
    }
}
