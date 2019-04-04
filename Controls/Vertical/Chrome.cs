// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Chrome.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
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
        //Color squareColor = Color.FromArgb(78, 87, 100);

        //private Color[] chromeBackColors = new Color[]
        //{
        //    SystemColors.Control,
        //    SystemColors.Control
        //};

        //private Color[] chromeForeColors = new Color[]
        //{
        //    Color.Black,
        //    Color.DimGray
        //};

        //bool showOuterBorders = false;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets a value indicating whether [show outer borders].
        /// </summary>
        /// <value><c>true</c> if [show outer borders]; otherwise, <c>false</c>.</value>
        [Browsable(false)]
        public bool ShowOuterBorders
        {
            get { return tabVerticalInput.ShowOuterBorders; }
            set
            {
                tabVerticalInput.ShowOuterBorders = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the square.
        /// </summary>
        /// <value>The color of the square.</value>
        [Browsable(false)]
        public Color SquareColor
        {
            get { return tabVerticalInput.SquareColor; }
            set
            {
                tabVerticalInput.SquareColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the chrome back.
        /// </summary>
        /// <value>The color of the chrome back.</value>
        [Browsable(false)]
        public Color[] ChromeBackColor
        {
            get { return tabVerticalInput.ChromeBackColor; }
            set
            {
                tabVerticalInput.ChromeBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the chrome fore colors.
        /// </summary>
        /// <value>The chrome fore colors.</value>
        [Browsable(false)]
        public Color[] ChromeForeColors
        {
            get { return tabVerticalInput.ChromeForeColors; }
            set
            {
                tabVerticalInput.ChromeForeColors = value;
                Invalidate();
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Chromes the tabcontrol.
        /// </summary>
        private void ChromeTabcontrol()
        {
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(30, 115);
            Alignment = TabAlignment.Left;
        }

        #endregion

        #region Paint
        /// <summary>
        /// Chromes the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ChromeOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            try
            {
                SelectedTab.BackColor = ChromeBackColor[1];
            }
            catch
            {
            }
            G.Clear(ChromeBackColor[0]);
            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                Rectangle textrectangle = new Rectangle(x2.Location.X + 20, x2.Location.Y, x2.Width - 20, x2.Height);
                if (i == SelectedIndex)
                {
                    G.FillRectangle(new SolidBrush(SquareColor), new Rectangle(x2.Location, new Size(9, x2.Height)));


                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(textrectangle.Location.X + 8, textrectangle.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text, Font, new SolidBrush(ChromeForeColors[0]), textrectangle, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Near
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, Font, new SolidBrush(ChromeForeColors[0]), textrectangle, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Near
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text, Font, new SolidBrush(ChromeForeColors[0]), textrectangle, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Near
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(ChromeForeColors[0]), textrectangle, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Near
                        });
                    }

                }
                else
                {
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(textrectangle.Location.X + 8, textrectangle.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text, Font, new SolidBrush(ChromeForeColors[1]), textrectangle, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Near
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text, Font, new SolidBrush(ChromeForeColors[1]), textrectangle, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Near
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text, Font, new SolidBrush(ChromeForeColors[1]), textrectangle, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Near
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(ChromeForeColors[1]), textrectangle, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Near
                        });
                    }
                }
            }

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

        #endregion

    }

}

