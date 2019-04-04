// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FlatUI.cs" company="Zeroit Dev Technologies">
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
using System;
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

        //private Color flatBGColor = Color.FromArgb(60, 70, 73);
        //private Color flatBaseColor = Color.FromArgb(45, 47, 49);
        //private Color flatActiveColor = Color.FromArgb(35, 168, 109);
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the color of the flat base.
        /// </summary>
        /// <value>The color of the flat base.</value>
        [Browsable(false)]
        public Color FlatBaseColor
        {
            get { return tabHorizontalInput.FlatBaseColor; }
            set { tabHorizontalInput.FlatBaseColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the flat active.
        /// </summary>
        /// <value>The color of the flat active.</value>
        [Browsable(false)]
        public Color FlatActiveColor
        {
            get { return tabHorizontalInput.FlatActiveColor; }
            set { tabHorizontalInput.FlatActiveColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the flat tab back.
        /// </summary>
        /// <value>The color of the flat tab back.</value>
        [Browsable(false)]
        public Color FlatTabBackColor
        {
            get { return tabHorizontalInput.FlatTabBackColor; }
            set { tabHorizontalInput.FlatTabBackColor = value; Invalidate(); }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Flats the tab control.
        /// </summary>
        private void FlatTabControl()
        {
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(120, 40);
            Alignment = TabAlignment.Top;
        }

        #endregion

        #region Paint

        /// <summary>
        /// Flats the tab on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.Exception">
        /// </exception>
        private void FlatTabOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            int W = Width - 1;
            int H = Height - 1;


            G.Clear(FlatBaseColor);

            try
            {
                SelectedTab.BackColor = FlatTabBackColor;
            }
            catch
            {
            }

            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle Base = new Rectangle(new Point(GetTabRect(i).Location.X + 2, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width, GetTabRect(i).Height));
                Rectangle BaseSize = new Rectangle(Base.Location, new Size(Base.Width, Base.Height));

                if (i == SelectedIndex)
                {
                    //-- Base
                    G.FillRectangle(new SolidBrush(FlatBaseColor), BaseSize);

                    //-- Gradiant
                    //.fill
                    G.FillRectangle(new SolidBrush(FlatActiveColor), BaseSize);

                    //-- ImageList
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                //-- Image
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(BaseSize.Location.X + 8, BaseSize.Location.Y + 6));
                                //-- Text
                                G.DrawString("      " + TabPages[i].Text, Font, new SolidBrush(ForeColor), BaseSize, Draw.CenterSF);
                            }
                            else
                            {
                                //-- Text
                                G.DrawString(TabPages[i].Text, Font, new SolidBrush(ForeColor), BaseSize, Draw.CenterSF);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        //-- Text
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(ForeColor), BaseSize, Draw.CenterSF);
                    }
                }
                else
                {
                    //-- Base
                    G.FillRectangle(new SolidBrush(FlatBaseColor), BaseSize);

                    //-- ImageList
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                //-- Image
                                G.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(BaseSize.Location.X + 8, BaseSize.Location.Y + 6));
                                //-- Text
                                G.DrawString("      " + TabPages[i].Text, Font, new SolidBrush(ForeColor), BaseSize, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                //-- Text
                                G.DrawString(TabPages[i].Text, Font, new SolidBrush(ForeColor), BaseSize, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        //-- Text
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(ForeColor), BaseSize, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }
                }
            }

            //G.Dispose();
            //e.Graphics.InterpolationMode = (InterpolationMode)7;
            //e.Graphics.DrawImageUnscaled(B, 0, 0);
            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //B.Dispose();
        }

        #endregion

    }

}

