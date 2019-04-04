// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SLC.cs" company="Zeroit Dev Technologies">
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

