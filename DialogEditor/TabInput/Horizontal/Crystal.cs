// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Crystal.cs" company="Zeroit Dev Technologies">
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

        //private Color _BG;

        #region Private Fields
        /// <summary>
        /// The crystal back colors
        /// </summary>
        private Color[] crystalBackColors = new Color[]
        {
            Color.FromArgb(230, 230, 230),
            Color.FromArgb(10, 0, 0, 0),
            Color.FromArgb(230, 230, 230),
            Color.FromArgb(10, Color.Black),
            Color.Transparent,
            Color.FromArgb(215, 215, 215),
            Color.FromArgb(230, 230, 230)
        };

        /// <summary>
        /// The crystal border colors
        /// </summary>
        private Color[] crystalBorderColors = new Color[]
        {
            Color.FromArgb(170, 170, 170),
            Color.FromArgb(170, 170, 170),
            Color.FromArgb(170, 170, 170),
            Color.FromArgb(170, 170, 170),
            Color.FromArgb(170, 170, 170)
        };

        /// <summary>
        /// The crystal fore colors
        /// </summary>
        private Color[] crystalForeColors = new Color[]
        {
            Color.Black,
            Color.Black
        };

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the crystal back colors.
        /// </summary>
        /// <value>The crystal back colors.</value>
        public Color[] CrystalBackColors
        {
            get => crystalBackColors;
            set
            {
                crystalBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the crystal border colors.
        /// </summary>
        /// <value>The crystal border colors.</value>
        public Color[] CrystalBorderColors
        {
            get => crystalBorderColors;
            set { crystalBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the crystal fore colors.
        /// </summary>
        /// <value>The crystal fore colors.</value>
        public Color[] CrystalForeColors
        {
            get => crystalForeColors;
            set { crystalForeColors = value;  }
        }

        #endregion

        


    }

}

