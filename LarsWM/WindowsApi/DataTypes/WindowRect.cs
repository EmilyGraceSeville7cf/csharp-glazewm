﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LarsWM.WindowsApi.DataTypes
{
    public struct WindowRect
    {
        /// <summary>
        /// The x-coordinate of the upper-left corner of the rectangle. 
        /// </summary>
        public int Left { get; set; }

        /// <summary>
        /// The y-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public int Top { get; set; }

        /// <summary>
        /// The x-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public int Right { get; set; }

        /// <summary>
        /// The y-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public int Bottom { get; set; }
    }
}
