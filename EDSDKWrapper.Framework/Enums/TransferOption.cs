using System;


namespace EDSDKWrapper.Framework.Enums
{
    public enum TransferOption : uint
    {
        ByDirectTransfer = 1,
        ByRelease = 2,
        ToDesktop = 0x00000100,
    }
}
