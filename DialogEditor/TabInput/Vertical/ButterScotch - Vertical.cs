// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ButterScotch - Vertical.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.TabThematic.Controls
{

    /// <summary>
    /// Class TabVerticalInput.
    /// </summary>
    public partial class TabVerticalInput
    {

        #region Private Fields
        /// <summary>
        /// The butter vert back colors
        /// </summary>
        private Color[] butterVertBackColors = new Color[]
        {
            Color.FromArgb(100, 90, 80),
            Color.FromArgb(40, 37, 33),
            Color.FromArgb(100, 90, 80),
            Color.FromArgb(48, 43, 39),
            Color.FromArgb(57, 52, 46),
            Color.FromArgb(92, 83, 74)
        };

        /// <summary>
        /// The butter vert border colors
        /// </summary>
        private Color[] butterVertBorderColors = new Color[]
        {
            Color.Black
        };

        /// <summary>
        /// The butter vert fore colors
        /// </summary>
        private Color[] butterVertForeColors = new Color[]
        {
            Color.FromArgb(25, 23, 22),
            Color.White
        };
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the butter vert back colors.
        /// </summary>
        /// <value>The butter vert back colors.</value>
        public Color[] ButterVertBackColors
        {
            get => butterVertBackColors;
            set
            {
                butterVertBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the butter vert border colors.
        /// </summary>
        /// <value>The butter vert border colors.</value>
        public Color[] ButterVertBorderColors
        {
            get => butterVertBorderColors;
            set { butterVertBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the butter vert fore colors.
        /// </summary>
        /// <value>The butter vert fore colors.</value>
        public Color[] ButterVertForeColors
        {
            get => butterVertForeColors;
            set { butterVertForeColors = value;  }
        }

        #endregion
        
    }


}

