// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FlatUI.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

