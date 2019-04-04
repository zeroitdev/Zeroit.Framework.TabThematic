// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="iTab.cs" company="Zeroit Dev Technologies">
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

        //private Color[] iTabBackColors = new Color[]
        //{
        //    Color.FromArgb(45, 45, 45),
        //    Color.FromArgb(10, 0, 0, 0),
        //    Color.FromArgb(35, 35, 35),
        //    Color.FromArgb(10, Color.Black),
        //    Color.Transparent,
        //    Color.FromArgb(30, 30, 30),
        //    Color.FromArgb(35, 35, 35)
        //};

        //private Color[] iTabBorderColors = new Color[]
        //{
        //    Color.FromArgb(10, 10, 10),
        //    Color.FromArgb(10, 10, 10),
        //    Color.FromArgb(10, 10, 10),
        //    Color.FromArgb(15, 15, 15),
        //    Color.Black

        //};

        //private Color[] iTabForeColors = new Color[]
        //{
        //    Color.DeepSkyBlue,
        //    Color.FromArgb(75, 75, 75)
        //};

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the i tab back colors.
        /// </summary>
        /// <value>The i tab back colors.</value>
        [Browsable(false)]
        public Color[] ITabBackColors
        {
            get => tabHorizontalInput.ITabBackColors;
            set
            {
                tabHorizontalInput.ITabBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the i tab border colors.
        /// </summary>
        /// <value>The i tab border colors.</value>
        [Browsable(false)]
        public Color[] ITabBorderColors
        {
            get => tabHorizontalInput.ITabBorderColors;
            set { tabHorizontalInput.ITabBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the i tab fore colors.
        /// </summary>
        /// <value>The i tab fore colors.</value>
        [Browsable(false)]
        public Color[] ITabForeColors
        {
            get => tabHorizontalInput.ITabForeColors;
            set { tabHorizontalInput.ITabForeColors = value; Invalidate(); }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// is the tab control.
        /// </summary>
        private void iTabControl()
        {
            DoubleBuffered = true;
            Alignment = TabAlignment.Top;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(120, 40);

        }

        #endregion

        #region Paint

        /// <summary>
        /// is the tab on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void iTabOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            try
            {
                SelectedTab.BackColor = ITabBackColors[0];
            }
            catch
            {
            }

            G.Clear(Parent.BackColor);

            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (i == SelectedIndex)
                {
                    Rectangle x2 = new Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y, GetTabRect(i).Width, GetTabRect(i).Height - 2);
                    Rectangle x3 = new Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y, GetTabRect(i).Width, GetTabRect(i).Height - 1);
                    Rectangle x4 = new Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y, GetTabRect(i).Width, GetTabRect(i).Height);
                    LinearGradientBrush G1 = new LinearGradientBrush(x3, ITabBackColors[1], ITabBackColors[2], 90f);
                    HatchBrush HB = new HatchBrush(HatchStyle.LightDownwardDiagonal, ITabBackColors[3], ITabBackColors[4]);

                    G.FillRectangle(HB, x3);
                    HB.Dispose();
                    G.FillRectangle(G1, x3);
                    G1.Dispose();
                    G.DrawLine(new Pen(ITabBorderColors[0]), x2.Location, new Point(x2.Location.X, x2.Location.Y + x2.Height));
                    G.DrawLine(new Pen(ITabBorderColors[1]), new Point(x2.Location.X + x2.Width, x2.Location.Y), new Point(x2.Location.X + x2.Width, x2.Location.Y + x2.Height));
                    G.DrawLine(new Pen(ITabBorderColors[2]), new Point(x2.Location.X, x2.Location.Y), new Point(x2.Location.X + x2.Width, x2.Location.Y));
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(ITabForeColors[0]), x4, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });
                }
                else
                {
                    Rectangle x2 = new Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y + 3, GetTabRect(i).Width, GetTabRect(i).Height - 5);
                    LinearGradientBrush G1 = new LinearGradientBrush(x2, ITabBackColors[5], ITabBackColors[6], -90f);
                    G.FillRectangle(G1, x2);
                    G1.Dispose();
                    G.DrawRectangle(new Pen(ITabBorderColors[3]), x2);
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(ITabForeColors[1]), x2, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });
                }

                //G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(10, 10, 10))),
                //    new Rectangle(0, ItemSize.Height + 1, TabPages[i].Width + 6, TabPages[i].Height + 4));

            }

            //G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(10, 10, 10))),
            //    new Rectangle(0, 38, Width - 1, Height - 39));


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.DrawRectangle(new Pen(ITabBorderColors[4]), new Rectangle(0, 0, Width - 1, Height - 1));
            //G.Dispose();
            //B.Dispose();
        }

        #endregion

    }
}
