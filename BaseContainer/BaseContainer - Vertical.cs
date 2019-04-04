// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BaseContainer - Vertical.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
    /// Class ZeroitThematicVerticalTab.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TabControl" />
    public partial class ZeroitThematicVerticalTab : TabControl
    {

        #region Private Fields

        /// <summary>
        /// The g
        /// </summary>
        private Graphics G;

        //private TabVerticalStyles tabStyle = TabVerticalStyles.FirefoxMain;

        /// <summary>
        /// The old index
        /// </summary>
        int OldIndex;

        //private int _Speed = 5;

        /// <summary>
        /// The tab vertical input
        /// </summary>
        private TabVerticalInput tabVerticalInput = new TabVerticalInput(
            
            new Color[]
            {
                Color.White,
                Color.FromArgb(66, 79, 90),
                Color.FromArgb(52, 63, 72),
                Color.FromArgb(255, 175, 54),
                Color.FromArgb(66, 79, 90)
            }, 
            new Color[]
            {
                Color.FromArgb(66, 79, 90),
                Color.FromArgb(245, Color.Gray),
                Color.FromArgb(192, Color.Gray)
            }
            );

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the tab style.
        /// </summary>
        /// <value>The tab style.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">value - null</exception>
        public TabVerticalStyles TabStyle
        {
            get { return tabVerticalInput.TabStyle; }
            set
            {
                switch (value)
                {
                    case TabVerticalStyles.ButterVertical:
                        ButterscotchVerticalTabControl();
                        break;
                    case TabVerticalStyles.Chrome:
                        ChromeTabcontrol();
                        break;
                    case TabVerticalStyles.DotBar:
                        DotNetBarTabcontrol();
                        break;
                    case TabVerticalStyles.DotBarV2:
                        DotnetBarV2Tabcontrol();
                        break;

                    case TabVerticalStyles.EightBall:
                        EightBallTabControl();
                        break;
                    case TabVerticalStyles.Empire:
                        EmpireTabcontrol();
                        break;
                    case TabVerticalStyles.FirefoxMain:
                        FirefoxMainTabControl();
                        break;
                    case TabVerticalStyles.Facebook:
                        FacebookTabControlVertical();
                        break;
                    case TabVerticalStyles.NS:
                        NSTabControl();
                        break;
                    case TabVerticalStyles.SLC:
                        NSTabControl();
                        break;
                    case TabVerticalStyles.Meph:
                        MephTabcontrol();
                        break;
                    case TabVerticalStyles.Redemption:
                        RedemptionTabControl();
                        break;
                    case TabVerticalStyles.xVisual:
                        xVisualTabControl();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }

                tabVerticalInput.TabStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the tab vertical input.
        /// </summary>
        /// <value>The tab vertical input.</value>
        public TabVerticalInput TabVerticalInput
        {
            get { return tabVerticalInput; }
            set
            {
                tabVerticalInput = value;
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
        TextRenderingHint textrendering = TextRenderingHint.AntiAlias;

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
            get { return tabVerticalInput.Speed; }
            set
            {
                if (value > 20 | value < -20)
                {
                    MessageBox.Show("Speed needs to be in between -20 and 20.");
                }
                else
                {
                    tabVerticalInput.Speed = value;
                }

                Invalidate();
            }
        }


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitThematicVerticalTab"/> class.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public ZeroitThematicVerticalTab()
        {

            switch (TabStyle)
            {
                case TabVerticalStyles.ButterVertical:
                    ButterscotchVerticalTabControl();
                    break;
                case TabVerticalStyles.Chrome:
                    ChromeTabcontrol();
                    break;
                case TabVerticalStyles.DotBar:
                    DotNetBarTabcontrol();
                    break;
                case TabVerticalStyles.DotBarV2:
                    DotnetBarV2Tabcontrol();
                    break;

                case TabVerticalStyles.EightBall:
                    EightBallTabControl();
                    break;
                case TabVerticalStyles.Empire:
                    EmpireTabcontrol();
                    break;
                case TabVerticalStyles.Facebook:
                    FacebookTabControlVertical();
                    break;
                case TabVerticalStyles.FirefoxMain:
                    FirefoxMainTabControl();
                    break;
                case TabVerticalStyles.NS:
                    NSTabControl();
                    break;
                case TabVerticalStyles.SLC:
                    SLCTabControl();
                    break;
                case TabVerticalStyles.Meph:
                    MephTabcontrol();
                    break;
                case TabVerticalStyles.Redemption:
                    RedemptionTabControl();
                    break;
                case TabVerticalStyles.xVisual:
                    xVisualTabControl();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            
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
            G.PixelOffsetMode = PixelOffsetMode;

            switch (TabStyle)
            {
                case TabVerticalStyles.ButterVertical:
                    ButterscotchVerticalOnPaint(e);
                    break;
                case TabVerticalStyles.Chrome:
                    ChromeOnPaint(e);
                    break;
                case TabVerticalStyles.DotBar:
                    DotnetBarOnPaint(e);
                    break;
                case TabVerticalStyles.DotBarV2:
                    DotnetBarV2OnPaint(e);
                    break;
                case TabVerticalStyles.EightBall:
                    EightBallOnPaint(e);
                    break;
                case TabVerticalStyles.Empire:
                    EmpireOnPaint(e);
                    break;
                case TabVerticalStyles.Facebook:
                    FaceBookOnPaint(e);
                    break;
                case TabVerticalStyles.FirefoxMain:
                    FireFoxMainOnPaint(e);
                    break;
                case TabVerticalStyles.NS:
                    NSOnPaint(e);
                    break;
                case TabVerticalStyles.SLC:
                    SLCOnPaint(e);
                    break;
                case TabVerticalStyles.Meph:
                    MephOnPaint(e);
                    break;
                case TabVerticalStyles.Redemption:
                    RedemptionOnPaint(e);
                    break;
                case TabVerticalStyles.xVisual:
                    xVisualOnPaint(e);
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
                
                case TabVerticalStyles.ButterVertical:
                    break;
                case TabVerticalStyles.Chrome:
                    break;
                case TabVerticalStyles.DotBar:
                    break;
                case TabVerticalStyles.DotBarV2:
                    break;
                case TabVerticalStyles.EightBall:
                    break;
                case TabVerticalStyles.Empire:
                    break;
                case TabVerticalStyles.FirefoxMain:
                    FireFoxMainOnControlAdded(e);
                    break;
                case TabVerticalStyles.Facebook:
                    break;
                case TabVerticalStyles.NS:
                    //NSOnControlAdded(e);
                    break;
                case TabVerticalStyles.SLC:
                    break;
                case TabVerticalStyles.Meph:
                    break;
                case TabVerticalStyles.Redemption:
                    break;
                case TabVerticalStyles.xVisual:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            switch (TabStyle)
            {
                case TabVerticalStyles.ButterVertical:
                    break;
                case TabVerticalStyles.Chrome:
                    break;
                case TabVerticalStyles.DotBar:
                    break;
                case TabVerticalStyles.DotBarV2:
                    break;
                case TabVerticalStyles.EightBall:
                    break;
                case TabVerticalStyles.Empire:
                    EmpireOnMouseMove(e);
                    break;
                case TabVerticalStyles.Facebook:
                    FaceBookOnMouseMove(e);
                    break;
                case TabVerticalStyles.FirefoxMain:
                    break;
                case TabVerticalStyles.NS:
                    break;
                case TabVerticalStyles.SLC:
                    break;
                case TabVerticalStyles.Meph:
                    break;
                case TabVerticalStyles.Redemption:
                    break;
                case TabVerticalStyles.xVisual:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            switch (TabStyle)
            {
                case TabVerticalStyles.ButterVertical:
                    break;
                case TabVerticalStyles.Chrome:
                    break;
                case TabVerticalStyles.DotBar:
                    break;
                case TabVerticalStyles.DotBarV2:
                    break;
                case TabVerticalStyles.EightBall:
                    break;
                case TabVerticalStyles.Empire:
                    EmpireOnMouseLeave(e);
                    break;
                case TabVerticalStyles.Facebook:
                    FaceBookOnMouseLeave(e);
                    break;
                case TabVerticalStyles.FirefoxMain:
                    break;
                case TabVerticalStyles.NS:
                    break;
                case TabVerticalStyles.SLC:
                    break;
                case TabVerticalStyles.Meph:
                    break;
                case TabVerticalStyles.Redemption:
                    break;
                case TabVerticalStyles.xVisual:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.TabControl.Selecting" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.TabControlCancelEventArgs" /> that contains the event data.</param>
        protected override void OnSelecting(System.Windows.Forms.TabControlCancelEventArgs e)
        {
            if (OldIndex < e.TabPageIndex)
            {
                DoAnimationScrollRight(TabPages[OldIndex], TabPages[e.TabPageIndex]);
            }
            else
            {
                DoAnimationScrollLeft(TabPages[OldIndex], TabPages[e.TabPageIndex]);
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

        #region Animation Methods

        /// <summary>
        /// Does the animation scroll left.
        /// </summary>
        /// <param name="Control1">The control1.</param>
        /// <param name="Control2">The control2.</param>
        public void DoAnimationScrollLeft(Control Control1, Control Control2)
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

            int Slide = Control1.Width - (Control1.Width % Speed);

            int a = 0;
            for (a = 0; a <= Slide; a += Speed)
            {
                G.DrawImage(P1, new Rectangle(a, 0, Control1.Width, Control1.Height));
                G.DrawImage(P2, new Rectangle(a - Control2.Width, 0, Control2.Width, Control2.Height));
            }
            a = Control1.Width;
            G.DrawImage(P1, new Rectangle(a, 0, Control1.Width, Control1.Height));
            G.DrawImage(P2, new Rectangle(a - Control2.Width, 0, Control2.Width, Control2.Height));

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
        /// Does the animation scroll right.
        /// </summary>
        /// <param name="Control1">The control1.</param>
        /// <param name="Control2">The control2.</param>
        public void DoAnimationScrollRight(Control Control1, Control Control2)
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

            int Slide = Control1.Width - (Control1.Width % Speed);

            int a = 0;
            for (a = 0; a >= -Slide; a += -Speed)
            {
                G.DrawImage(P1, new Rectangle(a, 0, Control1.Width, Control1.Height));
                G.DrawImage(P2, new Rectangle(a + Control2.Width, 0, Control2.Width, Control2.Height));
            }
            a = Control1.Width;
            G.DrawImage(P1, new Rectangle(a, 0, Control1.Width, Control1.Height));
            G.DrawImage(P2, new Rectangle(a + Control2.Width, 0, Control2.Width, Control2.Height));

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
