using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDSDKWrapper.Framework.Enums;
using EDSDKWrapper.Framework.Structs;

namespace EDSDKWrapper.Framework.Objects
{
    public class Image : Item
    {
        #region Properties

        /// <summary>
        /// Gets the name of the maker.
        /// </summary>
        /// <remarks></remarks>
        public string MakerName
        {
            get
            {
                return this.GetStringProperty(PropertyId.MakerName);
            }
        }

        /// <summary>
        /// Gets the shooting date.
        /// </summary>
        /// <remarks></remarks>
        public DateTime ShootingDate
        {
            get
            {
                return this.GetDateTimeProperty(PropertyId.DateTime);
            }
        }

        /// <summary>
        /// Gets the focus information.
        /// </summary>
        /// <remarks></remarks>
        public ICCProfile ICCProfile
        {
            get
            {
                return this.GetStructProperty<ICCProfile>(PropertyId.ICCProfile);
            }
        }
       
        /// <summary>
        /// Gets the image orientation.
        /// </summary>
        /// <remarks></remarks>
        public ImageOrientation ImageOrientation
        {
            get
            {
                return (ImageOrientation)this.GetUInt32Property(PropertyId.Orientation);
            }
        }

        /// <summary>
        /// Indicates settings values of the camera in shooting mode.
        /// </summary>
        /// <value>AEMode</value>
        /// <remarks></remarks>
        public AEMode AEMode
        {
            get
            {
                return (AEMode)this.GetUInt32Property(PropertyId.AEMode);
            }
        }

        /// <summary>
        /// Indicates settings values of the camera in drive mode.
        /// </summary>
        /// <remarks></remarks>
        public DriveMode DriveMode
        {
            get
            {
                return (DriveMode)this.GetUInt32Property(PropertyId.DriveMode);
            }
        }

        /// <summary>
        /// Indicates settings values of the camera in drive mode.
        /// </summary>
        /// <remarks></remarks>
        public MeteringMode MeteringMode
        {
            get
            {
                return (MeteringMode)this.GetUInt32Property(PropertyId.MeteringMode);
            }
        }

        /// <summary>
        /// Gets the level of degradation of the battery.
        /// </summary>
        /// <remarks></remarks>
        public ImageISOSensitivity ISOSensitivity
        {
            get
            {
                return (ImageISOSensitivity)this.GetUInt32Property(PropertyId.ISOSpeed);
            }
        }

        /// <summary>
        /// Gets the aperture value as an Rational type.
        /// </summary>
        /// <remarks></remarks>
        public Rational ApertureValue
        {
            get
            {
                return this.GetStructProperty<Rational>(PropertyId.Av);
            }
        }

        /// <summary>
        /// Gets the shutter speed value as an Rational type.
        /// </summary>
        /// <remarks></remarks>
        public Rational ShutterSpeed
        {
            get
            {
                return this.GetStructProperty<Rational>(PropertyId.Tv);
            }
        }

        /// <summary>
        /// Gets the shutter speed value as an Rational type.
        /// </summary>
        /// <remarks></remarks>
        public Rational ExposureCompensation
        {
            get
            {
                return this.GetStructProperty<Rational>(PropertyId.ExposureCompensation);
            }
        }

        /// <summary>
        /// Indicates the digital exposure compensation.
        /// </summary>
        /// <remarks>With this property, it is possible to get values at the time of shooting.</remarks>
        public Rational DigitalExposure
        {
            get
            {
                return this.GetStructProperty<Rational>(PropertyId.DigitalExposure);
            }
            // TODO: setter
        }

        // TODO: FocalLength Property

        /// <summary>
        /// Indicates the AE bracket compensation of image data.
        /// </summary>
        public Rational AEBracket
        {
            get
            {
                return this.GetStructProperty<Rational>(PropertyId.AEBracket);
            }
        }
        
        /// <summary>
        /// Indicates the FE bracket compensation at the time of shooting of image data.
        /// </summary>
        public Rational FEBracket
        {
            get
            {
                return this.GetStructProperty<Rational>(PropertyId.FEBracket);
            }
        }

        /// <summary>
        /// Indicates the ISO bracket compensation at the time of shooting of image data.
        /// </summary>
        public Rational ISOBracket
        {
            get
            {
                return this.GetStructProperty<Rational>(PropertyId.ISOBracket);
            }
        }

        /// <summary>
        /// Gets the white balance.
        /// </summary>
        /// <remarks></remarks>
        public WhiteBalance WhiteBalance
        {
            get
            {
                return (WhiteBalance)this.GetUInt32Property(PropertyId.WhiteBalance);
            }
        }

        /// <summary>
        /// Gets the color temperature.
        /// </summary>
        /// <remarks></remarks>
        public UInt32 ColorTemperature
        {
            get
            {
                return this.GetUInt32Property(PropertyId.ColorTemperature);
            }
        }

        /// <summary>
        /// Gets the name of the lens.
        /// </summary>
        /// <remarks>This property can only be retrieved from images shot using models supporting picture styles.</remarks>
        public string LensName
        {
            get
            {
                return this.GetStringProperty(PropertyId.LensName);
            }
        }


        #endregion

        #region Methods

        #region Instance

        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        /// <param name="handle">The Image handle.</param>
        /// <remarks></remarks>
        public Image(IntPtr handle)
            : base(handle)
        {

        }

        #endregion

        #endregion
    }
}
