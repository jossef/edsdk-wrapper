using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates settings values of the camera in drive mode.
    /// </summary>
    public enum DriveMode : uint
    {
        /// <summary>
        /// Single-Frame Shooting
        /// </summary>
        SingleFrameShooting = 0x00000000,

        /// <summary>
        /// Continuous Shooting
        /// </summary>
        ContinuousShooting = 0x00000001,

        /// <summary>
        /// Video
        /// </summary>
        Video = 0x00000002,

        /// <summary>
        /// Not used
        /// </summary>
        NotUsed = 0x00000003,

        /// <summary>
        /// High-Speed Continuous Shooting
        /// </summary>
        HighSpeedContinuousShooting = 0x00000004,

        /// <summary>
        /// Low-Speed Continuous Shooting
        /// </summary>
        LowSpeedContinuousShooting = 0x00000005,

        /// <summary>
        /// Silent single shooting
        /// </summary>
        SilentSingleShooting = 0x00000006,

        /// <summary>
        /// 10-Sec Self-Timer plus continuous shots
        /// </summary>
        Timer10SecondsWithContinuousShots = 0x00000007,

        /// <summary>
        /// 10-Sec Self-Timer
        /// </summary>
        Timer10Seconds = 0x00000010,

        /// <summary>
        /// 2-Sec Self-Timer
        /// </summary>
        Timer2Seconds = 0x00000011,
    }
}
