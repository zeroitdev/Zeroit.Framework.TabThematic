// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Simpla.cs" company="Zeroit Dev Technologies">
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
        /// The main background
        /// </summary>
        private Color mainBackground = Color.FromArgb(34, 34, 34);
        /// <summary>
        /// The top background
        /// </summary>
        private Color topBackground = Color.FromArgb(34, 34, 34);
        /// <summary>
        /// The active tab color
        /// </summary>
        private Color activeTabColor = Color.FromArgb(20, 20, 20);
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the main background.
        /// </summary>
        /// <value>The main background.</value>
        public Color MainBackground
        {
            get => mainBackground;
            set
            {
                mainBackground = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the top background.
        /// </summary>
        /// <value>The top background.</value>
        public Color TopBackground
        {
            get => topBackground;
            set
            {
                topBackground = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the active tab.
        /// </summary>
        /// <value>The color of the active tab.</value>
        public Color ActiveTabColor
        {
            get => activeTabColor;
            set
            {
                activeTabColor = value;
                
            }
        }

        #endregion
        

    }

}

