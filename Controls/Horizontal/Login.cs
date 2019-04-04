// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Login.cs" company="Zeroit Dev Technologies">
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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.TabThematic.Controls
{

    /// <summary>
    /// Class ZeroitThematicHorizontalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicHorizontalTab
    {

        #region Private Fields

        //private Color loginTextColour = Color.FromArgb(255, 255, 255);
        //private Color loginBackTabColour = Color.FromArgb(54, 54, 54);
        //private Color loginBaseColour = Color.FromArgb(35, 35, 35);
        //private Color loginActiveColour = Color.FromArgb(47, 47, 47);
        //private Color loginBorderColour = Color.FromArgb(30, 30, 30);
        //private Color loginUpLineColour = Color.FromArgb(0, 160, 199);
        //private Color loginHorizLineColour = Color.FromArgb(23, 119, 151);
        /// <summary>
        /// The center sf
        /// </summary>
        private StringFormat CenterSF = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center

        };
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the color of the login border.
        /// </summary>
        /// <value>The color of the login border.</value>
        [Browsable(false)]
        public Color LoginBorderColor
        {
            get { return tabHorizontalInput.LoginBorderColor; }
            set { tabHorizontalInput.LoginBorderColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the login up line.
        /// </summary>
        /// <value>The color of the login up line.</value>
        [Browsable(false)]
        public Color LoginUpLineColor
        {
            get { return tabHorizontalInput.LoginUpLineColor; }
            set { tabHorizontalInput.LoginUpLineColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the login horizontal line.
        /// </summary>
        /// <value>The color of the login horizontal line.</value>
        [Browsable(false)]
        public Color LoginHorizontalLineColor
        {
            get { return tabHorizontalInput.LoginHorizontalLineColor; }
            set { tabHorizontalInput.LoginHorizontalLineColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the login text.
        /// </summary>
        /// <value>The color of the login text.</value>
        [Browsable(false)]
        public Color LoginTextColor
        {
            get { return tabHorizontalInput.LoginTextColor; }
            set { tabHorizontalInput.LoginTextColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the login back tab.
        /// </summary>
        /// <value>The color of the login back tab.</value>
        [Browsable(false)]
        public Color LoginBackTabColor
        {
            get { return tabHorizontalInput.LoginBackTabColor; }
            set { tabHorizontalInput.LoginBackTabColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the login base.
        /// </summary>
        /// <value>The color of the login base.</value>
        [Browsable(false)]
        public Color LoginBaseColor
        {
            get { return tabHorizontalInput.LoginBaseColor; }
            set { tabHorizontalInput.LoginBaseColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the login active.
        /// </summary>
        /// <value>The color of the login active.</value>
        [Browsable(false)]
        public Color LoginActiveColor
        {
            get { return tabHorizontalInput.LoginActiveColor; }
            set {
                tabHorizontalInput.LoginActiveColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Logs the in tab control.
        /// </summary>
        private void LogInTabControl()
        {
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Normal;
            ItemSize = new Size(240, 32);
            Alignment = TabAlignment.Top;
        }

        #endregion

        #region Paint


        /// <summary>
        /// Logins the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void LoginOnPaint(PaintEventArgs e)
        {
            G.Clear(LoginBaseColor);
            try
            {
                SelectedTab.BackColor = LoginBackTabColor;
            }
            catch
            {
            }
            //try
            //{
            //    SelectedTab.BorderStyle = BorderStyle.FixedSingle;
            //}
            //catch
            //{
            //}
            G.DrawRectangle(new Pen(LoginBorderColor, 2), new Rectangle(0, 0, Width, Height));
            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle Base = new Rectangle(new Point(GetTabRect(i).Location.X, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width, GetTabRect(i).Height));
                Rectangle BaseSize = new Rectangle(Base.Location, new Size(Base.Width, Base.Height));
                if (i == SelectedIndex)
                {
                    G.FillRectangle(new SolidBrush(LoginBaseColor), BaseSize);
                    G.FillRectangle(new SolidBrush(LoginActiveColor), new Rectangle(Base.X + 1, Base.Y - 3, Base.Width, Base.Height + 5));
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(LoginTextColor), new Rectangle(Base.X + 7, Base.Y, Base.Width - 3, Base.Height), CenterSF);
                    G.DrawLine(new Pen(LoginHorizontalLineColor, 2), new Point(Base.X + 3, Convert.ToInt32(Base.Height / 2 + 2)), new Point(Base.X + 9, Convert.ToInt32(Base.Height / 2 + 2)));
                    G.DrawLine(new Pen(LoginUpLineColor, 2), new Point(Base.X + 3, Base.Y - 3), new Point(Base.X + 3, Base.Height + 5));
                }
                else
                {
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(LoginTextColor), BaseSize, CenterSF);
                }
            }
            G.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        #endregion
        
    }

}

