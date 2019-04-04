// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ButterScotch - Vertical.cs" company="Zeroit Dev Technologies">
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

