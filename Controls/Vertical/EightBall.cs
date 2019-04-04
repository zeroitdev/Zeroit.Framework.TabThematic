// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="EightBall.cs" company="Zeroit Dev Technologies">
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

        //private Color[] eightBallBackColors = new Color[]
        //{
        //    Color.FromArgb(100, 100, 100),
        //    Color.FromArgb(100, 100, 100),
        //    Color.FromArgb(30, Color.White), Color.FromArgb(10, Color.Black),
        //    Color.FromArgb(75, 75, 75),
        //    Color.Gray,
        //    Color.FromArgb(100, 100, 100),
        //    Color.SteelBlue
        //};

        //private Color[] eightBallBorderColors = new Color[]
        //{
        //    Color.FromArgb(55, 55, 55),
        //    Color.FromArgb(40, 105, 145),
        //    Color.FromArgb(100, 100, 100),
        //    Color.DimGray
        //};

        //private Color[] eightBallForeColors = new Color[]
        //{
        //    Color.White,
        //    Color.Silver
        //}; 
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the eight ball back colors.
        /// </summary>
        /// <value>The eight ball back colors.</value>
        [Browsable(false)]
        public Color[] EightBallBackColors
        {
            get => tabVerticalInput.EightBallBackColors;
            set
            {
                tabVerticalInput.EightBallBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the eight ball border colors.
        /// </summary>
        /// <value>The eight ball border colors.</value>
        [Browsable(false)]
        public Color[] EightBallBorderColors
        {
            get => tabVerticalInput.EightBallBorderColors;
            set
            {
                tabVerticalInput.EightBallBorderColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the eight ball fore colors.
        /// </summary>
        /// <value>The eight ball fore colors.</value>
        [Browsable(false)]
        public Color[] EightBallForeColors
        {
            get => tabVerticalInput.EightBallForeColors;
            set { tabVerticalInput.EightBallForeColors = value; Invalidate(); }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Eights the ball tab control.
        /// </summary>
        private void EightBallTabControl()
        {

            ItemSize = new Size(35, 145);
            Alignment = TabAlignment.Left;
            SizeMode = TabSizeMode.Fixed;

        }

        #endregion

        #region Paint
        /// <summary>
        /// Eights the ball on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void EightBallOnPaint(PaintEventArgs e)
        {

            G.Clear(Parent.BackColor);

            Color FontColor = new Color();
            Pen borderPen = new Pen(EightBallBorderColors[0]);

            Rectangle mainAreaRect = new Rectangle(ItemSize.Height + 2, 2, Width - 1 - ItemSize.Height - 2, Height - 3);
            GraphicsPath mainAreaPath = Draw.TabControlRect(mainAreaRect, 4);
            G.FillPath(new SolidBrush(EightBallBackColors[0]), mainAreaPath);
            G.DrawPath(borderPen, mainAreaPath);


            for (int i = 0; i <= TabCount - 1; i++)
            {

                if (SelectedIndex == i)
                {
                    Rectangle mainRect = GetTabRect(i);
                    GraphicsPath mainPath = Draw.LeftRoundRect(mainRect, 6);

                    G.FillPath(new SolidBrush(EightBallBackColors[1]), mainPath);
                    G.DrawPath(borderPen, mainPath);

                    Rectangle orbRect = new Rectangle(mainRect.X + 12, mainRect.Y + (mainRect.Height / 2) - 8, 16, 16);
                    G.FillEllipse(new SolidBrush(EightBallBackColors[7]), orbRect);
                    G.FillEllipse(new LinearGradientBrush(orbRect, EightBallBackColors[2], EightBallBackColors[3], 115f), orbRect);

                    G.DrawEllipse(new Pen(EightBallBorderColors[1]), orbRect);

                    G.SmoothingMode = SmoothingMode.None;
                    G.DrawLine(new Pen(EightBallBorderColors[2]), new Point(mainRect.X + mainRect.Width, mainRect.Y + 1), new Point(mainRect.X + mainRect.Width, mainRect.Y + mainRect.Height - 1));
                    G.SmoothingMode = SmoothingMode.HighQuality;

                    FontColor = EightBallForeColors[0];

                    int titleX = (mainRect.Location.X + 28 + 8);
                    int titleY = (mainRect.Location.Y + mainRect.Height / 2) - Convert.ToInt32((G.MeasureString(TabPages[i].Text, Font).Height / 2));
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(FontColor), new Point(titleX, titleY));


                }

                else
                {
                    Rectangle tabRect = GetTabRect(i);
                    Rectangle mainRect = new Rectangle(tabRect.X + 6, tabRect.Y, tabRect.Width - 6, tabRect.Height);
                    GraphicsPath mainPath = Draw.LeftRoundRect(mainRect, 6);

                    G.FillPath(new SolidBrush(EightBallBackColors[4]), mainPath);
                    G.DrawPath(borderPen, mainPath);

                    Rectangle orbRect = new Rectangle(mainRect.X + 12, mainRect.Y + (mainRect.Height / 2) - 8, 16, 16);
                    G.FillEllipse(new SolidBrush(EightBallBackColors[5]), orbRect);
                    G.DrawEllipse(new Pen(EightBallBorderColors[3]), orbRect);

                    FontColor = EightBallForeColors[1];

                    int titleX = (mainRect.Location.X + 28 + 8);
                    int titleY = (mainRect.Location.Y + mainRect.Height / 2) - Convert.ToInt32((G.MeasureString(TabPages[i].Text, Font).Height / 2));
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(FontColor), new Point(titleX, titleY));

                }


                try
                {
                    TabPages[i].BackColor = EightBallBackColors[6];
                }
                catch
                {
                }

            }

        }

        #endregion

    }

}

