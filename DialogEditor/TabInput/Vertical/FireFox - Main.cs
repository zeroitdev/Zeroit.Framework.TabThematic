// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FireFox - Main.cs" company="Zeroit Dev Technologies">
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
        /// The fire fox back colors
        /// </summary>
        private Color[] fireFoxBackColors = new Color[]
        {
            Color.White,
            Color.FromArgb(66, 79, 90),
            Color.FromArgb(52, 63, 72),
            Color.FromArgb(255, 175, 54),
            Color.FromArgb(66, 79, 90)
        };

        /// <summary>
        /// The fire fox fore colors
        /// </summary>
        private Color[] fireFoxForeColors = new Color[]
        {
            Color.FromArgb(66, 79, 90),
            Color.FromArgb(245, Color.Gray),
            Color.FromArgb(192, Color.Gray)
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

