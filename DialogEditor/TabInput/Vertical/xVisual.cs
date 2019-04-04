// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="xVisual.cs" company="Zeroit Dev Technologies">
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
        /// The inner texture
        /// </summary>
        Color[] innerTexture = new Color[]{
        Color.FromArgb(45, 41, 37),
        Color.FromArgb(47, 43, 39),
        Color.FromArgb(43, 39, 35)
    };

        /// <summary>
        /// The tab bg texture
        /// </summary>
        Color[] tabBGTexture = new Color[]
        {
            Color.FromArgb(55, 51, 48),
            Color.FromArgb(57, 53, 50),
            Color.FromArgb(53, 49, 46)

        };

        /// <summary>
        /// The x visual back colors
        /// </summary>
        private Color[] xVisualBackColors = new Color[]
        {
            Color.FromArgb(56, 52, 49),
            Color.FromArgb(114, 203, 232),
            Color.FromArgb(58, 118, 188),
            Color.FromArgb(114, 203, 232),
            Color.FromArgb(58, 118, 188),
            Color.FromArgb(15, Color.White),
            Color.FromArgb(100, Color.FromArgb(43, 40, 38)),
            Color.FromArgb(56, 52, 49)
        };

        /// <summary>
        /// The x visual border colors
        /// </summary>
        private Color[] xVisualBorderColors = new Color[]
        {
            Color.FromArgb(44, 42, 39),
            Color.FromArgb(48, 45, 43),
            Color.FromArgb(53, 50, 47),
            Color.Black,
            Color.FromArgb(99, 97, 94),
            Color.FromArgb(235, 255, 255),
            Color.FromArgb(235, 255, 255),
            Color.Black,
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(113, 110, 108),
            Color.Black,
            Color.FromArgb(64, 60, 57),
            Color.FromArgb(35, 33, 31),
            Color.FromArgb(43, 41, 38),
            Color.FromArgb(53, 50, 47),
            Color.FromArgb(58, 55, 51),
            Color.Black,
            Color.FromArgb(56, 52, 49),
            Color.FromArgb(56, 52, 49),
            Color.Black
        };

        /// <summary>
        /// The x visual fore colors
        /// </summary>
        private Color[] xVisualForeColors = new Color[]
        {
            Color.FromArgb(20, 20, 20),
            Color.White,
            Color.FromArgb(210, 220, 230)
        };

        /// <summary>
        /// The glow color
        /// </summary>
        Color[] glowColor =
        {
            Color.FromArgb(43, 40, 38),
            Color.FromArgb(50, 47, 44),
            Color.FromArgb(55, 52, 49)
        };

        #endregion

        #region Public 

        /// <summary>
        /// Gets or sets the x visual back colors.
        /// </summary>
        /// <value>The x visual back colors.</value>
        public Color[] XVisualBackColors
        {
            get => xVisualBackColors;
            set
            {
                xVisualBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the x visual border colors.
        /// </summary>
        /// <value>The x visual border colors.</value>
        public Color[] XVisualBorderColors
        {
            get => xVisualBorderColors;
            set { xVisualBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the x visual fore colors.
        /// </summary>
        /// <value>The x visual fore colors.</value>
        public Color[] XVisualForeColors
        {
            get => xVisualForeColors;
            set { xVisualForeColors = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the glow.
        /// </summary>
        /// <value>The color of the glow.</value>
        public Color[] GlowColor
        {
            get { return glowColor; }
            set
            {
                glowColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the inner texture.
        /// </summary>
        /// <value>The inner texture.</value>
        public Color[] InnerTexture
        {
            get { return innerTexture; }
            set
            {
                innerTexture = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the tab bg texture.
        /// </summary>
        /// <value>The tab bg texture.</value>
        public Color[] TabBGTexture
        {
            get { return tabBGTexture; }
            set { tabBGTexture = value;  }
        }

        #endregion
        
    }

}

