// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Meph.cs" company="Zeroit Dev Technologies">
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
    /// Class ZeroitThematicVerticalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicVerticalTab
    {
        #region Private Fields
        //private Color[] mephBackColors = new Color[]
        //{
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(50, 50, 50),
        //    Color.Black, Color.Black,
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(50, 50, 50)
        //};

        //private Color[] mephBorderColors = new Color[]
        //{
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(20, 20, 20),
        //};

        //private Color[] mephForeColors = new Color[]
        //{
        //    Color.White,
        //    Color.FromArgb(210, 220, 230)
        //};

        //private Color[] mephColorBlend = new Color[]
        //{
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(50, 50, 50)
        //};

        //private Color[] cFull = new Color[]
        //{
        //    Color.FromArgb(20, 20, 20),
        //    Color.FromArgb(40, 40, 40),
        //    Color.FromArgb(45, 45, 45),
        //    Color.FromArgb(46, 46, 46),
        //    Color.FromArgb(47, 47, 47),
        //    Color.FromArgb(48, 48, 48),
        //    Color.FromArgb(49, 49, 49),
        //    Color.FromArgb(50, 50, 50)
        //};

        //private Color[] cHighlight = new Color[]
        //{
        //    Color.FromArgb(20, 20, 20),
        //    Color.FromArgb(40, 40, 40),
        //    Color.FromArgb(45, 45, 45),
        //    Color.FromArgb(46, 46, 46),
        //    Color.FromArgb(47, 47, 47),
        //    Color.FromArgb(48, 48, 48),
        //    Color.FromArgb(49, 49, 49),
        //    Color.FromArgb(50, 50, 50)
        //};

        //private Color[] pageFill = new Color[]
        //{
        //    Color.FromArgb(20, 20, 20),
        //    Color.FromArgb(40, 40, 40),
        //    Color.FromArgb(45, 45, 45),
        //    Color.FromArgb(46, 46, 46),
        //    Color.FromArgb(47, 47, 47),
        //    Color.FromArgb(48, 48, 48),
        //    Color.FromArgb(49, 49, 49),
        //    Color.FromArgb(50, 50, 50)
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the meph back colors.
        /// </summary>
        /// <value>The meph back colors.</value>
        [Browsable(false)]
        public Color[] MephBackColors
        {
            get => tabVerticalInput.MephBackColors;
            set
            {
                tabVerticalInput.MephBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the meph border colors.
        /// </summary>
        /// <value>The meph border colors.</value>
        [Browsable(false)]
        public Color[] MephBorderColors
        {
            get => tabVerticalInput.MephBorderColors;
            set { tabVerticalInput.MephBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the meph fore colors.
        /// </summary>
        /// <value>The meph fore colors.</value>
        [Browsable(false)]
        public Color[] MephForeColors
        {
            get => tabVerticalInput.MephForeColors;
            set { tabVerticalInput.MephForeColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the meph color blend.
        /// </summary>
        /// <value>The meph color blend.</value>
        [Browsable(false)]
        public Color[] MephColorBlend
        {
            get { return tabVerticalInput.MephColorBlend; }
            set
            {
                tabVerticalInput.MephColorBlend = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c full.
        /// </summary>
        /// <value>The c full.</value>
        [Browsable(false)]
        public Color[] CFull
        {
            get { return tabVerticalInput.CFull; }
            set
            {
                tabVerticalInput.CFull = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c highlight.
        /// </summary>
        /// <value>The c highlight.</value>
        [Browsable(false)]
        public Color[] CHighlight
        {
            get { return tabVerticalInput.CHighlight; }
            set
            {
                tabVerticalInput.CHighlight = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the page fill.
        /// </summary>
        /// <value>The page fill.</value>
        [Browsable(false)]
        public Color[] PageFill
        {
            get => tabVerticalInput.PageFill;
            set
            {
                tabVerticalInput.PageFill = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Mephes the tabcontrol.
        /// </summary>
        private void MephTabcontrol()
        {
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(35, 85);
            Alignment = TabAlignment.Left;
        }

        #endregion

        #region Paint
        /// <summary>
        /// Mephes the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void MephOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Font FF = new Font("Verdana", 8, FontStyle.Regular);
            try
            {
                SelectedTab.BackColor = MephBackColors[0];
            }
            catch
            {
            }
            G.Clear(Parent.BackColor);

            G.FillRectangle(new SolidBrush(MephBackColors[1]), new Rectangle(0, 0, ItemSize.Height + 3, Height - 1));
            //Full Tab Background

            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (i == SelectedIndex)
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    ColorBlend myBlend = new ColorBlend();
                    myBlend.Colors = new Color[]
                    {
                        MephColorBlend[0],
                        MephColorBlend[1],
                        MephColorBlend[2]
                    };
                    //Full Tab Background Gradient Accents
                    myBlend.Positions = new float[]{
                    0f,
                    0.5f,
                    1f
                };
                    LinearGradientBrush lgBrush = new LinearGradientBrush(x2, MephBackColors[2], MephBackColors[3], 90f);
                    lgBrush.InterpolationColors = myBlend;
                    G.FillRectangle(lgBrush, x2);
                    //G.DrawRectangle(New Pen(Color.FromArgb(20, 20, 20)), x2) 'Full Tab Highlight Outline
                    Rectangle tabRect = new Rectangle(GetTabRect(i).Location.X + 4, GetTabRect(i).Location.Y + 2, GetTabRect(i).Size.Width + 10, GetTabRect(i).Size.Height - 11);
                    G.FillPath(new SolidBrush(MephBackColors[4]), Draw.RoundRect(tabRect, 4));
                    //Highlight Fill Background


                    Draw.InnerGlow(G, new Rectangle(0, 0, ItemSize.Height + 3, Height - 1), CFull);
                    // Main Left Box Outline

                    Draw.InnerGlowRounded(G, tabRect, 4, CHighlight);
                    // Fill HighLight Inner

                    //Dim p() As Point = {New Point(ItemSize.Height - 3, GetTabRect(i).Location.Y + 20), New Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 14), New Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 27)}
                    //G.FillPolygon(Brushes.White, p)

                    if (ImageList != null)
                    {
                        try
                        {

                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text.ToUpper(), new Font(Font.FontFamily, Font.Size, FontStyle.Regular), new SolidBrush(MephForeColors[0]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, FF, new SolidBrush(MephForeColors[0]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text, FF, new SolidBrush(MephForeColors[0]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Center
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, FF, new SolidBrush(MephForeColors[0]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }


                    G.DrawLine(new Pen(MephBorderColors[0]), new Point(x2.Location.X - 1, x2.Location.Y - 1), new Point(x2.Location.X, x2.Location.Y));
                    G.DrawLine(new Pen(MephBorderColors[1]), new Point(x2.Location.X - 1, x2.Bottom - 1), new Point(x2.Location.X, x2.Bottom));
                }
                else
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height + 1));
                    //G.FillRectangle(New SolidBrush(Color.FromArgb(50, 50, 50)), x2) 'Tab Highlight
                    G.DrawLine(new Pen(MephBorderColors[2]), new Point(x2.Right, x2.Top), new Point(x2.Right, x2.Bottom));
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text, Font, new SolidBrush(MephForeColors[0]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                                {
                                    LineAlignment = StringAlignment.Near,
                                    Alignment = StringAlignment.Near
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, FF, new SolidBrush(MephForeColors[1]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text, FF, new SolidBrush(MephForeColors[1]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Center
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, FF, new SolidBrush(MephForeColors[1]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }
                }
                G.FillRectangle(new SolidBrush(MephBackColors[5]), new Rectangle(86, -1, Width - 86, Height + 1));
                //Page Fill Full

                Draw.InnerGlowRounded(G, new Rectangle(86, 0, Width - 87, Height - 1), 3, PageFill);
                // Fill Page
            }

            G.DrawRectangle(new Pen(new SolidBrush(MephBorderColors[3])), new Rectangle(0, 0, ItemSize.Height + 4, Height - 1));
            //Full Tab Outer Outline
            G.DrawRectangle(new Pen(new SolidBrush(MephBorderColors[4])), new Rectangle(1, 0, ItemSize.Height + 3, Height - 2));
            //Full Tab Inner Outline

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }

        #endregion

    }
}
