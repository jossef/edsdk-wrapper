using System;
using EDSDKWrapper.Framework.Invokes;
using EDSDKWrapper.Framework.Enums;
using EDSDKWrapper.Framework.Exceptions;
using System.Collections;
using EDSDKWrapper.Framework.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using EDSDKLib;

namespace EDSDKWrapper.Framework.Managers
{
    /// <summary>
    /// Manages the SDK Access
    /// </summary>
    /// <remarks></remarks>
    public class FrameworkManager : IDisposable
    {
        #region Properties

        /// <summary>
        /// Gets the cameras.
        /// </summary>
        /// <remarks></remarks>
        public IEnumerable<Camera> Cameras 
        { 
            get
            {
                return this.GetCameras();
            }
        }

        #endregion

        #region Methods

        #region Instance

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameworkManager"/> class.
        /// </summary>
        /// <remarks></remarks>
        public FrameworkManager()
        {
            initializeSDK();
        }

        #endregion

        #region SDK Initialization and Termination

        /// <summary>
        /// Initializes the SDK.
        /// </summary>
        /// <remarks></remarks>
        private void initializeSDK()
        {
            UInt32 returnValue = EDSDK.EdsInitializeSDK();
            ReturnValueManager.HandleFunctionReturnValue(returnValue);
        }

        /// <summary>
        /// Terminates the SDK.
        /// </summary>
        /// <remarks></remarks>
        private void terminateSDK()
        {
            UInt32 returnValue = EDSDK.EdsTerminateSDK();
            ReturnValueManager.HandleFunctionReturnValue(returnValue);
        }

        #endregion

        #region Get Cameras

        public IEnumerable<Camera> GetCameras()
        {
            UInt32 returnValue;

            IntPtr cameraListPointer;
            returnValue = EDSDK.EdsGetCameraList(out cameraListPointer);
            ReturnValueManager.HandleFunctionReturnValue(returnValue);

            try
            {
                Int32 cameraListCount;
                returnValue = EDSDK.EdsGetChildCount(cameraListPointer, out cameraListCount);
                ReturnValueManager.HandleFunctionReturnValue(returnValue);

                for (var i = 0; i < cameraListCount; ++i)
                {
                    IntPtr cameraPointer;
                    returnValue = EDSDK.EdsGetChildAtIndex(cameraListPointer, i, out cameraPointer);
                    ReturnValueManager.HandleFunctionReturnValue(returnValue);
                    
                    Camera camera = new Camera(cameraPointer);

                    yield return camera;
                }
            }
            finally
            {
                // Release Camera List Pointer
                if (cameraListPointer != IntPtr.Zero)
                {
                    EDSDK.EdsRelease(cameraListPointer);
                }
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            
            terminateSDK();
        }

        #endregion

        
       
        #endregion
    }
}
