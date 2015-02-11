using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates the camera's aperture value.
    /// </summary>
    public enum ApertureValue : uint
    {
        AV_00 = 0x00,
        AV_1 = 0x08,
        AV_1_1 = 0x0B,
        AV_1_2 = 0x0C,
        AV_1_2__1_3 = 0x0D,
        AV_1_4 = 0x10,
        AV_1_6 = 0x13,
        AV_1_8 = 0x14,
        AV_1_8__1_3 = 0x15,
        AV_2 = 0x18,
        AV_2_2 = 0x1B,
        AV_2_5 = 0x1C,
        AV_2_5__1_3 = 0x1D,
        AV_2_8 = 0x20,
        AV_3_2 = 0x23,
        AV_3_5 = 0x24,
        AV_3_5__1_3 = 0x25,
        AV_4 = 0x28,
        AV_4_5 = 0x2B,
        AV_4_5__1_3 = 0x2C,
        AV_5_0 = 0x2D,
        AV_5_6 = 0x30,
        AV_6_3 = 0x33,
        AV_6_7 = 0x34,
        AV_7_1 = 0x35,
        AV_8 = 0x38,
        AV_9 = 0x3B,
        AV_9_5 = 0x3C,
        AV_10 = 0x3D,
        AV_11 = 0x40,
        AV_13__1_3 = 0x43,
        AV_13 = 0x44,
        AV_14 = 0x45,
        AV_16 = 0x48,
        AV_18 = 0x4B,
        AV_19 = 0x4C,
        AV_20 = 0x4D,
        AV_22 = 0x50,
        AV_25 = 0x53,
        AV_27 = 0x54,
        AV_29 = 0x55,
        AV_32 = 0x58,
        AV_36 = 0x5B,
        AV_38 = 0x5C,
        AV_40 = 0x5D,
        AV_45 = 0x60,
        AV_51 = 0x63,
        AV_54 = 0x64,
        AV_57 = 0x65,
        AV_64 = 0x68,
        AV_72 = 0x6B,
        AV_76 = 0x6C,
        AV_80 = 0x6D,
        AV_91 = 0x70,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xffffffff,
    }
}
