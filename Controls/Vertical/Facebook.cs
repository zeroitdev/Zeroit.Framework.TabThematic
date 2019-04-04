// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Facebook.cs" company="Zeroit Dev Technologies">
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

        //private Color pressedTabColor = Color.FromArgb(200, 215, 237);
        //private Color hoverColor = Color.FromArgb(109, 132, 180);
        //private Color normalColor = Color.FromArgb(237, 239, 244);
        //private Color faceBookBorderColor = Color.FromArgb(139, 162, 210);
        //private Color faceBookTextColor = Color.FromArgb(58, 66, 73);
        //private Color faceBookBack = Color.FromArgb(199, 201, 207);

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the color of the normal.
        /// </summary>
        /// <value>The color of the normal.</value>
        [Browsable(false)]
        public Color NormalColor
        {
            get { return tabVerticalInput.NormalColor; }
            set { tabVerticalInput.NormalColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the hover.
        /// </summary>
        /// <value>The color of the hover.</value>
        [Browsable(false)]
        public Color HoverColor
        {
            get { return tabVerticalInput.HoverColor; }
            set { tabVerticalInput.HoverColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the pressed tab.
        /// </summary>
        /// <value>The color of the pressed tab.</value>
        [Browsable(false)]
        public Color PressedTabColor
        {
            get { return tabVerticalInput.PressedTabColor; }
            set { tabVerticalInput.PressedTabColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the face book border.
        /// </summary>
        /// <value>The color of the face book border.</value>
        [Browsable(false)]
        public Color FaceBookBorderColor
        {
            get { return tabVerticalInput.FaceBookBorderColor; }
            set { tabVerticalInput.FaceBookBorderColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the face book text.
        /// </summary>
        /// <value>The color of the face book text.</value>
        [Browsable(false)]
        public Color FaceBookTextColor
        {
            get { return tabVerticalInput.FaceBookTextColor; }
            set { tabVerticalInput.FaceBookTextColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the face book back.
        /// </summary>
        /// <value>The face book back.</value>
        [Browsable(false)]
        public Color FaceBookBack
        {
            get => tabVerticalInput.FaceBookBack;
            set {
                tabVerticalInput.FaceBookBack = value;
                Invalidate();
            }
        }

        #endregion

        #region Draw Control

        /// <summary>
        /// The hover index
        /// </summary>
        private int HoverIndex = -1;

        /// <summary>
        /// Facebooks the tab control vertical.
        /// </summary>
        private void FacebookTabControlVertical()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(44, 95);
            Font = new Font("Segoe UI", 9, FontStyle.Regular);
            DrawMode = TabDrawMode.OwnerDrawFixed;
            Alignment = TabAlignment.Left;
        }

        /// <summary>
        /// Faces the book on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void FaceBookOnMouseMove(MouseEventArgs e)
        {
            for (int I = 0; I <= TabPages.Count - 1; I++)
            {
                if (GetTabRect(I).Contains(e.Location))
                {
                    HoverIndex = I;
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
            
        }

        /// <summary>
        /// Faces the book on mouse leave.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FaceBookOnMouseLeave(EventArgs e)
        {
            HoverIndex = -1;
            Invalidate();
            base.OnMouseLeave(e);

        }

        /// <summary>
        /// Faces the book on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void FaceBookOnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            G.Clear(BackColor);

            try
            {
                SelectedTab.BackColor = NormalColor;
            }
            catch
            {
            }

            G.FillRectangle(new SolidBrush(NormalColor), new Rectangle(-2, 0, ItemSize.Height + 4, Height + 22));
            for (int i = 0; i <= TabCount - 1; i++)
            {
                if (i == SelectedIndex)
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width + 3, GetTabRect(i).Height - 1));
                    G.FillRectangle(new SolidBrush(NormalColor), x2);
                    Rectangle tabRect = new Rectangle(GetTabRect(i).Location.X - 3, GetTabRect(i).Location.Y + 2, GetTabRect(i).Size.Width + 10, GetTabRect(i).Size.Height - 11);
                    G.FillRectangle(new SolidBrush(PressedTabColor), new Rectangle(tabRect.X + 1, tabRect.Y + 1, tabRect.Width - 1, tabRect.Height - 2));
                    G.DrawRectangle(new Pen(FaceBookBorderColor), tabRect);
                    G.SmoothingMode = SmoothingMode.AntiAlias;
                }
                else
                {
                    Rectangle x2 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2), new Size(GetTabRect(i).Width - 1, GetTabRect(i).Height - 11));
                    G.FillRectangle(new SolidBrush(NormalColor), x2);
                    if (HoverIndex == i)
                    {
                        Rectangle x21 = new Rectangle(new Point(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y + 2), new Size(GetTabRect(i).Width, GetTabRect(i).Height - 11));
                        G.FillRectangle(new SolidBrush(FaceBookBack), x21);
                    }
                }
                Rectangle tabRect1 = new Rectangle(GetTabRect(i).Location.X + 3, GetTabRect(i).Location.Y + 3, GetTabRect(i).Size.Width - 20, GetTabRect(i).Size.Height - 11);
                G.DrawString(TabPages[i].Text, Font, new SolidBrush(FaceBookTextColor), tabRect1, new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                });
                G.FillRectangle(new SolidBrush(NormalColor), new Rectangle(97, 0, Width - 97, Height));
                G.DrawLine(new Pen((FaceBookBorderColor), 1), new Point(96, 0), new Point(96, Height));
            }
            G.Dispose();
            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
        
        #endregion
        
    }

}

