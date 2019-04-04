// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="iTab.cs" company="Zeroit Dev Technologies">
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
        /// The i tab back colors
        /// </summary>
        private Color[] iTabBackColors = new Color[]
        {
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(10, 0, 0, 0),
            Color.FromArgb(35, 35, 35),
            Color.FromArgb(10, Color.Black),
            Color.Transparent,
            Color.FromArgb(30, 30, 30),
            Color.FromArgb(35, 35, 35)
        };

        /// <summary>
        /// The i tab border colors
        /// </summary>
        private Color[] iTabBorderColors = new Color[]
        {
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(15, 15, 15),
            Color.Black

        };

        /// <summary>
        /// The i tab fore colors
        /// </summary>
        private Color[] iTabForeColors = new Color[]
        {
            Color.DeepSkyBlue,
            Color.FromArgb(75, 75, 75)
        };

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the i tab back colors.
        /// </summary>
        /// <value>The i tab back colors.</value>
        public Color[] ITabBackColors
        {
            get => iTabBackColors;
            set
            {
                iTabBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the i tab border colors.
        /// </summary>
        /// <value>The i tab border colors.</value>
        public Color[] ITabBorderColors
        {
            get => iTabBorderColors;
            set { iTabBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the i tab fore colors.
        /// </summary>
        /// <value>The i tab fore colors.</value>
        public Color[] ITabForeColors
        {
            get => iTabForeColors;
            set { iTabForeColors = value;  }
        }

        #endregion
        

    }
}
