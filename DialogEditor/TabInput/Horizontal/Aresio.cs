// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Aresio.cs" company="Zeroit Dev Technologies">
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
        /// The aresio fore colors
        /// </summary>
        private Color[] aresioForeColors = new Color[]
        {
            Color.FromArgb(255,255,255),
            Color.FromArgb(80, 80, 80)
        };

        /// <summary>
        /// The aresio border colors
        /// </summary>
        private Color[] aresioBorderColors = new Color[]
        {
            Color.FromArgb(90, Color.Gray),
            Color.FromArgb(150, 151, 153),
            Color.FromArgb(150, 151, 153)

        };

        /// <summary>
        /// The aresio back colors
        /// </summary>
        private Color[] aresioBackColors = new Color[]
        {
            Color.FromArgb(236, 237, 239),
            Color.FromArgb(10, Color.Black),
            Color.FromArgb(236, 237, 239),
            Color.FromArgb(236, 237, 239)
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the aresio fore colors.
        /// </summary>
        /// <value>The aresio fore colors.</value>
        public Color[] AresioForeColors
        {
            get => aresioForeColors;
            set
            {
                aresioForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the aresio border colors.
        /// </summary>
        /// <value>The aresio border colors.</value>
        public Color[] AresioBorderColors
        {
            get => aresioBorderColors;
            set { aresioBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the aresio back colors.
        /// </summary>
        /// <value>The aresio back colors.</value>
        public Color[] AresioBackColors
        {
            get => aresioBackColors;
            set { aresioBackColors = value;  }
        }

        #endregion

        

    }

}
