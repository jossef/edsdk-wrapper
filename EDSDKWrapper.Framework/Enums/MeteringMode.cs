using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates the metering mode.
    /// </summary>
    public enum MeteringMode : uint
    {
        Spot = 0x1,
        Evaluative = 0x3,
        Partial = 0x4,
        CenterWeighted = 0x5,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xffffffff,
    }
}
