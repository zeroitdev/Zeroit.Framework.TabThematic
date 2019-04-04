// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Redemption.cs" company="Zeroit Dev Technologies">
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
        /// The redemption back colors
        /// </summary>
        private Color[] redemptionBackColors = new Color[]
        {
            Color.FromArgb(47, 48, 52),
            Color.FromArgb(51, 56, 60),
            Color.FromArgb(15, Color.White),
            Color.FromArgb(49, 50, 54),
            Color.FromArgb(72, 79, 87),
            Color.FromArgb(48, 51, 56)
        };

        /// <summary>
        /// The redemption border colors
        /// </summary>
        private Color[] redemptionBorderColors = new Color[]
        {
            Color.Transparent,
            Color.FromArgb(87, 88, 92),
            Color.FromArgb(32, 33, 37),
            Color.FromArgb(119, 124, 130),
            Color.FromArgb(64, 67, 72),
            Color.FromArgb(31, 36, 42)
        };

        /// <summary>
        /// The redemption fore colors
        /// </summary>
        private Color[] redemptionForeColors = new Color[]
        {
            Color.FromArgb(150, Color.Black),
            Color.White
        };

        /// <summary>
        /// The gradient pen
        /// </summary>
        Color[] gradientPen =
        {
            Color.FromArgb(43, 44, 48),
            Color.FromArgb(44, 45, 49),
            Color.FromArgb(45, 46, 50),
            Color.FromArgb(46, 47, 51),
            Color.FromArgb(47, 48, 52),
            Color.FromArgb(48, 49, 53)
        };

        /// <summary>
        /// The background noise
        /// </summary>
        private bool backgroundNoise = true;

        /// <summary>
        /// The align
        /// </summary>
        private HorizontalAlignments align = HorizontalAlignments.Left;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the text align.
        /// </summary>
        /// <value>The text align.</value>
        public HorizontalAlignments TextAlign
        {
            get { return align; }
            set
            {
                align = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [background noise].
        /// </summary>
        /// <value><c>true</c> if [background noise]; otherwise, <c>false</c>.</value>
        public bool BackgroundNoise
        {
            get { return backgroundNoise; }
            set
            {
                backgroundNoise = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the redemption back colors.
        /// </summary>
        /// <value>The redemption back colors.</value>
        public Color[] RedemptionBackColors
        {
            get => redemptionBackColors;
            set
            {
                redemptionBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the redemption border colors.
        /// </summary>
        /// <value>The redemption border colors.</value>
        public Color[] RedemptionBorderColors
        {
            get => redemptionBorderColors;
            set { redemptionBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the redemption fore colors.
        /// </summary>
        /// <value>The redemption fore colors.</value>
        public Color[] RedemptionForeColors
        {
            get => redemptionForeColors;
            set { redemptionForeColors = value;  }
        }

        /// <summary>
        /// Gets or sets the gradient pen.
        /// </summary>
        /// <value>The gradient pen.</value>
        public Color[] GradientPen
        {
            get { return gradientPen; }
            set
            {
                gradientPen = value;
                
            }
        }
        #endregion
        
    }

}

