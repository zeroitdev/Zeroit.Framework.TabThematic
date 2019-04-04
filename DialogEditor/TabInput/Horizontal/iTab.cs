// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="iTab.cs" company="Zeroit Dev Technologies">
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
        /// The i tab back colors
        /// </summary>
        private Color[] iTabBackColors = new Color[]
        {
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(10, 0, 0, 0),
            Color.FromArgb(35, 35, 35),
            Color.FromArgb(10, Color.Black),
            Color.Transparent,
            Color.FromArgb(30, 30, 30),
            Color.FromArgb(35, 35, 35)
        };

        /// <summary>
        /// The i tab border colors
        /// </summary>
        private Color[] iTabBorderColors = new Color[]
        {
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(15, 15, 15),
            Color.Black

        };

        /// <summary>
        /// The i tab fore colors
        /// </summary>
        private Color[] iTabForeColors = new Color[]
        {
            Color.DeepSkyBlue,
            Color.FromArgb(75, 75, 75)
        };

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the i tab back colors.
        /// </summary>
        /// <value>The i tab back colors.</value>
        public Color[] ITabBackColors
        {
            get => iTabBackColors;
            set
            {
                iTabBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the i tab border colors.
        /// </summary>
        /// <value>The i tab border colors.</value>
        public Color[] ITabBorderColors
        {
            get => iTabBorderColors;
            set { iTabBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the i tab fore colors.
        /// </summary>
        /// <value>The i tab fore colors.</value>
        public Color[] ITabForeColors
        {
            get => iTabForeColors;
            set { iTabForeColors = value;  }
        }

        #endregion
        

    }
}
