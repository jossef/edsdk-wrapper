using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document
    /// </summary>
    public enum PropertyEvent : uint
    {
        /// <summary>
        /// Notifies all property events. 
        /// </summary>
        All = 0x00000100,

        /// <summary>
        /// Notifies that a camera property value has been changed. 
        /// The changed property can be retrieved from event data. 
        /// The changed value can be retrieved by means of EdsGetPropertyData. 
        /// In the case of type 1 protocol standard cameras, 
        /// notification of changed properties can only be issued for custom functions (CFn). 
        /// If the property type is 0x0000FFFF, the changed property cannot be identified. 
        /// Thus, retrieve all required properties repeatedly. */
        /// </summary>
        PropertyChanged = 0x00000101,

        /// <summary>
        /// Notifies of changes in the list of camera properties with configurable values. 
        /// The list of configurable values for property IDs indicated in event data 
        /// can be retrieved by means of EdsGetPropertyDesc. 
        /// For type 1 protocol standard cameras, the property ID is identified as "Unknown"
        /// during notification. 
        /// Thus, you must retrieve a list of configurable values for all properties and
        /// retrieve the property values repeatedly. 
        /// (For details on properties for which you can retrieve a list of configurable
        /// properties, 
        /// see the description of EdsGetPropertyDesc). */
        /// </summary>
        PropertyDescChanged = 0x00000102,
    }
}
