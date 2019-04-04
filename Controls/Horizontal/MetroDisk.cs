// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MetroDisk.cs" company="Zeroit Dev Technologies">
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
    /// Class ZeroitThematicHorizontalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicHorizontalTab
    {

        #region Private Fields

        //private int metroDiskW;
        //private int metroDiskH;

        //private bool _Theme;

        //private Color metroDiskBaseColor = Color.FromArgb(45, 47, 49);
        //private Color metroActiveColor = Color.FromArgb(35, 168, 109);
        //private Color metroBackColor = Color.FromArgb(22, 22, 22);
        //private Color metroInactive = Color.DimGray;
        //private Color metroActive = Color.Silver;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the color of the metro disk base.
        /// </summary>
        /// <value>The color of the metro disk base.</value>
        [Browsable(false)]
        public Color MetroDiskBaseColor
        {
            get { return tabHorizontalInput.MetroDiskBaseColor; }
            set
            {
                tabHorizontalInput.MetroDiskBaseColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the metro active.
        /// </summary>
        /// <value>The color of the metro active.</value>
        [Browsable(false)]
        public Color MetroActiveColor
        {
            get { return tabHorizontalInput.MetroActiveColor; }
            set { tabHorizontalInput.MetroActiveColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the metro back.
        /// </summary>
        /// <value>The color of the metro back.</value>
        [Browsable(false)]
        public Color MetroBackColor
        {
            get { return tabHorizontalInput.MetroBackColor; }
            set
            {
                tabHorizontalInput.MetroBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the metro inactive.
        /// </summary>
        /// <value>The metro inactive.</value>
        [Browsable(false)]
        public Color MetroInactive
        {
            get { return tabHorizontalInput.MetroInactive; }
            set { tabHorizontalInput.MetroInactive = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the metro active.
        /// </summary>
        /// <value>The metro active.</value>
        [Browsable(false)]
        public Color MetroActive
        {
            get { return tabHorizontalInput.MetroActive; }
            set { tabHorizontalInput.MetroActive = value; Invalidate(); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Metroes the disk tab control.
        /// </summary>
        private void MetroDiskTabControl()
        {
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(140, 40);
            Alignment = TabAlignment.Top;

        }

        #endregion

        #region Paint

        /// <summary>
        /// Metroes the disk on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.Exception">
        /// </exception>
        private void MetroDiskOnPaint(PaintEventArgs e)
        {

            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            int metroDiskW = Width - 1;
            int metroDiskH = Height - 1;

            G.Clear(MetroDiskBaseColor);

            try
            {
                SelectedTab.BackColor = MetroBackColor;
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
                    //.FillRectangle(New SolidBrush(metroDiskBaseColor), BaseSize)

                    //-- Gradiant
                    //.fill
                    //.FillRectangle(New SolidBrush(metroActiveColor), BaseSize)

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
                                G.DrawString("      " + "MD" + TabPages[i].Text, Font, new SolidBrush(MetroInactive), BaseSize, CenterSF);
                            }
                            else
                            {
                                //-- Text
                                G.DrawString(TabPages[i].Text, Font, new SolidBrush(MetroActive), BaseSize, CenterSF);
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
                        //.DrawString(TabPages(i).Text, Font, Brushes.White, BaseSize, CenterSF)
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(MetroInactive), BaseSize, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }
                }
                else
                {
                    //-- Base
                    G.FillRectangle(new SolidBrush(MetroDiskBaseColor), BaseSize);

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
                                G.DrawString("      " + TabPages[i].Text, Font, new SolidBrush(Color.White), BaseSize, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                //-- Text
                                G.DrawString(TabPages[i].Text, Font, new SolidBrush(MetroActive), BaseSize, new StringFormat
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
                        G.DrawString(TabPages[i].Text, Font, new SolidBrush(MetroActive), BaseSize, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });


                    }
                }
            }

            G.Dispose();
            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        #endregion

    }

}

