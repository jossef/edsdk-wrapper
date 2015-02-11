using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// TODO - document
    /// </summary>
    public enum ObjectEvent : uint
    {
        /// <summary>
        /// Notifies all object events.
        /// </summary>
        All = 0x00000200,

        /// <summary>
        /// Notifies that the volume object (memory card) state (VolumeInfo)
        /// has been changed. 
        /// Changed objects are indicated by event data. 
        /// The changed value can be retrieved by means of EdsGetVolumeInfo. 
        /// Notification of this event is not issued for type 1 protocol standard cameras. 
        /// </summary>
        VolumeInfoChanged = 0x00000201,

        /// <summary>
        /// Notifies if the designated volume on a camera has been formatted.
        /// If notification of this event is received, get sub-items of the designated
        /// volume again as needed. 
        /// Changed volume objects can be retrieved from event data. 
        /// Objects cannot be identified on cameras earlier than the D30
        /// if files are added or deleted. 
        /// Thus, these events are subject to notification. 
        /// </summary>
        VolumeUpdateItems = 0x00000202,

        /// <summary>
        /// Notifies if many images are deleted in a designated folder on a camera.
        /// If notification of this event is received, get sub-items of the designated
        /// folder again as needed. 
        /// Changed folders (specifically, directory item objects) can be retrieved
        /// from event data. 
        /// </summary>
        FolderUpdateItems = 0x00000203,

        /// <summary>
        /// Notifies of the creation of objects such as new folders or files
        /// on a camera compact flash card or the like. 
        /// This event is generated if the camera has been set to store captured
        /// images simultaneously on the camera and a computer,
        /// for example, but not if the camera is set to store images
        /// on the computer alone. 
        /// Newly created objects are indicated by event data. 
        /// Because objects are not indicated for type 1 protocol standard cameras,
        /// (that is, objects are indicated as NULL),
        /// you must again retrieve child objects under the camera object to 
        /// identify the new objects. 
        /// </summary>
        DirItemCreated = 0x00000204,

        /// <summary>
        /// Notifies of the deletion of objects such as folders or files on a camera
        /// compact flash card or the like. 
        /// Deleted objects are indicated in event data. 
        /// Because objects are not indicated for type 1 protocol standard cameras, 
        /// you must again retrieve child objects under the camera object to
        /// identify deleted objects. 
        /// </summary>
        DirItemRemoved = 0x00000205,

        /// <summary>
        /// Notifies that information of DirItem objects has been changed. 
        /// Changed objects are indicated by event data. 
        /// The changed value can be retrieved by means of EdsGetDirectoryItemInfo. 
        /// Notification of this event is not issued for type 1 protocol standard cameras. 
        /// </summary>
        DirItemInfoChanged = 0x00000206,

        /// <summary>
        /// Notifies that header information has been updated, as for rotation information
        /// of image files on the camera. 
        /// If this event is received, get the file header information again, as needed. 
        /// This function is for type 2 protocol standard cameras only. 
        /// </summary>
        DirItemContentChanged = 0x00000207,

        /// <summary>
        /// Notifies that there are objects on a camera to be transferred to a computer. 
        /// This event is generated after remote release from a computer or local release
        /// from a camera. 
        /// If this event is received, objects indicated in the event data must be downloaded.
        /// Furthermore, if the application does not require the objects, instead
        /// of downloading them,
        /// execute EdsDownloadCancel and release resources held by the camera. 
        /// The order of downloading from type 1 protocol standard cameras must be the order
        /// in which the events are received. 
        /// </summary>
        DirItemRequestTransfer = 0x00000208,

        /// <summary>
        /// Notifies if the camera's direct transfer button is pressed. 
        /// If this event is received, objects indicated in the event data must be downloaded. 
        /// Furthermore, if the application does not require the objects, instead of
        /// downloading them, 
        /// execute EdsDownloadCancel and release resources held by the camera. 
        /// Notification of this event is not issued for type 1 protocol standard cameras. 
        /// </summary>
        DirItemRequestTransferDT = 0x00000209,

        /// <summary>
        /// Notifies of requests from a camera to cancel object transfer 
        /// if the button to cancel direct transfer is pressed on the camera. 
        /// If the parameter is 0, it means that cancellation of transfer is requested for
        /// objects still not downloaded,
        /// with these objects indicated by kEdsObjectEvent_DirItemRequestTransferDT. 
        /// Notification of this event is not issued for type 1 protocol standard cameras. 
        /// </summary>
        DirItemCancelTransferDT = 0x0000020a,

        VolumeAdded = 0x0000020c,
        VolumeRemoved = 0x0000020d,

    }
}
