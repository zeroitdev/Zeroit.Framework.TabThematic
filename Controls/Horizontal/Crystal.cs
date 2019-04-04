// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Crystal.cs" company="Zeroit Dev Technologies">
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

        //private Color _BG;

        #region Private Fields
        //private Color[] crystalBackColors = new Color[]
        //{
        //    Color.FromArgb(230, 230, 230),
        //    Color.FromArgb(10, 0, 0, 0), Color.FromArgb(230, 230, 230),
        //    Color.FromArgb(10, Color.Black), Color.Transparent,
        //    Color.FromArgb(215, 215, 215), Color.FromArgb(230, 230, 230)
        //};

        //private Color[] crystalBorderColors = new Color[]
        //{
        //    Color.FromArgb(170, 170, 170),
        //    Color.FromArgb(170, 170, 170),
        //    Color.FromArgb(170, 170, 170),
        //    Color.FromArgb(170, 170, 170),
        //    Color.FromArgb(170, 170, 170)
        //};

        //private Color[] crystalForeColors = new Color[]
        //{
        //    Color.Black,
        //    Color.Black
        //};

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the crystal back colors.
        /// </summary>
        /// <value>The crystal back colors.</value>
        [Browsable(false)]
        public Color[] CrystalBackColors
        {
            get => tabHorizontalInput.CrystalBackColors;
            set
            {
                tabHorizontalInput.CrystalBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the crystal border colors.
        /// </summary>
        /// <value>The crystal border colors.</value>
        [Browsable(false)]
        public Color[] CrystalBorderColors
        {
            get => tabHorizontalInput.CrystalBorderColors;
            set { tabHorizontalInput.CrystalBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the crystal fore colors.
        /// </summary>
        /// <value>The crystal fore colors.</value>
        [Browsable(false)]
        public Color[] CrystalForeColors
        {
            get => tabHorizontalInput.CrystalForeColors;
            set { tabHorizontalInput.CrystalForeColors = value; Invalidate(); }
        }

        #endregion

        #region Paint and Methods
        /// <summary>
        /// Crystals the clear tab control.
        /// </summary>
        private void CrystalClearTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            DoubleBuffered = true;
            Alignment = TabAlignment.Top;

        }


        /// <summary>
        /// Crystals the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void CrystalOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            try
            {
                SelectedTab.BackColor = CrystalBackColors[0];
            }
            catch
            {
            }
            G.Clear(Parent.BackColor);
            //G.DrawRectangle(new Pen(Color.FromArgb(170, 170, 170)), new Rectangle(0, 21, Width - 1, Height - 22));
            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (i == SelectedIndex)
                {
                    Rectangle x2 = new Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y, GetTabRect(i).Width, GetTabRect(i).Height - 2);
                    Rectangle x3 = new Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y, GetTabRect(i).Width, GetTabRect(i).Height - 1);
                    Rectangle x4 = new Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y, GetTabRect(i).Width, GetTabRect(i).Height);
                    LinearGradientBrush G1 = new LinearGradientBrush(x3, CrystalBackColors[1], CrystalBackColors[2], 90f);
                    HatchBrush HB = new HatchBrush(HatchStyle.LightDownwardDiagonal, CrystalBackColors[3], CrystalBackColors[4]);

                    G.FillRectangle(HB, x3);
                    HB.Dispose();
                    G.FillRectangle(G1, x3);
                    G1.Dispose();
                    G.DrawLine(new Pen(CrystalBorderColors[0]), x2.Location, new Point(x2.Location.X, x2.Location.Y + x2.Height));
                    G.DrawLine(new Pen(CrystalBorderColors[1]), new Point(x2.Location.X + x2.Width, x2.Location.Y), new Point(x2.Location.X + x2.Width, x2.Location.Y + x2.Height));
                    G.DrawLine(new Pen(CrystalBorderColors[2]), new Point(x2.Location.X, x2.Location.Y), new Point(x2.Location.X + x2.Width, x2.Location.Y));
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(CrystalForeColors[0]), x4, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });
                }
                else
                {
                    Rectangle x2 = new Rectangle(GetTabRect(i).X - 2, GetTabRect(i).Y + 3, GetTabRect(i).Width, GetTabRect(i).Height - 5);
                    LinearGradientBrush G1 = new LinearGradientBrush(x2, CrystalBackColors[5], CrystalBackColors[6], -90f);
                    G.FillRectangle(G1, x2);
                    G1.Dispose();
                    G.DrawRectangle(new Pen(CrystalBorderColors[3]), x2);
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(CrystalForeColors[1]), x2, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });
                }

                G.DrawRectangle(new Pen(new SolidBrush(CrystalBorderColors[4])),
                    new Rectangle(0, ItemSize.Height + 1, TabPages[i].Width + 6, TabPages[i].Height + 4));

            }

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

        #endregion


    }

}

