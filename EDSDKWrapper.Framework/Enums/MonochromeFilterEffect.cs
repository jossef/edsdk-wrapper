namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Monochrome filter effect
    /// </summary>
    public enum MonochromeFilterEffect : uint
    {
        None = 0,
        Yellow = 1,
        Orange = 2,
        Red = 3,
        Green = 4,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xffffffff,
    }
}
