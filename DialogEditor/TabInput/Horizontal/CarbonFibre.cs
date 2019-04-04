// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CarbonFibre.cs" company="Zeroit Dev Technologies">
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

        // BackColor
        /// <summary>
        /// The carbon back
        /// </summary>
        Color carbonBack = Color.FromArgb(22, 22, 22);
        // ' OUter Black
        /// <summary>
        /// The carbon outer border
        /// </summary>
        Color carbonOuterBorder = Color.FromArgb(6, 6, 6);
        // ' Inner Border
        /// <summary>
        /// The carbon inner border
        /// </summary>
        Color carbonInnerBorder = Color.FromArgb(32, 32, 32);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the carbon back.
        /// </summary>
        /// <value>The carbon back.</value>
        public Color CarbonBack
        {
            get => carbonBack;
            set
            {
                carbonBack = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the carbon outer border.
        /// </summary>
        /// <value>The carbon outer border.</value>
        public Color CarbonOuterBorder
        {
            get => carbonOuterBorder;
            set { carbonOuterBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the carbon inner border.
        /// </summary>
        /// <value>The carbon inner border.</value>
        public Color CarbonInnerBorder
        {
            get => carbonInnerBorder;
            set { carbonInnerBorder = value;  }
        } 
        #endregion
        

    }

}

