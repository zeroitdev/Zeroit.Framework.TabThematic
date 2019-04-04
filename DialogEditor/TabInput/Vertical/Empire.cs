// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Empire.cs" company="Zeroit Dev Technologies">
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
        /// The empire fore colors
        /// </summary>
        private Color[] empireForeColors = new Color[]
        {
            Color.Gainsboro,
            Color.Gray
        };

        /// <summary>
        /// The empire border colors
        /// </summary>
        private Color[] empireBorderColors = new Color[]
        {
            Color.Black,
            Color.FromArgb(51, 51, 51),
            Color.FromArgb(17, 17, 17),
            Color.FromArgb(51, 51, 51),
            Color.FromArgb(17, 17, 17)
        };

        /// <summary>
        /// The empire back colors
        /// </summary>
        Color[] empireBackColors = new Color[]
        {
            Color.FromArgb(55, 173, 242),
            Color.FromArgb(36, 36, 36),
            Color.FromArgb(42, 42, 42),
            Color.FromArgb(25, 25, 25),
            Color.Gainsboro,
            Color.FromArgb(90, Color.Black),
            Color.Transparent,
            Color.FromArgb(200, 200, 200),
            Color.FromArgb(36, 36, 36),
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(3, Color.White)

        };

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the empire fore colors.
        /// </summary>
        /// <value>The empire fore colors.</value>
        public Color[] EmpireForeColors
        {
            get => empireForeColors;
            set
            {
                empireForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the empire border colors.
        /// </summary>
        /// <value>The empire border colors.</value>
        public Color[] EmpireBorderColors
        {
            get => empireBorderColors;
            set { empireBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the empire back colors.
        /// </summary>
        /// <value>The empire back colors.</value>
        public Color[] EmpireBackColors
        {
            get => empireBackColors;
            set { empireBackColors = value;  }
        } 
        #endregion
        

    }

}

