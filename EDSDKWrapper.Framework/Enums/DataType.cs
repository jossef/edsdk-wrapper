using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document this enum
    /// </summary>
    /// <remarks></remarks>
    public enum DataType : uint
    {
        Unknown = 0,
        Bool = 1,
        String = 2,
        Int8 = 3,
        UInt8 = 6,
        Int16 = 4,
        UInt16 = 7,
        Int32 = 8,
        UInt32 = 9,
        Int64 = 10,
        UInt64 = 11,
        Float = 12,
        Double = 13,
        ByteBlock = 14,
        Rational = 20,
        Point = 21,
        Rect = 22,
        Time = 23,

        Bool_Array = 30,
        Int8_Array = 31,
        Int16_Array = 32,
        Int32_Array = 33,
        UInt8_Array = 34,
        UInt16_Array = 35,
        UInt32_Array = 36,
        Rational_Array = 37,

        FocusInfo = 101,
        PictureStyleDesc,
    }
}
