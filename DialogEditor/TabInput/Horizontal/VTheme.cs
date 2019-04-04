// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="VTheme.cs" company="Zeroit Dev Technologies">
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
        /// The v back colors
        /// </summary>
        private Color[] vBackColors = new Color[]
        {
            Color.FromArgb(18, 18, 18),
            Color.FromArgb(15, 15, 15),
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(42, 42, 42),
            Color.Transparent,
            Color.Transparent,
            Color.FromArgb(5, 5, 5),
            Color.FromArgb(24, 24, 24),
            Color.FromArgb(15, 15, 15)
        };

        /// <summary>
        /// The v border colors
        /// </summary>
        private Color[] vBorderColors = new Color[]
        {
            Color.FromArgb(21, 21, 21),
            Color.Black,
            Color.FromArgb(255, Color.Black),
            Color.FromArgb(255, Color.Black),
            Color.FromArgb(35, 35, 35),
            Color.FromArgb(70, 70, 70)
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the v back colors.
        /// </summary>
        /// <value>The v back colors.</value>
        public Color[] VBackColors
        {
            get => vBackColors;
            set
            {
                vBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the v border colors.
        /// </summary>
        /// <value>The v border colors.</value>
        public Color[] VBorderColors
        {
            get => vBorderColors;
            set { vBorderColors = value;  }
        } 
        #endregion
        

    }

}

