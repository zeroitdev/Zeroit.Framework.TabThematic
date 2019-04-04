// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BCEvo.cs" company="Zeroit Dev Technologies">
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
        /// The b c evo fore colors
        /// </summary>
        private Color[] bCEvoForeColors = new Color[]
        {
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(100, 100, 100)
        };

        /// <summary>
        /// The b c evo border colors
        /// </summary>
        private Color[] bCEvoBorderColors = new Color[]
        {
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The b c evo back colors
        /// </summary>
        private Color[] bCEvoBackColors = new Color[]
        {
            Color.FromArgb(255, 55, 55, 55),
            Color.FromArgb(255, 22, 22, 22),
            Color.FromArgb(100, 0, 0),
            Color.FromArgb(60, 0, 0),
            Color.FromArgb(25, Color.White),
            Color.FromArgb(90, 90, 90)

        };

        /// <summary>
        /// The border width
        /// </summary>
        private int borderWidth = 2;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the bc evo fore colors.
        /// </summary>
        /// <value>The bc evo fore colors.</value>
        public Color[] BCEvoForeColors
        {
            get => bCEvoForeColors;
            set
            {
                bCEvoForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the bc evo border colors.
        /// </summary>
        /// <value>The bc evo border colors.</value>
        public Color[] BCEvoBorderColors
        {
            get => bCEvoBorderColors;
            set { bCEvoBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the bc evo back colors.
        /// </summary>
        /// <value>The bc evo back colors.</value>
        public Color[] BCEvoBackColors
        {
            get => bCEvoBackColors;
            set { bCEvoBackColors = value;  }
        }

        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>The width of the border.</value>
        public int BorderWidth
        {
            get => borderWidth;
            set
            {
                borderWidth = value;
                
            }
        }

        #endregion

        
        
    }
}
