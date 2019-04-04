// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Reactor.cs" company="Zeroit Dev Technologies">
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

        //private Color _TabBrColor = Color.White;
        ////private Color reactorControlBColor = Color.White;

        //private Color[] reactForeColors = new Color[]
        //{
        //    Color.White,
        //    Color.DimGray
        //};

        //private Color[] reactBackColors = new Color[]
        //{
        //    Color.FromArgb(50, Color.White),
        //    Color.FromArgb(25, Color.White),
        //    Color.FromArgb(10, 10, 10),
        //    Color.FromArgb(50, 50, 50),
        //    Color.Transparent,
        //    Color.Transparent,
        //    Color.FromArgb(32, 32, 32),
        //    Color.FromArgb(175, 219, 78, 0),
        //    Color.FromArgb(175, 229, 98, 0),
        //    Color.FromArgb(80, Color.White),
        //    Color.FromArgb(20, Color.White),
        //    Color.FromArgb(32, 32, 32)
        //};

        //private Color[] reactBorderColors = new Color[]
        //{
        //    Color.FromArgb(28, 28, 28),
        //    Color.Transparent,
        //    Color.FromArgb(10, 10, 10),
        //    Color.FromArgb(100, 230, 90, 0),
        //    Color.Transparent,
        //    Color.Black,
        //    Color.FromArgb(70, 70, 70),
        //    Color.FromArgb(45, 45, 45),
        //    Color.FromArgb(45, 45, 45),
        //    Color.FromArgb(45, 45, 45),
        //    Color.FromArgb(31, 31, 31),
        //    Color.FromArgb(10, 10, 10)
        //};

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the tab border.
        /// </summary>
        /// <value>The color of the tab border.</value>
        [Browsable(false)]
        public Color TabBorderColor
        {
            get { return tabHorizontalInput.TabBorderColor; }
            set
            {
                tabHorizontalInput.TabBorderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the react fore colors.
        /// </summary>
        /// <value>The react fore colors.</value>
        [Browsable(false)]
        public Color[] ReactForeColors
        {
            get => tabHorizontalInput.ReactForeColors;
            set
            {
                tabHorizontalInput.ReactForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the react back colors.
        /// </summary>
        /// <value>The react back colors.</value>
        [Browsable(false)]
        public Color[] ReactBackColors
        {
            get => tabHorizontalInput.ReactBackColors;
            set { tabHorizontalInput.ReactBackColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the react border colors.
        /// </summary>
        /// <value>The react border colors.</value>
        [Browsable(false)]
        public Color[] ReactBorderColors
        {
            get => tabHorizontalInput.ReactBorderColors;
            set { tabHorizontalInput.ReactBorderColors = value; Invalidate(); }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Reactors the tab control.
        /// </summary>
        private void ReactorTabControl()
        {

            SizeMode = TabSizeMode.Fixed;

        }

        #endregion

        #region Paint

        /// <summary>
        /// Reactors the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ReactorOnPaint(PaintEventArgs e)
        {

            Rectangle r2 = new Rectangle(0, 0, Width - 1, 25);
            Rectangle r3 = new Rectangle(0, 0, Width - 1, 25);
            Rectangle r4 = new Rectangle(2, 0, Width - 1, 13);
            Rectangle ItemBounds = new Rectangle();
            SolidBrush TextBrush = new SolidBrush(Color.Empty);
            SolidBrush TabBrush = new SolidBrush(Color.DimGray);
            LinearGradientBrush dgb2 = new LinearGradientBrush(r4, ReactBackColors[0], ReactBackColors[1], 90);

            G.Clear(ReactBackColors[6]);
            LinearGradientBrush DrawGradientBrush2 = new LinearGradientBrush(r3, ReactBackColors[2], ReactBackColors[3], 90);
            G.DrawRectangle(new Pen(new SolidBrush(ReactBorderColors[0])), new Rectangle(1, 1, Width - 3, Height - 3));

            G.FillRectangle(DrawGradientBrush2, r2);
            G.FillRectangle(dgb2, r4);

            for (int TabItemIndex = 0; TabItemIndex <= this.TabCount - 1; TabItemIndex++)
            {
                ItemBounds = this.GetTabRect(TabItemIndex);

                if (Convert.ToBoolean(TabItemIndex & 1))
                {
                    TabBrush.Color = ReactBackColors[4];
                }
                else
                {
                    TabBrush.Color = ReactBackColors[5];
                }
                G.FillRectangle(TabBrush, ItemBounds);
                Pen BorderPen = default(Pen);
                if (TabItemIndex == SelectedIndex)
                {
                    BorderPen = new Pen(ReactBorderColors[1], 1);
                    LinearGradientBrush dgb = new LinearGradientBrush(new Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 0, ItemBounds.Width - 8, ItemBounds.Height - 6), ReactBackColors[7], ReactBackColors[8], 90);
                    LinearGradientBrush gloss = new LinearGradientBrush(new Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 3, ItemBounds.Width - 8, ItemBounds.Height / 2 - 5), ReactBackColors[9], ReactBackColors[10], 90);
                    G.FillRectangle(dgb, new Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 0, ItemBounds.Width - 8, ItemBounds.Height - 6));
                    G.FillRectangle(gloss, new Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 3, ItemBounds.Width - 8, ItemBounds.Height / 2 - 4));
                    G.DrawRectangle(new Pen(new SolidBrush(ReactBorderColors[2])), new Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 0, ItemBounds.Width - 8, ItemBounds.Height - 6));
                    G.DrawRectangle(new Pen(new SolidBrush(ReactBorderColors[3])), new Rectangle(ItemBounds.Location.X + 4, ItemBounds.Location.Y + 0, ItemBounds.Width - 10, ItemBounds.Height - 8));
                    Rectangle r1 = new Rectangle(1, 1, Width - 1, 3);
                }
                else
                {
                    BorderPen = new Pen(ReactBorderColors[4], 1);
                }

                G.DrawRectangle(BorderPen, new Rectangle(ItemBounds.Location.X + 3, ItemBounds.Location.Y + 1, ItemBounds.Width - 8, ItemBounds.Height - 4));

                BorderPen.Dispose();

                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;

                if (this.SelectedIndex == TabItemIndex)
                {
                    TextBrush.Color = ReactForeColors[0];
                }
                else
                {

                    TextBrush.Color = ReactForeColors[1];
                }
                G.DrawString(this.TabPages[TabItemIndex].Text, this.Font, TextBrush, new RectangleF(this.GetTabRect(TabItemIndex).Location.X, this.GetTabRect(TabItemIndex).Location.Y + 2, 80, 15), sf);
                try
                {
                    this.TabPages[TabItemIndex].BackColor = ReactBackColors[11];
                }
                catch
                {
                }


                //G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(10, 10, 10))), 2, ItemSize.Height + 1, TabPages[TabItemIndex].Width + 6, TabPages[TabItemIndex].Height + 4);

            }
            //try
            //{
            //    foreach (TabPage tabpg in this.TabPages)
            //    {
            //        tabpg.BorderStyle = BorderStyle.None;
            //    }
            //}
            //catch
            //{
            //}

            G.DrawLine(new Pen(new SolidBrush(ReactBorderColors[11])), new Point(0, ItemSize.Height), new Point(Width - 2, ItemSize.Height));


            //G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(10, 10, 10))), 2, ItemSize.Height, Width - 2, 24);
            G.DrawRectangle(new Pen((ReactBorderColors[5])), new Rectangle(1, 1, Width - 3, Height - 3));
            G.DrawRectangle((new Pen(new SolidBrush(ReactBorderColors[6]))), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawLine(new Pen(new SolidBrush(ReactBorderColors[7])), 0, 0, Width, 0);
            G.DrawLine(new Pen(new SolidBrush(ReactBorderColors[8])), 0, 0, 0, Height);
            G.DrawLine(new Pen(new SolidBrush(ReactBorderColors[9])), Width - 1, 0, Width - 1, Height);
            G.DrawLine(new Pen(new SolidBrush(ReactBorderColors[10])), 2, 2, Width - 3, 2);
        }

        #endregion


    }



}

