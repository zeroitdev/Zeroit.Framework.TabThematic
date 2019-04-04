// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Empire.cs" company="Zeroit Dev Technologies">
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

        //private Color[] empireForeColors = new Color[]
        //{
        //    Color.Gainsboro,
        //    Color.Gray
        //};

        //private Color[] empireBorderColors = new Color[]
        //{
        //    Color.Black,
        //    Color.FromArgb(51, 51, 51),
        //    Color.FromArgb(17, 17, 17),
        //    Color.FromArgb(51, 51, 51),
        //    Color.FromArgb(17, 17, 17)
        //};

        //Color[] empireBackColors = new Color[]
        //{
        //    Color.FromArgb(55, 173, 242),
        //    Color.FromArgb(36, 36, 36),
        //    Color.FromArgb(42, 42, 42),
        //    Color.FromArgb(25, 25, 25),
        //    Color.Gainsboro,
        //    Color.FromArgb(90, Color.Black),
        //    Color.Transparent,
        //    Color.FromArgb(200, 200, 200),
        //    Color.FromArgb(36, 36, 36),
        //    Color.FromArgb(25, 25, 25),
        //    Color.FromArgb(3, Color.White)

        //}; 

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the empire fore colors.
        /// </summary>
        /// <value>The empire fore colors.</value>
        [Browsable(false)]
        public Color[] EmpireForeColors
        {
            get => tabVerticalInput.EmpireForeColors;
            set
            {
                tabVerticalInput.EmpireForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the empire border colors.
        /// </summary>
        /// <value>The empire border colors.</value>
        [Browsable(false)]
        public Color[] EmpireBorderColors
        {
            get => tabVerticalInput.EmpireBorderColors;
            set { tabVerticalInput.EmpireBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the empire back colors.
        /// </summary>
        /// <value>The empire back colors.</value>
        [Browsable(false)]
        public Color[] EmpireBackColors
        {
            get => tabVerticalInput.EmpireBackColors;
            set { tabVerticalInput.EmpireBackColors = value; Invalidate(); }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Empires the tabcontrol.
        /// </summary>
        public void EmpireTabcontrol()
        {
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(37, 120);
            Alignment = TabAlignment.Left;
        }

        #endregion

        #region Mouse Events

        /// <summary>
        /// The old index over
        /// </summary>
        int _OldIndexOver = 0;

        /// <summary>
        /// Empires the on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void EmpireOnMouseMove(MouseEventArgs e)
        {
            X = e.Location.X;
            Y = e.Location.Y;
            if (e.X > ItemSize.Height)
            {
                _IndexOver = -1;
            }
            else
            {
                Y = (Y - (Y % ItemSize.Width)) / ItemSize.Width;
                _IndexOver = Y;
            }

            if (_IndexOver != _OldIndexOver)
            {
                Invalidate();
            }

            _OldIndexOver = _IndexOver;
            
        }

        /// <summary>
        /// Empires the on mouse leave.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EmpireOnMouseLeave(EventArgs e)
        {
            _IndexOver = -1;
            Invalidate();
            
        }

        #endregion

        #region Declarations
        /// <summary>
        /// The index over
        /// </summary>
        int _IndexOver = -1;
        /// <summary>
        /// The x
        /// </summary>
        int X;
        /// <summary>
        /// The y
        /// </summary>
        int Y;

        #endregion

        #region Paint

        /// <summary>
        /// Empires the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void EmpireOnPaint(PaintEventArgs e)
        {
            G.Clear(EmpireBackColors[0]);
            G.FillRectangle(new LinearGradientBrush(new Rectangle(0, 0, Width, Height), EmpireBackColors[2], EmpireBackColors[3], 90f), new Rectangle(0, 0, Width, Height));


            G.FillRectangle(new SolidBrush(EmpireBackColors[4]), new Rectangle(ItemSize.Height, 0, Width - ItemSize.Height, Height));
            LinearGradientBrush LinearGB = new LinearGradientBrush(new Rectangle(ItemSize.Height, 0, Width - ItemSize.Height, 4), EmpireBackColors[5], EmpireBackColors[6], 90f);
            G.FillRectangle(LinearGB, LinearGB.Rectangle);
            G.DrawLine(new Pen(EmpireBorderColors[0]), new Point(ItemSize.Height, 0), new Point(ItemSize.Height, Height));

            try
            {
                foreach (TabPage T in TabPages)
                {
                    T.BackColor = EmpireBackColors[7];
                }
            }
            catch
            {
            }


            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width, GetTabRect(i).Height));
                Rectangle textrectangle = new Rectangle(x2.Location.X + 34, x2.Location.Y, x2.Width - 34, x2.Height);

                if (i == SelectedIndex)
                {
                    LinearGradientBrush LGB = new LinearGradientBrush(x2, EmpireBackColors[8], EmpireBackColors[9], 90f);
                    G.FillRectangle(LGB, LGB.Rectangle);
                    G.FillRectangle(new SolidBrush(EmpireBackColors[0]), new Rectangle(x2.Location, new Size(6, x2.Height)));



                    G.DrawRectangle(new Pen(EmpireBorderColors[1]), x2);
                    G.DrawLine(new Pen(EmpireBorderColors[2]), new Point(x2.Location.X + 1, x2.Location.Y + x2.Height - 1), new Point(x2.Location.X + x2.Width, x2.Location.Y + x2.Height - 1));

                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(EmpireForeColors[0]), textrectangle, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Near
                    });
                }
                else
                {
                    G.DrawString(TabPages[i].Text, Font, new SolidBrush(EmpireForeColors[1]), textrectangle, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Near
                    });
                    G.DrawRectangle(new Pen(EmpireBorderColors[3]), x2);
                    G.DrawLine(new Pen(EmpireBorderColors[4]), new Point(x2.Location.X + 1, x2.Location.Y + x2.Height - 1), new Point(x2.Location.X + x2.Width, x2.Location.Y + x2.Height - 1));
                }

                if (i == _IndexOver)
                    G.FillRectangle(new SolidBrush(EmpireBackColors[10]), x2);
            }
        }
        
        #endregion

    }

}

