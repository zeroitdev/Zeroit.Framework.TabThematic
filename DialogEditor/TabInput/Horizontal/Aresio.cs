// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Aresio.cs" company="Zeroit Dev Technologies">
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
        /// The aresio fore colors
        /// </summary>
        private Color[] aresioForeColors = new Color[]
        {
            Color.FromArgb(255,255,255),
            Color.FromArgb(80, 80, 80)
        };

        /// <summary>
        /// The aresio border colors
        /// </summary>
        private Color[] aresioBorderColors = new Color[]
        {
            Color.FromArgb(90, Color.Gray),
            Color.FromArgb(150, 151, 153),
            Color.FromArgb(150, 151, 153)

        };

        /// <summary>
        /// The aresio back colors
        /// </summary>
        private Color[] aresioBackColors = new Color[]
        {
            Color.FromArgb(236, 237, 239),
            Color.FromArgb(10, Color.Black),
            Color.FromArgb(236, 237, 239),
            Color.FromArgb(236, 237, 239)
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the aresio fore colors.
        /// </summary>
        /// <value>The aresio fore colors.</value>
        public Color[] AresioForeColors
        {
            get => aresioForeColors;
            set
            {
                aresioForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the aresio border colors.
        /// </summary>
        /// <value>The aresio border colors.</value>
        public Color[] AresioBorderColors
        {
            get => aresioBorderColors;
            set { aresioBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the aresio back colors.
        /// </summary>
        /// <value>The aresio back colors.</value>
        public Color[] AresioBackColors
        {
            get => aresioBackColors;
            set { aresioBackColors = value;  }
        }

        #endregion

        

    }

}
