// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DotnetBar.cs" company="Zeroit Dev Technologies">
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
        /// The dotnet bar back colors
        /// </summary>
        private Color[] dotnetBarBackColors = new Color[]
        {
            Color.White,
            Color.White,
            Color.FromArgb(246, 248, 252),
            Color.Black, Color.Black,
            Color.White,
            Color.FromArgb(246, 248, 252)
        };

        /// <summary>
        /// The dotnet bar border colors
        /// </summary>
        private Color[] dotnetBarBorderColors = new Color[]
        {
            Color.FromArgb(170, 187, 204),
            Color.FromArgb(170, 187, 204),
            Color.FromArgb(170, 187, 204),
            Color.FromArgb(200, 200, 250),
            Color.FromArgb(200, 200, 250),
            Color.FromArgb(170, 187, 204)

        };

        /// <summary>
        /// The dotnet bar fore colors
        /// </summary>
        private Color[] dotnetBarForeColors = new Color[]
        {
            Color.Black,
            Color.DimGray
        };

        /// <summary>
        /// The dotnet bar color blend
        /// </summary>
        private Color[] dotnetBarColorBlend = new Color[]
        {
            Color.FromArgb(232, 232, 240),
            Color.FromArgb(232, 232, 240),
            Color.FromArgb(232, 232, 240)
        };
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the dotnet bar back colors.
        /// </summary>
        /// <value>The dotnet bar back colors.</value>
        public Color[] DotnetBarBackColors
        {
            get => dotnetBarBackColors;
            set
            {
                dotnetBarBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dotnet bar border colors.
        /// </summary>
        /// <value>The dotnet bar border colors.</value>
        public Color[] DotnetBarBorderColors
        {
            get => dotnetBarBorderColors;
            set
            {
                dotnetBarBorderColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dotnet bar fore colors.
        /// </summary>
        /// <value>The dotnet bar fore colors.</value>
        public Color[] DotnetBarForeColors
        {
            get => dotnetBarForeColors;
            set
            {
                dotnetBarForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dotnet bar color blend.
        /// </summary>
        /// <value>The dotnet bar color blend.</value>
        public Color[] DotnetBarColorBlend
        {
            get { return dotnetBarColorBlend; }
            set
            {
                dotnetBarColorBlend = value;
                
            }
        }
        #endregion
        

    }
}
