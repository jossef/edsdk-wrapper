using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Represents an operation return value.
    /// Most of the return values here represent Failures except the "Ok" one
    /// </summary>
    /// <remarks></remarks>
    public enum ReturnValue : uint
    {
        #region Successful Return Values

        /// <summary>
        /// Ok notification, this is the only non error result in this enum.
        /// </summary>
        Ok = 0x00000000,

        #endregion

        #region Error Return Values

        #region Miscellaneous errors

        /// <summary>
        /// Not implemented
        /// </summary>
        Unimplemented = 0x00000001,

        /// <summary>
        /// Internal error
        /// </summary>
        InternalError = 0x00000002,

        /// <summary>
        /// Memory allocation error
        /// </summary>
        MemoryAllocationFailed = 0x00000003,

        /// <summary>
        /// Memory release error
        /// </summary>
        MemoryFreeFailed = 0x00000004,

        /// <summary>
        /// Operation canceled
        /// </summary>
        OperationCancelled = 0x00000005,

        /// <summary>
        /// Version error
        /// </summary>
        IncompatibleVersion = 0x00000006,

        /// <summary>
        /// Not supported
        /// </summary>
        NotSupported = 0x00000007,

        /// <summary>
        /// Unexpected exception
        /// </summary>
        UnexpectedException = 0x00000008,

        /// <summary>
        /// Protection violation
        /// </summary>
        ProtectionViolation = 0x00000009,

        /// <summary>
        /// Missing subcomponent
        /// </summary>
        MissingSubcomponent = 0x0000000a,

        /// <summary>
        /// Selection unavailable
        /// </summary>
        SelectionUnavailable = 0x0000000b,

        #endregion

        #region File errors

        /// <summary>
        /// IO error
        /// </summary>
        FileIOError = 0x00000020,

        /// <summary>
        /// Too many files open
        /// </summary>
        FileTooManyOpen = 0x00000021,

        /// <summary>
        /// File does not exist
        /// </summary>
        FileNotFound = 0x00000022,

        /// <summary>
        /// Open error
        /// </summary>
        FileOpenError = 0x00000023,

        /// <summary>
        /// Close error
        /// </summary>
        FileCloseError = 0x00000024,

        /// <summary>
        /// Seek error
        /// </summary>
        FileSeekError = 0x00000025,

        /// <summary>
        /// Tell error
        /// </summary>
        FileTellError = 0x00000026,

        /// <summary>
        /// Read error
        /// </summary>
        FileReadError = 0x00000027,

        /// <summary>
        /// Write error
        /// </summary>
        FileWriteError = 0x00000028,

        /// <summary>
        /// Permission error
        /// </summary>
        FilePermissionError = 0x00000029,

        /// <summary>
        /// Disk full
        /// </summary>
        FileDiskFullError = 0x0000002a,

        /// <summary>
        /// File already exists
        /// </summary>
        FileAlreadyExists = 0x0000002b,

        /// <summary>
        /// File Format error
        /// </summary>
        FileFormatUnrecognized = 0x0000002c,

        /// <summary>
        /// Invalid data
        /// </summary>
        FileDataCorrupt = 0x0000002d,

        /// <summary>
        /// File naming error
        /// </summary>
        FileNamingError = 0x0000002e,

        #endregion

        #region Directory errors

        /// <summary>
        /// Directory does not exist
        /// </summary>
        DirectoryNotFound = 0x00000040,

        /// <summary>
        /// I/O error
        /// </summary>
        DirectoryIoError = 0x00000041,

        /// <summary>
        /// No file in directory
        /// </summary>
        DirectoryEntryNotFound = 0x00000042,

        /// <summary>
        /// File in directory
        /// </summary>
        DirectoryEntryExists = 0x00000043,

        /// <summary>
        /// Directory not empty
        /// </summary>
        DirectoryNotEmpty = 0x00000044,

        #endregion

        #region Property errors

        /// <summary>
        /// Property (and additional property information) unavailable
        /// </summary>
        PropertiesUnavailable = 0x00000050,

        /// <summary>
        /// Property mismatch
        /// </summary>
        PropertiesMismatch = 0x00000051,

        /// <summary>
        /// Property not loaded
        /// </summary>
        PropertiesNotLoaded = 0x00000053,

        #endregion

        #region Function Parameter errors

        /// <summary>
        /// Invalid function parameter
        /// </summary>
        InvalidParameter = 0x00000060,

        /// <summary>
        /// Handle error
        /// </summary>
        InvalidHandle = 0x00000061,

        /// <summary>
        /// Pointer error
        /// </summary>
        InvalidPointer = 0x00000062,

        /// <summary>
        /// Index error
        /// </summary>
        InvalidIndex = 0x00000063,

        /// <summary>
        /// Length error
        /// </summary>
        InvalidLength = 0x00000064,

        /// <summary>
        /// FN pointer error
        /// </summary>
        InvalidFNPointer = 0x00000065,

        /// <summary>
        /// Sort FN error
        /// </summary>
        InvalidSortFN = 0x00000066,

        #endregion

        #region Device errors

        /// <summary>
        /// Device not found
        /// </summary>
        DeviceNotFound = 0x00000080,

        /// <summary>
        /// Device busy
        /// Note: If a device busy error occurs, reissue the
        /// command after a while. The camera will become unstable.
        /// </summary>
        DeviceBusy = 0x00000081,

        /// <summary>
        /// Device error
        /// </summary>
        DeviceInvalid = 0x00000082,

        /// <summary>
        /// Device emergency
        /// </summary>
        DeviceEmergency = 0x00000083,

        /// <summary>
        /// Device memory full
        /// </summary>
        DeviceMemoryFull = 0x00000084,

        /// <summary>
        /// Internal device error
        /// </summary>
        DeviceInternalError = 0x00000085,

        /// <summary>
        /// Device parameter invalid
        /// </summary>
        DeviceInvalidParameter = 0x00000086,

        /// <summary>
        /// No disk
        /// </summary>
        DeviceNoDisk = 0x00000087,

        /// <summary>
        /// Disk error
        /// </summary>
        DeviceDiskError = 0x00000088,

        /// <summary>
        /// The CF gate has been changed
        /// </summary>
        DeviceCFGateChanged = 0x00000089,

        /// <summary>
        /// The dial has been changed
        /// </summary>
        DeviceDialChanged = 0x0000008a,

        /// <summary>
        /// Device not installed
        /// </summary>
        DeviceNotInstalled = 0x0000008b,

        /// <summary>
        /// Device connected in awake mode
        /// </summary>
        DeviceStayAwake = 0x0000008c,

        /// <summary>
        /// Device not released
        /// </summary>
        DeviceNotReleased = 0x0000008d,

        #endregion

        #region Stream errors

        /// <summary>
        /// Stream I/O error
        /// </summary>
        StreamIOError = 0x000000a0,

        /// <summary>
        /// Stream open error
        /// </summary>
        StreamNotOpen = 0x000000a1,

        /// <summary>
        /// Stream already open
        /// </summary>
        StreamAlreadyOpen = 0x000000a2,

        /// <summary>
        /// Failed to open stream
        /// </summary>
        StreamOpenError = 0x000000a3,

        /// <summary>
        /// Failed to close stream
        /// </summary>
        StreamCloseError = 0x000000a4,

        /// <summary>
        /// Stream seek error
        /// </summary>
        StreamSeekError = 0x000000a5,

        /// <summary>
        /// Stream tell error
        /// </summary>
        StreamTellError = 0x000000a6,

        /// <summary>
        /// Failed to read stream
        /// </summary>
        StreamReadError = 0x000000a7,

        /// <summary>
        /// Failed to write stream
        /// </summary>
        StreamWriteError = 0x000000a8,

        /// <summary>
        /// Permission error
        /// </summary>
        StreamPermissionError = 0x000000a9,

        /// <summary>
        /// Could not start a Thread (original PDF Says -> "Could not start reading thumbnail" O.o )
        /// </summary>
        StreamCouldntBeginThread = 0x000000aa,

        /// <summary>
        /// Invalid stream option
        /// </summary>
        StreamBadOptions = 0x000000ab,

        /// <summary>
        /// Invalid stream termination
        /// </summary>
        StreamEndOfStream = 0x000000ac,

        #endregion

        #region Communication errors

        /// <summary>
        /// Communication Port is in use
        /// </summary>
        CommunicationPortIsInUse = 0x000000c0,

        /// <summary>
        /// Communication Port disconnected
        /// </summary>
        CommunicationDisconnected = 0x000000c1,

        /// <summary>
        /// Incompatible device
        /// </summary>
        CommunicationDeviceIncompatible = 0x000000c2,

        /// <summary>
        /// Buffer full
        /// </summary>
        CommunicationBufferFull = 0x000000c3,

        /// <summary>
        /// USB bus error
        /// </summary>
        CommunicationUsbBusError = 0x000000c4,

        #endregion

        #region Camera UI lock/unlock errors

        /// <summary>
        /// Failed to lock the UI
        /// </summary>
        USBDeviceLockError = 0x000000d0,

        /// <summary>
        /// Failed to unlock the UI
        /// </summary>
        USBDeviceUnlockError = 0x000000d1,

        #endregion

        #region STI/WIA errors

        /// <summary>
        /// Unknown STI
        /// </summary>
        STIUnknownError = 0x000000e0,

        /// <summary>
        /// Internal STI error
        /// </summary>
        STIInternalError = 0x000000e1,

        /// <summary>
        /// Device creation error
        /// </summary>
        STIDeviceCreateError = 0x000000e2,

        /// <summary>
        /// Device release error
        /// </summary>
        STIDeviceReleaseError = 0x000000e3,

        /// <summary>
        /// Device startup failed
        /// </summary>
        DeviceNotLaunched = 0x000000e4,

        #endregion

        #region Other general errors

        /// <summary>
        /// Enumeration terminated (there was no suitable enumeration item)
        /// </summary>
        EnumerationNA = 0x000000f0,

        /// <summary>
        /// Called in a mode when the function could not be used
        /// </summary>
        InvalidFunctionCall = 0x000000f1,

        /// <summary>
        /// Handle not found
        /// </summary>
        HandleNotFound = 0x000000f2,

        /// <summary>
        /// Invalid ID
        /// </summary>
        InvalidId = 0x000000f3,

        /// <summary>
        /// Timeout
        /// </summary>
        WaitTimeoutError = 0x000000f4,

        /// <summary>
        /// Not used.
        /// </summary>
        LastGenericErrorPlusOne = 0x000000f5,

        #endregion

        #region PTP errors

        /// <summary>
        /// Session open error
        /// </summary>
        SessionNotOpen = 0x00002003,

        /// <summary>
        /// Invalid transaction ID
        /// </summary>
        InvalidTransactionId = 0x00002004,

        /// <summary>
        /// Transfer problem
        /// </summary>
        IncompleteTransfer = 0x00002007,

        /// <summary>
        /// Storage error
        /// </summary>
        InvalidStrageId = 0x00002008,

        /// <summary>
        /// Unsupported device property
        /// </summary>
        DevicePropertyNotSupported = 0x0000200a,

        /// <summary>
        /// Invalid object format code
        /// </summary>
        InvalidObjectFormatCode = 0x0000200b,

        /// <summary>
        /// Failed self-diagnosis
        /// </summary>
        SelfTestFailed = 0x00002011,

        /// <summary>
        /// Failed in partial deletion
        /// </summary>
        PartialDeletion = 0x00002012,

        /// <summary>
        /// Unsupported format specification
        /// </summary>
        SpecificationByFormatUnsupported = 0x00002014,

        /// <summary>
        /// Invalid object information
        /// </summary>
        InvalidObjectInformation = 0x00002015,

        /// <summary>
        /// Invalid code format
        /// </summary>
        InvalidCodeFormat = 0x00002016,

        /// <summary>
        /// Unknown vendor code
        /// </summary>
        UnknownVenderCode = 0x00002017,

        /// <summary>
        /// Capture already terminated
        /// </summary>
        CaptureAlreadyTerminated = 0x00002018,

        /// <summary>
        /// Invalid parent object
        /// </summary>
        InvalidParentObject = 0x0000201a,

        /// <summary>
        /// Invalid property format
        /// </summary>
        InvalidDevicePropertyFormat = 0x0000201b,


        /// <summary>
        /// Invalid property value
        /// </summary>
        InvalidDevicePropertyValue = 0x0000201c,

        /// <summary>
        /// Session already open
        /// </summary>
        SessionAlreadyOpen = 0x0000201e,

        /// <summary>
        /// Transaction canceled
        /// </summary>
        TransactionCancelled = 0x0000201f,

        /// <summary>
        /// Unsupported destination specification
        /// </summary>
        SpecificationOfDestinationUnsupported = 0x00002020,

        /// <summary>
        /// Unknown command
        /// </summary>
        UnknownCommand = 0x0000a001,

        /// <summary>
        /// Operation refused
        /// </summary>
        OperationRefused = 0x0000a005,

        /// <summary>
        /// Lens cover closed
        /// </summary>
        LensCoverClose = 0x0000a006,

        /// <summary>
        /// Low battery
        /// </summary>
        LowBattery = 0x0000a101,

        /// <summary>
        /// Image data set not ready for live view
        /// </summary>
        ObjectNotready = 0x0000a102,

        #endregion

        #region Image Capturing errors

        /// <summary>
        /// Focus failed
        /// </summary>
        TakePictureAutoFocusNG = 0x00008d01,

        /// <summary>
        /// Reserved
        /// </summary>
        TakePictureReserved = 0x00008d02,

        /// <summary>
        /// Currently configuring mirror up
        /// </summary>
        TakePictureMirrorUpNG = 0x00008d03,

        /// <summary>
        /// Currently cleaning sensor
        /// </summary>
        TakePictureSensorCleaningNG = 0x00008d04,

        /// <summary>
        /// Currently performing silent operations
        /// </summary>
        TakePictureSilenceNG = 0x00008d05,

        /// <summary>
        /// Card not installed
        /// </summary>
        TakePictureNoCardNG = 0x00008d06,

        /// <summary>
        /// Error writing to card
        /// </summary>
        TakePictureCardNG = 0x00008d07,

        /// <summary>
        /// Card write protected
        /// </summary>
        TakePictureCardProtectNG = 0x00008d08,

        #endregion

        #region Custom errors

        /// <summary>
        /// Represents an Unknown Return Value
        /// </summary>
        UnknownReturnValue = 0xffffffff,

        #endregion

        #endregion
    }
}
