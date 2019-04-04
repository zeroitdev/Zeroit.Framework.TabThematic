// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MetroDisk.cs" company="Zeroit Dev Technologies">
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
    /// Class TabHorizontalInput.
    /// </summary>
    public partial class TabHorizontalInput
    {

        #region Private Fields

        //private int metroDiskW;
        //private int metroDiskH;
        //private bool _Theme;

        /// <summary>
        /// The metro disk base color
        /// </summary>
        private Color metroDiskBaseColor = Color.FromArgb(45, 47, 49);
        /// <summary>
        /// The metro active color
        /// </summary>
        private Color metroActiveColor = Color.FromArgb(35, 168, 109);
        /// <summary>
        /// The metro back color
        /// </summary>
        private Color metroBackColor = Color.FromArgb(22, 22, 22);
        /// <summary>
        /// The metro inactive
        /// </summary>
        private Color metroInactive = Color.DimGray;
        /// <summary>
        /// The metro active
        /// </summary>
        private Color metroActive = Color.Silver;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the color of the metro disk base.
        /// </summary>
        /// <value>The color of the metro disk base.</value>
        public Color MetroDiskBaseColor
        {
            get { return metroDiskBaseColor; }
            set
            {
                metroDiskBaseColor = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color of the metro active.
        /// </summary>
        /// <value>The color of the metro active.</value>
        public Color MetroActiveColor
        {
            get { return metroActiveColor; }
            set { metroActiveColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the metro back.
        /// </summary>
        /// <value>The color of the metro back.</value>
        public Color MetroBackColor
        {
            get { return metroBackColor; }
            set
            {
                metroBackColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the metro inactive.
        /// </summary>
        /// <value>The metro inactive.</value>
        public Color MetroInactive
        {
            get { return metroInactive; }
            set { metroInactive = value;  }
        }

        /// <summary>
        /// Gets or sets the metro active.
        /// </summary>
        /// <value>The metro active.</value>
        public Color MetroActive
        {
            get { return metroActive; }
            set { metroActive = value;  }
        }

        #endregion
        

    }

}

