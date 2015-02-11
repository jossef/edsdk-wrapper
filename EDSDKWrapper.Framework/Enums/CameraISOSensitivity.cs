using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates Camera's ISO sensitivity values.
    /// </summary>
    public enum CameraISOSensitivity : uint
    {
        ISO_6 = 0x00000028,
        ISO_12 = 0x00000030,
        ISO_25 = 0x00000038,
        ISO_50 = 0x00000040,
        ISO_100 = 0x00000048,
        ISO_125 = 0x0000004b,
        ISO_160 = 0x0000004d,
        ISO_200 = 0x00000050,
        ISO_250 = 0x00000053,
        ISO_320 = 0x00000055,
        ISO_400 = 0x00000058,
        ISO_500 = 0x0000005b,
        ISO_640 = 0x0000005d,
        ISO_800 = 0x00000060,
        ISO_1000 = 0x00000063,
        ISO_1250 = 0x00000065,
        ISO_1600 = 0x00000068,
        ISO_3200 = 0x00000070,
        ISO_6400 = 0x00000078,
        ISO_12800 = 0x00000080,
        ISO_25600 = 0x00000088,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xffffffff,
    }
}
