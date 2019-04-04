// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Simpla.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

