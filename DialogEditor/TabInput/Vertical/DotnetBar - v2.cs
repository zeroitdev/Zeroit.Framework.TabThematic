// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DotnetBar - v2.cs" company="Zeroit Dev Technologies">
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
        /// The dot v2 back colors
        /// </summary>
        private Color[] dotV2BackColors = new Color[]
        {
            Color.White,
            Color.FromArgb(96, 110, 121),
            Color.Black,
            Color.Black,
            Color.FromArgb(80, 90, 100),
            Color.FromArgb(96, 110, 121),
            Color.White
        };

        /// <summary>
        /// The dot v2 border colors
        /// </summary>
        private Color[] dotV2BorderColors = new Color[]
        {
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(67, 77, 87),
            Color.FromArgb(115, 125, 135),
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(65, 75, 85)
        };

        /// <summary>
        /// The dot v2 fore colors
        /// </summary>
        private Color[] dotV2ForeColors = new Color[]
        {
            Color.White,
            Color.FromArgb(210, 220, 230)
        };

        /// <summary>
        /// The dot v2 blend colors
        /// </summary>
        private Color[] dotV2BlendColors = new Color[]
        {
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(96, 110, 121)
        };
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the dot v2 back colors.
        /// </summary>
        /// <value>The dot v2 back colors.</value>
        public Color[] DotV2BackColors
        {
            get => dotV2BackColors;
            set
            {
                dotV2BackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dot v2 blend colors.
        /// </summary>
        /// <value>The dot v2 blend colors.</value>
        public Color[] DotV2BlendColors
        {
            get => dotV2BlendColors;
            set
            {
                dotV2BlendColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dot v2 border colors.
        /// </summary>
        /// <value>The dot v2 border colors.</value>
        public Color[] DotV2BorderColors
        {
            get { return dotV2BorderColors; }
            set
            {
                dotV2BorderColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dot v2 fore colors.
        /// </summary>
        /// <value>The dot v2 fore colors.</value>
        public Color[] DotV2ForeColors
        {
            get => dotV2ForeColors;
            set
            {
                dotV2ForeColors = value;
                
            }
        }
        #endregion
        
    }


}

