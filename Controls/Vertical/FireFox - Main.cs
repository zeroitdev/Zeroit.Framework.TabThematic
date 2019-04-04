// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FireFox - Main.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
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

        //private Color[] fireFoxBackColors = new Color[]
        //{
        //    Color.White,
        //    Color.FromArgb(66, 79, 90),
        //    Color.FromArgb(52, 63, 72),
        //    Color.FromArgb(255, 175, 54),
        //    Color.FromArgb(66, 79, 90)
        //};


        //private Color[] fireFoxForeColors = new Color[]
        //{
        //    Color.FromArgb(66, 79, 90),
        //    Color.FromArgb(245, Color.Gray),
        //    Color.FromArgb(192, Color.Gray)
        //};

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the fire fox back colors.
        /// </summary>
        /// <value>The fire fox back colors.</value>
        [Browsable(false)]
        public Color[] FireFoxBackColors
        {
            get => tabVerticalInput.FireFoxBackColors;
            set
            {
                tabVerticalInput.FireFoxBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the fire fox fore colors.
        /// </summary>
        /// <value>The fire fox fore colors.</value>
        [Browsable(false)]
        public Color[] FireFoxForeColors
        {
            get => tabVerticalInput.FireFoxForeColors;
            set { tabVerticalInput.FireFoxForeColors = value; Invalidate(); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// The fire fox fc
        /// </summary>
        private Color fireFoxFC;

        /// <summary>
        /// Firefoxes the main tab control.
        /// </summary>
        public void FirefoxMainTabControl()
        {
            DoubleBuffered = true;
            ItemSize = new Size(43, 152);
            Alignment = TabAlignment.Left;
            SizeMode = TabSizeMode.Fixed;

        }

        #endregion

        #region Paint and Methods

        /// <summary>
        /// Fires the fox main on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void FireFoxMainOnPaint(PaintEventArgs e)
        {
            Rectangle fireFoxTabRect;

            G.Clear(FireFoxBackColors[1]);

            

            for (int i = 0; i <= TabPages.Count - 1; i++)
            {
                fireFoxTabRect = GetTabRect(i);

                TabPages[i].BackColor = FireFoxBackColors[0];

                if (SelectedIndex == i)
                {
                    using (SolidBrush B = new SolidBrush(FireFoxBackColors[2]))
                    {
                        G.FillRectangle(B, fireFoxTabRect);
                    }

                    fireFoxFC = FireFoxForeColors[1];

                    using (SolidBrush B = new SolidBrush(FireFoxBackColors[3]))
                    {
                        G.FillRectangle(B, new Rectangle(fireFoxTabRect.Location.X - 3, fireFoxTabRect.Location.Y + 1, 5, fireFoxTabRect.Height - 2));
                    }

                }
                else
                {
                    fireFoxFC = FireFoxForeColors[2] /*Helper.GreyColor(192)*/;

                    using (SolidBrush B = new SolidBrush(FireFoxBackColors[4]))
                    {
                        G.FillRectangle(B, fireFoxTabRect);
                    }

                }

                using (SolidBrush B = new SolidBrush(fireFoxFC))
                {
                    G.DrawString(TabPages[i].Text, Font, B, new Point(fireFoxTabRect.X + 50, fireFoxTabRect.Y + 12));
                }

                if ((ImageList != null))
                {
                    if (!(TabPages[i].ImageIndex < 0))
                    {
                        G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Rectangle(fireFoxTabRect.X + 19, fireFoxTabRect.Y + ((fireFoxTabRect.Height / 2) - 10), 18, 18));
                    }
                }

            }

        }

        /// <summary>
        /// Fires the fox on create control.
        /// </summary>
        private void FireFoxOnCreateControl()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Fires the fox main on control added.
        /// </summary>
        /// <param name="e">The <see cref="ControlEventArgs"/> instance containing the event data.</param>
        private void FireFoxMainOnControlAdded(ControlEventArgs e)
        {
            try
            {
                for (int i = 0; i <= TabPages.Count - 1; i++)
                {
                    TabPages[i].BackColor = FireFoxBackColors[0];
                    TabPages[i].ForeColor = FireFoxForeColors[0];

                }
            }
            catch
            {
            }
        }


        #endregion

    }

}

