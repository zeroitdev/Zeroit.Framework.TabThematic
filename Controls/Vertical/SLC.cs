// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SLC.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
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
        //private Color[] slcBackColors = new Color[]
        //{
        //    Color.White,
        //    Color.FromArgb(250, 250, 250),
        //    Color.FromArgb(237, 237, 237),
        //    Color.FromArgb(227, 227, 227), Color.Transparent,
        //    Color.FromArgb(227, 227, 227), Color.Transparent,
        //    Color.FromArgb(242, 242, 242),
        //    Color.FromArgb(56, 142, 196),
        //    Color.FromArgb(64, 106, 140),
        //    Color.FromArgb(40, Color.WhiteSmoke),
        //    Color.FromArgb(242, 242, 242),
        //    Color.LightGray,

        //};

        //private Color[] slcBorderColors = new Color[]
        //{
        //    Color.LightGray,
        //    Color.Gray,
        //    Color.White,
        //    Color.FromArgb(70, Color.FromArgb(39, 93, 127)),
        //    Color.FromArgb(200, 200, 200),
        //    Color.FromArgb(150, 150, 150),
        //    Color.FromArgb(49, 63, 86),
        //    Color.White,
        //    Color.FromArgb(70, Color.FromArgb(39, 93, 127)),
        //    Color.FromArgb(100, 100, 100),

        //};

        //private Color[] slcForeColors = new Color[]
        //{
        //    Color.FromArgb(56, 106, 137)
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the SLC back colors.
        /// </summary>
        /// <value>The SLC back colors.</value>
        [Browsable(false)]
        public Color[] SlcBackColors
        {
            get => tabVerticalInput.SlcBackColors;
            set
            {
                tabVerticalInput.SlcBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the SLC border colors.
        /// </summary>
        /// <value>The SLC border colors.</value>
        [Browsable(false)]
        public Color[] SlcBorderColors
        {
            get => tabVerticalInput.SlcBorderColors;
            set { tabVerticalInput.SlcBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the SLC fore colors.
        /// </summary>
        /// <value>The SLC fore colors.</value>
        [Browsable(false)]
        public Color[] SlcForeColors
        {
            get => tabVerticalInput.SlcForeColors;
            set { tabVerticalInput.SlcForeColors = value; Invalidate(); }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// SLCs the tab control.
        /// </summary>
        private void SLCTabControl()
        {
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(30, 120);
            Alignment = TabAlignment.Left;
        }

        #endregion

        #region Paint and Methods
        /// <summary>
        /// Borderptses this instance.
        /// </summary>
        /// <returns>GraphicsPath.</returns>
        private GraphicsPath Borderpts()
        {
            GraphicsPath P = new GraphicsPath();
            List<Point> PS = new List<Point>();

            PS.Add(new Point(0, 0));
            PS.Add(new Point(Width - 1, 0));
            PS.Add(new Point(Width - 1, Height - 1));
            PS.Add(new Point(0, Height - 1));



            P.AddPolygon(PS.ToArray());
            return P;
        }

        /// <summary>
        /// Borderptses the inside.
        /// </summary>
        /// <returns>GraphicsPath.</returns>
        private GraphicsPath BorderptsInside()
        {
            GraphicsPath P = new GraphicsPath();
            List<Point> PS = new List<Point>();

            PS.Add(new Point(1, 1));
            PS.Add(new Point(122, 1));
            PS.Add(new Point(122, Height - 2));
            PS.Add(new Point(1, Height - 2));



            P.AddPolygon(PS.ToArray());
            return P;
        }

        /// <summary>
        /// Bigs the border.
        /// </summary>
        /// <returns>GraphicsPath.</returns>
        private GraphicsPath BigBorder()
        {
            GraphicsPath P = new GraphicsPath();
            List<Point> PS = new List<Point>();

            PS.Add(new Point(50, 1));
            PS.Add(new Point(349, 50));
            PS.Add(new Point(349, 50));
            PS.Add(new Point(50, 349));

            P.AddPolygon(PS.ToArray());
            return P;
        }

        /// <summary>
        /// SLCs the on paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void SLCOnPaint(System.Windows.Forms.PaintEventArgs e)
        {

            Bitmap b = new Bitmap(Width, Height);
            G = Graphics.FromImage(b);
            G.Clear(SlcBackColors[0]);

            GraphicsPath GP1 = Borderpts();
            G.DrawPath(new Pen(SlcBorderColors[0]), GP1);


            //// small border
            GraphicsPath tmp1 = BorderptsInside();

            PathGradientBrush PB2 = default(PathGradientBrush);
            PB2 = new PathGradientBrush(tmp1);
            PB2.CenterColor = SlcBackColors[1];
            PB2.SurroundColors = new Color[] { SlcBackColors[2] };
            PB2.FocusScales = new PointF(0.9f, 0.9f);

            G.FillPath(PB2, tmp1);
            G.DrawPath(new Pen(SlcBorderColors[1]), tmp1);

            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle rec = GetTabRect(i);
                Rectangle rec2 = rec;


                ////inside small 
                rec2.Width -= 3;
                rec2.Height -= 3;
                rec2.Y += 1;
                rec2.X += 1;


                if (i == SelectedIndex)
                {


                    LinearGradientBrush linear = new LinearGradientBrush(new Rectangle(rec2.X + 108, rec2.Y + 1, 10, rec2.Height - 1), SlcBackColors[3], SlcBackColors[4], 180f);
                    LinearGradientBrush linear3 = new LinearGradientBrush(new Rectangle(rec2.X, rec2.Y + 1, 10, rec2.Height - 1), SlcBackColors[5], SlcBackColors[6], 180f);


                    G.FillRectangle(new SolidBrush(SlcBackColors[7]), rec2);
                    G.DrawRectangle(new Pen(SlcBorderColors[2]), rec2);
                    G.DrawRectangle(new Pen(SlcBorderColors[3], 2), rec);
                    G.FillRectangle(linear, new Rectangle(rec2.X + 113, rec2.Y + 1, 6, rec2.Height - 1));
                    G.FillRectangle(linear3, new Rectangle(rec2.X, rec2.Y + 1, 6, rec2.Height - 1));
                    //// circle



                    G.SmoothingMode = SmoothingMode.HighQuality;

                    G.DrawEllipse(new Pen(SlcBorderColors[4], 3),
                        new Rectangle(rec2.X + (int)6.5f, rec2.Y + 7, 14, 14));
                    G.DrawEllipse(new Pen(SlcBorderColors[5], 1),
                        new Rectangle(rec2.X + (int)6.5f, rec2.Y + 7, 14, 14));



                    GraphicsPath GPF = new GraphicsPath();
                    GPF.AddEllipse(new Rectangle(rec2.X + 8, rec2.Y + 8, 12, 12));
                    PathGradientBrush PB3 = default(PathGradientBrush);
                    PB3 = new PathGradientBrush(GPF);
                    PB3.CenterPoint = new Point(rec2.X - 10, rec2.Y - 10);
                    PB3.CenterColor = SlcBackColors[8];
                    PB3.SurroundColors = new Color[] { SlcBackColors[9] };
                    PB3.FocusScales = new PointF(0.9f, 0.9f);


                    G.FillPath(PB3, GPF);

                    G.DrawPath(new Pen(SlcBorderColors[6]), GPF);
                    G.SetClip(GPF);
                    G.FillEllipse(new SolidBrush(SlcBackColors[10]), new Rectangle((int)(rec2.X + 10.5f), rec2.Y + 11, 6, 6));
                    G.ResetClip();



                    G.SmoothingMode = SmoothingMode.None;


                }
                else
                {
                    G.SmoothingMode = SmoothingMode.HighQuality;
                    LinearGradientBrush linear = new LinearGradientBrush(new Rectangle(rec2.X + 108, rec2.Y + 1, 10, rec2.Height - 1), Color.FromArgb(227, 227, 227), Color.Transparent, 180f);
                    LinearGradientBrush linear3 = new LinearGradientBrush(new Rectangle(rec2.X, rec2.Y + 1, 10, rec2.Height - 1), Color.FromArgb(227, 227, 227), Color.Transparent, 180f);


                    G.FillRectangle(new SolidBrush(SlcBackColors[11]), rec2);
                    G.DrawRectangle(new Pen(SlcBorderColors[7]), rec2);
                    G.DrawRectangle(new Pen(SlcBorderColors[8], 2), rec);
                    G.FillRectangle(linear, new Rectangle(rec2.X + 113, rec2.Y + 1, 6, rec2.Height - 1));
                    G.FillRectangle(linear3, new Rectangle(rec2.X, rec2.Y + 1, 6, rec2.Height - 1));


                    G.FillEllipse(new SolidBrush(SlcBackColors[12]), new Rectangle(rec2.X + 8, rec2.Y + 8, 12, 12));
                    G.DrawEllipse(new Pen(SlcBorderColors[9], 1), new Rectangle(rec2.X + 8, rec2.Y + 8, 12, 12));
                    G.SmoothingMode = SmoothingMode.None;

                }

                G.DrawString(TabPages[i].Text, Font, new SolidBrush(SlcForeColors[0]), rec, new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }




            e.Graphics.DrawImage((Bitmap)b.Clone(), 0, 0);
            //G.Dispose();
            //b.Dispose();

        }

        #endregion

    }

}

