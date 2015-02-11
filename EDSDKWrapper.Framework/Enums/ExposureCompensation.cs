using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates the exposure compensation.
    /// Exposure compensation refers to compensation relative to the position of the standard exposure mark (in the
    /// center of the exposure gauge).
    /// </summary>
    public enum ExposureCompensation : uint
    {
        Plus_3 = 0x18,
        Plus_2__2_3 = 0x15,
        Plus_2__1_2 = 0x14,
        Plus_2__1_3 = 0x13,
        Plus_2 = 0x10,
        Plus_1__2_3 = 0x0d,
        Plus_1__1_2 = 0x0c,
        Plus_1__1_3 = 0x0b,
        Plus_1 = 0x08,
        Plus_2_3 = 0x05,
        Plus_1_2 = 0x04,
        Plus_1_3 = 0x03,
        Zero = 0x00,
        Minus_1_3 = 0xfd,
        Minus_1_2 = 0xfc,
        Minus_2_3 = 0xfb,
        Minus_1 = 0xf8,
        Minus_1__1_3 = 0xf5,
        Minus_1__1_2 = 0xf4,
        Minus_1__2_3 = 0xf3,
        Minus_2 = 0xf0,
        Minus_2__1_3 = 0xed,
        Minus_2__1_2 = 0xec,
        Minus_2__2_3 = 0xeb,
        Minus_3 = 0xe8,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xffffffff,
    }
}