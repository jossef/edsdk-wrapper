using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document this enum
    /// </summary>
    /// <remarks></remarks>
    public enum CameraCommand : uint
    {
        // Send Commands
        TakePicture = 0x00000000,
        ExtendShutDownTimer = 0x00000001,
        BulbStart = 0x00000002,
        BulbEnd = 0x00000003,
        DoEvfAf = 0x00000102,
        DriveLensEvf = 0x00000103,
        DoClickWBEvf = 0x00000104,
        PressShutterButton = 0x00000004,

        // Evf Commands
        EvfAf_OFF = 0,
        EvfAf_ON = 1,

        // Shutter Button Commands
        ShutterButton_OFF = 0x00000000,
        ShutterButton_Halfway = 0x00000001,
        ShutterButton_Completely = 0x00000003,
        ShutterButton_Halfway_NonAF = 0x00010001,
        ShutterButton_Completely_NonAF = 0x00010003,
      
    }
}
