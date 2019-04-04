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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.TabThematic.Controls
{
    /// <summary>
    /// Class TabVerticalInput.
    /// </summary>
    [TypeConverter(typeof(TabVerticalInputConverter))]
    [Editor(typeof(TabVerticalEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public partial class TabVerticalInput
    {

        #region Private Fields


        /// <summary>
        /// The tab style
        /// </summary>
        private TabVerticalStyles tabStyle = TabVerticalStyles.FirefoxMain;

        /// <summary>
        /// The speed
        /// </summary>
        private int _Speed = 5;

        /// <summary>
        /// The dummy int
        /// </summary>
        private int dummyInt = 0;
        /// <summary>
        /// The dummy float
        /// </summary>
        private float dummyFloat = 0;
        /// <summary>
        /// The dummy string
        /// </summary>
        private string dummyString = "";
        /// <summary>
        /// The dummy long
        /// </summary>
        private long dummyLong = 0;
        /// <summary>
        /// The dummy unlong
        /// </summary>
        private ulong dummyUnlong = 0;
        /// <summary>
        /// The dummy short
        /// </summary>
        private short dummyShort = 0;
        /// <summary>
        /// The dummy byte
        /// </summary>
        private int dummyByte = 0;
        /// <summary>
        /// The dummy bool
        /// </summary>
        private bool dummyBool = true;
        /// <summary>
        /// The dummy s byte
        /// </summary>
        private sbyte dummySByte = 1;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the tab style.
        /// </summary>
        /// <value>The tab style.</value>
        public TabVerticalStyles TabStyle
        {
            get { return tabStyle; }
            set
            {
                
                tabStyle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the speed.
        /// </summary>
        /// <value>The speed.</value>
        public int Speed
        {
            get { return _Speed; }
            set
            {
                if (value > 20 | value < -20)
                {
                    MessageBox.Show("Speed needs to be in between -20 and 20.");
                }
                else
                {
                    _Speed = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets the dummy int.
        /// </summary>
        /// <value>The dummy int.</value>
        public int DummyInt { get => dummyInt; set => dummyInt = value; }
        /// <summary>
        /// Gets or sets the dummy float.
        /// </summary>
        /// <value>The dummy float.</value>
        public float DummyFloat { get => dummyFloat; set => dummyFloat = value; }
        /// <summary>
        /// Gets or sets the dummy string.
        /// </summary>
        /// <value>The dummy string.</value>
        public string DummyString { get => dummyString; set => dummyString = value; }
        /// <summary>
        /// Gets or sets the dummy long.
        /// </summary>
        /// <value>The dummy long.</value>
        public long DummyLong { get => dummyLong; set => dummyLong = value; }
        /// <summary>
        /// Gets or sets the dummy unlong.
        /// </summary>
        /// <value>The dummy unlong.</value>
        public ulong DummyUnlong { get => dummyUnlong; set => dummyUnlong = value; }
        /// <summary>
        /// Gets or sets the dummy short.
        /// </summary>
        /// <value>The dummy short.</value>
        public short DummyShort { get => dummyShort; set => dummyShort = value; }
        /// <summary>
        /// Gets or sets the dummy byte.
        /// </summary>
        /// <value>The dummy byte.</value>
        public int DummyByte { get => dummyByte; set => dummyByte = value; }
        /// <summary>
        /// Gets or sets a value indicating whether [dummy bool].
        /// </summary>
        /// <value><c>true</c> if [dummy bool]; otherwise, <c>false</c>.</value>
        public bool DummyBool
        {
            get { return dummyBool; }
            set { dummyBool = value; }
        }
        /// <summary>
        /// Gets or sets the dummy s byte.
        /// </summary>
        /// <value>The dummy s byte.</value>
        public sbyte DummySByte
        {
            get { return dummySByte; }
            set { dummySByte = value; }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>TabVerticalInput.</returns>
        public TabVerticalInput Clone()
        {
            return new TabVerticalInput(
                tabStyle
            );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>TabVerticalInput.</returns>
        public static TabVerticalInput Empty()
        {
            return new TabVerticalInput();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TabVerticalInput"/> class.
        /// </summary>
        /// <param name="TabStyle">The tab style.</param>
        public TabVerticalInput(TabVerticalStyles TabStyle)
        {
            this.TabStyle = TabStyle;
        }

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public TabVerticalInput() : this(TabVerticalStyles.FirefoxMain)
        {

        }

        /// <summary>
        /// ButterScotch Constructor.
        /// </summary>
        /// <param name="butterVertBackColors">The butter vert back colors.</param>
        /// <param name="butterVertBorderColors">The butter vert border colors.</param>
        /// <param name="butterVertForeColors">The butter vert fore colors.</param>
        public TabVerticalInput(
            Color[] butterVertBackColors,
            Color[] butterVertBorderColors,
            Color[] butterVertForeColors) : this(TabVerticalStyles.ButterVertical)
        {
            this.butterVertBackColors = butterVertBackColors;
            this.butterVertBorderColors = butterVertBorderColors;
            this.butterVertForeColors = butterVertForeColors;
            
        }

        /// <summary>
        /// Chrome Constructor.
        /// </summary>
        /// <param name="chromeBackColors">The chrome back colors.</param>
        /// <param name="chromeForeColors">The chrome fore colors.</param>
        /// <param name="squareColor">Color of the square.</param>
        /// <param name="showOuterBorders">if set to <c>true</c> [show outer borders].</param>
        public TabVerticalInput(
            Color[] chromeBackColors,
            Color[] chromeForeColors,
            Color squareColor,
            bool showOuterBorders) : this(TabVerticalStyles.Chrome)
        {
            this.chromeBackColors = chromeBackColors;
            this.chromeForeColors = chromeForeColors;
            this.squareColor = squareColor;
            this.showOuterBorders = showOuterBorders;

        }

        /// <summary>
        /// Dotnet V2 Constructor.
        /// </summary>
        /// <param name="dotV2BackColors">The dot v2 back colors.</param>
        /// <param name="dotV2BorderColors">The dot v2 border colors.</param>
        /// <param name="dotV2ForeColors">The dot v2 fore colors.</param>
        /// <param name="dotV2BlendColors">The dot v2 blend colors.</param>
        public TabVerticalInput(
            Color[] dotV2BackColors,
            Color[] dotV2BorderColors,
            Color[] dotV2ForeColors,
            Color[] dotV2BlendColors) : this(TabVerticalStyles.DotBarV2)
        {
            this.dotV2BackColors = dotV2BackColors;
            this.dotV2BorderColors = dotV2BorderColors;
            this.dotV2ForeColors = dotV2ForeColors;
            this.dotV2BlendColors = dotV2BlendColors;

        }

        /// <summary>
        /// Donet Constructor.
        /// </summary>
        /// <param name="dotnetBarBackColors">The dotnet bar back colors.</param>
        /// <param name="dotnetBarBorderColors">The dotnet bar border colors.</param>
        /// <param name="dotnetBarForeColors">The dotnet bar fore colors.</param>
        /// <param name="dotnetBarColorBlend">The dotnet bar color blend.</param>
        /// <param name="dummyBool">if set to <c>true</c> [dummy bool].</param>
        public TabVerticalInput(
            Color[] dotnetBarBackColors,
            Color[] dotnetBarBorderColors,
            Color[] dotnetBarForeColors,
            Color[] dotnetBarColorBlend,
            bool dummyBool = true) : this(TabVerticalStyles.DotBar)
        {
            this.dotnetBarBackColors = dotnetBarBackColors;
            this.dotnetBarBorderColors = dotnetBarBorderColors;
            this.dotnetBarForeColors = dotnetBarForeColors;
            this.dotnetBarColorBlend = dotnetBarColorBlend;

        }

        /// <summary>
        /// EightBall Constructor.
        /// </summary>
        /// <param name="eightBallBackColors">The eight ball back colors.</param>
        /// <param name="eightBallBorderColors">The eight ball border colors.</param>
        /// <param name="eightBallForeColors">The eight ball fore colors.</param>
        /// <param name="dummyBool">if set to <c>true</c> [dummy bool].</param>
        public TabVerticalInput(
            Color[] eightBallBackColors,
            Color[] eightBallBorderColors,
            Color[] eightBallForeColors,
            bool dummyBool = true) : this(TabVerticalStyles.EightBall)
        {
            this.eightBallBackColors = eightBallBackColors;
            this.eightBallBorderColors = eightBallBorderColors;
            this.eightBallForeColors = eightBallForeColors;
            

        }

        /// <summary>
        /// Empire Constructor.
        /// </summary>
        /// <param name="empireForeColors">The empire fore colors.</param>
        /// <param name="empireBorderColors">The empire border colors.</param>
        /// <param name="empireBackColors">The empire back colors.</param>
        /// <param name="dummyString">The dummy string.</param>
        public TabVerticalInput(
            Color[] empireForeColors,
            Color[] empireBorderColors,
            Color[] empireBackColors,
            string dummyString = "") : this(TabVerticalStyles.Empire)
        {
            this.empireForeColors = empireForeColors;
            this.empireBorderColors = empireBorderColors;
            this.empireBackColors = empireBackColors;


        }

        /// <summary>
        /// Facebook Constructor.
        /// </summary>
        /// <param name="pressedTabColor">Color of the pressed tab.</param>
        /// <param name="hoverColor">Color of the hover.</param>
        /// <param name="normalColor">Color of the normal.</param>
        /// <param name="faceBookBorderColor">Color of the face book border.</param>
        /// <param name="faceBookTextColor">Color of the face book text.</param>
        /// <param name="faceBookBack">The face book back.</param>
        public TabVerticalInput(
            Color pressedTabColor,
            Color hoverColor,
            Color normalColor,
            Color faceBookBorderColor,
            Color faceBookTextColor,
            Color faceBookBack) : this(TabVerticalStyles.Facebook)
        {
            this.pressedTabColor = pressedTabColor;
            this.hoverColor = hoverColor;
            this.normalColor = normalColor;
            this.faceBookBorderColor = faceBookBorderColor;
            this.faceBookTextColor = faceBookTextColor;
            this.faceBookBack = faceBookBack;
            
        }

        /// <summary>
        /// Firefox Constructor.
        /// </summary>
        /// <param name="fireFoxBackColors">The fire fox back colors.</param>
        /// <param name="fireFoxForeColors">The fire fox fore colors.</param>
        public TabVerticalInput(
            Color[] fireFoxBackColors,
            Color[] fireFoxForeColors
            ) : this(TabVerticalStyles.FirefoxMain)
        {
            this.fireFoxBackColors = fireFoxBackColors;
            this.fireFoxForeColors = fireFoxForeColors;
            
        }

        /// <summary>
        /// Meph Constructor.
        /// </summary>
        /// <param name="mephBackColors">The meph back colors.</param>
        /// <param name="mephBorderColors">The meph border colors.</param>
        /// <param name="mephForeColors">The meph fore colors.</param>
        /// <param name="mephColorBlend">The meph color blend.</param>
        /// <param name="cFull">The c full.</param>
        /// <param name="cHighlight">The c highlight.</param>
        /// <param name="pageFill">The page fill.</param>
        public TabVerticalInput(
            Color[] mephBackColors,
            Color[] mephBorderColors,
            Color[] mephForeColors,
            Color[] mephColorBlend,
            Color[] cFull,
            Color[] cHighlight,
            Color[] pageFill
        ) : this(TabVerticalStyles.Meph)
        {
            this.mephBackColors = mephBackColors;
            this.mephBorderColors = mephBorderColors;
            this.mephForeColors = mephForeColors;
            this.mephColorBlend = mephColorBlend;
            this.cFull = cFull;
            this.cHighlight = cHighlight;
            this.pageFill = pageFill;
            
        }

        /// <summary>
        /// NS Constructor.
        /// </summary>
        /// <param name="nsBorderColors">The ns border colors.</param>
        /// <param name="nsBackColors">The ns back colors.</param>
        /// <param name="nsForeColors">The ns fore colors.</param>
        /// <param name="dummyInt">The dummy int.</param>
        public TabVerticalInput(
            Color[] nsBorderColors,
            Color[] nsBackColors,
            Color[] nsForeColors,
            int dummyInt = 0
        ) : this(TabVerticalStyles.NS)
        {
            this.nsBorderColors = nsBorderColors;
            this.nsBackColors = nsBackColors;
            this.nsForeColors = nsForeColors;
        }

        /// <summary>
        /// Redemption Constructor.
        /// </summary>
        /// <param name="redemptionBackColors">The redemption back colors.</param>
        /// <param name="redemptionBorderColors">The redemption border colors.</param>
        /// <param name="redemptionForeColors">The redemption fore colors.</param>
        /// <param name="gradientPen">The gradient pen.</param>
        /// <param name="backgroundNoise">if set to <c>true</c> [background noise].</param>
        /// <param name="align">The align.</param>
        public TabVerticalInput(
            Color[] redemptionBackColors,
            Color[] redemptionBorderColors,
            Color[] redemptionForeColors,
            Color[] gradientPen,
            bool backgroundNoise,
            HorizontalAlignments align
        ) : this(TabVerticalStyles.Redemption)
        {
            this.redemptionBackColors = redemptionBackColors;
            this.redemptionBorderColors = redemptionBorderColors;
            this.redemptionForeColors = redemptionForeColors;
            this.gradientPen = gradientPen;
            this.backgroundNoise = backgroundNoise;
            this.align = align;

        }


        /// <summary>
        /// SLC Constructor.
        /// </summary>
        /// <param name="slcBackColors">The SLC back colors.</param>
        /// <param name="slcBorderColors">The SLC border colors.</param>
        /// <param name="slcForeColors">The SLC fore colors.</param>
        /// <param name="dummyLong">The dummy long.</param>
        public TabVerticalInput(
            Color[] slcBackColors,
            Color[] slcBorderColors,
            Color[] slcForeColors,
            long dummyLong = 0
        ) : this(TabVerticalStyles.SLC)
        {
            this.slcBackColors = slcBackColors;
            this.slcBorderColors = slcBorderColors;
            this.slcForeColors = slcForeColors;
        }


        /// <summary>
        /// xVisual Constructor.
        /// </summary>
        /// <param name="innerTexture">The inner texture.</param>
        /// <param name="tabBGTexture">The tab bg texture.</param>
        /// <param name="xVisualBackColors">The x visual back colors.</param>
        /// <param name="xVisualBorderColors">The x visual border colors.</param>
        /// <param name="xVisualForeColors">The x visual fore colors.</param>
        /// <param name="glowColor">Color of the glow.</param>
        public TabVerticalInput(
            Color[] innerTexture,
            Color[] tabBGTexture,
            Color[] xVisualBackColors,
            Color[] xVisualBorderColors,
            Color[] xVisualForeColors,
            Color[] glowColor
        ) : this(TabVerticalStyles.xVisual)
        {
            this.innerTexture = innerTexture;
            this.tabBGTexture = tabBGTexture;
            this.xVisualBackColors = xVisualBackColors;
            this.xVisualBorderColors = xVisualBorderColors;
            this.xVisualForeColors = xVisualForeColors;
            this.glowColor = glowColor;
        }

        #endregion

        #region Editor Brush

        /// <summary>
        /// The bordercolor
        /// </summary>
        private Color bordercolor = Color.DeepSkyBlue;
        /// <summary>
        /// The shapecolor
        /// </summary>
        private Color shapecolor = Color.DarkSlateBlue;

        /// <summary>
        /// Gets foreground color in a solid fill.
        /// </summary>
        /// <value>Foreground color in a solid fill.</value>
        public Color ShapeColor
        {
            get { return shapecolor; }
            set { shapecolor = value; }
        }

        /// <summary>
        /// Gets foreground color in a hatched fill.
        /// </summary>
        /// <value>Foreground color in a hatched fill.</value>
        public Color BorderColor
        {
            get { return bordercolor; }

            set { bordercolor = value; }
        }

        /// <summary>
        /// Gets the UI type editor pen.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        /// <returns>Pen.</returns>
        internal Pen GetUITypeEditorPen(Rectangle bounds)
        {
            return GetPen(bounds);
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Pen GetPen(Rectangle rect)
        {
            return GetPen(new RectangleF(rect.X, rect.Y, rect.Width, rect.Height));
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Pen GetPen(RectangleF rect)
        {
            switch (TabStyle)
            {
                case TabVerticalStyles.ButterVertical:
                    return new Pen(BorderColor);
                case TabVerticalStyles.Chrome:
                    return new Pen(BorderColor);
                case TabVerticalStyles.DotBar:
                    return new Pen(BorderColor);
                case TabVerticalStyles.DotBarV2:
                    return new Pen(BorderColor);
                case TabVerticalStyles.EightBall:
                    return new Pen(BorderColor);
                case TabVerticalStyles.Empire:
                    return new Pen(BorderColor);
                case TabVerticalStyles.Facebook:
                    return new Pen(BorderColor);
                case TabVerticalStyles.FirefoxMain:
                    return new Pen(BorderColor);
                case TabVerticalStyles.Meph:
                    return new Pen(BorderColor);
                case TabVerticalStyles.NS:
                    return new Pen(BorderColor);
                case TabVerticalStyles.Redemption:
                    return new Pen(BorderColor);
                case TabVerticalStyles.SLC:
                    return new Pen(BorderColor);
                case TabVerticalStyles.xVisual:
                    return new Pen(BorderColor);
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
            return null;
        }



        /// <summary>
        /// Gets the UI type editor brush.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        /// <returns>Brush.</returns>
        internal Brush GetUITypeEditorBrush(Rectangle bounds)
        {
            return GetBrush(bounds);
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Brush GetBrush(Rectangle rect)
        {
            return GetBrush(new RectangleF(rect.X, rect.Y, rect.Width, rect.Height));
        }

        /// <summary>
        /// Get <c>Brush</c> for this fill.
        /// </summary>
        /// <param name="rect">Rectangle area to which fill is to be applied.</param>
        /// <returns>Brush.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <remarks>The <c>rect</c> parameter only affects the brush if <c>FillerType</c> is <c>LinearGradient</c> or <c>PathGradient</c>.
        /// <para>
        /// The caller is responsible for disposing of the returned brush.
        /// </para></remarks>
        public Brush GetBrush(RectangleF rect)
        {
            switch (TabStyle)
            {
                case TabVerticalStyles.ButterVertical:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.Chrome:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.DotBar:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.DotBarV2:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.EightBall:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.Empire:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.Facebook:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.FirefoxMain:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.Meph:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.NS:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.Redemption:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.SLC:
                    return new SolidBrush(ShapeColor);
                case TabVerticalStyles.xVisual:
                    return new SolidBrush(ShapeColor);
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return null;
        }

        #endregion


    }
}
