// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Facebook.cs" company="Zeroit Dev Technologies">
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
        /// The pressed tab color
        /// </summary>
        private Color pressedTabColor = Color.FromArgb(200, 215, 237);
        /// <summary>
        /// The hover color
        /// </summary>
        private Color hoverColor = Color.FromArgb(109, 132, 180);
        /// <summary>
        /// The normal color
        /// </summary>
        private Color normalColor = Color.FromArgb(237, 239, 244);
        /// <summary>
        /// The face book border color
        /// </summary>
        private Color faceBookBorderColor = Color.FromArgb(139, 162, 210);
        /// <summary>
        /// The face book text color
        /// </summary>
        private Color faceBookTextColor = Color.FromArgb(58, 66, 73);
        /// <summary>
        /// The face book back
        /// </summary>
        private Color faceBookBack = Color.FromArgb(199, 201, 207);

        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the color of the normal.
        /// </summary>
        /// <value>The color of the normal.</value>
        public Color NormalColor
        {
            get { return normalColor; }
            set { normalColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the hover.
        /// </summary>
        /// <value>The color of the hover.</value>
        public Color HoverColor
        {
            get { return hoverColor; }
            set { hoverColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the pressed tab.
        /// </summary>
        /// <value>The color of the pressed tab.</value>
        public Color PressedTabColor
        {
            get { return pressedTabColor; }
            set { pressedTabColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the face book border.
        /// </summary>
        /// <value>The color of the face book border.</value>
        public Color FaceBookBorderColor
        {
            get { return faceBookBorderColor; }
            set { faceBookBorderColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the face book text.
        /// </summary>
        /// <value>The color of the face book text.</value>
        public Color FaceBookTextColor
        {
            get { return faceBookTextColor; }
            set { faceBookTextColor = value;  }
        }

        /// <summary>
        /// Gets or sets the face book back.
        /// </summary>
        /// <value>The face book back.</value>
        public Color FaceBookBack
        {
            get => faceBookBack;
            set { faceBookBack = value;
                
            }
        }

        #endregion
        
    }

}

