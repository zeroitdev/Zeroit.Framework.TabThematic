// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="NS.cs" company="Zeroit Dev Technologies">
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
        //private Color[] nsBorderColors = new Color[]
        //{
        //    Color.FromArgb(55, 55, 55),
        //    Color.FromArgb(24, 24, 24),
        //    Color.FromArgb(45, 45, 45)
        //};

        //private Color[] nsBackColors = new Color[]
        //{
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(45, 45, 45),

        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(24, 24, 24),
        //    Color.FromArgb(51, 181, 229),
        //    Color.FromArgb(65, 65, 65)
        //};

        //private Color[] nsForeColors = new Color[]
        //{
        //    Color.Black,
        //    Color.WhiteSmoke
        //}; 
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the ns fore colors.
        /// </summary>
        /// <value>The ns fore colors.</value>
        [Browsable(false)]
        public Color[] NsForeColors
        {
            get { return tabVerticalInput.NsForeColors; }
            set {
                tabVerticalInput.NsForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ns back colors.
        /// </summary>
        /// <value>The ns back colors.</value>
        [Browsable(false)]
        public Color[] NsBackColors
        {
            get => tabVerticalInput.NsBackColors;
            set {
                tabVerticalInput.NsBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ns border colors.
        /// </summary>
        /// <value>The ns border colors.</value>
        [Browsable(false)]
        public Color[] NsBorderColors
        {
            get => tabVerticalInput.NsBorderColors;
            set {
                tabVerticalInput.NsBorderColors = value;
                Invalidate();
            }
        }

        #endregion

        #region Brushes
        /// <summary>
        /// The g p1
        /// </summary>
        private GraphicsPath GP1;
        /// <summary>
        /// The g p2
        /// </summary>
        private GraphicsPath GP2;
        /// <summary>
        /// The g p3
        /// </summary>
        private GraphicsPath GP3;
        /// <summary>
        /// The g p4
        /// </summary>
        private GraphicsPath GP4;
        /// <summary>
        /// The r1
        /// </summary>
        private Rectangle R1;
        /// <summary>
        /// The r2
        /// </summary>
        private Rectangle R2;
        /// <summary>
        /// The p b1
        /// </summary>
        private PathGradientBrush PB1;
        /// <summary>
        /// The t p1
        /// </summary>
        private TabPage TP1;
        /// <summary>
        /// The s f1
        /// </summary>
        private StringFormat SF1;
        /// <summary>
        /// The offset
        /// </summary>
        private int Offset;
        /// <summary>
        /// The item height
        /// </summary>
        private int ItemHeight;


        #endregion

        #region Constructor
        /// <summary>
        /// Nses the tab control.
        /// </summary>
        public void NSTabControl()
        {
            SetStyle((ControlStyles)139286, true);
            SetStyle(ControlStyles.Selectable, false);

            SizeMode = TabSizeMode.Fixed;
            Alignment = TabAlignment.Left;
            ItemSize = new Size(28, 115);

            DrawMode = TabDrawMode.OwnerDrawFixed;

            SF1 = new StringFormat();
            SF1.LineAlignment = StringAlignment.Center;
        }
        #endregion

        #region Paint and Methods

        /// <summary>
        /// Nses the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void NSOnPaint(PaintEventArgs e)
        {

            G.Clear(NsBackColors[0]);

            try
            {
                SelectedTab.BackColor = NsBackColors[1];
            }
            catch
            {
            }

            ItemHeight = ItemSize.Height + 2;

            GP1 = Draw.CreateRound(0, 0, ItemHeight + 3, Height - 1, 7);
            GP2 = Draw.CreateRound(1, 1, ItemHeight + 3, Height - 3, 7);

            PB1 = new PathGradientBrush(GP1);
            PB1.CenterColor = NsBackColors[2];
            PB1.SurroundColors = new Color[] { NsBackColors[3] };
            PB1.FocusScales = new PointF(0.8f, 0.95f);

            G.FillPath(PB1, GP1);

            G.DrawPath(new Pen(NsBorderColors[0]), GP1);
            G.DrawPath(new Pen(NsBorderColors[1]), GP2);

            for (int I = 0; I <= TabCount - 1; I++)
            {
                R1 = GetTabRect(I);
                R1.Y += 2;
                R1.Height -= 3;
                R1.Width += 1;
                R1.X -= 1;

                TP1 = TabPages[I];
                Offset = 0;

                if (SelectedIndex == I)
                {
                    G.FillRectangle(new SolidBrush(NsBackColors[4]), R1);

                    for (int J = 0; J <= 1; J++)
                    {
                        G.FillRectangle(new SolidBrush(NsBackColors[5]), R1.X + 5 + (J * 5), R1.Y + 6, 2, R1.Height - 9);

                        G.SmoothingMode = Smoothing;
                        G.FillRectangle(new SolidBrush(NsBackColors[6]), R1.X + 5 + (J * 5), R1.Y + 5, 2, R1.Height - 9);
                        G.SmoothingMode = Smoothing;

                        Offset += 5;
                    }

                    G.DrawRectangle(new Pen(NsBorderColors[2], 2), R1.X + 1, R1.Y - 1, R1.Width, R1.Height + 2);
                    G.DrawRectangle(new Pen(NsBorderColors[0]), R1.X + 1, R1.Y + 1, R1.Width - 2, R1.Height - 2);
                    G.DrawRectangle(new Pen(NsBorderColors[1]), R1);
                }
                else
                {
                    for (int J = 0; J <= 1; J++)
                    {
                        G.FillRectangle(new SolidBrush(NsBackColors[5]), R1.X + 5 + (J * 5), R1.Y + 6, 2, R1.Height - 9);

                        G.SmoothingMode = Smoothing;
                        G.FillRectangle(new SolidBrush(NsBackColors[7]), R1.X + 5 + (J * 5), R1.Y + 5, 2, R1.Height - 9);
                        G.SmoothingMode = Smoothing;

                        Offset += 5;
                    }
                }

                R1.X += 5 + Offset;

                R2 = R1;
                R2.Y += 1;
                R2.X += 1;

                G.DrawString(TP1.Text, Font, new SolidBrush(NsForeColors[0]), R2, SF1);
                G.DrawString(TP1.Text, Font, new SolidBrush(NsForeColors[0]), R1, SF1);
            }

            GP3 = Draw.CreateRound(ItemHeight, 0, Width - ItemHeight - 1, Height - 1, 7);
            GP4 = Draw.CreateRound(ItemHeight + 1, 1, Width - ItemHeight - 3, Height - 3, 7);

            G.DrawPath(new Pen(NsBorderColors[1]), GP3);
            G.DrawPath(new Pen(NsBorderColors[0]), GP4);
        }

        /// <summary>
        /// Nses the on control added.
        /// </summary>
        /// <param name="e">The <see cref="ControlEventArgs"/> instance containing the event data.</param>
        private void NSOnControlAdded(ControlEventArgs e)
        {
            if (e.Control is TabPage)
            {
                e.Control.BackColor = Color.FromArgb(50, 50, 50);
            }

        } 
        #endregion

    }
}
