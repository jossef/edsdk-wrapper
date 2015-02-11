using System.Runtime.InteropServices;
using EDSDKWrapper.Framework.Enums;
using System;

namespace EDSDKWrapper.Framework.Structs
{
    /// <summary>
    /// Indicates the white balance bracket amount.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WhiteBalanceBracket
    {
        BracketMode BracketMode;
        WhiteBalanceShift WhiteBalanceShift;
    }
}
