using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document this enum
    /// </summary>
    /// <remarks></remarks>
    public enum CameraState : uint
    {
        UILock = 0x00000000,
        UIUnLock = 0x00000001,
        EnterDirectTransfer = 0x00000002,
        ExitDirectTransfer = 0x00000003,
    }
}
