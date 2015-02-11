using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document this enum
    /// File and Properties Access
    /// </summary>
    /// <remarks></remarks>
    public enum Access : uint
    {
        Read = 0,
        Write,
        ReadWrite,
        Error = 0xFFFFFFFF,
    }
}
