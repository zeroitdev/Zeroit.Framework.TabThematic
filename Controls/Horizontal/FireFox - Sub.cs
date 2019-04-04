// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FireFox - Sub.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

using Zeroit.Framework.TabThematic.ThemeManagers;

namespace Zeroit.Framework.TabThematic.Controls
{

    /// <summary>
    /// Class ZeroitThematicHorizontalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicHorizontalTab
    {
        #region Private Fields
        //private Color[] fireFoxBackColors = new Color[]
        //{
        //    Color.White,
        //    Color.LightGray,
        //    Color.Gray,
        //    Color.White
        //};

        //private Color[] fireFoxBorderColors = new Color[]
        //{
        //    Color.FromArgb(255, 149, 0),
        //    Color.SlateGray
        //};

        //private Color[] fireFoxForeColors = new Color[]
        //{
        //    Color.FromArgb(56, 69, 80)
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
            get => tabHorizontalInput.FireFoxBackColors;
            set
            {
                tabHorizontalInput.FireFoxBackColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the fire fox border colors.
        /// </summary>
        /// <value>The fire fox border colors.</value>
        [Browsable(false)]
        public Color[] FireFoxBorderColors
        {
            get => tabHorizontalInput.FireFoxBorderColors;
            set { tabHorizontalInput.FireFoxBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the fire fox fore colors.
        /// </summary>
        /// <value>The fire fox fore colors.</value>
        [Browsable(false)]
        public Color[] FireFoxForeColors
        {
            get => tabHorizontalInput.FireFoxForeColors;
            set { tabHorizontalInput.FireFoxForeColors = value; Invalidate(); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Firfoxes the sub on create control.
        /// </summary>
        private void FirfoxSubOnCreateControl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            ItemSize = new Size(100, 40);
            SizeMode = TabSizeMode.Fixed;

        }

        #endregion

        #region Paint and Methods

        /// <summary>
        /// Firefoxes the sub tab control.
        /// </summary>
        public void FirefoxSubTabControl()
        {
            //DoubleBuffered = true;
            //Alignment = TabAlignment.Top;
            //ItemSize = new Size(100, 40);
            //SizeMode = TabSizeMode.Fixed;

            DoubleBuffered = true;
            Alignment = TabAlignment.Top;
        }


        /// <summary>
        /// Fires the fox sub on control added.
        /// </summary>
        /// <param name="e">The <see cref="ControlEventArgs"/> instance containing the event data.</param>
        private void FireFoxSubOnControlAdded(ControlEventArgs e)
        {
            try
            {
                for (int i = 0; i <= TabPages.Count - 1; i++)
                {
                    TabPages[i].BackColor = FireFoxBackColors[0];
                    TabPages[i].ForeColor = Color.FromArgb(66, 79, 90);
                    TabPages[i].Font = Font;
                }
            }
            catch
            {
            }
        }


        /// <summary>
        /// Fires the fox sub on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void FireFoxSubOnPaint(PaintEventArgs e)
        {
            
            Rectangle fireFoxTabRect;

            G.Clear(Parent.BackColor);


            for (int i = 0; i <= TabPages.Count - 1; i++)
            {
                fireFoxTabRect = GetTabRect(i);


                if (GetTabRect(i).Contains(this.PointToClient(Cursor.Position)) & !(SelectedIndex == i))
                {
                    using (SolidBrush B = new SolidBrush(FireFoxBackColors[1]))
                    {
                        G.FillRectangle(B, new Rectangle(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2, GetTabRect(i).Width, GetTabRect(i).Height + 1));
                    }


                }
                else if (SelectedIndex == i)
                {
                    using (SolidBrush B = new SolidBrush(FireFoxBackColors[2]))
                    {
                        G.FillRectangle(B, new Rectangle(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2, GetTabRect(i).Width, GetTabRect(i).Height + 1));
                    }

                    using (Pen P = new Pen(FireFoxBorderColors[0], 4))
                    {
                        G.DrawLine(P, new Point(fireFoxTabRect.X - 2, fireFoxTabRect.Y + ItemSize.Height - 2), new Point(fireFoxTabRect.X + fireFoxTabRect.Width - 2, fireFoxTabRect.Y + ItemSize.Height - 2));
                    }

                }
                else if (!(SelectedIndex == i)) 
                {
                    G.FillRectangle(new SolidBrush(FireFoxBackColors[2]), GetTabRect(i));
                }

                using (SolidBrush B = new SolidBrush(FireFoxForeColors[0]))
                {
                    Helper.CenterStringTab(G, TabPages[i].Text, Font, B, GetTabRect(i));
                }

            }

            using (Pen P = new Pen(FireFoxBorderColors[1]))
            {
                G.DrawLine(P, new Point(0, ItemSize.Height + 2), new Point(Width, ItemSize.Height + 2));
            }
            
        }

        #endregion

    }

}

