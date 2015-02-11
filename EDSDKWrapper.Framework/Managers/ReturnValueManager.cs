using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDSDKWrapper.Framework.Enums;
using EDSDKWrapper.Framework.Exceptions;

namespace EDSDKWrapper.Framework.Managers
{
    public static class ReturnValueManager
    {
        #region Methods

        /// <summary>
        /// Handles the function return value.
        /// May throw Exception if the result is not Ok
        /// </summary>
        /// <param name="functionReturnValue">EDSDK function return value.</param>
        /// <remarks></remarks>
        public static void HandleFunctionReturnValue(UInt32 functionReturnValue)
        {
            // Check if the functionReturnValue exists in the ReturnValue Enum
            // Fastest way to Do this is to cast the numeric value into enum 
            // and asking for the enum Name. if the result is null - > this value is not defined in the enum
            ReturnValue returnValue = (ReturnValue)functionReturnValue;
            String name = Enum.GetName(typeof(ReturnValue), returnValue);

            if (name == null)
            {
                returnValue = ReturnValue.UnknownReturnValue;
            }

            HandleFunctionReturnValue(returnValue);
        }

        /// <summary>
        /// Handles the function return value.
        /// May throw Exception if the result is not Ok
        /// </summary>
        /// <param name="functionReturnValue">EDSDK function return value.</param>
        /// <exception cref="EDSDKException">if the functionReturnValue is not "Ok".</exception>
        /// <remarks></remarks>
        public static void HandleFunctionReturnValue(ReturnValue functionReturnValue)
        {
            // This is a good return value
            if (functionReturnValue == ReturnValue.Ok)
            {
                // Return and proceed
                return;
            }

            // If we end up with this section, the return value represents one of the Failure Return values.
            throw new EDSDKException(functionReturnValue);
        }

        #endregion
    }
}
