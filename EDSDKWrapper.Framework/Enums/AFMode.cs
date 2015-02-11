using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates AF mode settings values.
    /// </summary>
    public enum AFMode : uint
    {
        OneShot = 0,
        AIServo = 1,
        AIFocus = 2,
        ManualFocus = 3,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xffffffff,
    }
}
