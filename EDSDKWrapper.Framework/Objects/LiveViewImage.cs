using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDSDKWrapper.Framework.Enums;
using EDSDKWrapper.Framework.Structs;

namespace EDSDKWrapper.Framework.Objects
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class LiveViewImage : Item
    {
        #region Properties

        /// <summary>
        /// Gets the live view zoom.
        /// </summary>
        /// <value>The live view zoom.</value>
        /// <remarks></remarks>
        public LiveViewZoom Zoom
        {
            get
            {
                return (LiveViewZoom)this.GetUInt32Property(PropertyId.LiveViewZoom);
            }
        }

        /// <summary>
        /// Gets the live view zoom position.
        /// </summary>
        /// <value>The live view zoom position.</value>
        /// <remarks></remarks>
        public Point ZoomPosition
        {
            get
            {
                return this.GetStructProperty<Point>(PropertyId.LiveViewZoomPosition);
            }
        }

        /// <summary>
        /// Gets the live view zoom rectangle.
        /// </summary>
        /// <value>
        /// The “point” member is the upper left coordinates of the focus and zoom border. And the “size” member is the
        /// rectangle of focus border size. These values expressed in a coordinate system of
        /// kEdsPropID_Evf_CoordinateSystem.
        /// </value>
        /// <remarks></remarks>
        public Rectangle ZoomRectangle
        {
            get
            {
                return this.GetStructProperty<Rectangle>(PropertyId.LiveViewZoomRectangle);
            }
        }

        /// <summary>
        /// Gets the live view cropped image position.
        /// </summary>
        /// <value>The coordinates used are the upper left coordinates of the enlarged image.</value>
        /// <remarks></remarks>
        public Point CroppedImagePosition
        {
            get
            {
                return this.GetStructProperty<Point>(PropertyId.LiveViewZoomRectangle);
            }
        }

        /// <summary>
        /// Gets the coordinate system of the live view image..
        /// </summary>
        /// <value>The coordinates used are the upper left coordinates of the enlarged image.</value>
        /// <remarks></remarks>
        public Size CoordinateSystem
        {
            get
            {
                return this.GetStructProperty<Size>(PropertyId.LiveViewCoordinateSystem);
            }
        }

                

        #endregion

        #region Methods

        #region Instance

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveViewImage"/> class.
        /// </summary>
        /// <param name="handle">The item handle.</param>
        /// <remarks></remarks>
        public LiveViewImage(IntPtr handle) : base(handle)
        {
        }

        #endregion

        #endregion
    }
}
