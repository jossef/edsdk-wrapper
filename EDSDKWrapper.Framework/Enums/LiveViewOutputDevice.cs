using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Electronic View Finder Output Device (LiveView)
    /// </summary>
    public enum LiveViewOutputDevice : uint
    {
        /// <summary>
        /// Live view is displayed on the camera’s TFT
        /// </summary>
        Camera = 1,

        /// <summary>
        /// The live view image can be transferred to the PC
        /// </summary>
        Computer = 2,
    }
}
