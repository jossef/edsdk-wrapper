using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document this enum
    /// File Attributes
    /// </summary>
    /// <remarks></remarks>
    public enum FileAttribute : uint
    {
        Normal = 0x00000000,
        ReadOnly = 0x00000001,
        Hidden = 0x00000002,
        System = 0x00000004,
        Archive = 0x00000020,
    }
}
