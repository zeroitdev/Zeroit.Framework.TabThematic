// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BCEvo.cs" company="Zeroit Dev Technologies">
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
        /// The b c evo fore colors
        /// </summary>
        private Color[] bCEvoForeColors = new Color[]
        {
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(100, 100, 100)
        };

        /// <summary>
        /// The b c evo border colors
        /// </summary>
        private Color[] bCEvoBorderColors = new Color[]
        {
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The b c evo back colors
        /// </summary>
        private Color[] bCEvoBackColors = new Color[]
        {
            Color.FromArgb(255, 55, 55, 55),
            Color.FromArgb(255, 22, 22, 22),
            Color.FromArgb(100, 0, 0),
            Color.FromArgb(60, 0, 0),
            Color.FromArgb(25, Color.White),
            Color.FromArgb(90, 90, 90)

        };

        /// <summary>
        /// The border width
        /// </summary>
        private int borderWidth = 2;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the bc evo fore colors.
        /// </summary>
        /// <value>The bc evo fore colors.</value>
        public Color[] BCEvoForeColors
        {
            get => bCEvoForeColors;
            set
            {
                bCEvoForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the bc evo border colors.
        /// </summary>
        /// <value>The bc evo border colors.</value>
        public Color[] BCEvoBorderColors
        {
            get => bCEvoBorderColors;
            set { bCEvoBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the bc evo back colors.
        /// </summary>
        /// <value>The bc evo back colors.</value>
        public Color[] BCEvoBackColors
        {
            get => bCEvoBackColors;
            set { bCEvoBackColors = value;  }
        }

        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>The width of the border.</value>
        public int BorderWidth
        {
            get => borderWidth;
            set
            {
                borderWidth = value;
                
            }
        }

        #endregion

        
        
    }
}
