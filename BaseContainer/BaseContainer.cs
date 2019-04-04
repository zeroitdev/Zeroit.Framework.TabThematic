// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BaseContainer.cs" company="Zeroit Dev Technologies">
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
    public partial class ZeroitThematicHorizontalTab : TabControl
    {

        #region Private Fields

        /// <summary>
        /// The g
        /// </summary>
        private Graphics G;

        //private TabStyles tabStyle = TabStyles.Aresio;

        //private int _Speed = 10;

        /// <summary>
        /// The old index
        /// </summary>
        int OldIndex;

        /// <summary>
        /// The tab horizontal input
        /// </summary>
        private TabHorizontalInput tabHorizontalInput = new TabHorizontalInput(
           new Color[]
        {
            Color.FromArgb(255,255,255),
            Color.FromArgb(80, 80, 80)
        }, new Color[]
        {
            Color.FromArgb(90, Color.Gray),
            Color.FromArgb(150, 151, 153),
            Color.FromArgb(150, 151, 153)

        }, new Color[]
        {
            Color.FromArgb(236, 237, 239),
            Color.FromArgb(10, Color.Black),
            Color.FromArgb(236, 237, 239),
            Color.FromArgb(236, 237, 239)

        }, true);

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the tab style.
        /// </summary>
        /// <value>The tab style.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">value - null</exception>
        public TabStyles TabStyle
        {
            get { return tabHorizontalInput.TabStyle; }
            set
            {
                switch (value)
                {
                    case TabStyles.Aresio:
                        AresioTabControl();
                        break;
                    case TabStyles.ASC:
                        ASCTabControl();
                        break;
                    case TabStyles.BCEvo:
                        break;
                    case TabStyles.Butter:
                        ButterscotchTabControl();
                        break;
                    case TabStyles.CarbonFibre:
                        CarbonFiberTabControl();
                        break;
                    case TabStyles.CrystalClear:
                        CrystalClearTabControl();
                        break;
                    case TabStyles.FirefoxSub:
                        FirefoxSubTabControl();
                        break;
                    case TabStyles.Flat:
                        FlatTabControl();
                        break;
                    case TabStyles.iTab:
                        iTabControl();
                        break;
                    case TabStyles.Login:
                        LogInTabControl();
                        break;
                    case TabStyles.MetroDisk:
                        MetroDiskTabControl();
                        break;
                    case TabStyles.Reactor:
                        ReactorTabControl();
                        break;
                    case TabStyles.Simpla:
                        SimplaTabControl();
                        break;
                    case TabStyles.Unique:
                        UniqueTabControl();
                        break;
                    case TabStyles.VTab:
                        VTabControl();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }

                tabHorizontalInput.TabStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the tab horizontal input.
        /// </summary>
        /// <value>The tab horizontal input.</value>
        public TabHorizontalInput TabHorizontalInput
        {
            get { return tabHorizontalInput; }
            set
            {
                tabHorizontalInput = value;
                Invalidate();
            }
        }

        #region Smoothing Mode

        /// <summary>
        /// The smoothing
        /// </summary>
        private SmoothingMode smoothing = SmoothingMode.HighQuality;

        /// <summary>
        /// Gets or sets the smoothing.
        /// </summary>
        /// <value>The smoothing.</value>
        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                smoothing = value;
                Invalidate();
            }
        }

        #endregion

        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        /// <summary>
        /// The textrendering
        /// </summary>
        TextRenderingHint textrendering = TextRenderingHint.ClearTypeGridFit;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }


        #endregion

        #region Interpolation Mode

        /// <summary>
        /// The interpolation mode
        /// </summary>
        private InterpolationMode interpolationMode = InterpolationMode.HighQualityBicubic;

        /// <summary>
        /// Gets or sets the interpolation mode.
        /// </summary>
        /// <value>The interpolation mode.</value>
        public InterpolationMode InterpolationMode
        {
            get { return interpolationMode; }
            set
            {
                interpolationMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Pixel Offset
        /// <summary>
        /// The pixel offset mode
        /// </summary>
        private PixelOffsetMode pixelOffsetMode = PixelOffsetMode.None;

        /// <summary>
        /// Gets or sets the pixel offset mode.
        /// </summary>
        /// <value>The pixel offset mode.</value>
        public PixelOffsetMode PixelOffsetMode
        {
            get { return pixelOffsetMode; }
            set
            {
                pixelOffsetMode = value;
                Invalidate();
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the speed.
        /// </summary>
        /// <value>The speed.</value>
        public int Speed
        {
            get { return tabHorizontalInput.Speed; }
            set
            {
                if (value > 20 | value < -20)
                {
                    MessageBox.Show("Speed needs to be in between -20 and 20.");
                }
                else
                {
                    tabHorizontalInput.Speed = value;
                }

                Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitThematicHorizontalTab"/> class.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public ZeroitThematicHorizontalTab()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            
            switch (TabStyle)
            {
                case TabStyles.Aresio:
                    AresioTabControl();
                    break;
                case TabStyles.ASC:
                    ASCTabControl();
                    break;
                case TabStyles.BCEvo:
                    break;
                case TabStyles.Butter:
                    ButterscotchTabControl();
                    break;
                case TabStyles.CarbonFibre:
                    CarbonFiberTabControl();
                    break;
                case TabStyles.CrystalClear:
                    CrystalClearTabControl();
                    break;
                case TabStyles.FirefoxSub:
                    FirefoxSubTabControl();
                    break;
                case TabStyles.Flat:
                    FlatTabControl();
                    break;
                case TabStyles.iTab:
                    iTabControl();
                    break;
                case TabStyles.Login:
                    LogInTabControl();
                    break;
                case TabStyles.MetroDisk:
                    MetroDiskTabControl();
                    break;
                case TabStyles.Reactor:
                    ReactorTabControl();
                    break;
                case TabStyles.Simpla:
                    SimplaTabControl();
                    break;
                case TabStyles.Unique:
                    UniqueTabControl();
                    break;
                case TabStyles.VTab:
                    VTabControl();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            //SetStyle(ControlStyles.UserPaint, true);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            G = e.Graphics;
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;

            switch (TabStyle)
            {
                case TabStyles.Aresio:
                    AresioOnPaint(e);
                    break;
                case TabStyles.ASC:
                    ASCOnPaint(e);
                    break;
                case TabStyles.BCEvo:
                    BCEvoOnPaint(e);
                    break;
                case TabStyles.Butter:
                    ButterscotchOnPaint(e);
                    break;
                case TabStyles.CarbonFibre:
                    CarbonFibreOnPaint(e);
                    break;
                case TabStyles.CrystalClear:
                    CrystalOnPaint(e);
                    break;
                case TabStyles.FirefoxSub:
                    FireFoxSubOnPaint(e);
                    break;
                case TabStyles.Flat:
                    FlatTabOnPaint(e);
                    break;
                case TabStyles.iTab:
                    iTabOnPaint(e);
                    break;
                case TabStyles.Login:
                    LoginOnPaint(e);
                    break;
                case TabStyles.MetroDisk:
                    MetroDiskOnPaint(e);
                    break;
                case TabStyles.Reactor:
                    ReactorOnPaint(e);
                    break;
                case TabStyles.Simpla:
                    SimplaOnPaint(e);
                    break;
                case TabStyles.Unique:
                    UniqueOnPaint(e);
                    break;
                case TabStyles.VTab:
                    VOnPaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.ControlAdded" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ControlEventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            switch (TabStyle)
            {
                case TabStyles.Aresio:
                    //FireFoxMainOnControlAdded(e);
                    break;
                case TabStyles.ASC:
                    break;
                case TabStyles.BCEvo:
                    break;
                case TabStyles.Butter:
                    break;
                case TabStyles.CarbonFibre:
                    break;
                case TabStyles.CrystalClear:
                    break;
                case TabStyles.FirefoxSub:
                    FireFoxSubOnControlAdded(e);
                    break;
                case TabStyles.Flat:
                    break;
                case TabStyles.iTab:
                    break;
                case TabStyles.Login:
                    break;
                case TabStyles.MetroDisk:
                    break;
                case TabStyles.Reactor:
                    break;
                case TabStyles.Simpla:
                    break;
                case TabStyles.Unique:
                    break;
                case TabStyles.VTab:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// This member overrides <see cref="M:System.Windows.Forms.Control.CreateHandle" />.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void CreateHandle()
        {
            base.CreateHandle();

            switch (TabStyle)
            {
                case TabStyles.Aresio:
                    AresioCreateHandle();
                    break;
                case TabStyles.ASC:
                    ASCCreateHandle();
                    break;
                case TabStyles.BCEvo:
                    break;
                case TabStyles.Butter:
                    break;
                case TabStyles.CarbonFibre:
                    break;
                case TabStyles.CrystalClear:
                    break;
                case TabStyles.FirefoxSub:
                    FirfoxSubOnCreateControl();
                    break;
                case TabStyles.Flat:
                    break;
                case TabStyles.iTab:
                    break;
                case TabStyles.Login:
                    break;
                case TabStyles.MetroDisk:
                    break;
                case TabStyles.Reactor:
                    break;
                case TabStyles.Simpla:
                    break;
                case TabStyles.Unique:
                    break;
                case TabStyles.VTab:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        //protected override void OnCreateControl()
        //{
        //    //base.OnCreateControl();

        //    switch (TabStyle)
        //    {
        //        case TabStyles.Aresio:
        //            break;
        //        case TabStyles.ASC:
        //            break;
        //        case TabStyles.BCEvo:
        //            break;
        //        case TabStyles.Butter:
        //            break;
        //        case TabStyles.ButterVertical:
        //            break;
        //        case TabStyles.CarbonFibre:
        //            break;
        //        case TabStyles.CrystalClear:
        //            break;
        //        case TabStyles.DotBar:
        //            break;
        //        case TabStyles.DotBarV2:
        //            break;
        //        case TabStyles.Facebook:
        //            break;
        //        case TabStyles.FirefoxMain:
        //            FireFoxMainOnCreateControl();
        //            break;
        //        case TabStyles.FirefoxSub:
        //            FirfoxSubOnCreateControl();
        //            break;
        //        case TabStyles.Flat:
        //            break;
        //        case TabStyles.iTab:
        //            break;
        //        case TabStyles.Login:
        //            break;
        //        case TabStyles.MetroDisk:
        //            break;
        //        case TabStyles.NS:
        //            break;
        //        case TabStyles.Reactor:
        //            break;
        //        case TabStyles.Redemption:
        //            break;
        //        case TabStyles.Simpla:
        //            break;
        //        case TabStyles.SLC:
        //            break;
        //        case TabStyles.VTab:
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }
        //}

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.TabControl.Selecting" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.TabControlCancelEventArgs" /> that contains the event data.</param>
        protected override void OnSelecting(System.Windows.Forms.TabControlCancelEventArgs e)
        {
            if (OldIndex < e.TabPageIndex)
            {
                DoAnimationScrollUp(TabPages[OldIndex], TabPages[e.TabPageIndex]);
            }
            else
            {
                DoAnimationScrollDown(TabPages[OldIndex], TabPages[e.TabPageIndex]);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.TabControl.Deselecting" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.TabControlCancelEventArgs" /> that contains the event data.</param>
        protected override void OnDeselecting(System.Windows.Forms.TabControlCancelEventArgs e)
        {
            OldIndex = e.TabPageIndex;
        }

        #endregion

        #region DrawBorders

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int offset)
        {
            DrawBorders(p1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, Rectangle r, int offset)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
        {
            DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawBorders(Pen p1)
        {
            DrawBorders(p1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        protected void DrawBorders(Pen p1, Rectangle r)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height)
        {
            G.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>Pen.</returns>
        public Pen ToPen(Color color)
        {
            return new Pen(color);
        }

        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>Brush.</returns>
        public Brush ToBrush(Color color)
        {
            return new SolidBrush(color);
        }

        #endregion

        #region Animation Methods

        /// <summary>
        /// Does the animation scroll up.
        /// </summary>
        /// <param name="Control1">The control1.</param>
        /// <param name="Control2">The control2.</param>
        public void DoAnimationScrollUp(Control Control1, Control Control2)
        {
            Graphics G = Control1.CreateGraphics();
            Bitmap P1 = new Bitmap(Control1.Width, Control1.Height);
            Bitmap P2 = new Bitmap(Control2.Width, Control2.Height);
            Control1.DrawToBitmap(P1, new Rectangle(0, 0, Control1.Width, Control1.Height));
            Control2.DrawToBitmap(P2, new Rectangle(0, 0, Control2.Width, Control2.Height));

            foreach (Control c in Control1.Controls)
            {
                c.Hide();
            }
            int Slide = Control1.Height - (Control1.Height % Speed);
            int a = 0;
            for (a = 0; a >= -Slide; a += -Speed)
            {
                G.DrawImage(P1, new Rectangle(0, a, Control1.Width, Control1.Height));
                G.DrawImage(P2, new Rectangle(0, a + Control2.Height, Control2.Width, Control2.Height));
            }
            a = Control1.Width;
            G.DrawImage(P1, new Rectangle(0, a, Control1.Width, Control1.Height));
            G.DrawImage(P2, new Rectangle(0, a + Control2.Height, Control2.Width, Control2.Height));

            SelectedTab = (TabPage)Control2;

            foreach (Control c in Control2.Controls)
            {
                c.Show();
            }

            foreach (Control c in Control1.Controls)
            {
                c.Show();
            }
        }

        /// <summary>
        /// Does the animation scroll down.
        /// </summary>
        /// <param name="Control1">The control1.</param>
        /// <param name="Control2">The control2.</param>
        public void DoAnimationScrollDown(Control Control1, Control Control2)
        {
            Graphics G = Control1.CreateGraphics();
            Bitmap P1 = new Bitmap(Control1.Width, Control1.Height);
            Bitmap P2 = new Bitmap(Control2.Width, Control2.Height);
            Control1.DrawToBitmap(P1, new Rectangle(0, 0, Control1.Width, Control1.Height));
            Control2.DrawToBitmap(P2, new Rectangle(0, 0, Control2.Width, Control2.Height));
            foreach (Control c in Control1.Controls)
            {
                c.Hide();
            }
            int Slide = Control1.Height - (Control1.Height % Speed);
            int a = 0;
            for (a = 0; a <= Slide; a += Speed)
            {
                G.DrawImage(P1, new Rectangle(0, a, Control1.Width, Control1.Height));
                G.DrawImage(P2, new Rectangle(0, a - Control2.Height, Control2.Width, Control2.Height));
            }
            a = Control1.Width;
            G.DrawImage(P1, new Rectangle(0, a, Control1.Width, Control1.Height));
            G.DrawImage(P2, new Rectangle(0, a - Control2.Height, Control2.Width, Control2.Height));
            SelectedTab = (TabPage)Control2;
            foreach (Control c in Control2.Controls)
            {
                c.Show();
            }
            foreach (Control c in Control1.Controls)
            {
                c.Show();
            }
        }

        #endregion

    }
}
