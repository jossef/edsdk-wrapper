using System.Runtime.InteropServices;
using System;

namespace EDSDKWrapper.Framework.Structs
{
    /// <summary>
    /// Indicates the white balance compensation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WhiteBalanceShift
    {
        Int32 AmberBlueValue;
        Int32 GreenMagentaValue;
    }
}
