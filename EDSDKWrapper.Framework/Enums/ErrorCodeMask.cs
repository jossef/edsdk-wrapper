using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document
    /// </summary>
    public enum ErrorCodeMask : uint
    {
        IsSpecific = 0x80000000,
        ComponentId = 0x7F000000,
        Reserved = 0x00FF0000,
        ErrorId = 0x0000FFFF,
    }
}