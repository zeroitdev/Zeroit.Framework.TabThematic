// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="NS.cs" company="Zeroit Dev Technologies">
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
        /// The ns border colors
        /// </summary>
        private Color[] nsBorderColors = new Color[]
        {
            Color.FromArgb(55, 55, 55),
            Color.FromArgb(24, 24, 24),
            Color.FromArgb(45, 45, 45)
        };

        /// <summary>
        /// The ns back colors
        /// </summary>
        private Color[] nsBackColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(24, 24, 24),
            Color.FromArgb(51, 181, 229),
            Color.FromArgb(65, 65, 65)
        };

        /// <summary>
        /// The ns fore colors
        /// </summary>
        private Color[] nsForeColors = new Color[]
        {
            Color.Black,
            Color.WhiteSmoke
        };

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the ns fore colors.
        /// </summary>
        /// <value>The ns fore colors.</value>
        public Color[] NsForeColors
        {
            get { return nsForeColors; }
            set { nsForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the ns back colors.
        /// </summary>
        /// <value>The ns back colors.</value>
        public Color[] NsBackColors
        {
            get => nsBackColors;
            set { nsBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the ns border colors.
        /// </summary>
        /// <value>The ns border colors.</value>
        public Color[] NsBorderColors
        {
            get => nsBorderColors;
            set { nsBorderColors = value;
                
            }
        }

        #endregion
        

    }
}
