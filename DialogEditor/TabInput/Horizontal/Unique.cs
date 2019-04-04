// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Unique.cs" company="Zeroit Dev Technologies">
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
        /// The unique fore colors
        /// </summary>
        private Color[] uniqueForeColors = new Color[]
        {
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255)
        };

        /// <summary>
        /// The unique back colors
        /// </summary>
        private Color[] uniqueBackColors = new Color[]
        {
            Color.FromArgb(72, 72, 72),
            Color.FromArgb(52, 52, 52),
            Color.FromArgb(56, 68, 85),
            Color.FromArgb(41, 42, 46)
        };

        /// <summary>
        /// The unique border colors
        /// </summary>
        private Color[] uniqueBorderColors = new Color[]
        {
            Color.Black,
            Color.Black
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the unique fore colors.
        /// </summary>
        /// <value>The unique fore colors.</value>
        public Color[] UniqueForeColors
        {
            get => uniqueForeColors;
            set
            {
                uniqueForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the unique back colors.
        /// </summary>
        /// <value>The unique back colors.</value>
        public Color[] UniqueBackColors
        {
            get => uniqueBackColors;
            set { uniqueBackColors = value;  }
        }

        /// <summary>
        /// Gets or sets the unique border colors.
        /// </summary>
        /// <value>The unique border colors.</value>
        public Color[] UniqueBorderColors
        {
            get => uniqueBorderColors;
            set { uniqueBorderColors = value;  }
        }
        #endregion
        

    }

}

