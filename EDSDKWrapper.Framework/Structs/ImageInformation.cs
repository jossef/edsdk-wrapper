using System;

using System.Runtime.InteropServices;

namespace EDSDKWrapper.Framework.Structs
{
    /// <summary>
    /// TODO - document
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ImageInformation
    {
        public UInt32 Width;                  // image width 
        public UInt32 Height;                 // image height

        public UInt32 NumOfComponents;        // number of color components in image.
        public UInt32 ComponentDepth;         // bits per sample.  8 or 16.

        public Rectangle EffectiveRectangle;          // Effective rectangles except 
        // a black line of the image. 
        // A black line might be in the top and bottom
        // of the thumbnail image. 

        public UInt32 Reserved1;
        public UInt32 Reserved2;
    }
}
