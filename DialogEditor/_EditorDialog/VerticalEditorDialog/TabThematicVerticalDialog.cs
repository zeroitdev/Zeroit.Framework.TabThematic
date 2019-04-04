// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TabThematicVerticalDialog.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;
using Zeroit.Framework.TabThematic.Controls;

namespace Zeroit.Framework.TabThematic.DialogEditor
{
    /// <summary>
    /// Class TabThematicVerticalDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TabThematicVerticalDialog : Form
    {

        #region Private Fields

        /// <summary>
        /// The butter scotch vertical user control
        /// </summary>
        private ButterScotchVerticalUserControl butterScotchVerticalUserControl = new ButterScotchVerticalUserControl();
        /// <summary>
        /// The chrome user control
        /// </summary>
        private ChromeUserControl chromeUserControl = new ChromeUserControl();
        /// <summary>
        /// The dotnet bar user control
        /// </summary>
        private DotnetBarUserControl dotnetBarUserControl = new DotnetBarUserControl();
        /// <summary>
        /// The dotnet barv2 user control
        /// </summary>
        private DotnetBarv2UserControl dotnetBarv2UserControl = new DotnetBarv2UserControl();
        /// <summary>
        /// The eight ball user control
        /// </summary>
        private EightBallUserControl eightBallUserControl = new EightBallUserControl();
        /// <summary>
        /// The empire user control
        /// </summary>
        private EmpireUserControl empireUserControl = new EmpireUserControl();
        /// <summary>
        /// The facebook user control
        /// </summary>
        private FacebookUserControl facebookUserControl = new FacebookUserControl();
        /// <summary>
        /// The fire fox main user control
        /// </summary>
        private FireFoxMainUserControl fireFoxMainUserControl = new FireFoxMainUserControl();
        /// <summary>
        /// The meph user control
        /// </summary>
        private MephUserControl mephUserControl = new MephUserControl();
        /// <summary>
        /// The n s user control
        /// </summary>
        private NSUserControl nSUserControl = new NSUserControl();
        /// <summary>
        /// The redemption user control
        /// </summary>
        private RedemptionUserControl redemptionUserControl = new RedemptionUserControl();
        /// <summary>
        /// The s lc user control
        /// </summary>
        private SLCUserControl sLCUserControl = new SLCUserControl();
        /// <summary>
        /// The x visual user control
        /// </summary>
        private xVisualUserControl xVisualUserControl = new xVisualUserControl();

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public TabThematicVerticalDialog() : this(TabVerticalInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public TabThematicVerticalDialog(Control c) : this(TabVerticalInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public TabThematicVerticalDialog(TabVerticalInput tabVerticalInput, Control c) : this(tabVerticalInput)
        {
            Zeroit.Framework.TabThematic.ThemeManagers.Utils.SetStartPositionBelowControl(this, c);
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public TabThematicVerticalDialog(TabVerticalInput tabVerticalInput)
        {
            if (tabVerticalInput == null)
            {
                throw new ArgumentNullException("tabVerticalInput");
            }

            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            LoadInitialValues(tabVerticalInput);
            ButterScotchInitialValues(tabVerticalInput);
            ChromeInitialValues(tabVerticalInput);
            DotnetBarInitialValues(tabVerticalInput);
            DotnetBarV2InitialValues(tabVerticalInput);
            EightBallInitialValues(tabVerticalInput);
            EmpireInitialValues(tabVerticalInput);
            FacebookInitialValues(tabVerticalInput);
            FireFoxInitialValues(tabVerticalInput);
            MephInitialValues(tabVerticalInput);
            NSInitialValues(tabVerticalInput);
            RedemptionInitialValues(tabVerticalInput);
            SLCInitialValues(tabVerticalInput);
            xVisualInitialValues(tabVerticalInput);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The tab vertical input
        /// </summary>
        private TabVerticalInput tabVerticalInput;

        /// <summary>
        /// Gets the tab vertical input.
        /// </summary>
        /// <value>The tab vertical input.</value>
        public TabVerticalInput TabVerticalInput
        {
            get { return tabVerticalInput; }
        }


        #endregion

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mainControl_TabStyle_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_TabStyle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddControls();

            if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                (int)TabVerticalStyles.ButterVertical)
            {

                ButterScotchAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Chrome)
            {
                ChromeAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.DotBar)
            {

                DotnetBarAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.DotBarV2)
            {

                DotnetBarV2Add();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.EightBall)
            {

                EightBallAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Empire)
            {

                EmpireAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Facebook)
            {

                FacebookAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.FirefoxMain)
            {

                FireFoxAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Meph)
            {

                MephAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.NS)
            {

                NSAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Redemption)
            {

                RedemptionAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.SLC)
            {

                SLCAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.xVisual)
            {

                xVisualAdd();

            }

            

        }

        /// <summary>
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {

            if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                (int)TabVerticalStyles.ButterVertical)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.FromArgb(100, 90, 80),
                        Color.FromArgb(40, 37, 33),
                        Color.FromArgb(100, 90, 80),
                        Color.FromArgb(48, 43, 39),
                        Color.FromArgb(57, 52, 46),
                        Color.FromArgb(92, 83, 74)
                    },
                    new Color[]
                    {
                        Color.Black
                    },
                    new Color[]
                    {
                        Color.FromArgb(25, 23, 22),
                        Color.White
                    }
                );

                ButterScotchSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Chrome)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        SystemColors.Control,
                        SystemColors.Control
                    },
                    new Color[]
                    {
                        Color.Black,
                        Color.DimGray
                    },
                    Color.FromArgb(78, 87, 100),
                    false
                );

                ChromeSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.DotBarV2)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.White,
                        Color.FromArgb(96, 110, 121),
                        Color.Black,
                        Color.Black,
                        Color.FromArgb(80, 90, 100),
                        Color.FromArgb(96, 110, 121),
                        Color.White
                    },
                    new Color[]
                    {
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(67, 77, 87),
                        Color.FromArgb(115, 125, 135),
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(65, 75, 85)
                    },
                    new Color[]
                    {
                        Color.White,
                        Color.FromArgb(210, 220, 230)
                    },
                    new Color[]
                    {
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(96, 110, 121)
                    }
                );

                DotnetBarV2Submit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                (int)TabVerticalStyles.DotBar)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.White,
                        Color.White,
                        Color.FromArgb(246, 248, 252),
                        Color.Black, Color.Black,
                        Color.White,
                        Color.FromArgb(246, 248, 252)
                    },
                    new Color[]
                    {
                        Color.FromArgb(170, 187, 204),
                        Color.FromArgb(170, 187, 204),
                        Color.FromArgb(170, 187, 204),
                        Color.FromArgb(200, 200, 250),
                        Color.FromArgb(200, 200, 250),
                        Color.FromArgb(170, 187, 204)
                    },
                    new Color[]
                    {
                        Color.Black,
                        Color.DimGray
                    },
                    new Color[]
                    {
                        Color.FromArgb(232, 232, 240),
                        Color.FromArgb(232, 232, 240),
                        Color.FromArgb(232, 232, 240)
                    },
                    true
                );

                DotnetBarSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.EightBall)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.FromArgb(100, 100, 100),
                        Color.FromArgb(100, 100, 100),
                        Color.FromArgb(30, Color.White),
                        Color.FromArgb(10, Color.Black),
                        Color.FromArgb(75, 75, 75),
                        Color.Gray,
                        Color.FromArgb(100, 100, 100),
                        Color.SteelBlue
                    },
                    new Color[]
                    {
                        Color.FromArgb(55, 55, 55),
                        Color.FromArgb(40, 105, 145),
                        Color.FromArgb(100, 100, 100),
                        Color.DimGray
                    },
                    new Color[]
                    {
                        Color.White,
                        Color.Silver
                    },
                    true
                );

                EightBallSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Empire)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.Gainsboro,
                        Color.Gray
                    },
                    new Color[]
                    {
                        Color.Black,
                        Color.FromArgb(51, 51, 51),
                        Color.FromArgb(17, 17, 17),
                        Color.FromArgb(51, 51, 51),
                        Color.FromArgb(17, 17, 17)
                    },
                    new Color[]
                    {
                        Color.FromArgb(55, 173, 242),
                        Color.FromArgb(36, 36, 36),
                        Color.FromArgb(42, 42, 42),
                        Color.FromArgb(25, 25, 25),
                        Color.Gainsboro,
                        Color.FromArgb(90, Color.Black),
                        Color.Transparent,
                        Color.FromArgb(200, 200, 200),
                        Color.FromArgb(36, 36, 36),
                        Color.FromArgb(25, 25, 25),
                        Color.FromArgb(3, Color.White)
                    },
                    ""
                );

                EmpireSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Facebook)
            {

                tabVerticalInput = new TabVerticalInput(
                    Color.FromArgb(200, 215, 237),
                    Color.FromArgb(109, 132, 180),
                    Color.FromArgb(237, 239, 244),
                    Color.FromArgb(139, 162, 210),
                    Color.FromArgb(58, 66, 73),
                    Color.FromArgb(199, 201, 207)
                );

                FacebookSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.FirefoxMain)
            {

                tabVerticalInput = new TabVerticalInput(
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

                FireFoxSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Meph)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(50, 50, 50),
                        Color.Black, Color.Black,
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(50, 50, 50)
                    },
                    new Color[]
                    {
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(20, 20, 20),
                    },
                    new Color[]
                    {
                        Color.White,
                        Color.FromArgb(210, 220, 230)
                    },
                    new Color[]
                    {
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(50, 50, 50)
                    },
                    new Color[]
                    {
                        Color.FromArgb(20, 20, 20),
                        Color.FromArgb(40, 40, 40),
                        Color.FromArgb(45, 45, 45),
                        Color.FromArgb(46, 46, 46),
                        Color.FromArgb(47, 47, 47),
                        Color.FromArgb(48, 48, 48),
                        Color.FromArgb(49, 49, 49),
                        Color.FromArgb(50, 50, 50)
                    },
                    new Color[]
                    {
                        Color.FromArgb(20, 20, 20),
                        Color.FromArgb(40, 40, 40),
                        Color.FromArgb(45, 45, 45),
                        Color.FromArgb(46, 46, 46),
                        Color.FromArgb(47, 47, 47),
                        Color.FromArgb(48, 48, 48),
                        Color.FromArgb(49, 49, 49),
                        Color.FromArgb(50, 50, 50)
                    },
                    new Color[]
                    {
                        Color.FromArgb(20, 20, 20),
                        Color.FromArgb(40, 40, 40),
                        Color.FromArgb(45, 45, 45),
                        Color.FromArgb(46, 46, 46),
                        Color.FromArgb(47, 47, 47),
                        Color.FromArgb(48, 48, 48),
                        Color.FromArgb(49, 49, 49),
                        Color.FromArgb(50, 50, 50)
                    }
                );

                MephSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.NS)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.FromArgb(55, 55, 55),
                        Color.FromArgb(24, 24, 24),
                        Color.FromArgb(45, 45, 45)
                    },
                    new Color[]
                    {
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(45, 45, 45),
                        Color.FromArgb(50, 50, 50),
                        Color.FromArgb(24, 24, 24),
                        Color.FromArgb(51, 181, 229),
                        Color.FromArgb(65, 65, 65)
                    },
                    new Color[]
                    {
                        Color.Black,
                        Color.WhiteSmoke
                    },
                    10
                );

                NsSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.Redemption)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.FromArgb(47, 48, 52),
                        Color.FromArgb(51, 56, 60),
                        Color.FromArgb(15, Color.White),
                        Color.FromArgb(49, 50, 54),
                        Color.FromArgb(72, 79, 87),
                        Color.FromArgb(48, 51, 56)
                    },
                    new Color[]
                    {
                        Color.Transparent,
                        Color.FromArgb(87, 88, 92),
                        Color.FromArgb(32, 33, 37),
                        Color.FromArgb(119, 124, 130),
                        Color.FromArgb(64, 67, 72),
                        Color.FromArgb(31, 36, 42)
                    },
                    new Color[]
                    {
                        Color.FromArgb(150, Color.Black),
                        Color.White
                    },
                    new Color[]
                    {
                        Color.FromArgb(43, 44, 48),
                        Color.FromArgb(44, 45, 49),
                        Color.FromArgb(45, 46, 50),
                        Color.FromArgb(46, 47, 51),
                        Color.FromArgb(47, 48, 52),
                        Color.FromArgb(48, 49, 53)
                    },
                    true,
                    HorizontalAlignments.Left
                );

                RedemptionSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.SLC)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.White,
                        Color.FromArgb(250, 250, 250),
                        Color.FromArgb(237, 237, 237),
                        Color.FromArgb(227, 227, 227),
                        Color.Transparent,
                        Color.FromArgb(227, 227, 227),
                        Color.Transparent,
                        Color.FromArgb(242, 242, 242),
                        Color.FromArgb(56, 142, 196),
                        Color.FromArgb(64, 106, 140),
                        Color.FromArgb(40, Color.WhiteSmoke),
                        Color.FromArgb(242, 242, 242),
                        Color.LightGray
                    },
                    new Color[]
                    {
                        Color.LightGray,
                        Color.Gray,
                        Color.White,
                        Color.FromArgb(70, Color.FromArgb(39, 93, 127)),
                        Color.FromArgb(200, 200, 200),
                        Color.FromArgb(150, 150, 150),
                        Color.FromArgb(49, 63, 86),
                        Color.White,
                        Color.FromArgb(70, Color.FromArgb(39, 93, 127)),
                        Color.FromArgb(100, 100, 100)
                    },
                    new Color[]
                    {
                        Color.FromArgb(56, 106, 137)
                    },
                    10L
                );

                SLCSubmit(tabVerticalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabVerticalStyles.xVisual)
            {

                tabVerticalInput = new TabVerticalInput(
                    new Color[]
                    {
                        Color.FromArgb(45, 41, 37),
                        Color.FromArgb(47, 43, 39),
                        Color.FromArgb(43, 39, 35)
                    },
                    new Color[]
                    {
                        Color.FromArgb(55, 51, 48),
                        Color.FromArgb(57, 53, 50),
                        Color.FromArgb(53, 49, 46)
                    },
                    new Color[]
                    {
                        Color.FromArgb(56, 52, 49),
                        Color.FromArgb(114, 203, 232),
                        Color.FromArgb(58, 118, 188),
                        Color.FromArgb(114, 203, 232),
                        Color.FromArgb(58, 118, 188),
                        Color.FromArgb(15, Color.White),
                        Color.FromArgb(100, Color.FromArgb(43, 40, 38)),
                        Color.FromArgb(56, 52, 49)
                    },
                    new Color[]
                    {
                        Color.FromArgb(44, 42, 39),
                        Color.FromArgb(48, 45, 43),
                        Color.FromArgb(53, 50, 47),
                        Color.Black,
                        Color.FromArgb(99, 97, 94),
                        Color.FromArgb(235, 255, 255),
                        Color.FromArgb(235, 255, 255),
                        Color.Black,
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(96, 110, 121),
                        Color.FromArgb(113, 110, 108),
                        Color.Black,
                        Color.FromArgb(64, 60, 57),
                        Color.FromArgb(35, 33, 31),
                        Color.FromArgb(43, 41, 38),
                        Color.FromArgb(53, 50, 47),
                        Color.FromArgb(58, 55, 51),
                        Color.Black,
                        Color.FromArgb(56, 52, 49),
                        Color.FromArgb(56, 52, 49),
                        Color.Black
                    },
                    new Color[]
                    {
                        Color.FromArgb(20, 20, 20),
                        Color.White,
                        Color.FromArgb(210, 220, 230)
                    },
                    new Color[]
                    {
                        Color.FromArgb(43, 40, 38),
                        Color.FromArgb(50, 47, 44),
                        Color.FromArgb(55, 52, 49)
                    }
                );

                xVisualSubmit(tabVerticalInput);
            }

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the cancelBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Handles the Click event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the ValueChanged event of the mainControl_SlideSpeed_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_SlideSpeed_ComboBox_ValueChanged(object sender, EventArgs e)
        {
            butterScotchVerticalUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            chromeUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            dotnetBarUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            dotnetBarv2UserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            eightBallUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            empireUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            facebookUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            fireFoxMainUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            mephUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            nSUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            redemptionUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            sLCUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            xVisualUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            butterScotchVerticalUserControl.preview.Invalidate();
            chromeUserControl.preview.Invalidate();
            dotnetBarUserControl.preview.Invalidate();
            dotnetBarv2UserControl.preview.Invalidate();
            eightBallUserControl.preview.Invalidate();
            empireUserControl.preview.Invalidate();
            facebookUserControl.preview.Invalidate();
            fireFoxMainUserControl.preview.Invalidate();
            mephUserControl.preview.Invalidate();
            nSUserControl.preview.Invalidate();
            redemptionUserControl.preview.Invalidate();
            sLCUserControl.preview.Invalidate();
            xVisualUserControl.preview.Invalidate();
        }
    }
}
