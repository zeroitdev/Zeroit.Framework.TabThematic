// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ButterScotch.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        //private Color[] butForeColors = new Color[]
        //{
        //    Color.FromArgb(25, 23, 22),
        //    Color.FromArgb(255, 255, 255)
        //};

        //private Color[] butBackColors = new Color[]
        //{
        //    Color.FromArgb(100, 90, 80),
        //    Color.FromArgb(40, 37, 33),
        //    Color.FromArgb(100, 90, 80),
        //    Color.FromArgb(48, 43, 39),
        //    Color.FromArgb(57, 52, 46), Color.FromArgb(92, 83, 74)
        //};

        //private Color[] butBorderColors = new Color[]
        //{
        //    Color.Black,

        //};
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the but fore colors.
        /// </summary>
        /// <value>The but fore colors.</value>
        [Browsable(false)]
        public Color[] ButForeColors
        {
            get => tabHorizontalInput.ButForeColors;
            set
            {
                tabHorizontalInput.ButForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the but back colors.
        /// </summary>
        /// <value>The but back colors.</value>
        [Browsable(false)]
        public Color[] ButBackColors
        {
            get => tabHorizontalInput.ButBackColors;
            set { tabHorizontalInput.ButBackColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the but border colors.
        /// </summary>
        /// <value>The but border colors.</value>
        [Browsable(false)]
        public Color[] ButBorderColors
        {
            get => tabHorizontalInput.ButBorderColors;
            set { tabHorizontalInput.ButBorderColors = value; Invalidate(); }
        }
        #endregion

        #region Paint and Private Methods

        /// <summary>
        /// Butterscotches the tab control.
        /// </summary>
        private void ButterscotchTabControl()
        {
            //BackColor = Color.Transparent;
            DoubleBuffered = true;
            ItemSize = new Size(100, 35);
        }

        /// <summary>
        /// Butterscotches the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ButterscotchOnPaint(PaintEventArgs e)
        {
            Bitmap b = new Bitmap(Width, Height);
            G = Graphics.FromImage(b);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            try
            {
                SelectedTab.BackColor = ButBackColors[0];
            }
            catch
            {
            }
            G.Clear(BackColor);
            G.FillRectangle(new SolidBrush(ButBackColors[1]), rect);
            G.DrawRectangle(new Pen(ButBorderColors[0]), rect);

            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle textRectangle = new Rectangle(new Point(GetTabRect(i).Location.X + 3, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width - 7, GetTabRect(i).Height));
                if (i == SelectedIndex)
                {
                    Rectangle tabrect = new Rectangle(new Point(GetTabRect(i).Location.X + 1, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width - 2, GetTabRect(i).Height));
                    LinearGradientBrush buttonrect = new LinearGradientBrush(tabrect, ButBackColors[2], ButBackColors[3], 90);
                    G.FillPath(buttonrect, Draw.RoundRect(tabrect, 5));
                    G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(ButForeColors[0]), textRectangle, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Near
                    });
                }
                else
                {
                    Rectangle tabrect = new Rectangle(new Point(GetTabRect(i).Location.X + 1, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width - 2, GetTabRect(i).Height));
                    LinearGradientBrush buttonrect = new LinearGradientBrush(tabrect, ButBackColors[4], ButBackColors[5], 90);

                    G.FillPath(buttonrect, Draw.RoundRect(tabrect, 5));
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(ButForeColors[1]), textRectangle, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Near
                    });
                }
            }
            e.Graphics.DrawImage(b, new Point(0, 0));
            //G.Dispose();
            //b.Dispose();
        }

        #endregion
    }


}

