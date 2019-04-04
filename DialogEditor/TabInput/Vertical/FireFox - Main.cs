// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FireFox - Main.cs" company="Zeroit Dev Technologies">
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

