// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="VTheme.cs" company="Zeroit Dev Technologies">
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

        //private Color[] vBackColors = new Color[]
        //{
        //    Color.FromArgb(18, 18, 18),
        //    Color.FromArgb(15, 15, 15),
        //    Color.FromArgb(25, 25, 25),
        //    Color.FromArgb(42, 42, 42),
        //    Color.Transparent,
        //    Color.Transparent,
        //    Color.FromArgb(5, 5, 5),
        //    Color.FromArgb(24, 24, 24),
        //    Color.FromArgb(15, 15, 15)
        //};

        //private Color[] vBorderColors = new Color[]
        //{
        //    Color.FromArgb(21, 21, 21),
        //    Color.Black,
        //    Color.FromArgb(255, Color.Black),
        //    Color.FromArgb(255, Color.Black),
        //    Color.FromArgb(35, 35, 35),
        //    Color.FromArgb(70, 70, 70)
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the v back colors.
        /// </summary>
        /// <value>The v back colors.</value>
        [Browsable(false)]
        public Color[] VBackColors
        {
            get => tabHorizontalInput.VBackColors;
            set
            {
                tabHorizontalInput.VBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the v border colors.
        /// </summary>
        /// <value>The v border colors.</value>
        [Browsable(false)]
        public Color[] VBorderColors
        {
            get => tabHorizontalInput.VBorderColors;
            set { tabHorizontalInput.VBorderColors = value; Invalidate(); }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// vs the tab control.
        /// </summary>
        private void VTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            ItemSize = new Size(77, 31);
            SizeMode = TabSizeMode.Fixed;
            Alignment = TabAlignment.Top;
        }

        #endregion

        #region Paint

        /// <summary>
        /// vs the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void VOnPaint(PaintEventArgs e)
        {
            Rectangle r2 = new Rectangle(2, 0, Width, 25);
            Rectangle r3 = new Rectangle(2, 0, Width, 25);
            G.Clear(VBackColors[0]);
            Rectangle ItemBounds = default(Rectangle);
            SolidBrush TextBrush = new SolidBrush(Color.Empty);
            SolidBrush TabBrush = new SolidBrush(VBackColors[1]);
            LinearGradientBrush vDrawGradientBrush2 = new LinearGradientBrush(r3, VBackColors[2], VBackColors[3], LinearGradientMode.ForwardDiagonal);
            G.FillRectangle(vDrawGradientBrush2, r2);
            for (int TabItemIndex = 0; TabItemIndex <= this.TabCount - 1; TabItemIndex++)
            {
                ItemBounds = this.GetTabRect(TabItemIndex);

                if (Convert.ToBoolean(TabItemIndex & 1))
                {
                    TabBrush.Color = VBackColors[4];
                }
                else
                {
                    TabBrush.Color = VBackColors[5];
                }
                G.FillRectangle(TabBrush, ItemBounds);

                Pen BorderPen = default(Pen);

                if (TabItemIndex == SelectedIndex)
                {
                    BorderPen = new Pen(VBorderColors[1], 1);
                }
                else
                {
                    BorderPen = new Pen(VBorderColors[1], 1);
                }
                Rectangle rPen = new Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 0, ItemBounds.Width - 4, ItemBounds.Height - 2);
                G.DrawRectangle(BorderPen, rPen);
                LinearGradientBrush DrawGradientBrushPen = new LinearGradientBrush(rPen, VBackColors[6], VBackColors[7], LinearGradientMode.Vertical);
                G.FillRectangle(DrawGradientBrushPen, rPen);
                BorderPen.Dispose();
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;

                if (this.SelectedIndex == TabItemIndex)
                {
                    TextBrush.Color = ForeColor;
                }
                else
                {
                    TextBrush.Color = Color.Gray;
                }
                G.DrawString(this.TabPages[TabItemIndex].Text, this.Font, TextBrush, new RectangleF(this.GetTabRect(TabItemIndex).Location.X + 3, GetTabRect(TabItemIndex).Location.Y + 0, GetTabRect(TabItemIndex).Width - 4, GetTabRect(TabItemIndex).Height - 2), sf);
                try
                {
                    this.TabPages[TabItemIndex].BackColor = VBackColors[8];

                }
                catch
                {
                }
            }
            try
            {
                foreach (TabPage Page in this.TabPages)
                {
                    Page.BorderStyle = BorderStyle.None;
                }
            }
            catch
            {
            }
            G.DrawRectangle(new Pen(new SolidBrush(VBorderColors[2])), 2, 0, Width - 3, Height - 3);
            G.DrawRectangle(new Pen(new SolidBrush(VBorderColors[0])), new Rectangle(3, 24, Width - 5, Height - 28));
            G.DrawLine(new Pen(new SolidBrush(VBorderColors[3])), 2, 32, Width - 2, 32);
            G.DrawLine(new Pen(new SolidBrush(VBorderColors[4])), 0, 0, 1, 1);
            G.DrawLine(new Pen(new SolidBrush(VBorderColors[5])), 2, Height - 2, Width + 1, Height - 2);

        }

        #endregion

    }

}

