using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates bracket type.
    /// </summary>
    public enum Bracket : uint
    {
        AE = 0x01,
        ISO = 0x02,
        WB = 0x04,
        FE = 0x08,
        BracketOff = 0xffffffff,
    }
}
