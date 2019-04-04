// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Chrome.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Tab control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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

