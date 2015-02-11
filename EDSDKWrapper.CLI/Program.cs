using System;
using System.Threading;
using EDSDKWrapper.Framework.Enums;
using EDSDKWrapper.Framework.Managers;
using EDSDKWrapper.Framework.Miscellaneous;

namespace EDSDKWrapper.CLI
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    class Program
    {
        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        /// <remarks></remarks>
        static void Main(string[] args)
        {
            mockTesting();
            //frameworkTesting();
        }

        private static void mockTesting()
        {
            try
            {
                
            }
            finally
            {
            }
        }

        private static void frameworkTesting()
        {
            using (var f = new FrameworkManager())
            {
                foreach (var camera in f.Cameras)
                {
                    using (camera)
                    {

                        camera.SaveTo = SaveTo.Both;

                        Console.WriteLine(camera.ProductName);

                        foreach (var item in EnumUtilities.GetEnumValues<WhiteBalance>())
                        {
                            camera.WhiteBalance = item;
                        }

                        foreach (var item in camera.SupportedISOSensitivityValues)
                        {
                            camera.ISOSensitivity = item;
                        }
                        foreach (var item in camera.SupportedMeteringModes)
                        {
                            camera.MeteringMode = item;
                        }

                        foreach (var item in camera.SupportedApertureValues)
                        {
                            camera.ApertureValue = item;
                        }

                        foreach (var item in camera.SupportedShutterSpeeds)
                        {
                            camera.ShutterSpeed = item;
                        }

                        foreach (var item in camera.SupportedExposureCompensations)
                        {
                            camera.ExposureCompensation = item;
                        }

                        while (true)
                        {
                            Thread.Sleep(50);
                        }

                    }
                }
            }
        }
    }
}
