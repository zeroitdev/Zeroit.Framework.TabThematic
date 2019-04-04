// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Chrome.cs" company="Zeroit Dev Technologies">
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
        /// The chrome back colors
        /// </summary>
        private Color[] chromeBackColors = new Color[]
        {
            SystemColors.Control,
            SystemColors.Control
        };

        /// <summary>
        /// The chrome fore colors
        /// </summary>
        private Color[] chromeForeColors = new Color[]
        {
            Color.Black,
            Color.DimGray
        };

        /// <summary>
        /// The square color
        /// </summary>
        Color squareColor = Color.FromArgb(78, 87, 100);

        /// <summary>
        /// The show outer borders
        /// </summary>
        bool showOuterBorders = false;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets a value indicating whether [show outer borders].
        /// </summary>
        /// <value><c>true</c> if [show outer borders]; otherwise, <c>false</c>.</value>
        public bool ShowOuterBorders
        {
            get { return showOuterBorders; }
            set
            {
                showOuterBorders = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the square.
        /// </summary>
        /// <value>The color of the square.</value>
        public Color SquareColor
        {
            get { return squareColor; }
            set
            {
                squareColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the chrome back.
        /// </summary>
        /// <value>The color of the chrome back.</value>
        public Color[] ChromeBackColor
        {
            get { return chromeBackColors; }
            set
            {
                chromeBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the chrome fore colors.
        /// </summary>
        /// <value>The chrome fore colors.</value>
        public Color[] ChromeForeColors
        {
            get { return chromeForeColors; }
            set
            {
                chromeForeColors = value;
                
            }
        }
        #endregion
        

    }

}

