// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DotnetBar.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
    /// Class ZeroitThematicVerticalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicVerticalTab
    {

        #region Private Fields
        //private Color[] dotnetBarBackColors = new Color[]
        //{
        //    Color.White,
        //    Color.White,
        //    Color.FromArgb(246, 248, 252),
        //    Color.Black, Color.Black,
        //    Color.White,
        //    Color.FromArgb(246, 248, 252)
        //};

        //private Color[] dotnetBarBorderColors = new Color[]
        //{
        //    Color.FromArgb(170, 187, 204),
        //    Color.FromArgb(170, 187, 204),
        //    Color.FromArgb(170, 187, 204),
        //    Color.FromArgb(200, 200, 250),
        //    Color.FromArgb(200, 200, 250),
        //    Color.FromArgb(170, 187, 204)

        //};

        //private Color[] dotnetBarForeColors = new Color[]
        //{
        //    Color.Black,
        //    Color.DimGray
        //};

        //private Color[] dotnetBarColorBlend = new Color[]
        //{
        //    Color.FromArgb(232, 232, 240),
        //    Color.FromArgb(232, 232, 240),
        //    Color.FromArgb(232, 232, 240)
        //};
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the dotnet bar back colors.
        /// </summary>
        /// <value>The dotnet bar back colors.</value>
        [Browsable(false)]
        public Color[] DotnetBarBackColors
        {
            get => tabVerticalInput.DotnetBarBackColors;
            set
            {
                tabVerticalInput.DotnetBarBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dotnet bar border colors.
        /// </summary>
        /// <value>The dotnet bar border colors.</value>
        [Browsable(false)]
        public Color[] DotnetBarBorderColors
        {
            get => tabVerticalInput.DotnetBarBorderColors;
            set
            {
                tabVerticalInput.DotnetBarBorderColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dotnet bar fore colors.
        /// </summary>
        /// <value>The dotnet bar fore colors.</value>
        [Browsable(false)]
        public Color[] DotnetBarForeColors
        {
            get => tabVerticalInput.DotnetBarForeColors;
            set
            {
                tabVerticalInput.DotnetBarForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dotnet bar color blend.
        /// </summary>
        /// <value>The dotnet bar color blend.</value>
        [Browsable(false)]
        public Color[] DotnetBarColorBlend
        {
            get { return tabVerticalInput.DotnetBarColorBlend; }
            set
            {
                tabVerticalInput.DotnetBarColorBlend = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Dots the net bar tabcontrol.
        /// </summary>
        public void DotNetBarTabcontrol()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(44, 136);
            Alignment = TabAlignment.Left;
        }

        #endregion

        #region Paint
        /// <summary>
        /// Dotnets the bar on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void DotnetBarOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            try
            {
                SelectedTab.BackColor = DotnetBarBackColors[0];
            }
            catch
            {
            }
            G.Clear(DotnetBarBackColors[1]);
            G.FillRectangle(new SolidBrush(DotnetBarBackColors[2]), new Rectangle(0, 0, ItemSize.Height + 4, Height));
            G.DrawLine(new Pen(DotnetBarBorderColors[0]), new Point(ItemSize.Height + 3, 0), new Point(ItemSize.Height + 3, 999));

            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (i == SelectedIndex)
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    ColorBlend myBlend = new ColorBlend();
                    myBlend.Colors = new Color[] {
                        DotnetBarColorBlend[0],
                        DotnetBarColorBlend[1],
                        DotnetBarColorBlend[2],
                };
                    myBlend.Positions = new float[] {
                    0f,
                    0.5f,
                    1f
                };
                    LinearGradientBrush lgBrush = new LinearGradientBrush(x2, DotnetBarBackColors[3], DotnetBarBackColors[4], 90f);
                    lgBrush.InterpolationColors = myBlend;
                    G.FillRectangle(lgBrush, x2);
                    G.DrawRectangle(new Pen(DotnetBarBorderColors[1]), x2);

                    Point[] p = {
                    new Point(ItemSize.Height - 3, GetTabRect(i).Location.Y + 20),
                    new Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 14),
                    new Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 27)
                };
                    G.FillPolygon(new SolidBrush(DotnetBarBackColors[5]), p);
                    G.DrawPolygon(new Pen(DotnetBarBorderColors[2]), p);

                    if (ImageList != null)
                    {
                        try
                        {

                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                                G.DrawString("  " + TabPages[i].Text, Font, new SolidBrush(DotnetBarForeColors[0]), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotnetBarForeColors[0]), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotnetBarForeColors[0]), x2, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Center
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotnetBarForeColors[0]), x2, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }

                    G.DrawLine(new Pen(DotnetBarBorderColors[3]), new Point(x2.Location.X - 1, x2.Location.Y - 1), new Point(x2.Location.X, x2.Location.Y));
                    G.DrawLine(new Pen(DotnetBarBorderColors[4]), new Point(x2.Location.X - 1, x2.Bottom - 1), new Point(x2.Location.X, x2.Bottom));
                }
                else
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    G.FillRectangle(new SolidBrush(DotnetBarBackColors[6]), x2);
                    G.DrawLine(new Pen(DotnetBarBorderColors[5]), new Point(x2.Right, x2.Top), new Point(x2.Right, x2.Bottom));
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                                G.DrawString("  " + TabPages[i].Text, Font, new SolidBrush(DotnetBarForeColors[1]), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, Font, new SolidBrush(DotnetBarForeColors[1]), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text, Font, new SolidBrush(DotnetBarForeColors[1]), x2, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Center
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(DotnetBarForeColors[1]), x2, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }
                }
            }


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }

        #endregion

    }
}
