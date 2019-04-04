// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Reactor.cs" company="Zeroit Dev Technologies">
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

        //private Color reactorControlBColor = Color.White;

        /// <summary>
        /// The react fore colors
        /// </summary>
        private Color[] reactForeColors = new Color[]
        {
            Color.White,
            Color.DimGray
        };

        /// <summary>
        /// The react back colors
        /// </summary>
        private Color[] reactBackColors = new Color[]
        {
            Color.FromArgb(50, Color.White),
            Color.FromArgb(25, Color.White),
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(50, 50, 50),
            Color.Transparent,
            Color.Transparent,
            Color.FromArgb(32, 32, 32),
            Color.FromArgb(175, 219, 78, 0),
            Color.FromArgb(175, 229, 98, 0),
            Color.FromArgb(80, Color.White),
            Color.FromArgb(20, Color.White),
            Color.FromArgb(32, 32, 32)
        };

        /// <summary>
        /// The react border colors
        /// </summary>
        private Color[] reactBorderColors = new Color[]
        {
            Color.FromArgb(28, 28, 28),
            Color.Transparent,
            Color.FromArgb(10, 10, 10),
            Color.FromArgb(100, 230, 90, 0),
            Color.Transparent,
            Color.Black,
            Color.FromArgb(70, 70, 70),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(31, 31, 31),
            Color.FromArgb(10, 10, 10)
        };

        /// <summary>
        /// The reac tab border color
        /// </summary>
        private Color reacTabBorderColor = Color.White;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the color of the tab border.
        /// </summary>
        /// <value>The color of the tab border.</value>
        public Color TabBorderColor
        {
            get { return reacTabBorderColor; }
            set
            {
                reacTabBorderColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the react fore colors.
        /// </summary>
        /// <value>The react fore colors.</value>
        public Color[] ReactForeColors
        {
            get => reactForeColors;
            set
            {
                reactForeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the react back colors.
        /// </summary>
        /// <value>The react back colors.</value>
        public Color[] ReactBackColors
        {
            get => reactBackColors;
            set { reactBackColors = value;  }
        }

        /// <summary>
        /// Gets or sets the react border colors.
        /// </summary>
        /// <value>The react border colors.</value>
        public Color[] ReactBorderColors
        {
            get => reactBorderColors;
            set { reactBorderColors = value;  }
        }
        #endregion
        
    }



}

