using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates image rotation information.
    /// </summary>
    public enum ImageOrientation : uint
    {
        /// <summary>
        /// Normal Image Orientation 
        /// </summary>
        Normal = 0x1,

        /// <summary>
        /// Flipped Image Orientation
        /// </summary>
        Flipped = 0x3,

        /// <summary>
        /// Tilted to the Right Image Orientation
        /// </summary>
        TiltedRight = 0x6,

        /// <summary>
        /// Tilted to the Left Image Orientation
        /// </summary>
        TiltedLeft = 0x8,
    }
}
