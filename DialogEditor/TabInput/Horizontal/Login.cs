// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Login.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
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
        /// The login text colour
        /// </summary>
        private Color loginTextColour = Color.FromArgb(255, 255, 255);
        /// <summary>
        /// The login back tab colour
        /// </summary>
        private Color loginBackTabColour = Color.FromArgb(54, 54, 54);
        /// <summary>
        /// The login base colour
        /// </summary>
        private Color loginBaseColour = Color.FromArgb(35, 35, 35);
        /// <summary>
        /// The login active colour
        /// </summary>
        private Color loginActiveColour = Color.FromArgb(47, 47, 47);
        /// <summary>
        /// The login border colour
        /// </summary>
        private Color loginBorderColour = Color.FromArgb(30, 30, 30);
        /// <summary>
        /// The login up line colour
        /// </summary>
        private Color loginUpLineColour = Color.FromArgb(0, 160, 199);
        /// <summary>
        /// The login horiz line colour
        /// </summary>
        private Color loginHorizLineColour = Color.FromArgb(23, 119, 151);
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the color of the login border.
        /// </summary>
        /// <value>The color of the login border.</value>
        [Category("Colours")]
        public Color LoginBorderColor
        {
            get { return loginBorderColour; }
            set { loginBorderColour = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the login up line.
        /// </summary>
        /// <value>The color of the login up line.</value>
        [Category("Colours")]
        public Color LoginUpLineColor
        {
            get { return loginUpLineColour; }
            set { loginUpLineColour = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the login horizontal line.
        /// </summary>
        /// <value>The color of the login horizontal line.</value>
        [Category("Colours")]
        public Color LoginHorizontalLineColor
        {
            get { return loginHorizLineColour; }
            set { loginHorizLineColour = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the login text.
        /// </summary>
        /// <value>The color of the login text.</value>
        [Category("Colours")]
        public Color LoginTextColor
        {
            get { return loginTextColour; }
            set { loginTextColour = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the login back tab.
        /// </summary>
        /// <value>The color of the login back tab.</value>
        [Category("Colours")]
        public Color LoginBackTabColor
        {
            get { return loginBackTabColour; }
            set { loginBackTabColour = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the login base.
        /// </summary>
        /// <value>The color of the login base.</value>
        [Category("Colours")]
        public Color LoginBaseColor
        {
            get { return loginBaseColour; }
            set { loginBaseColour = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the login active.
        /// </summary>
        /// <value>The color of the login active.</value>
        [Category("Colours")]
        public Color LoginActiveColor
        {
            get { return loginActiveColour; }
            set { loginActiveColour = value;
                
            }
        }



        #endregion
        
    }

}

