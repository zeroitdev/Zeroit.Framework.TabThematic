// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SLC.cs" company="Zeroit Dev Technologies">
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
        /// The SLC back colors
        /// </summary>
        private Color[] slcBackColors = new Color[]
        {
            Color.White,
            Color.FromArgb(250, 250, 250),
            Color.FromArgb(237, 237, 237),
            Color.FromArgb(227, 227, 227),
            Color.Transparent,
            Color.FromArgb(227, 227, 227),
            Color.Transparent,
            Color.FromArgb(242, 242, 242),
            Color.FromArgb(56, 142, 196),
            Color.FromArgb(64, 106, 140),
            Color.FromArgb(40, Color.WhiteSmoke),
            Color.FromArgb(242, 242, 242),
            Color.LightGray

        };

        /// <summary>
        /// The SLC border colors
        /// </summary>
        private Color[] slcBorderColors = new Color[]
        {
            Color.LightGray,
            Color.Gray,
            Color.White,
            Color.FromArgb(70, Color.FromArgb(39, 93, 127)),
            Color.FromArgb(200, 200, 200),
            Color.FromArgb(150, 150, 150),
            Color.FromArgb(49, 63, 86),
            Color.White,
            Color.FromArgb(70, Color.FromArgb(39, 93, 127)),
            Color.FromArgb(100, 100, 100)

        };

        /// <summary>
        /// The SLC fore colors
        /// </summary>
        private Color[] slcForeColors = new Color[]
        {
            Color.FromArgb(56, 106, 137)
        };

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the SLC back colors.
        /// </summary>
        /// <value>The SLC back colors.</value>
        public Color[] SlcBackColors
        {
            get => slcBackColors;
            set
            {
                slcBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the SLC border colors.
        /// </summary>
        /// <value>The SLC border colors.</value>
        public Color[] SlcBorderColors
        {
            get => slcBorderColors;
            set { slcBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the SLC fore colors.
        /// </summary>
        /// <value>The SLC fore colors.</value>
        public Color[] SlcForeColors
        {
            get => slcForeColors;
            set { slcForeColors = value;  }
        }
        #endregion
        

    }

}

