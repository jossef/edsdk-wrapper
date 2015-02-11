namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Bracket Mode
    /// </summary>
    public enum BracketMode : uint
    {
        Off = 0,
        AmberBlue = 1,
        GreenMagenta = 2,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        NotSupported = 0xffffffff,
    }
}
