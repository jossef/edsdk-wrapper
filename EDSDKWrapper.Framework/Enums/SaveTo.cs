using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates the destination of images after shooting.
    /// </summary>
    /// <remarks></remarks>
    public enum SaveTo : uint
    {
        /// <summary>
        /// Save on a memory card of a remote camera
        /// </summary>
        Camera = 1,

        /// <summary>
        /// Save by downloading to a host computer
        /// </summary>
        Host = 2,

        /// <summary>
        /// Save both ways
        /// </summary>
        Both = 3,
    }
}
