// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="VTheme.cs" company="Zeroit Dev Technologies">
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
        /// The v back colors
        /// </summary>
        private Color[] vBackColors = new Color[]
        {
            Color.FromArgb(18, 18, 18),
            Color.FromArgb(15, 15, 15),
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(42, 42, 42),
            Color.Transparent,
            Color.Transparent,
            Color.FromArgb(5, 5, 5),
            Color.FromArgb(24, 24, 24),
            Color.FromArgb(15, 15, 15)
        };

        /// <summary>
        /// The v border colors
        /// </summary>
        private Color[] vBorderColors = new Color[]
        {
            Color.FromArgb(21, 21, 21),
            Color.Black,
            Color.FromArgb(255, Color.Black),
            Color.FromArgb(255, Color.Black),
            Color.FromArgb(35, 35, 35),
            Color.FromArgb(70, 70, 70)
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the v back colors.
        /// </summary>
        /// <value>The v back colors.</value>
        public Color[] VBackColors
        {
            get => vBackColors;
            set
            {
                vBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the v border colors.
        /// </summary>
        /// <value>The v border colors.</value>
        public Color[] VBorderColors
        {
            get => vBorderColors;
            set { vBorderColors = value;  }
        } 
        #endregion
        

    }

}

