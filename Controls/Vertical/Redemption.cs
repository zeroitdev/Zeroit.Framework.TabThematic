// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Redemption.cs" company="Zeroit Dev Technologies">
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


        //private bool _BackgrounNoise = true;

        //private HorizontalAlignments _Align = HorizontalAlignments.Left;

        //private Color[] redemptionBackColors = new Color[]
        //{
        //    Color.FromArgb(47, 48, 52),
        //    Color.FromArgb(51, 56, 60),
        //    Color.FromArgb(15, Color.White),
        //    Color.FromArgb(49, 50, 54),
        //    Color.FromArgb(72, 79, 87),
        //    Color.FromArgb(48, 51, 56)
        //};

        //private Color[] redemptionBorderColors = new Color[]
        //{
        //    Color.Transparent, Color.FromArgb(87, 88, 92),
        //    Color.FromArgb(32, 33, 37),
        //    Color.FromArgb(119, 124, 130), Color.FromArgb(64, 67, 72),
        //    Color.FromArgb(31, 36, 42)
        //};

        //private Color[] redemptionForeColors = new Color[]
        //{
        //    Color.FromArgb(150, Color.Black),
        //    Color.White
        //};

        //Color[] gradientPen =
        //{
        //    Color.FromArgb(43, 44, 48),
        //    Color.FromArgb(44, 45, 49),
        //    Color.FromArgb(45, 46, 50),
        //    Color.FromArgb(46, 47, 51),
        //    Color.FromArgb(47, 48, 52),
        //    Color.FromArgb(48, 49, 53)
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the text align.
        /// </summary>
        /// <value>The text align.</value>
        [Browsable(false)]
        public HorizontalAlignments TextAlign
        {
            get { return tabVerticalInput.TextAlign; }
            set
            {
                tabVerticalInput.TextAlign = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [background noise].
        /// </summary>
        /// <value><c>true</c> if [background noise]; otherwise, <c>false</c>.</value>
        [Browsable(false)]
        public bool BackgroundNoise
        {
            get { return tabVerticalInput.BackgroundNoise; }
            set
            {
                tabVerticalInput.BackgroundNoise = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the redemption back colors.
        /// </summary>
        /// <value>The redemption back colors.</value>
        [Browsable(false)]
        public Color[] RedemptionBackColors
        {
            get => tabVerticalInput.RedemptionBackColors;
            set
            {
                tabVerticalInput.RedemptionBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the redemption border colors.
        /// </summary>
        /// <value>The redemption border colors.</value>
        [Browsable(false)]
        public Color[] RedemptionBorderColors
        {
            get => tabVerticalInput.RedemptionBorderColors;
            set { tabVerticalInput.RedemptionBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the redemption fore colors.
        /// </summary>
        /// <value>The redemption fore colors.</value>
        [Browsable(false)]
        public Color[] RedemptionForeColors
        {
            get => tabVerticalInput.RedemptionForeColors;
            set { tabVerticalInput.RedemptionForeColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the gradient pen.
        /// </summary>
        /// <value>The gradient pen.</value>
        [Browsable(false)]
        public Color[] GradientPen
        {
            get { return tabVerticalInput.GradientPen; }
            set
            {
                tabVerticalInput.GradientPen = value;
                Invalidate();
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Redemptions the tab control.
        /// </summary>
        private void RedemptionTabControl()
        {
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            BackColor = Color.Transparent;
            ItemSize = new Size(35, 100);
            Alignment = TabAlignment.Left;

        }

        #endregion

        #region Paint

        /// <summary>
        /// Redemptions the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void RedemptionOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            G.SmoothingMode = Smoothing;
            int Curve = 10;
            try
            {
                SelectedTab.BackColor = RedemptionBackColors[0];
            }
            catch
            {
            }
            G.Clear(RedemptionBackColors[1]);
            if (BackgroundNoise)
            {
                TextureBrush MatteNoise = Draw.TiledTextureFromCode("iVBORw0KGgoAAAANSUhEUgAAAEYAAABGCAIAAAD+THXTAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAA2ZpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wTU09Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9tbS8iIHhtbG5zOnN0UmVmPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvc1R5cGUvUmVzb3VyY2VSZWYjIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDo1OEU1MkNDNjNCQjBFMjExQjY2NkFFNERBQzEzREJERiIgeG1wTU06RG9jdW1lbnRJRD0ieG1wLmRpZDpGQTIzMjhDQUIwM0IxMUUyOEY4NDk4NjlBRTkxQzE1QyIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDpGQTIzMjhDOUIwM0IxMUUyOEY4NDk4NjlBRTkxQzE1QyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ1M2IChXaW5kb3dzKSI+IDx4bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSJ4bXAuaWlkOjU4RTUyQ0M2M0JCMEUyMTFCNjY2QUU0REFDMTNEQkRGIiBzdFJlZjpkb2N1bWVudElEPSJ4bXAuZGlkOjU4RTUyQ0M2M0JCMEUyMTFCNjY2QUU0REFDMTNEQkRGIi8+IDwvcmRmOkRlc2NyaXB0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");
                G.FillRectangle(MatteNoise, new Rectangle(-1, -1, Width + 3, Height + 3));
                G.FillRectangle(new SolidBrush(RedemptionBackColors[2]), new Rectangle(-1, -1, Width + 3, Height + 3));
            }


            G.FillPath(new SolidBrush(RedemptionBackColors[3]), Draw.RoundRect(new Rectangle(ItemSize.Height - 1, 0, Width - ItemSize.Height - 1 - 1, Height - 1), Curve));



            for (int i = 0; i <= 5; i++)
            {
                G.DrawPath(new Pen(GradientPen[i]), Draw.RoundRect(new Rectangle(ItemSize.Height - 1 + i + 1, i + 1, Width - ItemSize.Height - 1 - ((2 * i) + 3), Height - ((2 * i) + 3)), Curve));
            }

            LinearGradientBrush BorderPen = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), RedemptionBorderColors[0], RedemptionBorderColors[1], 90);

            G.DrawPath(new Pen(BorderPen), Draw.RoundRect(new Rectangle(ItemSize.Height - 1, 0, Width - ItemSize.Height - 1 - 1, Height - 1), Curve));
            G.DrawPath(new Pen(RedemptionBorderColors[2]), Draw.RoundRect(new Rectangle(ItemSize.Height - 1, 0, Width - ItemSize.Height - 1 - 1, Height - 2), Curve));

            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (i == SelectedIndex)
                {
                    Rectangle OuterBorder = new Rectangle(new Point(GetTabRect(i).Location.X - 1, GetTabRect(i).Location.Y + 3), new Size(GetTabRect(i).Width - 7, GetTabRect(i).Height - 7));
                    Rectangle InnerBorder = new Rectangle(new Point(GetTabRect(i).Location.X - 1, GetTabRect(i).Location.Y + 4), new Size(GetTabRect(i).Width - 7, GetTabRect(i).Height - 8));
                    LinearGradientBrush MainBody = new LinearGradientBrush(OuterBorder, RedemptionBackColors[4], RedemptionBackColors[5], 90);
                    G.FillPath(MainBody, Draw.RoundRect(OuterBorder, Curve));
                    LinearGradientBrush GlossPen = new LinearGradientBrush(OuterBorder, RedemptionBorderColors[3], RedemptionBorderColors[4], 90);
                    G.DrawPath(new Pen(GlossPen), Draw.RoundRect(InnerBorder, Curve));
                    G.DrawPath(new Pen(RedemptionBorderColors[5]), Draw.RoundRect(OuterBorder, Curve));
                }

                switch (TextAlign)
                {
                    case HorizontalAlignments.Center:
                        Rectangle TextRectangle = new Rectangle(new Point(GetTabRect(i).Location.X - 4, GetTabRect(i).Location.Y + 4), new Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7));
                        Rectangle TextShadow = new Rectangle(new Point(GetTabRect(i).Location.X - 3, GetTabRect(i).Location.Y + 5), new Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7));
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(RedemptionForeColors[0]), TextShadow, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(RedemptionForeColors[1]), TextRectangle, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                        break;
                    case HorizontalAlignments.Left:
                        Rectangle TextRectangle1 = new Rectangle(new Point(GetTabRect(i).Location.X + 5, GetTabRect(i).Location.Y + 4), new Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7));
                        Rectangle TextShadow1 = new Rectangle(new Point(GetTabRect(i).Location.X + 6, GetTabRect(i).Location.Y + 5), new Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7));
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(RedemptionForeColors[0]), TextShadow1, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Near
                        });
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(RedemptionForeColors[1]), TextRectangle1, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Near
                        });
                        break;
                    case HorizontalAlignments.Right:
                        Rectangle TextRectangle2 = new Rectangle(new Point(GetTabRect(i).Location.X - 9, GetTabRect(i).Location.Y + 4), new Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7));
                        Rectangle TextShadow2 = new Rectangle(new Point(GetTabRect(i).Location.X - 8, GetTabRect(i).Location.Y + 5), new Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 7));
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(RedemptionForeColors[0]), TextShadow2, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Far
                        });
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(RedemptionForeColors[1]), TextRectangle2, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Far
                        });
                        break;
                }
            }
            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

        #endregion
    }

}

