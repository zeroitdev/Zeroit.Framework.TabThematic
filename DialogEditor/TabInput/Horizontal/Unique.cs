// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Unique.cs" company="Zeroit Dev Technologies">
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
        /// The unique fore colors
        /// </summary>
        private Color[] uniqueForeColors = new Color[]
        {
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255)
        };

        /// <summary>
        /// The unique back colors
        /// </summary>
        private Color[] uniqueBackColors = new Color[]
        {
            Color.FromArgb(72, 72, 72),
            Color.FromArgb(52, 52, 52),
            Color.FromArgb(56, 68, 85),
            Color.FromArgb(41, 42, 46)
        };

        /// <summary>
        /// The unique border colors
        /// </summary>
        private Color[] uniqueBorderColors = new Color[]
        {
            Color.Black,
            Color.Black
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the unique fore colors.
        /// </summary>
        /// <value>The unique fore colors.</value>
        public Color[] UniqueForeColors
        {
            get => uniqueForeColors;
            set
            {
                uniqueForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the unique back colors.
        /// </summary>
        /// <value>The unique back colors.</value>
        public Color[] UniqueBackColors
        {
            get => uniqueBackColors;
            set { uniqueBackColors = value;  }
        }

        /// <summary>
        /// Gets or sets the unique border colors.
        /// </summary>
        /// <value>The unique border colors.</value>
        public Color[] UniqueBorderColors
        {
            get => uniqueBorderColors;
            set { uniqueBorderColors = value;  }
        }
        #endregion
        

    }

}

