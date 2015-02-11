using System;

namespace EDSDKWrapper.Framework.Enums
{
    public enum BatteryQuality : uint
    {
        Empty = 1,
        Low = 30,
        Half = 50,
        Normal = 80,
        AC = 0xFFFFFFFF,
    }
}
