// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="DotnetBar - v2.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.TabThematic.ThemeManagers;

namespace Zeroit.Framework.TabThematic.Controls
{
    /// <summary>
    /// Class ZeroitThematicVerticalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicVerticalTab : TabControl
    {

        #region Private Fields
        //private Color[] dotV2BackColors = new Color[]
        //{
        //    Color.White,
        //    Color.FromArgb(96, 110, 121),
        //    Color.Black,
        //    Color.Black,
        //    Color.FromArgb(80, 90, 100),
        //    Color.FromArgb(96, 110, 121),
        //    Color.White
        //};

        //private Color[] dotV2BorderColors = new Color[]
        //{
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(67, 77, 87),
        //    Color.FromArgb(115, 125, 135),
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(65, 75, 85)
        //};

        //private Color[] dotV2ForeColors = new Color[]
        //{
        //    Color.White,
        //    Color.FromArgb(210, 220, 230)
        //};

        //private Color[] dotV2BlendColors = new Color[]
        //{
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(96, 110, 121),
        //    Color.FromArgb(96, 110, 121)
        //};
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the dot v2 back colors.
        /// </summary>
        /// <value>The dot v2 back colors.</value>
        [Browsable(false)]
        public Color[] DotV2BackColors
        {
            get => tabVerticalInput.DotV2BackColors;
            set
            {
                tabVerticalInput.DotV2BackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dot v2 blend colors.
        /// </summary>
        /// <value>The dot v2 blend colors.</value>
        [Browsable(false)]
        public Color[] DotV2BlendColors
        {
            get => tabVerticalInput.DotV2BlendColors;
            set
            {
                tabVerticalInput.DotV2BlendColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dot v2 border colors.
        /// </summary>
        /// <value>The dot v2 border colors.</value>
        [Browsable(false)]
        public Color[] DotV2BorderColors
        {
            get { return tabVerticalInput.DotV2BorderColors; }
            set
            {
                tabVerticalInput.DotV2BorderColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dot v2 fore colors.
        /// </summary>
        /// <value>The dot v2 fore colors.</value>
        [Browsable(false)]
        public Color[] DotV2ForeColors
        {
            get => tabVerticalInput.DotV2ForeColors;
            set
            {
                tabVerticalInput.DotV2ForeColors = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DotNetBarTabcontrol" /> class.
        /// </summary>
        private void DotnetBarV2Tabcontrol()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(35, 85);
            Alignment = TabAlignment.Left;
        }
        #endregion

        #region Paint

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        private void DotnetBarV2OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);

            G = Graphics.FromImage(B);
            try
            {
                SelectedTab.BackColor = DotV2BackColors[0];
            }
            catch
            {
            }
            G.Clear(Parent.BackColor);
            G.FillRectangle(new SolidBrush(DotV2BackColors[1]), new Rectangle(0, 0, ItemSize.Height + 4, Height));
            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (i == SelectedIndex)
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    ColorBlend myBlend = new ColorBlend();
                    myBlend.Colors = new Color[]
                    {
                            DotV2BlendColors[0],
                            DotV2BlendColors[1],
                            DotV2BlendColors[2]
                    };
                    myBlend.Positions = new float[]{
                    0f,
                    0.5f,
                    1f
                };
                    LinearGradientBrush lgBrush = new LinearGradientBrush(x2, DotV2BackColors[2], DotV2BackColors[3], 90f);
                    lgBrush.InterpolationColors = myBlend;
                    G.FillRectangle(lgBrush, x2);
                    G.DrawRectangle(new Pen(DotV2BorderColors[0]), x2);
                    Rectangle tabRect = new Rectangle(GetTabRect(i).Location.X + 4, GetTabRect(i).Location.Y + 2, GetTabRect(i).Size.Width + 10, GetTabRect(i).Size.Height - 11);
                    G.FillPath(new SolidBrush(DotV2BackColors[4]), Draw.RoundRect(tabRect, 5));
                    G.DrawPath(new Pen(DotV2BorderColors[1]), Draw.RoundRect(new Rectangle(tabRect.X + 1, tabRect.Y + 1, tabRect.Width - 1, tabRect.Height - 2), 5));
                    G.DrawPath(new Pen(DotV2BorderColors[2]), Draw.RoundRect(tabRect, 5));

                    //Dim p() As Point = {New Point(ItemSize.Height - 3, GetTabRect(i).Location.Y + 20), New Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 14), New Point(ItemSize.Height + 4, GetTabRect(i).Location.Y + 27)}
                    //G.FillPolygon(Brushes.White, p)

                    if (ImageList != null)
                    {
                        try
                        {

                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text.ToUpper(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotV2ForeColors[0]), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text.ToUpper(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotV2ForeColors[0]), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text.ToUpper(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotV2ForeColors[0]), x2, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Center
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text.ToUpper(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotV2ForeColors[0]), x2, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }

                    G.DrawLine(new Pen(DotV2BorderColors[3]), new Point(x2.Location.X - 1, x2.Location.Y - 1), new Point(x2.Location.X, x2.Location.Y));
                    G.DrawLine(new Pen(DotV2BorderColors[4]), new Point(x2.Location.X - 1, x2.Bottom - 1), new Point(x2.Location.X, x2.Bottom));
                }
                else
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height + 1));
                    G.FillRectangle(new SolidBrush(DotV2BackColors[5]), x2);
                    G.DrawLine(new Pen(DotV2BorderColors[5]), new Point(x2.Right, x2.Top), new Point(x2.Right, x2.Bottom));
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(x2.Location.X + 8, x2.Location.Y + 6));
                                G.DrawString("      " + TabPages[i].Text, Font, new SolidBrush(DotV2ForeColors[0]), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Near,
                                    Alignment = StringAlignment.Near
                                });
                            }
                            else
                            {
                                G.DrawString(TabPages[i].Text.ToUpper(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotV2ForeColors[1]), x2, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            G.DrawString(TabPages[i].Text.ToUpper(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotV2ForeColors[1]), x2, new StringFormat
                            {
                                LineAlignment = StringAlignment.Center,
                                Alignment = StringAlignment.Center
                            });
                        }
                    }
                    else
                    {
                        G.DrawString(TabPages[i].Text.ToUpper(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(DotV2ForeColors[1]), x2, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }
                }
                G.FillPath(new SolidBrush(DotV2BackColors[6]), Draw.RoundRect(new Rectangle(86, 0, Width - 89, Height - 3), 5));
                G.DrawPath(new Pen(DotV2BorderColors[6]), Draw.RoundRect(new Rectangle(86, 0, Width - 89, Height - 3), 5));
            }

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

        #endregion
    }


}

