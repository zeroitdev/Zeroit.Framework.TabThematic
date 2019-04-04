// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Aresio.cs" company="Zeroit Dev Technologies">
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
        //private Color[] aresioForeColors = new Color[]
        //{
        //    Color.FromArgb(255,255,255),
        //    Color.FromArgb(80, 80, 80)
        //};

        //private Color[] aresioBorderColors = new Color[]
        //{
        //    Color.FromArgb(90, Color.Gray),
        //    Color.FromArgb(150, 151, 153),
        //    Color.FromArgb(150, 151, 153)

        //};

        //private Color[] aresioBackColors = new Color[]
        //{
        //    Color.FromArgb(236, 237, 239),
        //    Color.FromArgb(10, Color.Black),
        //    Color.FromArgb(236, 237, 239),
        //    Color.FromArgb(236, 237, 239)
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the aresio fore colors.
        /// </summary>
        /// <value>The aresio fore colors.</value>
        [Browsable(false)]
        public Color[] AresioForeColors
        {
            get => tabHorizontalInput.AresioForeColors;
            set
            {
                tabHorizontalInput.AresioForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the aresio border colors.
        /// </summary>
        /// <value>The aresio border colors.</value>
        [Browsable(false)]
        public Color[] AresioBorderColors
        {
            get => tabHorizontalInput.AresioBorderColors;
            set { tabHorizontalInput.AresioBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the aresio back colors.
        /// </summary>
        /// <value>The aresio back colors.</value>
        [Browsable(false)]
        public Color[] AresioBackColors
        {
            get => tabHorizontalInput.AresioBackColors;
            set { tabHorizontalInput.AresioBackColors = value; Invalidate(); }
        }

        #endregion

        #region Private Methods and Overrides
        /// <summary>
        /// Initializes a new instance of the <see cref="AresioTabControl" /> class.
        /// </summary>
        private void AresioTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            Alignment = TabAlignment.Top;
            SizeMode = TabSizeMode.Normal;
            ItemSize = new Size(77, 31);

        }
        /// <summary>
        /// This member overrides <see cref="M:System.Windows.Forms.Control.CreateHandle" />.
        /// </summary>
        private void AresioCreateHandle()
        {

            //SizeMode = TabSizeMode.Normal;
            //ItemSize = new Size(77, 31);
        }


        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        private void AresioOnPaint(PaintEventArgs e)
        {

            Rectangle ItemBounds = default(Rectangle);
            SolidBrush TextBrush = new SolidBrush(Color.Empty);
            int SOFF = 0;
            //G.Clear(Color.FromArgb(236, 237, 239));

            G.Clear(Parent.BackColor);

            for (int TabItemIndex = 0; TabItemIndex <= this.TabCount - 1; TabItemIndex++)
            {
                ItemBounds = this.GetTabRect(TabItemIndex);

                if (!(TabItemIndex == SelectedIndex))
                {
                    SOFF = 2;

                    G.FillPath(new SolidBrush(AresioBackColors[1]), DesignFunctions.RoundRect(new Rectangle(new Point(ItemBounds.X, ItemBounds.Y + SOFF), new Size(ItemBounds.Width, ItemBounds.Height)), 2));
                    G.DrawPath(new Pen(AresioBorderColors[0]), DesignFunctions.RoundRect(new Rectangle(new Point(ItemBounds.X, ItemBounds.Y + SOFF), new Size(ItemBounds.Width, ItemBounds.Height)), 2));

                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    TextBrush.Color = AresioForeColors[0];
                    try
                    {
                        G.DrawString(TabPages[TabItemIndex].Text, new Font(Font.Name, Font.Size - 1), TextBrush, new Rectangle(GetTabRect(TabItemIndex).Location, GetTabRect(TabItemIndex).Size), sf);
                        TabPages[TabItemIndex].BackColor = AresioBackColors[0];
                    }
                    catch
                    {
                    }

                }
            }

            G.FillPath(new SolidBrush(AresioBackColors[2]), DesignFunctions.RoundRect(0, ItemSize.Height - 1, Width - 1, Height - ItemSize.Height - 1, 2));
            G.DrawPath(new Pen(AresioBorderColors[1]), DesignFunctions.RoundRect(0, ItemSize.Height - 1, Width - 1, Height - ItemSize.Height - 1, 2));

            for (int TabItemIndex = 0; TabItemIndex <= this.TabCount - 1; TabItemIndex++)
            {
                ItemBounds = this.GetTabRect(TabItemIndex);

                if (TabItemIndex == SelectedIndex)
                {
                    G.FillPath(new SolidBrush(AresioBackColors[2]), DesignFunctions.RoundRect(new Rectangle(new Point(ItemBounds.X - 2, ItemBounds.Y), new Size(ItemBounds.Width + 3, ItemBounds.Height - 2)), 2));
                    G.DrawPath(new Pen(AresioBorderColors[2]), DesignFunctions.RoundRect(new Rectangle(new Point(ItemBounds.X - 2, ItemBounds.Y), new Size(ItemBounds.Width + 2, ItemBounds.Height - 2)), 2));

                    G.FillRectangle(new SolidBrush(AresioBackColors[3]), new Rectangle(new Point(ItemBounds.X - 1, ItemBounds.Y + 1), new Size(ItemBounds.Width + 1, ItemBounds.Height)));
                    SOFF = 0;

                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    TextBrush.Color = AresioForeColors[1];
                    try
                    {
                        G.DrawString(TabPages[TabItemIndex].Text, Font, TextBrush, new Rectangle(new Point(Convert.ToInt32(GetTabRect(TabItemIndex).Location), SOFF), GetTabRect(TabItemIndex).Size), sf);
                        TabPages[TabItemIndex].BackColor = AresioBackColors[0];


                    }
                    catch
                    {
                    }

                }

            }
        }

        #endregion

    }

}
