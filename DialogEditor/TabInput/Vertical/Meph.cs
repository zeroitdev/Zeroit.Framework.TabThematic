// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Meph.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Tab control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
        /// The meph back colors
        /// </summary>
        private Color[] mephBackColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(50, 50, 50),
            Color.Black, Color.Black,
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(50, 50, 50)
        };

        /// <summary>
        /// The meph border colors
        /// </summary>
        private Color[] mephBorderColors = new Color[]
        {
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(96, 110, 121),
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(20, 20, 20)
        };

        /// <summary>
        /// The meph fore colors
        /// </summary>
        private Color[] mephForeColors = new Color[]
        {
            Color.White,
            Color.FromArgb(210, 220, 230)
        };

        /// <summary>
        /// The meph color blend
        /// </summary>
        private Color[] mephColorBlend = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(50, 50, 50)
        };

        /// <summary>
        /// The c full
        /// </summary>
        private Color[] cFull = new Color[]
        {
            Color.FromArgb(20, 20, 20),
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(46, 46, 46),
            Color.FromArgb(47, 47, 47),
            Color.FromArgb(48, 48, 48),
            Color.FromArgb(49, 49, 49),
            Color.FromArgb(50, 50, 50)
        };

        /// <summary>
        /// The c highlight
        /// </summary>
        private Color[] cHighlight = new Color[]
        {
            Color.FromArgb(20, 20, 20),
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(46, 46, 46),
            Color.FromArgb(47, 47, 47),
            Color.FromArgb(48, 48, 48),
            Color.FromArgb(49, 49, 49),
            Color.FromArgb(50, 50, 50)
        };

        /// <summary>
        /// The page fill
        /// </summary>
        private Color[] pageFill = new Color[]
        {
            Color.FromArgb(20, 20, 20),
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(45, 45, 45),
            Color.FromArgb(46, 46, 46),
            Color.FromArgb(47, 47, 47),
            Color.FromArgb(48, 48, 48),
            Color.FromArgb(49, 49, 49),
            Color.FromArgb(50, 50, 50)
        };

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the meph back colors.
        /// </summary>
        /// <value>The meph back colors.</value>
        public Color[] MephBackColors
        {
            get => mephBackColors;
            set
            {
                mephBackColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the meph border colors.
        /// </summary>
        /// <value>The meph border colors.</value>
        public Color[] MephBorderColors
        {
            get => mephBorderColors;
            set { mephBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the meph fore colors.
        /// </summary>
        /// <value>The meph fore colors.</value>
        public Color[] MephForeColors
        {
            get => mephForeColors;
            set { mephForeColors = value;  }
        }

        /// <summary>
        /// Gets or sets the meph color blend.
        /// </summary>
        /// <value>The meph color blend.</value>
        public Color[] MephColorBlend
        {
            get { return mephColorBlend; }
            set
            {
                mephColorBlend = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the c full.
        /// </summary>
        /// <value>The c full.</value>
        public Color[] CFull
        {
            get { return cFull; }
            set
            {
                cFull = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the c highlight.
        /// </summary>
        /// <value>The c highlight.</value>
        public Color[] CHighlight
        {
            get { return cHighlight; }
            set
            {
                cHighlight = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the page fill.
        /// </summary>
        /// <value>The page fill.</value>
        public Color[] PageFill
        {
            get => pageFill;
            set
            {
                pageFill = value;
                
            }
        }

        #endregion
        
    }
}
