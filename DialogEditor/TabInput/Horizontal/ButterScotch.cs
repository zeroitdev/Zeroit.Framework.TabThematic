// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ButterScotch.cs" company="Zeroit Dev Technologies">
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
        /// The but fore colors
        /// </summary>
        private Color[] butForeColors = new Color[]
        {
            Color.FromArgb(25, 23, 22),
            Color.FromArgb(255, 255, 255)
        };

        /// <summary>
        /// The but back colors
        /// </summary>
        private Color[] butBackColors = new Color[]
        {
            Color.FromArgb(100, 90, 80),
            Color.FromArgb(40, 37, 33),
            Color.FromArgb(100, 90, 80),
            Color.FromArgb(48, 43, 39),
            Color.FromArgb(57, 52, 46),
            Color.FromArgb(92, 83, 74)
        };

        /// <summary>
        /// The but border colors
        /// </summary>
        private Color[] butBorderColors = new Color[]
        {
            Color.Black,

        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the but fore colors.
        /// </summary>
        /// <value>The but fore colors.</value>
        public Color[] ButForeColors
        {
            get => butForeColors;
            set
            {
                butForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the but back colors.
        /// </summary>
        /// <value>The but back colors.</value>
        public Color[] ButBackColors
        {
            get => butBackColors;
            set { butBackColors = value;  }
        }

        /// <summary>
        /// Gets or sets the but border colors.
        /// </summary>
        /// <value>The but border colors.</value>
        public Color[] ButBorderColors
        {
            get => butBorderColors;
            set { butBorderColors = value;  }
        }
        #endregion

        
    }


}

