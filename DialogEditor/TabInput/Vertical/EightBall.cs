// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="EightBall.cs" company="Zeroit Dev Technologies">
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
        /// The eight ball back colors
        /// </summary>
        private Color[] eightBallBackColors = new Color[]
        {
            Color.FromArgb(100, 100, 100),
            Color.FromArgb(100, 100, 100),
            Color.FromArgb(30, Color.White),
            Color.FromArgb(10, Color.Black),
            Color.FromArgb(75, 75, 75),
            Color.Gray,
            Color.FromArgb(100, 100, 100),
            Color.SteelBlue
        };

        /// <summary>
        /// The eight ball border colors
        /// </summary>
        private Color[] eightBallBorderColors = new Color[]
        {
            Color.FromArgb(55, 55, 55),
            Color.FromArgb(40, 105, 145),
            Color.FromArgb(100, 100, 100),
            Color.DimGray
        };

        /// <summary>
        /// The eight ball fore colors
        /// </summary>
        private Color[] eightBallForeColors = new Color[]
        {
            Color.White,
            Color.Silver
        };

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the eight ball back colors.
        /// </summary>
        /// <value>The eight ball back colors.</value>
        public Color[] EightBallBackColors
        {
            get => eightBallBackColors;
            set
            {
                eightBallBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the eight ball border colors.
        /// </summary>
        /// <value>The eight ball border colors.</value>
        public Color[] EightBallBorderColors
        {
            get => eightBallBorderColors;
            set { eightBallBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the eight ball fore colors.
        /// </summary>
        /// <value>The eight ball fore colors.</value>
        public Color[] EightBallForeColors
        {
            get => eightBallForeColors;
            set { eightBallForeColors = value;  }
        }

        #endregion
        
    }

}

