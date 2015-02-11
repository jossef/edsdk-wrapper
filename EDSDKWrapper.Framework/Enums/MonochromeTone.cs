namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Monochrome tone
    /// </summary>
    public enum MonochromeTone : uint
    {
        None = 0,
        Sepia = 1,
        Blue = 2,
        Violet = 3,
        Green = 4,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xffffffff,
    }
}
