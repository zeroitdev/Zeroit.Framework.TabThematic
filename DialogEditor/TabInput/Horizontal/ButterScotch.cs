// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ButterScotch.cs" company="Zeroit Dev Technologies">
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
        /// The but fore colors
        /// </summary>
        private Color[] butForeColors = new Color[]
        {
            Color.FromArgb(25, 23, 22),
            Color.FromArgb(255, 255, 255)
        };

        /// <summary>
        /// The but back colors
        /// </summary>
        private Color[] butBackColors = new Color[]
        {
            Color.FromArgb(100, 90, 80),
            Color.FromArgb(40, 37, 33),
            Color.FromArgb(100, 90, 80),
            Color.FromArgb(48, 43, 39),
            Color.FromArgb(57, 52, 46),
            Color.FromArgb(92, 83, 74)
        };

        /// <summary>
        /// The but border colors
        /// </summary>
        private Color[] butBorderColors = new Color[]
        {
            Color.Black,

        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the but fore colors.
        /// </summary>
        /// <value>The but fore colors.</value>
        public Color[] ButForeColors
        {
            get => butForeColors;
            set
            {
                butForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the but back colors.
        /// </summary>
        /// <value>The but back colors.</value>
        public Color[] ButBackColors
        {
            get => butBackColors;
            set { butBackColors = value;  }
        }

        /// <summary>
        /// Gets or sets the but border colors.
        /// </summary>
        /// <value>The but border colors.</value>
        public Color[] ButBorderColors
        {
            get => butBorderColors;
            set { butBorderColors = value;  }
        }
        #endregion

        
    }


}

