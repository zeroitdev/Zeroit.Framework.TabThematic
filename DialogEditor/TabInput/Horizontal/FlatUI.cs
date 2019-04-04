// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FlatUI.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
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
        /// The flat bg color
        /// </summary>
        private Color flatBGColor = Color.FromArgb(60, 70, 73);
        /// <summary>
        /// The flat base color
        /// </summary>
        private Color flatBaseColor = Color.FromArgb(45, 47, 49);
        /// <summary>
        /// The flat active color
        /// </summary>
        private Color flatActiveColor = Color.FromArgb(35, 168, 109);
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the color of the flat base.
        /// </summary>
        /// <value>The color of the flat base.</value>
        [Category("Colors")]
        public Color FlatBaseColor
        {
            get { return flatBaseColor; }
            set { flatBaseColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the flat active.
        /// </summary>
        /// <value>The color of the flat active.</value>
        [Category("Colors")]
        public Color FlatActiveColor
        {
            get { return flatActiveColor; }
            set { flatActiveColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the flat tab back.
        /// </summary>
        /// <value>The color of the flat tab back.</value>
        [Category("Colors")]
        public Color FlatTabBackColor
        {
            get { return flatBGColor; }
            set { flatBGColor = value;  }
        }

        #endregion
        

    }

}

