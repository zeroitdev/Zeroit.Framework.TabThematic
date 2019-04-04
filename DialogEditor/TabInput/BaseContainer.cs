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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.TabThematic.Controls
{

    /// <summary>
    /// Class TabHorizontalInput.
    /// </summary>
    [TypeConverter(typeof(TabHorizontalConverter))]
    [Editor(typeof(TabHorizontalEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public partial class TabHorizontalInput
    {

        #region Private Fields

        /// <summary>
        /// The g
        /// </summary>
        private Graphics G;

        /// <summary>
        /// The tab style
        /// </summary>
        private TabStyles tabStyle = TabStyles.Aresio;

        /// <summary>
        /// The speed
        /// </summary>
        private int _Speed = 10;

        /// <summary>
        /// The old index
        /// </summary>
        int OldIndex;


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
        public TabStyles TabStyle
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
        /// <returns>TabHorizontalInput.</returns>
        public TabHorizontalInput Clone()
        {
            return new TabHorizontalInput(
                tabStyle
            ); 
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>TabHorizontalInput.</returns>
        public static TabHorizontalInput Empty()
        {
            return new TabHorizontalInput();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TabHorizontalInput"/> class.
        /// </summary>
        /// <param name="tabStyle">The tab style.</param>
        public TabHorizontalInput(TabStyles tabStyle)
        {
            this.tabStyle = tabStyle;
        }

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public TabHorizontalInput() : this(TabStyles.Aresio)
        {

        }

        /// <summary>
        /// ASC Constructor.
        /// </summary>
        /// <param name="ascForeColors">The asc fore colors.</param>
        /// <param name="ascBorderColors">The asc border colors.</param>
        /// <param name="ascBackColors">The asc back colors.</param>
        public TabHorizontalInput(
            Color[] ascForeColors,
            Color[] ascBorderColors,
            Color[] ascBackColors
            ) : this(TabStyles.ASC)
        {
            this.ascForeColors = ascForeColors;
            this.ascBorderColors = ascBorderColors;
            this.ascBackColors = ascBackColors;
        }

        /// <summary>
        /// Aresio Constructor.
        /// </summary>
        /// <param name="aresioForeColors">The aresio fore colors.</param>
        /// <param name="aresioBorderColors">The aresio border colors.</param>
        /// <param name="aresioBackColors">The aresio back colors.</param>
        /// <param name="dummyBool">if set to <c>true</c> [dummy bool].</param>
        public TabHorizontalInput(
            Color[] aresioForeColors,
            Color[] aresioBorderColors,
            Color[] aresioBackColors,
            bool dummyBool
        ) : this(TabStyles.Aresio)
        {
            this.aresioForeColors = aresioForeColors;
            this.aresioBorderColors = aresioBorderColors;
            this.aresioBackColors = aresioBackColors;
        }

        /// <summary>
        /// BCEvo Constructor.
        /// </summary>
        /// <param name="bCEvoForeColors">The b c evo fore colors.</param>
        /// <param name="bCEvoBorderColors">The b c evo border colors.</param>
        /// <param name="bCEvoBackColors">The b c evo back colors.</param>
        /// <param name="borderWidth">Width of the border.</param>
        public TabHorizontalInput(
            Color[] bCEvoForeColors,
            Color[] bCEvoBorderColors,
            Color[] bCEvoBackColors,
            int borderWidth
        ) : this(TabStyles.BCEvo)
        {
            this.bCEvoForeColors = bCEvoForeColors;
            this.bCEvoBorderColors = bCEvoBorderColors;
            this.bCEvoBackColors = bCEvoBackColors;
            this.borderWidth = borderWidth;
        }

        /// <summary>
        /// ButterScotch Constructor.
        /// </summary>
        /// <param name="butForeColors">The but fore colors.</param>
        /// <param name="butBackColors">The but back colors.</param>
        /// <param name="butBorderColors">The but border colors.</param>
        /// <param name="dummyString">The dummy string.</param>
        public TabHorizontalInput(
            Color[] butForeColors,
            Color[] butBackColors,
            Color[] butBorderColors,
            string dummyString
        ) : this(TabStyles.Butter)
        {
            this.butForeColors = butForeColors;
            this.butBackColors = butBackColors;
            this.butBorderColors = butBorderColors;
            
        }

        /// <summary>
        /// Carbon Constructor.
        /// </summary>
        /// <param name="carbonBack">The carbon back.</param>
        /// <param name="carbonOuterBorder">The carbon outer border.</param>
        /// <param name="carbonInnerBorder">The carbon inner border.</param>
        public TabHorizontalInput(
            Color carbonBack,
            Color carbonOuterBorder,
            Color carbonInnerBorder
        ) : this(TabStyles.CarbonFibre)
        {
            this.carbonBack = carbonBack;
            this.carbonOuterBorder = carbonOuterBorder;
            this.carbonInnerBorder = carbonInnerBorder;

        }

        /// <summary>
        /// Crystal Constructor.
        /// </summary>
        /// <param name="crystalBackColors">The crystal back colors.</param>
        /// <param name="crystalBorderColors">The crystal border colors.</param>
        /// <param name="crystalForeColors">The crystal fore colors.</param>
        /// <param name="dummyLong">The dummy long.</param>
        public TabHorizontalInput(
            Color[] crystalBackColors,
            Color[] crystalBorderColors,
            Color[] crystalForeColors,
            long dummyLong
        ) : this(TabStyles.CrystalClear)
        {
            this.crystalBackColors = crystalBackColors;
            this.crystalBorderColors = crystalBorderColors;
            this.crystalForeColors = crystalForeColors;

        }

        /// <summary>
        /// Firefox Constructor.
        /// </summary>
        /// <param name="fireFoxBackColors">The fire fox back colors.</param>
        /// <param name="fireFoxBorderColors">The fire fox border colors.</param>
        /// <param name="fireFoxForeColors">The fire fox fore colors.</param>
        /// <param name="dummyFloat">The dummy float.</param>
        public TabHorizontalInput(
            Color[] fireFoxBackColors,
            Color[] fireFoxBorderColors,
            Color[] fireFoxForeColors,
            float dummyFloat
        ) : this(TabStyles.FirefoxSub)
        {
            this.fireFoxBackColors = fireFoxBackColors;
            this.fireFoxBorderColors = fireFoxBorderColors;
            this.fireFoxForeColors = fireFoxForeColors;

        }

        /// <summary>
        /// FlatUI Constructor.
        /// </summary>
        /// <param name="flatBGColor">Color of the flat bg.</param>
        /// <param name="flatBaseColor">Color of the flat base.</param>
        /// <param name="flatActiveColor">Color of the flat active.</param>
        /// <param name="dummyFloat">The dummy float.</param>
        public TabHorizontalInput(
            Color flatBGColor,
            Color flatBaseColor,
            Color flatActiveColor,
            float dummyFloat
        ) : this(TabStyles.Flat)
        {
            this.flatBGColor = flatBGColor;
            this.flatBaseColor = flatBaseColor;
            this.flatActiveColor = flatActiveColor;

        }

        /// <summary>
        /// iTab Constructor.
        /// </summary>
        /// <param name="iTabBackColors">The i tab back colors.</param>
        /// <param name="iTabBorderColors">The i tab border colors.</param>
        /// <param name="iTabForeColors">The i tab fore colors.</param>
        /// <param name="dummyUlong">The dummy ulong.</param>
        public TabHorizontalInput(
            Color[] iTabBackColors,
            Color[] iTabBorderColors,
            Color[] iTabForeColors,
            ulong dummyUlong
        ) : this(TabStyles.iTab)
        {
            this.iTabBackColors = iTabBackColors;
            this.iTabBorderColors = iTabBorderColors;
            this.iTabForeColors = iTabForeColors;

        }

        /// <summary>
        /// Login Constructor.
        /// </summary>
        /// <param name="loginTextColour">The login text colour.</param>
        /// <param name="loginBackTabColour">The login back tab colour.</param>
        /// <param name="loginBaseColour">The login base colour.</param>
        /// <param name="loginActiveColour">The login active colour.</param>
        /// <param name="loginBorderColour">The login border colour.</param>
        /// <param name="loginUpLineColour">The login up line colour.</param>
        /// <param name="loginHorizLineColour">The login horiz line colour.</param>
        public TabHorizontalInput(
            Color loginTextColour,
            Color loginBackTabColour,
            Color loginBaseColour,
            Color loginActiveColour,
            Color loginBorderColour,
            Color loginUpLineColour,
            Color loginHorizLineColour
        ) : this(TabStyles.Login)
        {
            this.loginTextColour = loginTextColour;
            this.loginBackTabColour = loginBackTabColour;
            this.loginBaseColour = loginBaseColour;
            this.loginActiveColour = loginActiveColour;
            this.loginBorderColour = loginBorderColour;
            this.loginUpLineColour = loginUpLineColour;
            this.loginHorizLineColour = loginHorizLineColour;
        }


        /// <summary>
        /// MetroDisk Constructor.
        /// </summary>
        /// <param name="metroDiskBaseColor">Color of the metro disk base.</param>
        /// <param name="metroActiveColor">Color of the metro active.</param>
        /// <param name="metroBackColor">Color of the metro back.</param>
        /// <param name="metroInactive">The metro inactive.</param>
        /// <param name="metroActive">The metro active.</param>
        public TabHorizontalInput(
            Color metroDiskBaseColor,
            Color metroActiveColor,
            Color metroBackColor,
            Color metroInactive,
            Color metroActive
        ) : this(TabStyles.MetroDisk)
        {
            this.metroDiskBaseColor = metroDiskBaseColor;
            this.metroActiveColor = metroActiveColor;
            this.metroBackColor = metroBackColor;
            this.metroInactive = metroInactive;
            this.metroActive = metroActive;
            
        }

        /// <summary>
        /// Reactor Constructor.
        /// </summary>
        /// <param name="reactForeColors">The react fore colors.</param>
        /// <param name="reactBackColors">The react back colors.</param>
        /// <param name="reactBorderColors">The react border colors.</param>
        /// <param name="reacTabBorderColor">Color of the reac tab border.</param>
        public TabHorizontalInput(
            Color[] reactForeColors,
            Color[] reactBackColors,
            Color[] reactBorderColors,
            Color reacTabBorderColor
        ) : this(TabStyles.Reactor)
        {
            this.reactForeColors = reactForeColors;
            this.reactBackColors = reactBackColors;
            this.reactBorderColors = reactBorderColors;
            this.reacTabBorderColor = reacTabBorderColor;
            

        }


        /// <summary>
        /// Simpla Constructor.
        /// </summary>
        /// <param name="mainBackground">The main background.</param>
        /// <param name="topBackground">The top background.</param>
        /// <param name="activeTabColor">Color of the active tab.</param>
        /// <param name="dummyByte">The dummy byte.</param>
        public TabHorizontalInput(
            Color mainBackground,
            Color topBackground,
            Color activeTabColor,
            byte dummyByte

        ) : this(TabStyles.Simpla)
        {
            this.mainBackground = mainBackground;
            this.topBackground = topBackground;
            this.activeTabColor = activeTabColor;
            
        }

        /// <summary>
        /// Unique Constructor.
        /// </summary>
        /// <param name="uniqueForeColors">The unique fore colors.</param>
        /// <param name="uniqueBackColors">The unique back colors.</param>
        /// <param name="uniqueBorderColors">The unique border colors.</param>
        /// <param name="dummySByte">The dummy s byte.</param>
        public TabHorizontalInput(
            Color[] uniqueForeColors,
            Color[] uniqueBackColors,
            Color[] uniqueBorderColors,
            sbyte dummySByte
        ) : this(TabStyles.Unique)
        {
            this.uniqueForeColors = uniqueForeColors;
            this.uniqueBackColors = uniqueBackColors;
            this.uniqueBorderColors = uniqueBorderColors;
            
        }


        /// <summary>
        /// VTab Constructor.
        /// </summary>
        /// <param name="vBackColors">The v back colors.</param>
        /// <param name="vBorderColors">The v border colors.</param>
        /// <param name="dummyBool">if set to <c>true</c> [dummy bool].</param>
        public TabHorizontalInput(
            Color[] vBackColors,
            Color[] vBorderColors,
            bool dummyBool
        ) : this(TabStyles.VTab)
        {
            this.vBackColors = vBackColors;
            this.vBorderColors = vBorderColors;
            
        }

        #endregion

    }
}
