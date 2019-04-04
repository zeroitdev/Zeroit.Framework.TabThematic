// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CarbonFibre.cs" company="Zeroit Dev Technologies">
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

        // BackColor
        /// <summary>
        /// The carbon back
        /// </summary>
        Color carbonBack = Color.FromArgb(22, 22, 22);
        // ' OUter Black
        /// <summary>
        /// The carbon outer border
        /// </summary>
        Color carbonOuterBorder = Color.FromArgb(6, 6, 6);
        // ' Inner Border
        /// <summary>
        /// The carbon inner border
        /// </summary>
        Color carbonInnerBorder = Color.FromArgb(32, 32, 32);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the carbon back.
        /// </summary>
        /// <value>The carbon back.</value>
        public Color CarbonBack
        {
            get => carbonBack;
            set
            {
                carbonBack = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the carbon outer border.
        /// </summary>
        /// <value>The carbon outer border.</value>
        public Color CarbonOuterBorder
        {
            get => carbonOuterBorder;
            set { carbonOuterBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the carbon inner border.
        /// </summary>
        /// <value>The carbon inner border.</value>
        public Color CarbonInnerBorder
        {
            get => carbonInnerBorder;
            set { carbonInnerBorder = value;  }
        } 
        #endregion
        

    }

}

