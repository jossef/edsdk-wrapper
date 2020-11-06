using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDSDKWrapper.Framework.Managers;
using System.Runtime.InteropServices;
using EDSDKWrapper.Framework.Enums;
using EDSDKWrapper.Framework.Structs;
using EDSDKWrapper.Framework.Miscellaneous;
using EDSDKLib;

namespace EDSDKWrapper.Framework.Objects
{
    public abstract class Item : IDisposable
    {
        #region Constants

        public const int STRING_PROPERTY_BUFFER_SIZE = 256;
        public const int STRING_PROPERTY_DEFAULT_MAXIMUM_SIZE = 32;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the product.
        /// </summary>
        /// <remarks></remarks>
        public string ProductName
        {
            get 
            {
                return this.GetStringProperty(PropertyId.ProductName); 
            }
        }

        /// <summary>
        /// Gets the body ID.
        /// </summary>
        /// <remarks></remarks>
        public UInt32 BodyID
        {
            get
            {
                return this.GetUInt32Property(PropertyId.BodyID);
            }
        }

        /// <summary>
        /// Gets the name of the owner.
        /// </summary>
        /// <remarks></remarks>
        public string OwnerName
        {
            get 
            {
                return this.GetStringProperty(PropertyId.OwnerName); 
            }
        }

        /// <summary>
        /// Gets the artist.
        /// </summary>
        /// <remarks></remarks>
        public string Artist
        {
            get 
            {
                return this.GetStringProperty(PropertyId.Artist); 
            }
        }


        /// <summary>
        /// Gets the copyright.
        /// </summary>
        /// <remarks></remarks>
        public string Copyright
        {
            get 
            {
                return this.GetStringProperty(PropertyId.Copyright); 
            }
        }

        /// <summary>
        /// Gets the firmware version.
        /// </summary>
        /// <remarks></remarks>
        public string FirmwareVersion
        {
            get 
            {
                return this.GetStringProperty(PropertyId.FirmwareVersion); 
            }
        }
        
        /// <summary>
        /// Gets or sets the item handle.
        /// </summary>
        /// <value>The item handle.</value>
        /// <remarks></remarks>
        protected IntPtr Handle { get; set; }


        /// <summary>
        /// Gets the focus information.
        /// </summary>
        /// <remarks></remarks>
        public FocusInformation FocusInformation
        {
            get
            {
                return this.GetStructProperty<FocusInformation>(PropertyId.BatteryQuality);
            }
        }

        // TODO: make this property enabled
        ///// <summary>
        ///// Gets the image quality.
        ///// </summary>
        ///// <remarks></remarks>
        //public virtual ImageQuality ImageQuality
        //{
        //    get
        //    {
        //        return this.GetStructProperty<ImageQuality>(PropertyId.ImageQuality);
        //    }
        //}

        // TODO: make this property enabled
        ///// <summary>
        ///// Gets the JPEG quality.
        ///// Indicates the JPEG compression.
        ///// In the inParam argument, designate Image Size as retrieved by means of the kEdsPropID_ImageQuality property.
        ///// </summary>
        ///// <value>An integer value of 0–10. (0 if uncompressed.)</value>
        ///// <remarks>This property is valid for the EOS 1 series only.</remarks>
        //public virtual UInt32 JpegQuality
        //{
        //    get
        //    {
        //        // TODO: after completing ImageQuality property wrapping, send as additional information the image size of ImageQuality
        //        return this.GetUInt32Property(PropertyId.JpegQuality);
        //    }
        //}

        /// <summary>
        /// Indicates settings values of the camera in shooting mode.
        /// </summary>
        /// <value>AEMode</value>
        /// <remarks></remarks>
        public AFMode AFMode
        {
            get
            {
                return (AFMode)this.GetUInt32Property(PropertyId.AFMode);
            }
        }

        /// <summary>
        /// Indicates the current bracket type.
        /// If multiple brackets have been set on the camera, you can get the bracket type as a logical sum.
        /// </summary>
        /// <value>Bracket</value>
        /// <remarks></remarks>
        public Bracket Bracket
        {
            get
            {
                return (Bracket)this.GetUInt32Property(PropertyId.Bracket);
            }
        }

        /// <summary>
        /// Gets the white balance bracket.
        /// </summary>
        /// <remarks></remarks>
        public WhiteBalanceBracket WhiteBalanceBracket
        {
            get
            {
                return this.GetStructProperty<WhiteBalanceBracket>(PropertyId.WhiteBalanceBracket);
            }
        }

        #endregion

        #region Methods

        #region Instance

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="handle">The item handle.</param>
        /// <remarks></remarks>
        public Item(IntPtr handle)
        {
            this.Handle = handle;
        }

        #endregion

        #region Get Property

        /// <summary>
        /// Gets the property pointer.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="bufferSize">Size of the buffer.</param>
        /// <param name="additionalInformation">Additional information of property.
        /// We use this parameter in order to specify an index.</param>
        /// <returns>pointer to the property value buffer</returns>
        /// <remarks></remarks>
        private IntPtr GetProperty(PropertyId propertyId, int bufferSize, int additionalInformation = 0)
        {
            IntPtr allocatedBufferPointer = Marshal.AllocHGlobal(bufferSize);

            try
            {
                UInt32 returnValue = EDSDK.EdsGetPropertyData(this.Handle, (UInt32)propertyId, additionalInformation, bufferSize, allocatedBufferPointer);
                ReturnValueManager.HandleFunctionReturnValue(returnValue);

            }
            // If Caught any exception during the native call
            catch
            {
                // If buffer was allocated
                if (allocatedBufferPointer != IntPtr.Zero)
                {
                    // Release him
                    Marshal.FreeHGlobal(allocatedBufferPointer);
                    allocatedBufferPointer = IntPtr.Zero;
                }

                // Eventually, throw the caught exception
                throw;
            }

            // Return the allocated buffer
            return allocatedBufferPointer;
        }

        /// <summary>
        /// Gets the string property.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="additionalInformation">Additional information of property.
        /// We use this parameter in order to specify an index.</param>
        /// <returns>property value as string</returns>
        /// <remarks></remarks>
        protected string GetStringProperty(PropertyId propertyId, int additionalInformation = 0)
        {
            int bufferSize = STRING_PROPERTY_BUFFER_SIZE;

            IntPtr stringPointer = GetProperty(propertyId, bufferSize, additionalInformation);

            try
            {
                string data = Marshal.PtrToStringAnsi(stringPointer);
                return data;
            }
            finally
            {
                // If buffer was allocated
                if (stringPointer != IntPtr.Zero)
                {
                    // Release him
                    Marshal.FreeHGlobal(stringPointer);
                    stringPointer = IntPtr.Zero;
                }
            }
        }

        /// <summary>
        /// Gets the Structure property.
        /// </summary>
        /// <typeparam name="StructureType">The type of the Structure.</typeparam>
        /// <param name="propertyId">The property id.</param>
        /// <param name="additionalInformation">Additional information of property.
        /// We use this parameter in order to specify an index.</param>
        /// <returns>property value as <typeparamref name="StructureType"/></returns>
        /// <remarks></remarks>
        protected StructureType GetStructProperty<StructureType>(PropertyId propertyId, int additionalInformation = 0)
            where StructureType : struct
        {
            Type structureType = typeof(StructureType);
            int bufferSize = Marshal.SizeOf(structureType); ;

            IntPtr structurePointer = GetProperty(propertyId, bufferSize, additionalInformation);

            try
            {
                StructureType data = (StructureType)Marshal.PtrToStructure(structurePointer, structureType);
                return data;
            }
            finally
            {
                // If buffer was allocated
                if (structurePointer != IntPtr.Zero)
                {
                    // Release him
                    Marshal.FreeHGlobal(structurePointer);
                    structurePointer = IntPtr.Zero;
                }
            }
        }

        /// <summary>
        /// Gets the Unsigned int32 property.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="additionalInformation">Additional information of property.
        /// We use this parameter in order to specify an index.</param>
        /// <returns>property value as UInt32</returns>
        /// <remarks></remarks>
        protected UInt32 GetUInt32Property(PropertyId propertyId, int additionalInformation = 0)
        {
            UInt32 data = GetStructProperty<UInt32>(propertyId, additionalInformation);
            return data;
        }

        /// <summary>
        /// Gets the Time property.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="additionalInformation">Additional information of property.
        /// We use this parameter in order to specify an index.</param>
        /// <returns>property value as UInt32</returns>
        /// <remarks></remarks>
        protected Time GetTimeProperty(PropertyId propertyId, int additionalInformation = 0)
        {
            Time data = GetStructProperty<Time>(propertyId, additionalInformation);
            return data;
        }

        /// <summary>
        /// Gets the DateTime property.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="additionalInformation">Additional information of property.
        /// We use this parameter in order to specify an index.</param>
        /// <returns>property value as UInt32</returns>
        /// <remarks></remarks>
        protected DateTime GetDateTimeProperty(PropertyId propertyId, int additionalInformation = 0)
        {
            Time data = GetTimeProperty(propertyId, additionalInformation);

            DateTime dateTime = new DateTime(data.Year, data.Month, data.Day, data.Hour, data.Minute, data.Second);
            return dateTime;
        }

        /// <summary>
        /// Gets the DateTime property.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="additionalInformation">Additional information of property.
        /// We use this parameter in order to specify an index.</param>
        /// <returns>property value as UInt32</returns>
        /// <remarks></remarks>
        protected Boolean GetBooleanProperty(PropertyId propertyId, int additionalInformation = 0)
        {
            UInt32 propertyValue = this.GetUInt32Property(propertyId,additionalInformation);
            return propertyValue == 1;
        }

        #endregion

        #region Get Available Properties


        /// <summary>
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <returns>property values</returns>
        /// <remarks></remarks>
        protected IEnumerable<UInt32> GetSupportedProperties(PropertyId propertyId)
        {
            EDSDK.EdsPropertyDesc propertyDescription;

            UInt32 returnValue = EDSDK.EdsGetPropertyDesc(this.Handle, (UInt32)propertyId, out propertyDescription);
            ReturnValueManager.HandleFunctionReturnValue(returnValue);

            for (int i = 0; i < propertyDescription.PropDesc.Length ; i++)
            {
                yield return (UInt32)propertyDescription.PropDesc[i];
            }
        }


        /// <summary>
        /// Gets the available properties.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <returns>property values</returns>
        /// <remarks></remarks>
        protected IEnumerable<EnumType> GetSupportedEnumProperties<EnumType>(PropertyId propertyId)
            where EnumType : struct, IConvertible
        {
            IEnumerable<EnumType> uintProperties = GetSupportedProperties(propertyId).Cast<EnumType>();
            IEnumerable<EnumType> enumValues = EnumUtilities.GetEnumValues<EnumType>();
            return uintProperties.Intersect<EnumType>(enumValues);
        }



        #endregion

        #region Set Property

        /// <summary>
        /// Sets the property value.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="propertySize">Size of the property.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <param name="additionalInformation">The additional information.</param>
        /// <remarks></remarks>
        private void SetProperty(PropertyId propertyId, int propertySize, object propertyValue, int additionalInformation = 0)
        {
            UInt32 returnValue = EDSDK.EdsSetPropertyData(this.Handle, (UInt32)propertyId, additionalInformation, propertySize, propertyValue);
            ReturnValueManager.HandleFunctionReturnValue(returnValue);
        }

        /// <summary>
        /// Sets the int32 property value.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <param name="additionalInformation">The additional information.</param>
        /// <remarks></remarks>
        protected void SetUInt32Property(PropertyId propertyId, UInt32 propertyValue, int additionalInformation = 0)
        {
            int propertySize = Marshal.SizeOf(typeof(UInt32));
            SetProperty(propertyId, propertySize, propertyValue, additionalInformation);
        }

        /// <summary>
        /// Sets the Boolean property.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <param name="additionalInformation">The additional information.</param>
        /// <remarks></remarks>
        protected void SetBooleanProperty(PropertyId propertyId, Boolean propertyValue, int additionalInformation = 0)
        {
            UInt32 propertyValueUInt32 = (UInt32)(propertyValue ? 1 : 0);
            this.SetUInt32Property(propertyId, propertyValueUInt32, additionalInformation);
        }
        /// <summary>
        /// Sets the string property.
        /// </summary>
        /// <param name="propertyId">The property id.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <param name="propertyMaximumSize">Maximum size of the property.</param>
        /// <param name="additionalInformation">The additional information.</param>
        /// <remarks></remarks>
        /// <exception cref="ArgumentNullException">if <paramref name="propertyValue"/> is null or whitespace.</exception>
        /// <exception cref="ArgumentOutOfRangeException">if <paramref name="propertyValue"/> exceeded the <paramref name="propertyMaximumSize"/> .</exception>
        protected void SetStringProperty(PropertyId propertyId, String propertyValue, int propertyMaximumSize = STRING_PROPERTY_DEFAULT_MAXIMUM_SIZE, int additionalInformation = 0)
        {
            if (String.IsNullOrWhiteSpace(propertyValue))
            {
                throw new ArgumentNullException("propertyValue");
            }

            byte[] propertyValueBytes = Encoding.ASCII.GetBytes(propertyValue + '\0');
            int propertySize = propertyValueBytes.Length;

            if (propertySize > propertyMaximumSize)
            {
                throw new ArgumentOutOfRangeException("propertyValue");
            }

            SetProperty(propertyId, propertySize, propertyValueBytes, additionalInformation);
        }

        /// <summary>
        /// Sets structure property value.
        /// </summary>
        /// <typeparam name="StructureType">The type of the structure type.</typeparam>
        /// <param name="propertyId">The property id.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <param name="additionalInformation">The additional information.</param>
        /// <remarks></remarks>
        protected void SetStructProperty<StructureType>(PropertyId propertyId, StructureType propertyValue, int additionalInformation = 0)
        {
            int propertySize = Marshal.SizeOf(typeof(StructureType));
            SetProperty(propertyId, propertySize, propertyValue, additionalInformation);
        }

        #endregion

        #region IDisposable Members

        public virtual void Dispose()
        {
            if (this.Handle != IntPtr.Zero)
            {
                UInt32 returnValue = EDSDK.EdsRelease(this.Handle);

                this.Handle = IntPtr.Zero;
            }
        }

        #endregion

        #endregion
    }
}
