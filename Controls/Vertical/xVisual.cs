// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="xVisual.cs" company="Zeroit Dev Technologies">
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
    /// Class ZeroitThematicVerticalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicVerticalTab
    {

        #region Private Fields
        //    Color[] innerTexture = new Color[]{
        //    Color.FromArgb(45, 41, 37),
        //    Color.FromArgb(47, 43, 39),
        //    Color.FromArgb(43, 39, 35)
        //};

        //    Color[] tabBGTexture = new Color[]
        //    {
        //        Color.FromArgb(55, 51, 48),
        //        Color.FromArgb(57, 53, 50),
        //        Color.FromArgb(53, 49, 46)

        //    };

        //    private Color[] xVisualBackColors = new Color[]
        //    {
        //        Color.FromArgb(56, 52, 49),
        //        Color.FromArgb(114, 203, 232), Color.FromArgb(58, 118, 188),
        //        Color.FromArgb(114, 203, 232), Color.FromArgb(58, 118, 188),
        //        Color.FromArgb(15, Color.White), Color.FromArgb(100, Color.FromArgb(43, 40, 38)),
        //        Color.FromArgb(56, 52, 49)
        //    };

        //    private Color[] xVisualBorderColors = new Color[]
        //    {
        //        Color.FromArgb(44, 42, 39),
        //        Color.FromArgb(48, 45, 43),
        //        Color.FromArgb(53, 50, 47),
        //        Color.Black,
        //        Color.FromArgb(99, 97, 94),
        //        Color.FromArgb(235, 255, 255),
        //        Color.FromArgb(235, 255, 255),
        //        Color.Black,
        //        Color.FromArgb(96, 110, 121),
        //        Color.FromArgb(96, 110, 121),
        //        Color.FromArgb(113, 110, 108),
        //        Color.Black,
        //        Color.FromArgb(64, 60, 57),
        //        Color.FromArgb(35, 33, 31),
        //        Color.FromArgb(43, 41, 38),
        //        Color.FromArgb(53, 50, 47),
        //        Color.FromArgb(58, 55, 51),
        //        Color.Black,
        //        Color.FromArgb(56, 52, 49),
        //        Color.FromArgb(56, 52, 49),
        //        Color.Black
        //    };

        //    private Color[] xVisualForeColors = new Color[]
        //    {
        //        Color.FromArgb(20, 20, 20),
        //        Color.White,
        //        Color.FromArgb(210, 220, 230)
        //    };

        //    Color[] glowColor =
        //    {
        //        Color.FromArgb(43, 40, 38),
        //        Color.FromArgb(50, 47, 44),
        //        Color.FromArgb(55, 52, 49)
        //    };
        #endregion

        #region Public 
        /// <summary>
        /// Gets or sets the x visual back colors.
        /// </summary>
        /// <value>The x visual back colors.</value>
        [Browsable(false)]
        public Color[] XVisualBackColors
        {
            get => tabVerticalInput.XVisualBackColors;
            set
            {
                tabVerticalInput.XVisualBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the x visual border colors.
        /// </summary>
        /// <value>The x visual border colors.</value>
        [Browsable(false)]
        public Color[] XVisualBorderColors
        {
            get => tabVerticalInput.XVisualBorderColors;
            set { tabVerticalInput.XVisualBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the x visual fore colors.
        /// </summary>
        /// <value>The x visual fore colors.</value>
        [Browsable(false)]
        public Color[] XVisualForeColors
        {
            get => tabVerticalInput.XVisualForeColors;
            set { tabVerticalInput.XVisualForeColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the glow.
        /// </summary>
        /// <value>The color of the glow.</value>
        [Browsable(false)]
        public Color[] GlowColor
        {
            get { return tabVerticalInput.GlowColor; }
            set
            {
                tabVerticalInput.GlowColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the inner texture.
        /// </summary>
        /// <value>The inner texture.</value>
        [Browsable(false)]
        public Color[] InnerTexture
        {
            get { return tabVerticalInput.InnerTexture; }
            set
            {
                tabVerticalInput.InnerTexture = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the tab bg texture.
        /// </summary>
        /// <value>The tab bg texture.</value>
        [Browsable(false)]
        public Color[] TabBGTexture
        {
            get { return tabVerticalInput.TabBGTexture; }
            set { tabVerticalInput.TabBGTexture = value; Invalidate(); }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// xes the visual tab control.
        /// </summary>
        public void xVisualTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(35, 122);
            Alignment = TabAlignment.Left;
        }

        #endregion

        #region Paint

        /// <summary>
        /// xes the visual on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void xVisualOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Font FF = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);

            TextureBrush innerTexture = Draw.NoiseBrush(new Color[]{
                InnerTexture[0],
                InnerTexture[1],
                InnerTexture[2]
            });

            TextureBrush tabBGTexture = Draw.NoiseBrush(new Color[]{
                TabBGTexture[0],
                TabBGTexture[1],
                TabBGTexture[2]

            });

            try
            {
                SelectedTab.BackColor = XVisualBackColors[0];
            }
            catch
            {

            }
            G.Clear(Parent.BackColor);

            G.FillRectangle(tabBGTexture, new Rectangle(0, 0, ItemSize.Height + 3, Height - 1));
            //Full Tab Background
            G.DrawLine(Draw.GetPen(XVisualBorderColors[0]), 1, Height - 3, ItemSize.Height + 3, Height - 3);
            G.DrawLine(Draw.GetPen(XVisualBorderColors[1]), 1, Height - 4, ItemSize.Height + 3, Height - 4);
            G.DrawLine(Draw.GetPen(XVisualBorderColors[2]), 1, Height - 5, ItemSize.Height + 3, Height - 5);


            for (int i = 0; i <= TabCount - 1; i++)
            {
                int y = GetTabRect(i).Height * 2;
                while (!(y >= Height - 1))
                {
                    G.DrawLine(new Pen(XVisualBorderColors[3]), 1, y, Width - 2, y);
                    G.DrawLine(Draw.GetPen(XVisualBorderColors[4]), 1, y + 1, Width - 2, y + 1);
                    y = y + GetTabRect(0).Height;
                }

                if (i == SelectedIndex)
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));

                    if (SelectedIndex == 0)
                    {
                        Rectangle tabRect = new Rectangle(GetTabRect(i).Location.X, GetTabRect(i).Location.Y - 1, GetTabRect(i).Size.Width - 1, GetTabRect(i).Size.Height - 1);
                        LinearGradientBrush TabOverlay = new LinearGradientBrush(tabRect, XVisualBackColors[1], XVisualBackColors[2], 90);
                        G.FillRectangle(TabOverlay, tabRect);

                        G.DrawLine(Draw.GetPen(XVisualBorderColors[5]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y - 1, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y - 1);
                    }
                    else
                    {
                        Rectangle tabRect = new Rectangle(GetTabRect(i).Location.X, GetTabRect(i).Location.Y - 2, GetTabRect(i).Size.Width - 1, GetTabRect(i).Size.Height);
                        LinearGradientBrush TabOverlay = new LinearGradientBrush(tabRect, XVisualBackColors[3], XVisualBackColors[4], 90);
                        G.FillRectangle(TabOverlay, tabRect);

                        G.DrawLine(Draw.GetPen(XVisualBorderColors[6]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y - 2, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y - 2);
                    }



                    G.DrawLine(new Pen(XVisualBorderColors[7]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y + 33, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y + 33);

                    G.SmoothingMode = SmoothingMode.HighQuality;

                    G.DrawString(TabPages[i].Text, FF, Draw.GetBrush(XVisualForeColors[0]), new Rectangle(x2.X, x2.Y - 1, x2.Width + 1, x2.Height + 2), new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });

                    G.DrawString(TabPages[i].Text, FF, new SolidBrush(XVisualForeColors[1]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });



                    G.DrawLine(new Pen(XVisualBorderColors[8]), new Point(x2.Location.X - 1, x2.Location.Y - 1), new Point(x2.Location.X, x2.Location.Y));
                    G.DrawLine(new Pen(XVisualBorderColors[9]), new Point(x2.Location.X - 1, x2.Bottom - 1), new Point(x2.Location.X, x2.Bottom));
                }
                else
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    Rectangle tabRect = new Rectangle(GetTabRect(i).Location.X, GetTabRect(i).Location.Y - 2, GetTabRect(i).Size.Width - 1, GetTabRect(i).Size.Height - 1);





                    G.FillRectangle(innerTexture, tabRect);
                    //Highlight Fill Background
                    LinearGradientBrush TabOverlay = new LinearGradientBrush(tabRect, XVisualBackColors[5], XVisualBackColors[6], 90);
                    G.FillRectangle(TabOverlay, tabRect);

                    G.DrawLine(Draw.GetPen(XVisualBorderColors[10]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y - 1, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y - 1);
                    G.DrawLine(new Pen(XVisualBorderColors[11]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y + 32, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y + 32);

                    if (i == TabCount - 1)
                    {
                        G.DrawLine(Draw.GetPen(XVisualBorderColors[12]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y + 31, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y + 31);
                        G.DrawLine(Draw.GetPen(XVisualBorderColors[13]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y + 33, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y + 33);
                        G.DrawLine(Draw.GetPen(XVisualBorderColors[14]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y + 34, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y + 34);
                        G.DrawLine(Draw.GetPen(XVisualBorderColors[15]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y + 35, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y + 35);
                        G.DrawLine(Draw.GetPen(XVisualBorderColors[16]), GetTabRect(i).Location.X, GetTabRect(i).Location.Y + 36, GetTabRect(i).Size.Width, GetTabRect(i).Location.Y + 36);
                    }

                    G.DrawString(TabPages[i].Text, FF, new SolidBrush(XVisualForeColors[2]), new Rectangle(x2.X, x2.Y - 1, x2.Width, x2.Height), new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });

                }
                G.FillRectangle(new SolidBrush(XVisualBackColors[7]), new Rectangle(123, -1, Width - 123, Height + 1));
                //Page Fill Full

                G.DrawRectangle(new Pen(XVisualBorderColors[17]), new Rectangle(123, 0, Width - 124, Height - 2));

                Draw.InnerGlow(G, new Rectangle(124, 1, Width - 125, Height - 3), GlowColor);
            }



            G.DrawLine(Draw.GetPen(XVisualBorderColors[18]), -1, Height - 1, ItemSize.Height + 1, Height - 1);
            G.DrawLine(Draw.GetPen(XVisualBorderColors[19]), 0, -1, 0, Height - 1);
            G.DrawRectangle(new Pen(new SolidBrush(XVisualBorderColors[20])), new Rectangle(1, 0, ItemSize.Height, Height - 2));
            //Full Tab Inner Outline

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            B.Dispose();
        }

        #endregion

    }

}

