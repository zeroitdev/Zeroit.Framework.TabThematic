// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Simpla.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Zeroit.Framework.TabThematic.ThemeManagers;

namespace Zeroit.Framework.TabThematic.Controls
{

    /// <summary>
    /// Class ZeroitThematicHorizontalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicHorizontalTab
    {

        #region Private Fields
        //private Color mainBackground = Color.FromArgb(34, 34, 34);
        //private Color topBackground = Color.FromArgb(34, 34, 34);
        //private Color activeTabColor = Color.FromArgb(20, 20, 20);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the main background.
        /// </summary>
        /// <value>The main background.</value>
        [Browsable(false)]
        public Color MainBackground
        {
            get => tabHorizontalInput.MainBackground;
            set
            {
                tabHorizontalInput.MainBackground = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the top background.
        /// </summary>
        /// <value>The top background.</value>
        [Browsable(false)]
        public Color TopBackground
        {
            get => tabHorizontalInput.TopBackground;
            set
            {
                tabHorizontalInput.TopBackground = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the active tab.
        /// </summary>
        /// <value>The color of the active tab.</value>
        [Browsable(false)]
        public Color ActiveTabColor
        {
            get => tabHorizontalInput.ActiveTabColor;
            set
            {
                tabHorizontalInput.ActiveTabColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Simplas the tab control.
        /// </summary>
        private void SimplaTabControl()
        {
            DoubleBuffered = true;
        }

        #endregion

        #region Paint
        /// <summary>
        /// Simplas the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void SimplaOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            try
            {
                SelectedTab.BackColor = MainBackground;
            }
            catch
            {
            }

            G.Clear(TopBackground);

            for (int i = 0; i <= TabPages.Count - 1; i++)
            {
                Rectangle TabRect = new Rectangle(GetTabRect(i).X + 3, GetTabRect(i).Y, GetTabRect(i).Width - 5, GetTabRect(i).Height);
                G.FillRectangle(new SolidBrush(MainBackground), TabRect);
                G.DrawString(TabPages[i].Text, Font, new SolidBrush(ForeColor), TabRect, new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                });
            }

            G.FillRectangle(new SolidBrush(MainBackground), 0, ItemSize.Height, Width, Height);

            if (!(SelectedIndex == -1))
            {
                Rectangle TabRect = new Rectangle(GetTabRect(SelectedIndex).X + 3, GetTabRect(SelectedIndex).Y, GetTabRect(SelectedIndex).Width - 5, GetTabRect(SelectedIndex).Height);
                G.FillPath(new SolidBrush(ActiveTabColor), Draw.RoundRect(TabRect, 4));
                G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(20, 20, 20))), Draw.RoundRect(TabRect, 4));
                G.DrawString(TabPages[SelectedIndex].Text, Font, new SolidBrush(ForeColor), TabRect, new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }

            e.Graphics.DrawImage(B, new Point(0, 0));
            //G.Dispose();
            //B.Dispose();
        }

        #endregion

    }

}

