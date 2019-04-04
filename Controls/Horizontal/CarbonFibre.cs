// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CarbonFibre.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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

        //// BackColor
        //Color carbonBack = Color.FromArgb(22, 22, 22);
        //// ' OUter Black
        //Color carbonOuterBorder = Color.FromArgb(6, 6, 6);
        //// ' Inner Border
        //Color carbonInnerBorder = Color.FromArgb(32, 32, 32);


        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the carbon back.
        /// </summary>
        /// <value>The carbon back.</value>
        [Browsable(false)]
        public Color CarbonBack
        {
            get => tabHorizontalInput.CarbonBack;
            set
            {
                tabHorizontalInput.CarbonBack = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the carbon outer border.
        /// </summary>
        /// <value>The carbon outer border.</value>
        [Browsable(false)]
        public Color CarbonOuterBorder
        {
            get => tabHorizontalInput.CarbonOuterBorder;
            set { tabHorizontalInput.CarbonOuterBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the carbon inner border.
        /// </summary>
        /// <value>The carbon inner border.</value>
        [Browsable(false)]
        public Color CarbonInnerBorder
        {
            get => tabHorizontalInput.CarbonInnerBorder;
            set { tabHorizontalInput.CarbonInnerBorder = value; Invalidate(); }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Carbons the fiber tab control.
        /// </summary>
        private void CarbonFiberTabControl()
        {
            DoubleBuffered = true;
            Alignment = TabAlignment.Top;
        }

        #endregion

        #region "Color Of Control"

        /// <summary>
        /// Carbons the fibre on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void CarbonFibreOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            try
            {
                SelectedTab.BackColor = CarbonBack;
            }
            catch
            {
            }
            G.Clear(Parent.BackColor);
            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (!(i == SelectedIndex))
                {
                    Rectangle x2 = new Rectangle(GetTabRect(i).X - 1, GetTabRect(i).Y + 1, GetTabRect(i).Width + 2, GetTabRect(i).Height);
                    LinearGradientBrush G1 = new LinearGradientBrush(new Point(x2.X, x2.Y), new Point(x2.X, x2.Y + x2.Height), Color.FromArgb(22, 22, 22), Color.FromArgb(22, 22, 22));
                    G.FillRectangle(G1, x2);
                    G1.Dispose();
                    G.DrawRectangle(new Pen(CarbonInnerBorder), x2);
                    G.DrawRectangle(new Pen(CarbonOuterBorder), new Rectangle(x2.X + 1, x2.Y + 1, x2.Width - 2, x2.Height));
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(ForeColor), x2, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });
                    //
                }
            }

            G.FillRectangle(new SolidBrush(CarbonBack), 0, ItemSize.Height, Width, Height);
            G.DrawRectangle(new Pen(CarbonOuterBorder), 0, ItemSize.Height, Width - 1, Height - ItemSize.Height - 1);
            G.DrawRectangle(new Pen(CarbonInnerBorder), 1, ItemSize.Height + 1, Width - 3, Height - ItemSize.Height - 3);
            if (!(SelectedIndex == -1))
            {
                Rectangle x1 = new Rectangle(GetTabRect(SelectedIndex).X - 2, GetTabRect(SelectedIndex).Y, GetTabRect(SelectedIndex).Width + 3, GetTabRect(SelectedIndex).Height);
                G.FillRectangle(new SolidBrush(CarbonBack), new Rectangle(x1.X + 2, x1.Y + 2, x1.Width - 2, x1.Height));
                G.DrawLine(new Pen(CarbonOuterBorder), new Point(x1.X, x1.Y + x1.Height - 2), new Point(x1.X, x1.Y));
                G.DrawLine(new Pen(CarbonOuterBorder), new Point(x1.X, x1.Y), new Point(x1.X + x1.Width, x1.Y));
                G.DrawLine(new Pen(CarbonOuterBorder), new Point(x1.X + x1.Width, x1.Y), new Point(x1.X + x1.Width, x1.Y + x1.Height - 2));

                G.DrawLine(new Pen(CarbonInnerBorder), new Point(x1.X + 1, x1.Y + x1.Height - 1), new Point(x1.X + 1, x1.Y + 1));
                G.DrawLine(new Pen(CarbonInnerBorder), new Point(x1.X + 1, x1.Y + 1), new Point(x1.X + x1.Width - 1, x1.Y + 1));
                G.DrawLine(new Pen(CarbonInnerBorder), new Point(x1.X + x1.Width - 1, x1.Y + 1), new Point(x1.X + x1.Width - 1, x1.Y + x1.Height - 1));

                G.DrawString(TabPages[SelectedIndex].Text, Font, new SolidBrush(ForeColor), x1, new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                });
            }

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();

        }
        
        #endregion

    }

}

