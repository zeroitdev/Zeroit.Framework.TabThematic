// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="TabThematicHorizontalDialog.cs" company="Zeroit Dev Technologies">
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
    /// Class TabThematicHorizontalDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TabThematicHorizontalDialog : Form
    {

        #region Private Fields

        /// <summary>
        /// The asc
        /// </summary>
        private ASCUserControl asc = new ASCUserControl();
        /// <summary>
        /// The aresio user control
        /// </summary>
        private AresioUserControl aresioUserControl = new AresioUserControl();
        /// <summary>
        /// The b c evo user control
        /// </summary>
        private BCEvoUserControl bCEvoUserControl = new BCEvoUserControl();
        /// <summary>
        /// The butter scotch user control
        /// </summary>
        private ButterScotchUserControl butterScotchUserControl = new ButterScotchUserControl();
        /// <summary>
        /// The carbon fibre user control
        /// </summary>
        private CarbonFibreUserControl carbonFibreUserControl = new CarbonFibreUserControl();
        /// <summary>
        /// The crystal user control
        /// </summary>
        private CrystalUserControl crystalUserControl = new CrystalUserControl();
        /// <summary>
        /// The fire fox user control
        /// </summary>
        private FireFoxUserControl fireFoxUserControl = new FireFoxUserControl();
        /// <summary>
        /// The flat UI user control
        /// </summary>
        private FlatUIUserControl flatUIUserControl = new FlatUIUserControl();
        /// <summary>
        /// The i tab user control
        /// </summary>
        private iTabUserControl iTabUserControl = new iTabUserControl();
        /// <summary>
        /// The login user control
        /// </summary>
        private LoginUserControl loginUserControl = new LoginUserControl();
        /// <summary>
        /// The metro disk user control
        /// </summary>
        private MetroDiskUserControl metroDiskUserControl = new MetroDiskUserControl();
        /// <summary>
        /// The reactor user control
        /// </summary>
        private ReactorUserControl reactorUserControl = new ReactorUserControl();
        /// <summary>
        /// The simpla user control
        /// </summary>
        private SimplaUserControl simplaUserControl = new SimplaUserControl();
        /// <summary>
        /// The unique user control
        /// </summary>
        private UniqueUserControl uniqueUserControl = new UniqueUserControl();
        /// <summary>
        /// The v user control
        /// </summary>
        private VUserControl vUserControl = new VUserControl();

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public TabThematicHorizontalDialog() : this(TabHorizontalInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public TabThematicHorizontalDialog(Control c) : this(TabHorizontalInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public TabThematicHorizontalDialog(TabHorizontalInput tabHorizontalInput, Control c) : this(tabHorizontalInput)
        {
            Zeroit.Framework.TabThematic.ThemeManagers.Utils.SetStartPositionBelowControl(this, c);
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public TabThematicHorizontalDialog(TabHorizontalInput tabHorizontalInput)
        {
            if (tabHorizontalInput == null)
            {
                throw new ArgumentNullException("tabHorizontalInput");
            }

            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            LoadInitialValues(tabHorizontalInput);
            ASCInitialValues(tabHorizontalInput);
            AresioInitialValues(tabHorizontalInput);
            BCEvoInitialValues(tabHorizontalInput);
            ButterInitialValues(tabHorizontalInput);
            CarbonInitialValues(tabHorizontalInput);
            CrystalInitialValues(tabHorizontalInput);
            FirefoxInitialValues(tabHorizontalInput);
            FlatInitialValues(tabHorizontalInput);
            iTabInitialValues(tabHorizontalInput);
            LoginInitialValues(tabHorizontalInput);
            MetroDiskInitialValues(tabHorizontalInput);
            ReactorInitialValues(tabHorizontalInput);
            SimplaInitialValues(tabHorizontalInput);
            UniqueInitialValues(tabHorizontalInput);
            VInitialValues(tabHorizontalInput);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The tab horizontal input
        /// </summary>
        private TabHorizontalInput tabHorizontalInput;

        /// <summary>
        /// Gets the tab horizontal input.
        /// </summary>
        /// <value>The tab horizontal input.</value>
        public TabHorizontalInput TabHorizontalInput
        {
            get { return tabHorizontalInput; }
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
                (int)TabStyles.ASC)
            {

                AscAdd();
                //preview.GroupBoxStyle = GroupBoxStyles.Adobe;
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Aresio)
            {
                AresioAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.BCEvo)
            {
                BCEvoAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Butter)
            {
                ButterAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.CarbonFibre)
            {
                CarbonFibreAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.CrystalClear)
            {
                CrystalAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.FirefoxSub)
            {
                FireFoxAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Flat)
            {
                FlatUIAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.iTab)
            {
                iTabAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Login)
            {
                LoginAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.MetroDisk)
            {
                MetroDiskAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Reactor)
            {
                ReactorAdd();
                
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Simpla)
            {
                SimplaAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Unique)
            {
                UniqueAdd();

            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.VTab)
            {
                VAdd();

            }
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
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {

            if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                (int)TabStyles.ASC)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.FromArgb(80, 170, 245),
                        Color.FromArgb(160, 160, 160)
                    },
                    new Color[]
                    {
                        Color.FromArgb(5, 135, 250),
                        Color.FromArgb(25, 100, 140),
                        Color.FromArgb(30, 55, 85),
                        Color.FromArgb(30, 55, 85),
                        Color.FromArgb(30, 90, 125)
                    },
                    new Color[]
                    {
                        Color.FromArgb(22,22,22)
                    }
                    );

                ASCSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                (int)TabStyles.Aresio)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.FromArgb(255,255,255),
                        Color.FromArgb(80, 80, 80)
                    },
                    new Color[]
                    {
                        Color.FromArgb(90, Color.Gray),
                        Color.FromArgb(150, 151, 153),
                        Color.FromArgb(150, 151, 153)
                    },
                    new Color[]
                    {
                        Color.FromArgb(236, 237, 239),
                        Color.FromArgb(10, Color.Black),
                        Color.FromArgb(236, 237, 239),
                        Color.FromArgb(236, 237, 239)
                    },
                    true
                );

                AresioSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.BCEvo)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.FromArgb(255, 255, 255),
                        Color.FromArgb(100, 100, 100)
                    },
                    new Color[]
                    {
                        Color.Black,
                        Color.Black
                    },
                    new Color[]
                    {
                        Color.FromArgb(255, 55, 55, 55),
                        Color.FromArgb(255, 22, 22, 22),
                        Color.FromArgb(100, 0, 0),
                        Color.FromArgb(60, 0, 0),
                        Color.FromArgb(25, Color.White),
                        Color.FromArgb(90, 90, 90)
                    },
                    2
                );

                BCEvoSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Butter)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.FromArgb(25, 23, 22),
                        Color.FromArgb(255, 255, 255)
                    },
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
                        Color.Black,
                    },
                    ""
                );

                ButterSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.CarbonFibre)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    Color.FromArgb(22, 22, 22),
                    Color.FromArgb(6, 6, 6),
                    Color.FromArgb(32, 32, 32)
                );

                CarbonSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.CrystalClear)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.FromArgb(230, 230, 230),
                        Color.FromArgb(10, 0, 0, 0),
                        Color.FromArgb(230, 230, 230),
                        Color.FromArgb(10, Color.Black),
                        Color.Transparent,
                        Color.FromArgb(215, 215, 215),
                        Color.FromArgb(230, 230, 230)
                    },
                    new Color[]
                    {
                        Color.FromArgb(170, 170, 170),
                        Color.FromArgb(170, 170, 170),
                        Color.FromArgb(170, 170, 170),
                        Color.FromArgb(170, 170, 170),
                        Color.FromArgb(170, 170, 170)
                    },
                    new Color[]
                    {
                        Color.Black,
                        Color.Black
                    },
                    12L
                );

                CrystalSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.FirefoxSub)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.White,
                        Color.LightGray,
                        Color.Gray,
                        Color.White
                    },
                    new Color[]
                    {
                        Color.FromArgb(255, 149, 0),
                        Color.SlateGray
                    },
                    new Color[]
                    {
                        Color.FromArgb(56, 69, 80)
                    },
                    12F
                );

                FirefoxSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Flat)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    Color.FromArgb(60, 70, 73),
                    Color.FromArgb(45, 47, 49),
                    Color.FromArgb(35, 168, 109),
                    12F
                );

                FlatSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.iTab)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.FromArgb(45, 45, 45),
                        Color.FromArgb(10, 0, 0, 0),
                        Color.FromArgb(35, 35, 35),
                        Color.FromArgb(10, Color.Black),
                        Color.Transparent,
                        Color.FromArgb(30, 30, 30),
                        Color.FromArgb(35, 35, 35)
                    },
                    new Color[]
                    {
                        Color.FromArgb(10, 10, 10),
                        Color.FromArgb(10, 10, 10),
                        Color.FromArgb(10, 10, 10),
                        Color.FromArgb(15, 15, 15),
                        Color.Black
                    },
                    new Color[]
                    {
                        Color.DeepSkyBlue,
                        Color.FromArgb(75, 75, 75)
                    },
                    12UL
                );

                iTabSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Login)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    Color.FromArgb(255, 255, 255),
                    Color.FromArgb(54, 54, 54),
                    Color.FromArgb(35, 35, 35),
                    Color.FromArgb(47, 47, 47),
                    Color.FromArgb(30, 30, 30),
                    Color.FromArgb(0, 160, 199),
                    Color.FromArgb(23, 119, 151)
                );

                LoginSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.MetroDisk)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    Color.FromArgb(45, 47, 49),
                    Color.FromArgb(35, 168, 109),
                    Color.FromArgb(22, 22, 22),
                    Color.DimGray,
                    Color.Silver
                );

                MetroDiskSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Reactor)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.White,
                        Color.DimGray
                    },
                    new Color[]
                    {
                        Color.FromArgb(50, Color.White),
                        Color.FromArgb(25, Color.White),
                        Color.FromArgb(10, 10, 10),
                        Color.FromArgb(50, 50, 50),
                        Color.Transparent,
                        Color.Transparent,
                        Color.FromArgb(32, 32, 32),
                        Color.FromArgb(175, 219, 78, 0),
                        Color.FromArgb(175, 229, 98, 0),
                        Color.FromArgb(80, Color.White),
                        Color.FromArgb(20, Color.White),
                        Color.FromArgb(32, 32, 32)
                    },
                    new Color[]
                    {
                        Color.FromArgb(28, 28, 28),
                        Color.Transparent,
                        Color.FromArgb(10, 10, 10),
                        Color.FromArgb(100, 230, 90, 0),
                        Color.Transparent,
                        Color.Black,
                        Color.FromArgb(70, 70, 70),
                        Color.FromArgb(45, 45, 45),
                        Color.FromArgb(45, 45, 45),
                        Color.FromArgb(45, 45, 45),
                        Color.FromArgb(31, 31, 31),
                        Color.FromArgb(10, 10, 10)
                    },
                    Color.White
                );

                ReactorSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Simpla)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    Color.FromArgb(34, 34, 34),
                    Color.FromArgb(34, 34, 34),
                    Color.FromArgb(20, 20, 20),
                    (byte)12
                );

                SimplaSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.Unique)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.FromArgb(255, 255, 255),
                        Color.FromArgb(255, 255, 255)
                    },
                    new Color[]
                    {
                        Color.FromArgb(72, 72, 72),
                        Color.FromArgb(52, 52, 52),
                        Color.FromArgb(56, 68, 85),
                        Color.FromArgb(41, 42, 46)
                    },
                    new Color[]
                    {
                        Color.Black,
                        Color.Black
                    },
                    (sbyte)12
                );

                UniqueSubmit(tabHorizontalInput);
            }

            else if (mainControl_TabStyle_ComboBox.SelectedIndex ==
                     (int)TabStyles.VTab)
            {

                tabHorizontalInput = new TabHorizontalInput(
                    new Color[]
                    {
                        Color.FromArgb(18, 18, 18),
                        Color.FromArgb(15, 15, 15),
                        Color.FromArgb(25, 25, 25),
                        Color.FromArgb(42, 42, 42),
                        Color.Transparent,
                        Color.Transparent,
                        Color.FromArgb(5, 5, 5),
                        Color.FromArgb(24, 24, 24),
                        Color.FromArgb(15, 15, 15)
                    },
                    new Color[]
                    {
                        Color.FromArgb(21, 21, 21),
                        Color.Black,
                        Color.FromArgb(255, Color.Black),
                        Color.FromArgb(255, Color.Black),
                        Color.FromArgb(35, 35, 35),
                        Color.FromArgb(70, 70, 70)
                    },
                    true
                );

                VSubmit(tabHorizontalInput);
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
        /// Handles the ValueChanged event of the mainControl_SlideSpeed_ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mainControl_SlideSpeed_ComboBox_ValueChanged(object sender, EventArgs e)
        {
            asc.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            aresioUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            bCEvoUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            butterScotchUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            carbonFibreUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            crystalUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            fireFoxUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            flatUIUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            iTabUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            loginUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            metroDiskUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            reactorUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            simplaUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            uniqueUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;
            vUserControl.preview.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            asc.preview.Invalidate();
            aresioUserControl.preview.Invalidate();
            bCEvoUserControl.preview.Invalidate();
            butterScotchUserControl.preview.Invalidate();
            carbonFibreUserControl.preview.Invalidate();
            crystalUserControl.preview.Invalidate();
            fireFoxUserControl.preview.Invalidate();
            flatUIUserControl.preview.Invalidate();
            iTabUserControl.preview.Invalidate();
            loginUserControl.preview.Invalidate();
            metroDiskUserControl.preview.Invalidate();
            reactorUserControl.preview.Invalidate();
            simplaUserControl.preview.Invalidate();
            uniqueUserControl.preview.Invalidate();
            vUserControl.preview.Invalidate();
        }
    }
}
