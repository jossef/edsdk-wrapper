using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates settings values of the camera in shooting mode.
    /// </summary>
    /// <remarks></remarks>
    public enum AEMode : uint
    {
        /// <summary>
        /// Program
        /// </summary>
        Program = 0,

        /// <summary>
        /// Shutter-Speed Priority
        /// </summary>
        Tv = 1,

        /// <summary>
        /// Aperture Priority
        /// </summary>
        Av = 2,

        /// <summary>
        /// Manual Exposure
        /// </summary>
        Mamual = 3,

        /// <summary>
        /// Bulb
        /// </summary>
        /// <remarks>
        /// For some models, the value of the property cannot be retrieved as AEMode. 
        /// In this case, Bulb is retrieved as the value of the shutter speed (Tv) property.
        /// </remarks>
        Bulb = 4,

        /// <summary>
        /// Auto Depth-of-Field
        /// </summary>
        AutoDepthOfField = 5,

        /// <summary>
        /// Depth Of Field
        /// </summary>
        DepthOfField = 6,

        /// <summary>
        /// Camera settings registered
        /// </summary>
        Custom = 7,

        /// <summary>
        /// Lock
        /// </summary>
        Lock = 8,

        /// <summary>
        /// Automatic
        /// </summary>
        Automatic = 9,

        /// <summary>
        /// Night Scene Portrait
        /// </summary>
        NightScenePortrait = 10,

        /// <summary>
        /// Sports
        /// </summary>
        Sports = 11,

        /// <summary>
        /// Portrait
        /// </summary>
        Portrait = 12,

        /// <summary>
        /// Landscape
        /// </summary>
        Landscape = 13,

        /// <summary>
        /// Close-Up
        /// </summary>
        CloseUp = 14,

        /// <summary>
        /// Flash Off
        /// </summary>
        FlashOff = 15,

        /// <summary>
        /// Creative Auto
        /// </summary>
        CreativeAuto = 19,

        /// <summary>
        /// Photo In Movie (This value is valid for only Image.)
        /// </summary>
        PhotoInMovie = 21,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xFFFFFFFF,
    }
}
