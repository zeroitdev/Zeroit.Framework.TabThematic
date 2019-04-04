// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AdvancedSystem.cs" company="Zeroit Dev Technologies">
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
    /// Class ZeroitThematicHorizontalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicHorizontalTab
    {

        #region Private Fields
        //private Color[] ascForeColors = new Color[]
        //{
        //    Color.FromArgb(80, 170, 245),
        //    Color.FromArgb(160, 160, 160)
        //};

        //private Color[] ascBorderColors = new Color[]
        //{
        //    Color.FromArgb(5, 135, 250),
        //    Color.FromArgb(25, 100, 140),
        //    Color.FromArgb(30, 55, 85),
        //    Color.FromArgb(30, 55, 85),
        //    Color.FromArgb(30, 90, 125)
        //};

        //private Color[] ascBackColors = new Color[]
        //{
        //    Color.FromArgb(22,22,22)
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the asc fore colors.
        /// </summary>
        /// <value>The asc fore colors.</value>
        [Browsable(false)]
        public Color[] AscForeColors
        {
            get => tabHorizontalInput.AscForeColors;
            set
            {
                tabHorizontalInput.AscForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the asc border colors.
        /// </summary>
        /// <value>The asc border colors.</value>
        [Browsable(false)]
        public Color[] AscBorderColors
        {
            get => tabHorizontalInput.AscBorderColors;
            set { tabHorizontalInput.AscBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the asc back colors.
        /// </summary>
        /// <value>The asc back colors.</value>
        [Browsable(false)]
        public Color[] AscBackColors
        {
            get => tabHorizontalInput.AscBackColors;
            set { tabHorizontalInput.AscBackColors = value; Invalidate(); }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Ascs the tab control.
        /// </summary>
        public void ASCTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            ItemSize = new Size(0, 34);
            Padding = new Point(24, 0);
            Alignment = TabAlignment.Top;
            SizeMode = TabSizeMode.Normal;
        }
        #endregion

        #region Paint Overrides
        /// <summary>
        /// Ascs the on paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void ASCOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);

            Color FontColor = new Color();


            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle mainRect = GetTabRect(i);

                if (i == SelectedIndex)
                {
                    FontColor = AscForeColors[0];
                    G.DrawLine(new Pen(AscBorderColors[0]), new Point(mainRect.X - 2, mainRect.Height - 1), new Point(mainRect.X + mainRect.Width - 2, mainRect.Height - 1));
                    G.DrawLine(new Pen(AscBorderColors[1]), new Point(mainRect.X - 2, mainRect.Height), new Point(mainRect.X + mainRect.Width - 2, mainRect.Height));
                }
                else
                {
                    FontColor = AscForeColors[0];
                    G.DrawLine(new Pen(AscBorderColors[2]), new Point(mainRect.X - 2, mainRect.Height - 1), new Point(mainRect.X + mainRect.Width - 2, mainRect.Height - 1));
                    G.DrawLine(new Pen(AscBorderColors[3]), new Point(mainRect.X - 2, mainRect.Height), new Point(mainRect.X + mainRect.Width - 2, mainRect.Height));
                }

                if (i != 0)
                {
                    G.DrawLine(new Pen(AscBorderColors[4]), new Point(mainRect.X - 4, mainRect.Height - 7), new Point(mainRect.X + 4, mainRect.Y + 6));
                }

                int titleX = (mainRect.Location.X + mainRect.Width / 2) - Convert.ToInt32((G.MeasureString(TabPages[i].Text, Font).Width / 2));
                int titleY = (mainRect.Location.Y + mainRect.Height / 2) - Convert.ToInt32((G.MeasureString(TabPages[i].Text, Font).Height / 2));
                G.DrawString(TabPages[i].Text, Font, new SolidBrush(FontColor), new Point(titleX, titleY));

                try
                {
                    TabPages[i].BackColor = AscBackColors[0];
                }
                catch
                {
                }

            }



        }

        /// <summary>
        /// Ascs the create handle.
        /// </summary>
        private void ASCCreateHandle()
        {

        } 
        #endregion
    }
}
