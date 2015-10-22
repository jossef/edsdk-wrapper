using System;
using EDSDKWrapper.Framework.Invokes;
using EDSDKWrapper.Framework.Managers;
using EDSDKWrapper.Framework.Enums;
using EDSDKWrapper.Framework.Structs;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
namespace EDSDKWrapper.Framework.Objects
{
    /// <summary>
    /// Represents a Camera
    /// </summary>
    /// <remarks></remarks>
    public class Camera : Item
    {
        #region Constants

        // public const UInt32 AC_POWER_SOURCE = 0xffffffff;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the camera time.
        /// </summary>
        /// <remarks></remarks>
        public DateTime CameraTime
        {
            get
            {
                return this.GetDateTimeProperty(PropertyId.DateTime);
            }
        }

        /// <summary>
        /// Gets the battery level.
        /// </summary>
        /// <remarks></remarks>
        public UInt32 BatteryLevel
        {
            get
            {
                return this.GetUInt32Property(PropertyId.BatteryLevel);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the power source is AC.
        /// </summary>
        /// <remarks></remarks>
        public bool ACPowerSource
        {
            get
            {
                return this.BatteryLevel == (UInt32)Enums.BatteryQuality.AC;
            }
        }

        /// <summary>
        /// Gets the level of degradation of the battery.
        /// </summary>
        /// <remarks></remarks>
        public Enums.BatteryQuality BatteryQuality
        {
            get
            {
                return (Enums.BatteryQuality)this.GetUInt32Property(PropertyId.BatteryQuality);
            }
        }

        // TODO: make this property enabled
        ///// <summary>
        ///// Indicates the image quality.
        ///// this property indicates the current image quality set on the camera.
        ///// </summary>
        ///// <remarks></remarks>
        //public override ImageQuality ImageQuality 
        //{
        //    get
        //    {
        //        return base.ImageQuality;
        //    }
        //    set
        //    {

        //    }
        //}

        // TODO: make this property enabled
        ///// <summary>
        ///// Gets the JPEG quality.
        ///// Indicates the JPEG compression.
        ///// In the inParam argument, designate Image Size as retrieved by means of the kEdsPropID_ImageQuality property.
        ///// </summary>
        ///// <value>An integer value of 0–10. (0 if uncompressed.)</value>
        ///// <remarks></remarks>
        ///// <exception cref="ArgumentOutOfRangeException">when the given value is bigger then 10.</exception>
        //public override UInt32 JpegQuality
        //{
        //    get
        //    {
        //        return base.JpegQuality;
        //    }
        //    set
        //    {
        //        if (value > 10)
        //        {
        //            throw new ArgumentOutOfRangeException("JpegQuality");
        //        }

        //        this.SetUInt32Property(PropertyId.JpegQuality, value);
        //    }
        //}

        /// <summary>
        /// Indicates settings values of the camera in shooting mode.
        /// </summary>
        /// <value>AEMode</value>
        /// <remarks>You cannot set this property on cameras with a mode dial.</remarks>
        public AEMode AEMode
        {
            get
            {
                return (AEMode)this.GetUInt32Property(PropertyId.AEMode);
            }
            set
            {
                this.SetUInt32Property(PropertyId.AEMode, (UInt32)value);
            }
        }

        /// <summary>
        /// Indicates settings values of the camera in drive mode.
        /// </summary>
        /// <value>The drive mode.</value>
        /// <remarks></remarks>
        public DriveMode DriveMode
        {
            get
            {
                return (DriveMode)this.GetUInt32Property(PropertyId.DriveMode);
            }
            set
            {
                this.SetUInt32Property(PropertyId.DriveMode, (UInt32)value);
            }
        }
        /// <summary>
        /// Gets the level of degradation of the battery.
        /// </summary>
        /// <remarks></remarks>
        public CameraISOSensitivity ISOSensitivity
        {
            get
            {
                return (CameraISOSensitivity)this.GetUInt32Property(PropertyId.ISOSpeed);
            }
            set
            {
                this.SetUInt32Property(PropertyId.ISOSpeed, (UInt32)value);
            }
        }

        /// <summary>
        /// Gets the supported ISO sensitivity values.
        /// </summary>
        /// <remarks></remarks>
        public IEnumerable<CameraISOSensitivity> SupportedISOSensitivityValues
        {
            get
            {
                return GetSupportedEnumProperties<CameraISOSensitivity>(PropertyId.ISOSpeed);
            }
        }

        /// <summary>
        /// Indicates the camera's aperture value.
        /// </summary>
        /// <value>The aperture value.</value>
        /// <remarks></remarks>
        public MeteringMode MeteringMode
        {
            get
            {
                return (MeteringMode)this.GetUInt32Property(PropertyId.MeteringMode);
            }
            set
            {
                this.SetUInt32Property(PropertyId.MeteringMode, (UInt32)value);
            }
        }

        /// <summary>
        /// Gets the supported aperture values.
        /// </summary>
        /// <remarks></remarks>
        public IEnumerable<MeteringMode> SupportedMeteringModes
        {
            get
            {
                return GetSupportedEnumProperties<MeteringMode>(PropertyId.MeteringMode);
            }
        }

        /// <summary>
        /// Indicates the camera's aperture value.
        /// </summary>
        /// <value>The aperture value.</value>
        /// <remarks></remarks>
        public ApertureValue ApertureValue
        {
            get
            {
                return (ApertureValue)this.GetUInt32Property(PropertyId.Av);
            }
            set
            {
                this.SetUInt32Property(PropertyId.Av, (UInt32)value);
            }
        }

        /// <summary>
        /// Gets the supported aperture values.
        /// </summary>
        /// <remarks></remarks>
        public IEnumerable<ApertureValue> SupportedApertureValues
        {
            get
            {
                return GetSupportedEnumProperties<ApertureValue>(PropertyId.Av);
            }
        }

        /// <summary>
        /// Indicates the shutter speed.
        /// </summary>
        /// <value>The aperture value.</value>
        /// <remarks></remarks>
        public ShutterSpeed ShutterSpeed
        {
            get
            {
                return (ShutterSpeed)this.GetUInt32Property(PropertyId.Tv);
            }
            set
            {
                this.SetUInt32Property(PropertyId.Tv, (UInt32)value);
            }
        }

        /// <summary>
        /// Indicates the shutter speed.
        /// </summary>
        /// <remarks></remarks>
        public IEnumerable<ShutterSpeed> SupportedShutterSpeeds
        {
            get
            {
                return GetSupportedEnumProperties<ShutterSpeed>(PropertyId.Tv);
            }
        }

        /// <summary>
        /// Gets or sets the exposure compensation.
        /// </summary>
        /// <value>The exposure compensation.</value>
        /// <remarks>Exposure compensation is not available if the camera is in manual exposure mode. Thus, the exposure compensation property is invalid.</remarks>
        public ExposureCompensation ExposureCompensation
        {
            get
            {
                return (ExposureCompensation)this.GetUInt32Property(PropertyId.ExposureCompensation);
            }
            set
            {
                this.SetUInt32Property(PropertyId.ExposureCompensation, (UInt32)value);
            }
        }

        /// <summary>
        /// Gets the supported exposure compensations.
        /// </summary>
        /// <remarks></remarks>
        public IEnumerable<ExposureCompensation> SupportedExposureCompensations
        {
            get
            {
                return GetSupportedEnumProperties<ExposureCompensation>(PropertyId.ExposureCompensation);
            }
        }

        /// <summary>
        /// Indicates the flash compensation.
        /// </summary>
        /// <remarks>flash compensation cannot be retrieved for an external flash.</remarks>
        public ExposureCompensation FlashExposureCompensation
        {
            get
            {
                return (ExposureCompensation)this.GetUInt32Property(PropertyId.FlashCompensation);
            }
        }

        /// <summary>
        /// Indicates the flash compensation.
        /// </summary>
        /// <remarks>Cameras return the number of shots left on the camera based on the available disk capacity of the host computer they are connected to.</remarks>
        public UInt32 AvailableShots
        {
            get
            {
                return this.GetUInt32Property(PropertyId.AvailableShots);
            }
        }

        /// <summary>
        /// Gets the white balance.
        /// </summary>
        /// <value>The white balance.</value>
        /// <remarks></remarks>
        public WhiteBalance WhiteBalance
        {
            get
            {
                return (WhiteBalance)this.GetUInt32Property(PropertyId.WhiteBalance);
            }
            set
            {
                this.SetUInt32Property(PropertyId.WhiteBalance, (UInt32)value);
            }
        }

        /// <summary>
        /// Indicates the color temperature setting value. (Units: Kelvin).
        /// </summary>
        /// <value>The color temperature in 100-Kelvin increments. 2800–10000, 5200 represents a color temperature of 5200 K.</value>
        /// <remarks>Valid only when the white balance is set to Color Temperature.</remarks>
        public UInt32 ColorTemperature
        {
            get
            {
                return this.GetUInt32Property(PropertyId.ColorTemperature);
            }
            set
            {
                this.SetUInt32Property(PropertyId.ColorTemperature, value);
            }
        }

        /// <summary>
        /// Gets or sets the color space.
        /// </summary>
        /// <value>The color space.</value>
        /// <remarks></remarks>
        public ColorSpace ColorSpace
        {
            get
            {
                return (ColorSpace)this.GetUInt32Property(PropertyId.ColorSpace);
            }
            set
            {
                this.SetUInt32Property(PropertyId.ColorSpace, (UInt32)value);
            }
        }

        /// <summary>
        /// Indicates the picture style.
        /// </summary>
        /// <value>The picture style.</value>
        /// <remarks>This property is valid only for models supporting picture styles.</remarks>
        public PictureStyle PictureStyle
        {
            get
            {
                return (PictureStyle)this.GetUInt32Property(PropertyId.PictureStyle);
            }
            set
            {
                this.SetUInt32Property(PropertyId.PictureStyle, (UInt32)value);
            }
        }

        /// <summary>
        /// Gets or sets the picture style description.
        /// </summary>
        /// <value>The picture style description.</value>
        /// <remarks></remarks>
        public PictureStyleDescription PictureStyleDescription
        {
            get
            {
                return this.GetStructProperty<PictureStyleDescription>(PropertyId.PictureStyleDesc);
            }
            set
            {
                this.SetStructProperty<PictureStyleDescription>(PropertyId.PictureStyleDesc, value);
            }
        }

        /// <summary>
        /// Indicates the destination of images after shooting.
        /// </summary>
        /// <value>destination for saving images after shooting.</value>
        /// <remarks>
        /// If Host or Both is used, the camera caches the image data to be transferred until
        /// DownloadComplete or CancelDownload APIs are executed on the host computer (by an application). 
        /// 
        /// The application creates a callback function to receive camera events. 
        /// 
        /// If DirItemRequestTransfer or DirItemRequestTransferDT events are received, 
        /// the application must execute DownloadComplete (after downloading) or CancelDownload (if images are not needed) for the camera.
        /// </remarks>
        public SaveTo SaveTo
        {
            get
            {
                return (SaveTo)this.GetUInt32Property(PropertyId.SaveTo);
            }
            set
            {
                this.SetUInt32Property(PropertyId.SaveTo, (UInt32)value);
            }
        }

        /// <summary>
        /// Gets a <c>true</c> value indicating whether a lens is attached, Otherwise <c>false</c>.
        /// </summary>
        /// <remarks>This property can only be retrieved from images shot using models the EOS 50D or EOS 5D Mark II or later.</remarks>
        public bool LensAttached
        {
            get
            {
                return this.GetBooleanProperty(PropertyId.LensStatus);
            }
        }

        /// <summary>
        /// Gets the current storage media for the camera.
        /// </summary>
        /// <remarks></remarks>
        public string CurrentStorage
        {
            get
            {
                return this.GetStringProperty(PropertyId.CurrentStorage);
            }
        }

        /// <summary>
        /// Gets the current folder for the camera.
        /// </summary>
        /// <remarks></remarks>
        public string CurrentFolder
        {
            get
            {
                return this.GetStringProperty(PropertyId.CurrentFolder);
            }
        }

        /// <summary>
        /// Gets or sets the name of the USB storage directory.
        /// </summary>
        /// <value>USB storage directory name.</value>
        /// <remarks></remarks>
        public string USBStorageDirectoryName
        {
            get
            {
                return this.GetStringProperty(PropertyId.HDDirectoryStructure);
            }
            set
            {
                this.SetStringProperty(PropertyId.HDDirectoryStructure, value);
            }
        }

        #region LiveView

        /// <summary>
        /// Gets or sets the live view output device.
        /// </summary>
        /// <value>The live view output device.</value>
        /// <remarks></remarks>
        public LiveViewOutputDevice LiveViewOutputDevice
        {
            get
            {
                return (LiveViewOutputDevice)this.GetUInt32Property(PropertyId.LiveViewOutputDevice);
            }
            set
            {
                this.SetUInt32Property(PropertyId.LiveViewOutputDevice, (UInt32)value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the live view feature is enabled.
        /// </summary>
        /// <value><c>true</c> if live view enabled; otherwise, <c>false</c>.</value>
        /// <remarks></remarks>
        public bool LiveViewEnabled
        {
            get
            {
                return this.GetBooleanProperty(PropertyId.LiveViewMode);
            }
            set
            {
                this.SetBooleanProperty(PropertyId.LiveViewMode, value);
            }
        }

        /// <summary>
        /// Gets or sets the live view white balance.
        /// </summary>
        /// <value>The white balance.</value>
        /// <remarks></remarks>
        public WhiteBalance LiveViewWhiteBalance
        {
            get
            {
                return (WhiteBalance)this.GetUInt32Property(PropertyId.LiveViewWhiteBalance);
            }
            set
            {
                this.SetUInt32Property(PropertyId.LiveViewWhiteBalance, (UInt32)value);
            }
        }

        /// <summary>
        /// Indicates the color temperature setting value. (Units: Kelvin).
        /// </summary>
        /// <value>The color temperature in 100-Kelvin increments. 2800–10000, 5200 represents a color temperature of 5200 K.</value>
        /// <remarks>Valid only when the white balance is set to Color Temperature.</remarks>
        public UInt32 LiveViewColorTemperature
        {
            get
            {
                return this.GetUInt32Property(PropertyId.LiveViewColorTemperature);
            }
            set
            {
                this.SetUInt32Property(PropertyId.LiveViewColorTemperature, value);
            }
        }

        /// <summary>
        /// Turns the depth of field ON/OFF during Preview mode.
        /// </summary>
        /// <value><c>true</c> if ON; otherwise, <c>false</c>.</value>
        /// <remarks></remarks>
        public bool LiveViewDepthOfFieldPreview
        {
            get
            {
                return this.GetBooleanProperty(PropertyId.LiveViewDepthOfFieldPreview);
            }
            set
            {
                this.SetBooleanProperty(PropertyId.LiveViewDepthOfFieldPreview, value);
            }
        }

        /// <summary>
        /// Sets the live view zoom.
        /// </summary>
        /// <value>The live view zoom.</value>
        /// <remarks></remarks>
        public LiveViewZoom LiveViewZoom
        {
            set
            {
                this.SetUInt32Property(PropertyId.LiveViewZoom, (UInt32)value);
            }
        }

        /// <summary>
        /// Sets the live view zoom position.
        /// </summary>
        /// <value>The live view zoom position.</value>
        /// <remarks></remarks>
        public Point LiveViewZoomPosition
        {
            set
            {
                this.SetStructProperty<Point>(PropertyId.LiveViewZoomPosition, value);
            }
        }

        /// <summary>
        /// Gets or sets the live view auto focus mode.
        /// </summary>
        /// <value>The live view auto focus mode.</value>
        /// <remarks></remarks>
        public LiveViewAutoFocusMode LiveViewAutoFocusMode
        {
            get
            {
                return (LiveViewAutoFocusMode)this.GetUInt32Property(PropertyId.LiveViewAFMode);
            }
            set
            {
                this.SetUInt32Property(PropertyId.LiveViewAFMode, (UInt32)value);
            }
        }

        #endregion

        #endregion

        #region Methods

        #region Instance

        /// <summary>
        /// Initializes a new instance of the <see cref="Camera"/> class.
        /// Opens a session.
        /// </summary>
        /// <param name="handle">The item handle.</param>
        /// <remarks></remarks>
        public Camera(IntPtr handle)
            : base(handle)
        {
            // Register Event Handlers
            RegisterEventHandlers();

            // Opens a session
            OpenSession();
        }

        #endregion

        #region Session Management

        /// <summary>
        /// Opens the session.
        /// </summary>
        /// <remarks></remarks>
        protected void OpenSession()
        {
            UInt32 returnValue = EDSDKInvokes.OpenSession(this.Handle);
            ReturnValueManager.HandleFunctionReturnValue(returnValue);
        }

        /// <summary>
        /// Closes the session.
        /// </summary>
        /// <remarks></remarks>
        protected void CloseSession()
        {
            UInt32 returnValue = EDSDKInvokes.CloseSession(this.Handle);
            ReturnValueManager.HandleFunctionReturnValue(returnValue);
        }

        #endregion

        #region Overridden Methods

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        /// <remarks></remarks>
        public override void Dispose()
        {
            // Close the session
            CloseSession();

            // Dispose the camera item
            base.Dispose();
        }

        #endregion

        #region Camera Commands

        /// <summary>
        /// Starts the live view.
        /// </summary>
        /// <remarks></remarks>
        public void StartLiveView()
        {
            this.LiveViewOutputDevice = Enums.LiveViewOutputDevice.Computer;
            this.LiveViewEnabled = true;
        }


        public Stream GetLiveViewImage()
        {
            IntPtr streamPointer = IntPtr.Zero;
            IntPtr imagePointer = IntPtr.Zero;

            UInt32 returnValue = EDSDKInvokes.CreateMemoryStream(0, out streamPointer);
            ReturnValueManager.HandleFunctionReturnValue(returnValue);

            try
            {
                returnValue = EDSDKInvokes.CreateEvfImageRef(streamPointer, out imagePointer);
                ReturnValueManager.HandleFunctionReturnValue(returnValue);
                try
                {

                    returnValue = EDSDKInvokes.DownloadEvfImage(this.Handle, imagePointer);
                    ReturnValueManager.HandleFunctionReturnValue(returnValue);

                    IntPtr imageBlob;
                    returnValue = EDSDKInvokes.GetPointer(streamPointer, out imageBlob);
                    ReturnValueManager.HandleFunctionReturnValue(returnValue);

                    try
                    {
                        uint imageBlobLength;
                        returnValue = EDSDKInvokes.GetLength(streamPointer, out imageBlobLength);
                        ReturnValueManager.HandleFunctionReturnValue(returnValue);

                        byte[] buffer = new byte[imageBlobLength];
                        Marshal.Copy(imageBlob, buffer, 0, (int)imageBlobLength);

                        Stream stream = new MemoryStream(buffer);
                        return stream;
                    }
                    finally
                    {
                        EDSDKInvokes.Release(imageBlob);
                    }
                }
                finally
                {
                    EDSDKInvokes.Release(imagePointer);
                }
            }
            finally
            {
                EDSDKInvokes.Release(streamPointer);
            }
        }

        /// <summary>
        /// Stops the live view.
        /// </summary>
        /// <remarks></remarks>
        public void StopLiveView()
        {
            this.LiveViewEnabled = false;
        }

        /// <summary>
        /// Take a single photo
        /// </summary>
        public void TakePhoto()
        {
            UInt32 returnValue = EDSDKInvokes.SendCommand(this.Handle, (uint)CameraCommand.TakePicture, 0);
            ReturnValueManager.HandleFunctionReturnValue(returnValue);
        }

        public void ShutterPressed(int state)
        {
            UInt32 returnValue = EDSDKInvokes.SendCommand(this.Handle, (uint)CameraCommand.PressShutterButton, state);
            ReturnValueManager.HandleFunctionReturnValue(returnValue);

        }

        #endregion


        private EDSDKInvokes.EdsObjectEventHandler m_edsObjectEventHandler;
        private EDSDKInvokes.EdsPropertyEventHandler m_edsPropertyEventHandler;
        private EDSDKInvokes.EdsStateEventHandler m_edsStateEventHandler;

        #region Event Handling

        private void RegisterEventHandlers()
        {
            //  Register OBJECT events
            m_edsObjectEventHandler = new EDSDKInvokes.EdsObjectEventHandler(objectEventHandler);
            uint result = EDSDKInvokes.SetObjectEventHandler(
                    this.Handle, 
                    (uint)ObjectEvent.All,
                    m_edsObjectEventHandler,
                    IntPtr.Zero);

            ReturnValueManager.HandleFunctionReturnValue(result);

        }

        /// <summary>
        /// Registered callback function for recieving object events
        /// </summary>
        /// <param name="inEvent">Indicate the event type supplemented.</param>
        /// <param name="inRef">Returns a reference to objects created by the event.</param>
        /// <param name="inContext">Passes inContext without modification</param>
        /// <returns>Status 0 (OK)</returns>
        private uint objectEventHandler(uint inEvent, IntPtr inRef, IntPtr inContext)
        {
            Console.WriteLine(String.Format("ObjectEventHandler: event {0}, ref {1}", inEvent.ToString("X"), inRef.ToString()));

            return 0x0;
        }


        #endregion

        #endregion
    }
}
