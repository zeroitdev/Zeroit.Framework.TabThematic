// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FireFox - Sub.cs" company="Zeroit Dev Technologies">
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

