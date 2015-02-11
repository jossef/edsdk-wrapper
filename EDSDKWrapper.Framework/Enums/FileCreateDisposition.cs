using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document this enum
    /// File Create Disposition
    /// </summary>
    /// <remarks></remarks>
    public enum FileCreateDisposition : uint
    {
        CreateNew = 0,
        CreateAlways,
        OpenExisting,
        OpenAlways,
        TruncateExsisting,
    }
}
