using System;
using EDSDKWrapper.Framework.Enums;

namespace EDSDKWrapper.Framework.Exceptions
{
    /// <summary>
    /// Represents an EDSDK Exception.
    /// Supports Serialization
    /// </summary>
    /// <remarks></remarks>
    [Serializable]
    public class EDSDKException : Exception
    {
        #region Constants

        private const string RETURN_VALUE_STRING_IDENTIFIER = "ReturnValue";

        #endregion

        #region Properties

        /// <summary>
        /// Gets the return value.
        /// </summary>
        /// <remarks></remarks>
        public ReturnValue ReturnValue { get; private set; }

        #endregion

        #region Methods

        #region Instance

        /// <summary>
        /// Initializes a new instance of the <see cref="EDSDKException"/> class.
        /// </summary>
        /// <param name="returnValue">The return value.</param>
        /// <remarks></remarks>
        public EDSDKException(ReturnValue returnValue) 
        {
            this.ReturnValue = returnValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Exception"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is null. </exception>
        ///   
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/> is zero (0). </exception>
        /// <remarks></remarks>
        protected EDSDKException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) 
        {
            this.ReturnValue = (ReturnValue)info.GetValue(RETURN_VALUE_STRING_IDENTIFIER, typeof(ReturnValue));
        }

        #endregion
        
        #region Overridden Methods

        /// <summary>
        /// When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info"/> parameter is a null reference (Nothing in Visual Basic). </exception>
        ///   
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*"/>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter"/>
        ///   </PermissionSet>
        /// <remarks></remarks>
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);

            // Add a value to the Serialization information.
            info.AddValue(RETURN_VALUE_STRING_IDENTIFIER, this.ReturnValue);
        }
        
        #endregion

        #endregion
    }   
       
}
