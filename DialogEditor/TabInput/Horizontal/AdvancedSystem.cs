// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AdvancedSystem.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.TabThematic.Controls
{
    /// <summary>
    /// Class TabHorizontalInput.
    /// </summary>
    public partial class TabHorizontalInput
    {

        #region Private Fields
        /// <summary>
        /// The asc fore colors
        /// </summary>
        private Color[] ascForeColors = new Color[]
        {
            Color.FromArgb(80, 170, 245),
            Color.FromArgb(160, 160, 160)
        };

        /// <summary>
        /// The asc border colors
        /// </summary>
        private Color[] ascBorderColors = new Color[]
        {
            Color.FromArgb(5, 135, 250),
            Color.FromArgb(25, 100, 140),
            Color.FromArgb(30, 55, 85),
            Color.FromArgb(30, 55, 85),
            Color.FromArgb(30, 90, 125)
        };

        /// <summary>
        /// The asc back colors
        /// </summary>
        private Color[] ascBackColors = new Color[]
        {
            Color.FromArgb(22,22,22)
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the asc fore colors.
        /// </summary>
        /// <value>The asc fore colors.</value>
        public Color[] AscForeColors
        {
            get => ascForeColors;
            set
            {
                ascForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the asc border colors.
        /// </summary>
        /// <value>The asc border colors.</value>
        public Color[] AscBorderColors
        {
            get => ascBorderColors;
            set { ascBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the asc back colors.
        /// </summary>
        /// <value>The asc back colors.</value>
        public Color[] AscBackColors
        {
            get => ascBackColors;
            set { ascBackColors = value;  }
        }
        #endregion
        
    }
}
