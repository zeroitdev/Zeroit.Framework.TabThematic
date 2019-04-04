// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Unique.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
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
        //private Color[] uniqueForeColors = new Color[]
        //{
        //    Color.FromArgb(255, 255, 255),
        //    Color.FromArgb(255, 255, 255)
        //};

        //private Color[] uniqueBackColors = new Color[]
        //{
        //    Color.FromArgb(72, 72, 72),
        //    Color.FromArgb(52, 52, 52),
        //    Color.FromArgb(56, 68, 85),
        //    Color.FromArgb(41, 42, 46)
        //};

        //private Color[] uniqueBorderColors = new Color[]
        //{
        //    Color.Black,
        //    Color.Black
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the unique fore colors.
        /// </summary>
        /// <value>The unique fore colors.</value>
        [Browsable(false)]
        public Color[] UniqueForeColors
        {
            get => tabHorizontalInput.UniqueForeColors;
            set
            {
                tabHorizontalInput.UniqueForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the unique back colors.
        /// </summary>
        /// <value>The unique back colors.</value>
        [Browsable(false)]
        public Color[] UniqueBackColors
        {
            get => tabHorizontalInput.UniqueBackColors;
            set { tabHorizontalInput.UniqueBackColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the unique border colors.
        /// </summary>
        /// <value>The unique border colors.</value>
        [Browsable(false)]
        public Color[] UniqueBorderColors
        {
            get => tabHorizontalInput.UniqueBorderColors;
            set { tabHorizontalInput.UniqueBorderColors = value; Invalidate(); }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Uniques the tab control.
        /// </summary>
        private void UniqueTabControl()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            ItemSize = new Size(80, 35);
            SizeMode = TabSizeMode.Fixed;
            Alignment = TabAlignment.Top;
        }
        #endregion

        #region Paint

        /// <summary>
        /// Uniques the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void UniqueOnPaint(PaintEventArgs e)
        {
            Bitmap b = new Bitmap(Width, Height);
            G = Graphics.FromImage(b);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            try
            {
                SelectedTab.BackColor = UniqueBackColors[0];
            }
            catch (Exception ex)
            {
            }
            G.FillRectangle(new SolidBrush(UniqueBackColors[1]), rect);
            G.DrawRectangle(new Pen(UniqueBorderColors[0]), rect);
            for (var i = 0; i < TabCount; i++)
            {
                Rectangle textRectangle = new Rectangle(new Point(GetTabRect(i).Location.X + 5, GetTabRect(i).Location.Y + 1), new Size(GetTabRect(i).Width, GetTabRect(i).Height - 5));
                if (i == SelectedIndex)
                {
                    Rectangle tabrect = new Rectangle(new Point(GetTabRect(i).Location.X + 3, GetTabRect(i).Location.Y + 3), new Size(GetTabRect(i).Width - 6, GetTabRect(i).Height - 9));
                    LinearGradientBrush buttonrect = new LinearGradientBrush(rect, UniqueBackColors[2], UniqueBackColors[3], 90);
                    G.FillPath(buttonrect, Draw.RoundRect(tabrect, 3));
                    G.DrawPath(new Pen(UniqueBorderColors[1]), Draw.RoundRect(tabrect, 3));
                    G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(UniqueForeColors[0]), textRectangle, new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near });
                }
                else
                {
                    G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), new SolidBrush(UniqueForeColors[0]), textRectangle, new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near });
                }
            }
            e.Graphics.DrawImage(b, new Point(0, 0));
            b.Dispose();
        }

        #endregion

    }

}

