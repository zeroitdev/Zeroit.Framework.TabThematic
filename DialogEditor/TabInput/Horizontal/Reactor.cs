// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Reactor.cs" company="Zeroit Dev Technologies">
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

        //private Color reactorControlBColor = Color.White;

        /// <summary>
        /// The react fore colors
        /// </summary>
        private Color[] reactForeColors = new Color[]
        {
            Color.White,
            Color.DimGray
        };

        /// <summary>
        /// The react back colors
        /// </summary>
        private Color[] reactBackColors = new Color[]
        {
            Color.FromArgb(50, Color.White),
            Color.FromArgb(25, Color.White),
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(50, 50, 50),
            Color.Transparent,
            Color.Transparent,
            Color.FromArgb(32, 32, 32),
            Color.FromArgb(175, 219, 78, 0),
            Color.FromArgb(175, 229, 98, 0),
            Color.FromArgb(80, Color.White),
            Color.FromArgb(20, Color.White),
            Color.FromArgb(32, 32, 32)
        };

        /// <summary>
        /// The react border colors
        /// </summary>
        private Color[] reactBorderColors = new Color[]
        {
            Color.FromArgb(28, 28, 28),
            Color.Transparent,
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(100, 230, 90, 0),
            Color.Transparent,
            Color.Black,
            Color.FromArgb(70, 70, 70),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(31, 31, 31),
            Color.FromArgb(10, 10, 10)
        };

        /// <summary>
        /// The reac tab border color
        /// </summary>
        private Color reacTabBorderColor = Color.White;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the color of the tab border.
        /// </summary>
        /// <value>The color of the tab border.</value>
        public Color TabBorderColor
        {
            get { return reacTabBorderColor; }
            set
            {
                reacTabBorderColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the react fore colors.
        /// </summary>
        /// <value>The react fore colors.</value>
        public Color[] ReactForeColors
        {
            get => reactForeColors;
            set
            {
                reactForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the react back colors.
        /// </summary>
        /// <value>The react back colors.</value>
        public Color[] ReactBackColors
        {
            get => reactBackColors;
            set { reactBackColors = value;  }
        }

        /// <summary>
        /// Gets or sets the react border colors.
        /// </summary>
        /// <value>The react border colors.</value>
        public Color[] ReactBorderColors
        {
            get => reactBorderColors;
            set { reactBorderColors = value;  }
        }
        #endregion
        
    }



}

