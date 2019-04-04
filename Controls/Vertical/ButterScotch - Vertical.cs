// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ButterScotch - Vertical.cs" company="Zeroit Dev Technologies">
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
        //private Color[] butterVertBackColors = new Color[]
        //{
        //    Color.FromArgb(100, 90, 80),
        //    Color.FromArgb(40, 37, 33),
        //    Color.FromArgb(100, 90, 80),
        //    Color.FromArgb(48, 43, 39),
        //    Color.FromArgb(57, 52, 46),
        //    Color.FromArgb(92, 83, 74)
        //};

        //private Color[] butterVertBorderColors = new Color[]
        //{
        //    Color.Black
        //};

        //private Color[] butterVertForeColors = new Color[]
        //{
        //    Color.FromArgb(25, 23, 22),
        //    Color.White
        //}; 
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the butter vert back colors.
        /// </summary>
        /// <value>The butter vert back colors.</value>
        [Browsable(false)]
        public Color[] ButterVertBackColors
        {
            get => tabVerticalInput.ButterVertBackColors;
            set
            {
                tabVerticalInput.ButterVertBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the butter vert border colors.
        /// </summary>
        /// <value>The butter vert border colors.</value>
        [Browsable(false)]
        public Color[] ButterVertBorderColors
        {
            get => tabVerticalInput.ButterVertBorderColors;
            set { tabVerticalInput.ButterVertBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the butter vert fore colors.
        /// </summary>
        /// <value>The butter vert fore colors.</value>
        [Browsable(false)]
        public Color[] ButterVertForeColors
        {
            get => tabVerticalInput.ButterVertForeColors;
            set { tabVerticalInput.ButterVertForeColors = value; Invalidate(); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Butterscotches the vertical tab control.
        /// </summary>
        public void ButterscotchVerticalTabControl()
        {
            DoubleBuffered = true;
            ItemSize = new Size(35, 100);
            Alignment = TabAlignment.Left;
            SizeMode = TabSizeMode.Fixed;
        }

        #endregion

        #region Paint
        /// <summary>
        /// Butterscotches the vertical on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ButterscotchVerticalOnPaint(PaintEventArgs e)
        {
            Bitmap b = new Bitmap(Width, Height);
            G = Graphics.FromImage(b);
            G.SmoothingMode = Smoothing;
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            G.Clear(BackColor);
            try
            {
                SelectedTab.BackColor = ButterVertBackColors[0];
            }
            catch
            {
            }

            G.FillRectangle(new SolidBrush(ButterVertBackColors[1]), rect);
            G.DrawRectangle(new Pen(ButterVertBorderColors[0]), rect);

            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle textRectangle = new Rectangle(new Point(GetTabRect(i).Location.X + 7, GetTabRect(i).Location.Y + 2), new Size(GetTabRect(i).Width - 15, GetTabRect(i).Height - 5));
                if (SelectedIndex == i)
                {
                    Rectangle tabrect = new Rectangle(new Point(GetTabRect(i).Location.X + 2, GetTabRect(i).Location.Y + 1), new Size(GetTabRect(i).Width - 2, GetTabRect(i).Height - 3));
                    LinearGradientBrush buttonrect = new LinearGradientBrush(tabrect, ButterVertBackColors[2], ButterVertBackColors[3], 90);
                    G.FillPath(buttonrect, Draw.RoundRect(tabrect, 5));
                    G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(ButterVertForeColors[0]), textRectangle, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });

                }
                else
                {
                    Rectangle tabrect = new Rectangle(new Point(GetTabRect(i).Location.X + 2, GetTabRect(i).Location.Y + 1), new Size(GetTabRect(i).Width - 2, GetTabRect(i).Height - 3));
                    LinearGradientBrush buttonrect = new LinearGradientBrush(tabrect, ButterVertBackColors[4], ButterVertBackColors[5], 90);
                    G.FillPath(buttonrect, Draw.RoundRect(tabrect, 5));
                    G.DrawString(TabPages[i].Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), new SolidBrush(ButterVertForeColors[0]), textRectangle, new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });

                }
            }
            e.Graphics.DrawImage(b, new Point(0, 0));
            //G.Dispose();
            //b.Dispose();
        }

        #endregion

    }


}

