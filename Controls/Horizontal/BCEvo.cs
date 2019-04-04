// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BCEvo.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
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
        //private Color[] bCEvoForeColors = new Color[]
        //{
        //    Color.FromArgb(255, 255, 255),
        //    Color.FromArgb(100, 100, 100)
        //};

        //private Color[] bCEvoBorderColors = new Color[]
        //{
        //    Color.Black,
        //    Color.Black
        //};

        //private Color[] bCEvoBackColors = new Color[]
        //{
        //    Color.FromArgb(255, 55, 55, 55), Color.FromArgb(255, 22, 22, 22),
        //    Color.FromArgb(100, 0, 0), Color.FromArgb(60, 0, 0),
        //    Color.FromArgb(25, Color.White),
        //    Color.FromArgb(90, 90, 90)

        //};

        //private int borderWidth = 2;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the bc evo fore colors.
        /// </summary>
        /// <value>The bc evo fore colors.</value>
        [Browsable(false)]
        public Color[] BCEvoForeColors
        {
            get => tabHorizontalInput.BCEvoForeColors;
            set
            {
                tabHorizontalInput.BCEvoForeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bc evo border colors.
        /// </summary>
        /// <value>The bc evo border colors.</value>
        [Browsable(false)]
        public Color[] BCEvoBorderColors
        {
            get => tabHorizontalInput.BCEvoBorderColors;
            set { tabHorizontalInput.BCEvoBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the bc evo back colors.
        /// </summary>
        /// <value>The bc evo back colors.</value>
        [Browsable(false)]
        public Color[] BCEvoBackColors
        {
            get => tabHorizontalInput.BCEvoBackColors;
            set { tabHorizontalInput.BCEvoBackColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>The width of the border.</value>
        [Browsable(false)]
        public int BorderWidth
        {
            get => tabHorizontalInput.BorderWidth;
            set
            {
                tabHorizontalInput.BorderWidth = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint and Overrides

        /// <summary>
        /// The draw gradient brush
        /// </summary>
        private LinearGradientBrush DrawGradientBrush;
        /// <summary>
        /// The control b color
        /// </summary>
        private Color _ControlBColor;
        /// <summary>
        /// The tc brush
        /// </summary>
        private LinearGradientBrush TCBrush;
        /// <summary>
        /// The tci brush
        /// </summary>
        private LinearGradientBrush TCIBrush;
        /// <summary>
        /// The TCT brush
        /// </summary>
        private SolidBrush TCTBrush = new SolidBrush(Color.Empty);
        /// <summary>
        /// The tcig brush
        /// </summary>
        private SolidBrush TCIGBrush;
        /// <summary>
        /// The tc item b
        /// </summary>
        private Rectangle TCItemB;
        /// <summary>
        /// The tc item r
        /// </summary>
        private Rectangle TCItemR;
        /// <summary>
        /// The tc item g
        /// </summary>
        private Rectangle TCItemG;
        /// <summary>
        /// The tctat
        /// </summary>
        private StringFormat TCTAT = new StringFormat();

        /// <summary>
        /// Bcs the evo on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void BCEvoOnPaint(PaintEventArgs e)
        {
            TCBrush = new LinearGradientBrush(ClientRectangle, BCEvoBackColors[0], BCEvoBackColors[1], LinearGradientMode.Vertical);
            TCIBrush = new LinearGradientBrush(ClientRectangle, BCEvoBackColors[2], BCEvoBackColors[3], LinearGradientMode.Vertical);
            TCIGBrush = new SolidBrush(BCEvoBackColors[4]);
            TCTAT.LineAlignment = StringAlignment.Center;
            TCTAT.Alignment = StringAlignment.Center;

            G.FillRectangle(TCBrush, ClientRectangle);
            G.TextRenderingHint = TextRenderingHint.AntiAlias;

            for (int TabItemIndex = 0; TabItemIndex <= this.TabCount - 1; TabItemIndex++)
            {
                TCItemB = GetTabRect(TabItemIndex);

                //If TabItemIndex = 0 Then
                //    TCItemR = New Rectangle(10, TCItemB.Y + 1, TCItemB.Width - 18, TCItemB.Height - 5)
                //    TCItemG = New Rectangle(10, TCItemB.Y + 1, TCItemB.Width - 18, CInt(TCItemB.Height / 2 - 2))
                //Else
                //    TCItemR = New Rectangle(TCItemB.X + 8, TCItemB.Y + 1, TCItemB.Width - 17, TCItemB.Height - 5)
                //    TCItemG = New Rectangle(TCItemB.X + 8, TCItemB.Y + 1, TCItemB.Width - 17, CInt(TCItemB.Height / 2 - 2))
                //End If

                if (TabItemIndex == SelectedIndex)
                {
                }
                else
                {
                }

                if (SelectedIndex == TabItemIndex)
                {
                    TCTBrush.Color = BCEvoForeColors[0];
                    //####################################
                    //G.FillRectangle(TCIBrush, TCItemR)
                    //G.FillRectangle(TCIGBrush, TCItemG) TabPage Outline + Gradient + Gloss
                    //G.DrawRectangle(Pens.Black, TCItemR)
                    //####################################
                }
                else
                {
                    TCTBrush.Color = BCEvoForeColors[1];
                }
                try
                {
                    G.DrawString(TabPages[TabItemIndex].Text, Font, TCTBrush, new Rectangle(new Point(GetTabRect(TabItemIndex).Location.X, GetTabRect(TabItemIndex).Location.Y - 2), GetTabRect(TabItemIndex).Size), TCTAT);
                    TabPages[TabItemIndex].BackColor = BCEvoBackColors[5];
                }
                catch
                {
                }
            }
            DrawBorders(new Pen(BCEvoBorderColors[0]));
            DrawBorders(new Pen(BCEvoBorderColors[1]), BorderWidth);
        }


        #endregion
        
    }
}
