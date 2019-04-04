// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FireFox - Sub.cs" company="Zeroit Dev Technologies">
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
        /// The fire fox back colors
        /// </summary>
        private Color[] fireFoxBackColors = new Color[]
        {
            Color.White,
            Color.LightGray,
            Color.Gray,
            Color.White
        };

        /// <summary>
        /// The fire fox border colors
        /// </summary>
        private Color[] fireFoxBorderColors = new Color[]
        {
            Color.FromArgb(255, 149, 0),
            Color.SlateGray
        };

        /// <summary>
        /// The fire fox fore colors
        /// </summary>
        private Color[] fireFoxForeColors = new Color[]
        {
            Color.FromArgb(56, 69, 80)
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the fire fox back colors.
        /// </summary>
        /// <value>The fire fox back colors.</value>
        public Color[] FireFoxBackColors
        {
            get => fireFoxBackColors;
            set
            {
                fireFoxBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the fire fox border colors.
        /// </summary>
        /// <value>The fire fox border colors.</value>
        public Color[] FireFoxBorderColors
        {
            get => fireFoxBorderColors;
            set { fireFoxBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the fire fox fore colors.
        /// </summary>
        /// <value>The fire fox fore colors.</value>
        public Color[] FireFoxForeColors
        {
            get => fireFoxForeColors;
            set { fireFoxForeColors = value;  }
        } 
        #endregion

        

    }

}

