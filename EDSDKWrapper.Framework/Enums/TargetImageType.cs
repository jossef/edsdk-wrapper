using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document this enum
    /// Target Image Types
    /// </summary>
    /// <remarks></remarks>
    public enum TargetImageType : uint
    {
        Unknown = 0x00000000,
        Jpeg = 0x00000001,
        TIFF = 0x00000007,
        TIFF16 = 0x00000008,
        RGB = 0x00000009,
        RGB16 = 0x0000000A,
    }
}
