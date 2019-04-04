// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MetroDisk.cs" company="Zeroit Dev Technologies">
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

