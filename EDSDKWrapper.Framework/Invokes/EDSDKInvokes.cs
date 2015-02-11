using System;
using System.Runtime.InteropServices;
using EDSDKWrapper.Framework.Enums;
using EDSDKWrapper.Framework.Structs;

namespace EDSDKWrapper.Framework.Invokes
{
    /// <summary>
    /// Native Invokes of EDSDK.dll
    /// </summary>
    /// <remarks></remarks>
    public static class EDSDKInvokes
    {
        #region Basic Functions

        /// <summary>
        /// Initializes the libraries.
        /// When using the EDSDK libraries, you must call this API once
        /// before using EDSDK APIs.
        /// </summary>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsInitializeSDK")]
        public extern static UInt32 InitializeSDK();

        /// <summary>
        /// Terminates use of the libraries.
        /// This function muse be called when ending the SDK.
        /// Calling this function releases all resources allocated by the libraries.
        /// </summary>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsTerminateSDK")]
        public extern static UInt32 TerminateSDK();

        #endregion

        #region Reference-counter operating Functions

        /// <summary>
        /// Increments the reference counter of existing objects.
        /// </summary>
        /// <param name="inRef">The reference for the item.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsRetain")]
        public extern static UInt32 Retain(IntPtr inRef);

        /// <summary>
        /// Decrements the reference counter to an object.
        /// When the reference counter reaches 0, the object is released.
        /// </summary>
        /// <param name="inRef">The reference of the item.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsRelease")]
        public extern static UInt32 Release(IntPtr inRef);

        #endregion

        #region Item-tree operating Functions

        /// <summary>
        /// Gets the number of child objects of the designated object.
        /// Example: Number of files in a directory
        /// </summary>
        /// <param name="inRef">The reference of the list.</param>
        /// <param name="outCount">The out count.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetChildCount")]
        public extern static UInt32 GetChildCount(IntPtr inRef, out int outCount);

        /// <summary>
        /// Gets an indexed child object of the designated object.
        /// </summary>
        /// <param name="inRef">The reference of the item.</param>
        /// <param name="inIndex">The index that is passed in, is zero based.</param>
        /// <param name="outRef">The pointer which receives reference of the specified index.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetChildAtIndex")]
        public extern static UInt32 GetChildAtIndex(IntPtr inRef, int inIndex, out IntPtr outRef);

        /// <summary>
        /// Gets the parent object of the designated object.
        /// </summary>
        /// <param name="inRef">TThe reference of the item.</param>
        /// <param name="outParentRef">The pointer which receives reference.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetParent")]
        public extern static UInt32 GetParent(IntPtr inRef, out IntPtr outParentRef);

        #endregion

        #region Property operating Functions

        /// <summary>
        /// Gets the byte size and data type of a designated property
        /// from a camera object or image object.
        /// </summary>
        /// <param name="inRef">The reference of the item.</param>
        /// <param name="inPropertyID">The ProprtyID</param>
        /// <param name="inParam">Additional information of property.
        /// We use this parameter in order to specify an index
        /// in case there are two or more values over the same ID.</param>
        /// <param name="outDataType">Pointer to the buffer that is to receive the property type data.</param>
        /// <param name="outSize">Pointer to the buffer that is to receive the property size.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetPropertySize")]
        public extern static UInt32 GetPropertySize(IntPtr inRef, UInt32 inPropertyID, int inParam,
             out DataType outDataType, out int outSize);

        /// <summary>
        /// Gets property information from the object designated in inRef.
        /// </summary>
        /// <param name="inRef">The reference of the item.</param>
        /// <param name="inPropertyID">The ProprtyID.</param>
        /// <param name="inParam">Additional information of property.
        /// We use this parameter in order to specify an index
        /// in case there are two or more values over the same ID.</param>
        /// <param name="inPropertySize">The number of bytes of the prepared buffer for receive property-value.</param>
        /// <param name="outPropertyData">The buffer pointer to receive property-value.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetPropertyData")]
        public extern static UInt32 GetPropertyData(IntPtr inRef, UInt32 inPropertyID, int inParam,
             int inPropertySize, IntPtr outPropertyData);

        

        /// <summary>
        /// Sets property data for the object designated in inRef.
        /// </summary>
        /// <param name="inRef">The reference of the item.</param>
        /// <param name="inPropertyID">The ProprtyID</param>
        /// <param name="inParam">Additional information of property.</param>
        /// <param name="inPropertySize">The number of bytes of the prepared buffer for set property-value.</param>
        /// <param name="inPropertyData">The buffer pointer to set property-value.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSetPropertyData")]
        public extern static UInt32 SetPropertyData(IntPtr inRef, UInt32 inPropertyID,
             int inParam, int inPropertySize, [MarshalAs(UnmanagedType.AsAny), In] object inPropertyData);

        /// <summary>
        /// Gets a list of property data that can be set for the object designated in inRef,
        /// as well as maximum and minimum values.
        /// This API is intended for only some shooting-related properties.
        /// </summary>
        /// <param name="inRef">The reference of the camera.</param>
        /// <param name="inPropertyID">The ProprtyID</param>
        /// <param name="outPropertyDesc">Array of the value which can be set up.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetPropertyDesc")]
        public extern static UInt32 GetPropertyDescription(IntPtr inRef, UInt32 inPropertyID,
             out PropertyDescription outPropertyDesc);

        #endregion

        #region Device-list and device operating Functions

        /// <summary>
        /// Gets camera list objects.
        /// </summary>
        /// <param name="outCameraListRef">Pointer to the camera-list.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetCameraList")]
        public extern static UInt32 GetCameraList(out IntPtr outCameraListRef);

        #endregion

        #region Camera operating Functions

        /// <summary>
        /// Gets device information, such as the device name.
        /// Because device information of remote cameras is stored
        /// on the host computer, you can use this API
        /// before the camera object initiates communication
        /// (that is, before a session is opened).
        /// </summary>
        /// <param name="inCameraRef">The reference of the camera.</param>
        /// <param name="outDeviceInfo">Information as device of camera.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetDeviceInfo")]
        public extern static UInt32 GetDeviceInformation(IntPtr inCameraRef, out DeviceInformation outDeviceInfo);

        /// <summary>
        /// Establishes a logical connection with a remote camera.
        /// Use this API after getting the camera's EdsCamera object.
        /// </summary>
        /// <param name="inCameraRef">The reference of the camera</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsOpenSession")]
        public extern static UInt32 OpenSession(IntPtr inCameraRef);

        /// <summary>
        /// Closes a logical connection with a remote camera.
        /// </summary>
        /// <param name="inCameraRef">The reference of the camera</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCloseSession")]
        public extern static UInt32 CloseSession(IntPtr inCameraRef);

        /// <summary>
        /// Sends a command such as "Shoot" to a remote camera.
        /// </summary>
        /// <param name="inCameraRef">The reference of the camera which will receive the command.</param>
        /// <param name="inCommand">Specifies the command to be sent.</param>
        /// <param name="inParam">Specifies additional command-specific information.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSendCommand")]
        public extern static UInt32 SendCommand(IntPtr inCameraRef, UInt32 inCommand, int inParam);

        /// <summary>
        /// Sets the remote camera state or mode.
        /// </summary>
        /// <param name="inCameraRef">The reference of the camera which will receive the command.</param>
        /// <param name="inStatusCommand">Specifies the command to be sent.</param>
        /// <param name="inParam">The in param.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSendStatusCommand")]
        public extern static UInt32 SendStatusCommand(IntPtr inCameraRef, UInt32 inStatusCommand, int inParam);

        /// <summary>
        /// Sets the remaining HDD capacity on the host computer
        /// (excluding the portion from image transfer),
        /// as calculated by subtracting the portion from the previous time.
        /// Set a reset flag initially and designate the cluster length
        /// and number of free clusters.
        /// Some type 2 protocol standard cameras can display the number of shots
        /// left on the camera based on the available disk capacity
        /// of the host computer.
        /// For these cameras, after the storage destination is set to the computer,
        /// use this API to notify the camera of the available disk capacity
        /// of the host computer.
        /// </summary>
        /// <param name="inCameraRef">The reference of the camera which will receive the command.</param>
        /// <param name="inCapacity">The remaining capacity of a transmission place.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSetCapacity")]
        public extern static UInt32 SetCapacity(IntPtr inCameraRef, Capacity inCapacity);

        #endregion

        #region Volume operating Functions

        /// <summary>
        /// Gets volume information for a memory card in the camera.
        /// </summary>
        /// <param name="inVolumeRef">The reference of the volume.</param>
        /// <param name="outVolumeInfo">information of  the volume.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetVolumeInfo")]
        public extern static UInt32 GetVolumeInformation(IntPtr inVolumeRef, out VolumeInformation outVolumeInfo);

        /// <summary>
        /// Formats the volume.
        /// </summary>
        /// <param name="inVolumeRef">The reference of the volume.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsFormatVolume")]
        public extern static UInt32 FormatVolume(IntPtr inVolumeRef);

        #endregion

        #region Directory-item operating Functions

        /// <summary>
        /// Gets information about the directory or file objects
        /// on the memory card (volume) in a remote camera.
        /// </summary>
        /// <param name="inDirItemRef">The reference of the directory item.</param>
        /// <param name="outDirItemInfo">information of the directory item.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetDirectoryItemInfo")]
        public extern static UInt32 GetDirectoryItemInformation(IntPtr inDirItemRef,
             out DirectoryItemInformation outDirItemInfo);

        /// <summary>
        /// Deletes a camera folder or file.
        /// If folders with subdirectories are designated, all files are deleted
        /// except protected files.
        /// EdsDirectoryItem objects deleted by means of this API are implicitly
        /// released by the EDSDK. Thus, there is no need to release them
        /// by means of EdsRelease.
        /// </summary>
        /// <param name="inDirItemRef">The reference of the directory item.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsDeleteDirectoryItem")]
        public extern static UInt32 DeleteDirectoryItem(IntPtr inDirItemRef);

        /// <summary>
        /// Downloads a file on a remote camera
        /// (in the camera memory or on a memory card) to the host computer.
        /// The downloaded file is sent directly to a file stream created in advance.
        /// When dividing the file being retrieved, call this API repeatedly.
        /// Also in this case, make the data block size a multiple of 512 (bytes),
        /// excluding the final block.
        /// </summary>
        /// <param name="inDirItemRef">The reference of the directory item.</param>
        /// <param name="inReadSize">Size to read.</param>
        /// <param name="outStream">The reference of the stream.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsDownload")]
        public extern static UInt32 Download(IntPtr inDirItemRef, UInt32 inReadSize, IntPtr outStream);

        /// <summary>
        /// Must be executed when downloading of a directory item is canceled.
        /// Calling this API makes the camera cancel file transmission.
        /// It also releases resources.
        /// This operation need not be executed when using EdsDownloadThumbnail.
        /// </summary>
        /// <param name="inDirItemRef">The reference of the directory item.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsDownloadCancel")]
        public extern static UInt32 DownloadCancel(IntPtr inDirItemRef);

        /// <summary>
        /// Must be called when downloading of directory items is complete.
        /// Executing this API makes the camera
        /// recognize that file transmission is complete.
        /// This operation need not be executed when using EdsDownloadThumbnail.
        /// </summary>
        /// <param name="inDirItemRef">The reference of the directory item.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsDownloadComplete")]
        public extern static UInt32 DownloadComplete(IntPtr inDirItemRef);

        /// <summary>
        /// Extracts and downloads thumbnail information from image files in a camera.
        /// Thumbnail information in the camera's image files is downloaded
        /// to the host computer.
        /// Downloaded thumbnails are sent directly to a file stream created in advance.
        /// </summary>
        /// <param name="inDirItemRef">The reference of the directory item.</param>
        /// <param name="outStream">The reference of the stream.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsDownloadThumbnail")]
        public extern static UInt32 DownloadThumbnail(IntPtr inDirItemRef, IntPtr outStream);

        /// <summary>
        /// Gets attributes of files on a camera.
        /// </summary>
        /// <param name="inDirItemRef">The reference of the directory item.</param>
        /// <param name="outFileAttribute">Indicates the file attributes.
        /// As for the file attributes, OR values of the value defined
        /// by enum EdsFileAttributes can be retrieved. Thus, when
        /// determining the file attributes, you must check
        /// if an attribute flag is set for target attributes.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetAttribute")]
        public extern static UInt32 GetAttribute(IntPtr inDirItemRef, out FileAttribute outFileAttribute);

        /// <summary>
        /// Changes attributes of files on a camera.
        /// </summary>
        /// <param name="inDirItemRef">The reference of the directory item.</param>
        /// <param name="inFileAttribute">Indicates the file attributes.
        /// As for the file attributes, OR values of the value
        /// defined by enum EdsFileAttributes can be retrieved.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSetAttribute")]
        public extern static UInt32 SetAttribute(IntPtr inDirItemRef, FileAttribute inFileAttribute);

        #endregion

        #region Stream operating Functions

        /// <summary>
        /// Creates a new file on a host computer (or opens an existing file)
        /// and creates a file stream for access to the file.
        /// If a new file is designated before executing this API,
        /// the file is actually created following the timing of writing
        /// by means of EdsWrite or the like with respect to an open stream.
        /// </summary>
        /// <param name="inFileName">Pointer to a null-terminated string that specifies the file name.</param>
        /// <param name="inCreateDisposition">The in create disposition.</param>
        /// <param name="inDesiredAccess">The in desired access.</param>
        /// <param name="outStream">The reference of the stream.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCreateFileStream")]
        public extern static UInt32 CreateFileStream(string inFileName, FileCreateDisposition inCreateDisposition,
             Access inDesiredAccess, out IntPtr outStream);

        /// <summary>
        /// Creates a stream in the memory of a host computer.
        /// In the case of writing in excess of the allocated buffer size,
        /// the memory is automatically extended.
        /// </summary>
        /// <param name="inBufferSize">The number of bytes of the memory to allocate.</param>
        /// <param name="outStream">The reference of the stream.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCreateMemoryStream")]
        public extern static UInt32 CreateMemoryStream(UInt32 inBufferSize, out IntPtr outStream);

        /// <summary>
        /// Creates a stream in the memory of a host computer.
        /// In the case of writing in excess of the allocated buffer size,
        /// the memory is automatically extended.
        /// </summary>
        /// <param name="inFileName">Pointer to a null-terminated string that specifies the file name.</param>
        /// <param name="inCreateDisposition">Action to take on files that exist, and which action to take when files do not exist.</param>
        /// <param name="inDesiredAccess">Access to the stream (reading, writing, or both).</param>
        /// <param name="outStream">The reference of the stream.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCreateStreamEx")]
        public extern static UInt32 CreateStreamEx(
           string inFileName,
           FileCreateDisposition inCreateDisposition,
           Access inDesiredAccess,
           out IntPtr outStream
           );

        /// <summary>
        /// Creates a stream from the memory buffer you prepare.
        /// Unlike the buffer size of streams created by means of EdsCreateMemoryStream,
        /// the buffer size you prepare for streams created this way does not expand.
        /// </summary>
        /// <param name="inUserBuffer">The number of bytes of the memory to allocate.</param>
        /// <param name="inBufferSize">Size of the buffer.</param>
        /// <param name="outStream">The reference of the stream.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCreateMemoryStreamFromPointer")]
        public extern static UInt32 CreateMemoryStreamFromPointer(IntPtr inUserBuffer,
             UInt32 inBufferSize, out IntPtr outStream);

        /// <summary>
        /// Gets the pointer to the start address of memory managed by the memory stream.
        /// As the EDSDK automatically resizes the buffer, the memory stream provides
        /// you with the same access methods as for the file stream.
        /// If access is attempted that is excessive with regard to the buffer size
        /// for the stream, data before the required buffer size is allocated
        /// is copied internally, and new writing occurs.
        /// Thus, the buffer pointer might be switched on an unknown timing.
        /// Caution in use is therefore advised.
        /// </summary>
        /// <param name="inStreamRef">Designate the memory stream for the pointer to retrieve.</param>
        /// <param name="outPointer">If successful, returns the pointer to the buffer written in the memory stream.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetPointer")]
        public extern static UInt32 GetPointer(IntPtr inStreamRef, out IntPtr outPointer);

        /// <summary>
        /// Reads data the size of inReadSize into the outBuffer buffer,
        /// starting at the current read or write position of the stream.
        /// The size of data actually read can be designated in outReadSize.
        /// </summary>
        /// <param name="inStreamRef">The reference of the stream or image.</param>
        /// <param name="inReadSize">The number of bytes to read.</param>
        /// <param name="outBuffer">Pointer to the user-supplied buffer that is to receive the data read from the stream.</param>
        /// <param name="outReadSize">The actually read number of bytes.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsRead")]
        public extern static UInt32 Read(IntPtr inStreamRef, UInt32 inReadSize, IntPtr outBuffer,
             out UInt32 outReadSize);

        /// <summary>
        /// Writes data of a designated buffer
        /// to the current read or write position of the stream.
        /// </summary>
        /// <param name="inStreamRef">The reference of the stream or image.</param>
        /// <param name="inWriteSize">The number of bytes to write.</param>
        /// <param name="inBuffer">A pointer to the user-supplied buffer that contains the data to be written to the stream.</param>
        /// <param name="outWrittenSize">The actually written-in number of bytes.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsWrite")]
        public extern static UInt32 Write(IntPtr inStreamRef, UInt32 inWriteSize, IntPtr inBuffer,
             out UInt32 outWrittenSize);

        /// <summary>
        /// Moves the read or write position of the stream
        /// (that is, the file position indicator).
        /// </summary>
        /// <param name="inStreamRef">The reference of the stream or image.</param>
        /// <param name="inSeekOffset">Number of bytes to move the pointer.</param>
        /// <param name="inSeekOrigin">Pointer movement mode. Must be one of the following values.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSeek")]
        public extern static UInt32 Seek(IntPtr inStreamRef, int inSeekOffset, SeekOrigin inSeekOrigin);

        /// <summary>
        /// Gets the current read or write position of the stream
        /// (that is, the file position indicator).
        /// </summary>
        /// <param name="inStreamRef">The reference of the stream or image.</param>
        /// <param name="outPosition">The current stream pointer.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetPosition")]
        public extern static UInt32 GetPosition(IntPtr inStreamRef, out UInt32 outPosition);

        /// <summary>
        /// Gets the stream size.
        /// </summary>
        /// <param name="inStreamRef">The reference of the stream or image.</param>
        /// <param name="outLength">The length of the stream.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetLength")]
        public extern static UInt32 GetLength(IntPtr inStreamRef, out UInt32 outLength);

        /// <summary>
        /// Copies data from the copy source stream to the copy destination stream.
        /// The read or write position of the data to copy is determined from
        /// the current file read or write position of the respective stream.
        /// After this API is executed, the read or write positions of the copy source
        /// and copy destination streams are moved an amount corresponding to
        /// inWriteSize in the positive direction.
        /// </summary>
        /// <param name="inStreamRef">The reference of the stream or image.</param>
        /// <param name="inWriteSize">The number of bytes to copy.</param>
        /// <param name="outStreamRef">The reference of the stream or image.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCopyData")]
        public extern static UInt32 CopyData(IntPtr inStreamRef, UInt32 inWriteSize, IntPtr outStreamRef);

        /// <summary>
        /// Register a progress callback function.
        /// An event is received as notification of progress during processing that
        /// takes a relatively long time, such as downloading files from a
        /// remote camera.
        /// If you register the callback function, the EDSDK calls the callback
        /// function during execution or on completion of the following APIs.
        /// This timing can be used in updating on-screen progress bars, for example.
        /// </summary>
        /// <param name="inRef">The reference of the stream or image.</param>
        /// <param name="inProgressFunc">Pointer to a progress callback function.</param>
        /// <param name="inProgressOption">The option about progress is specified.</param>
        /// <param name="inContext">The in context.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSetProgressCallback")]
        public extern static UInt32 SetProgressCallback(IntPtr inRef, EdsProgressCallback inProgressFunc,
             ProgressOption inProgressOption, IntPtr inContext);

        #endregion

        #region Image operating Functions

        /// <summary>
        /// Creates an image object from an image file.
        /// Without modification, stream objects cannot be worked with as images.
        /// Thus, when extracting images from image files,
        /// you must use this API to create image objects.
        /// The image object created this way can be used to get image information
        /// (such as the height and width, number of color components, and
        /// resolution), thumbnail image data, and the image data itself.
        /// </summary>
        /// <param name="inStreamRef">The reference of the stream.</param>
        /// <param name="outImageRef">The reference of the image.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCreateImageRef")]
        public extern static UInt32 CreateImageReference(IntPtr inStreamRef, out IntPtr outImageRef);

        /// <summary>
        /// Gets image information from a designated image object.
        /// Here, image information means the image width and height,
        /// number of color components, resolution, and effective image area.
        /// </summary>
        /// <param name="inImageRef">Designate the object for which to get image information.</param>
        /// <param name="inImageSource">Of the various image data items in the image file,
        /// designate the type of image data representing the
        /// information you want to get. Designate the image as
        /// defined in Enum EdsImageSource.</param>
        /// <param name="outImageInfo">The out image info.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetImageInfo")]
        public extern static UInt32 GetImageInformation(IntPtr inImageRef, ImageSource inImageSource,
              out ImageInformation outImageInfo);

        /// <summary>
        /// Gets designated image data from an image file, in the form of a
        /// designated rectangle.
        /// Returns uncompressed results for JPEGs and processed results
        /// in the designated pixel order (RGB, Top-down BGR, and so on) for
        /// RAW images.
        /// Additionally, by designating the input/output rectangle,
        /// it is possible to get reduced, enlarged, or partial images.
        /// However, because images corresponding to the designated output rectangle
        /// are always returned by the SDK, the SDK does not take the aspect
        /// ratio into account.
        /// To maintain the aspect ratio, you must keep the aspect ratio in mind
        /// when designating the rectangle.
        /// </summary>
        /// <param name="inImageRef">Designate the image object for which to get the image data.</param>
        /// <param name="inImageSource">Designate the type of image data to get from
        /// the image file (thumbnail, preview, and so on).
        /// Designate values as defined in Enum EdsImageSource.</param>
        /// <param name="inImageType">Designate the output image type. Because
        /// the output format of EdGetImage may only be RGB, only
        /// kEdsTargetImageType_RGB or kEdsTargetImageType_RGB16
        /// can be designated.
        /// However, image types exceeding the resolution of
        /// inImageSource cannot be designated.</param>
        /// <param name="inSrcRect">Designate the coordinates and size of the rectangle to be retrieved (processed) from the source image.</param>
        /// <param name="inDstSize">Size of the in DST.</param>
        /// <param name="outStreamRef">Designate the rectangle size for output.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsGetImage")]
        public extern static UInt32 GetImage(IntPtr inImageRef, ImageSource inImageSource,
             TargetImageType inImageType, Rectangle inSrcRect, Size inDstSize, IntPtr outStreamRef);

        /// <summary>
        /// Saves as a designated image type after RAW processing.
        /// When saving with JPEG compression,
        /// the JPEG quality setting applies with respect to EdsOptionRef.
        /// </summary>
        /// <param name="inImageRef">Designate the image object for which to produce the file.</param>
        /// <param name="inImageType">Designate the image type to produce. Designate the following image types.</param>
        /// <param name="inSaveSetting">Designate saving options, such as JPEG image quality.</param>
        /// <param name="outStreamRef">Specifies the output file stream. The memory stream cannot be specified here.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSaveImage")]
        public extern static UInt32 SaveImage(IntPtr inImageRef, TargetImageType inImageType,
             SaveImageSetting inSaveSetting, IntPtr outStreamRef);

        /// <summary>
        /// Switches a setting on and off for creation of an image cache in the SDK
        /// for a designated image object during extraction (processing) of
        /// the image data.
        /// Creating the cache increases the processing speed, starting from
        /// the second time.
        /// </summary>
        /// <param name="inImageRef">The reference of the image.</param>
        /// <param name="inUseCache">If cache image data or not
        /// If set to FALSE, the cached image data will released.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCacheImage")]
        public extern static UInt32 CacheImage(IntPtr inImageRef, bool inUseCache);

        /// <summary>
        /// Description:
        /// Incorporates image object property changes
        /// (effected by means of EdsSetPropertyData) in the stream.
        /// </summary>
        /// <param name="inImageRef">The reference of the image.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsReflectImageProperty")]
        public extern static UInt32 ReflectImageProperty(IntPtr inImageRef);

        #endregion

        #region Event handler registering Functions

        /// <summary>
        /// Registers a callback function for when a camera is detected.
        /// </summary>
        /// <param name="inCameraAddedHandler">Pointer to a callback function
        /// called when a camera is connected physically</param>
        /// <param name="inContext">Specifies an application-defined value to be sent to
        /// the callback function pointed to by CallBack parameter.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSetCameraAddedHandler")]
        public extern static UInt32 SetCameraAddedHandler(EdsCameraAddedHandler inCameraAddedHandler,
              IntPtr inContext);

        /// <summary>
        /// Registers a callback function for receiving status
        /// change notification events for property states on a camera.
        /// </summary>
        /// <param name="inCameraRef">Designate the camera object.</param>
        /// <param name="inEvnet">Designate one or all events to be supplemented.</param>
        /// <param name="inPropertyEventHandler">Designate the pointer to the callback
        /// function for receiving property-related camera events.</param>
        /// <param name="inContext">Designate application information to be passed by
        /// means of the callback function. Any data needed for
        /// your application can be passed.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSetPropertyEventHandler")]
        public extern static UInt32 SetPropertyEventHandler(IntPtr inCameraRef, UInt32 inEvnet,
             EdsPropertyEventHandler inPropertyEventHandler, IntPtr inContext);

        /// <summary>
        /// Registers a callback function for receiving status
        /// change notification events for objects on a remote camera.
        /// Here, object means volumes representing memory cards, files and directories,
        /// and shot images stored in memory, in particular.
        /// </summary>
        /// <param name="inCameraRef">Designate the camera object.</param>
        /// <param name="inEvnet">Designate one or all events to be supplemented. To designate all events, use kEdsObjectEvent_All.</param>
        /// <param name="inObjectEventHandler">Designate the pointer to the callback function for receiving object-related camera events.</param>
        /// <param name="inContext">Passes inContext without modification, as designated as an EdsSetObjectEventHandler argument.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSetObjectEventHandler")]
        public extern static UInt32 SetObjectEventHandler(IntPtr inCameraRef, UInt32 inEvnet,
             EdsObjectEventHandler inObjectEventHandler, IntPtr inContext);

        /// <summary>
        /// Registers a callback function for receiving status
        /// change notification events for property states on a camera.
        /// </summary>
        /// <param name="inCameraRef">Designate the camera object.</param>
        /// <param name="inEvnet">Designate one or all events to be supplemented.
        /// To designate all events, use kEdsStateEvent_All.</param>
        /// <param name="inStateEventHandler">Designate the pointer to the callback function
        /// for receiving events related to camera object states.</param>
        /// <param name="inContext">Designate application information to be passed
        /// by means of the callback function. Any data needed for
        /// your application can be passed.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsSetCameraStateEventHandler")]
        public extern static UInt32 SetCameraStateEventHandler(IntPtr inCameraRef, UInt32 inEvnet,
             EdsStateEventHandler inStateEventHandler, IntPtr inContext);

        /// <summary>
        /// Creates an object used to get the live view image data set.
        /// </summary>
        /// <param name="inStreamRef">The stream reference which opened to get EVF JPEG image.</param>
        /// <param name="outEvfImageRef">The EVFData reference.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsCreateEvfImageRef", CallingConvention = CallingConvention.Cdecl)]
        public extern static UInt32 CreateEvfImageRef(IntPtr inStreamRef, out IntPtr outEvfImageRef);

        /// <summary>
        /// Downloads the live view image data set for a camera currently in live view mode.
        /// Live view can be started by using the property ID:kEdsPropertyID_Evf_OutputDevice and
        /// data:EdsOutputDevice_PC to call EdsSetPropertyData.
        /// In addition to image data, information such as zoom, focus position, and histogram data
        /// is included in the image data set. Image data is saved in a stream maintained by EdsEvfImageRef
        /// EdsGetPropertyData can be used to get information such as the zoom, focus position, etc.
        /// Although the information of the zoom and focus position can be obtained from EdsEvfImageRef,
        /// settings are applied to EdsCameraRef.
        /// </summary>
        /// <param name="inCameraRef">The Camera reference.</param>
        /// <param name="outEvfImageRef">The EVFData reference.</param>
        /// <returns>Any of the <see cref="ReturnValue"/> return values.</returns>
        /// <remarks></remarks>
        [DllImport("EDSDK.dll", EntryPoint = "EdsDownloadEvfImage", CallingConvention = CallingConvention.Cdecl)]
        public extern static UInt32 DownloadEvfImage(IntPtr inCameraRef, IntPtr outEvfImageRef);

        #endregion

        #region Callback Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inPercent">The in percent.</param>
        /// <param name="inContext">The in context.</param>
        /// <param name="outCancel">if set to <c>true</c> [out cancel].</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public delegate UInt32 EdsProgressCallback(UInt32 inPercent, IntPtr inContext, ref bool outCancel);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inContext">The in context.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public delegate UInt32 EdsCameraAddedHandler(IntPtr inContext);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inEvent">The in event.</param>
        /// <param name="inPropertyID">The in property ID.</param>
        /// <param name="inParam">The in param.</param>
        /// <param name="inContext">The in context.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public delegate UInt32 EdsPropertyEventHandler(UInt32 inEvent, UInt32 inPropertyID, UInt32 inParam, IntPtr inContext);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inEvent">The in event.</param>
        /// <param name="inRef">The in ref.</param>
        /// <param name="inContext">The in context.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public delegate UInt32 EdsObjectEventHandler(UInt32 inEvent, IntPtr inRef, IntPtr inContext);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inEvent">The in event.</param>
        /// <param name="inParameter">The in parameter.</param>
        /// <param name="inContext">The in context.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public delegate UInt32 EdsStateEventHandler(UInt32 inEvent, UInt32 inParameter, IntPtr inContext);

        #endregion
    }
}
