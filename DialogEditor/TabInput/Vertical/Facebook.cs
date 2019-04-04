// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Facebook.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

