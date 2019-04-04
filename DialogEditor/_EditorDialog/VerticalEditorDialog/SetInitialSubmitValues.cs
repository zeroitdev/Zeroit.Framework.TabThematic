// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SetInitialSubmitValues.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.TabThematic.Controls;

namespace Zeroit.Framework.TabThematic.DialogEditor
{
    /// <summary>
    /// Class TabThematicVerticalDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TabThematicVerticalDialog
    {

        /// <summary>
        /// Loads the initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void LoadInitialValues(TabVerticalInput tabVerticalInput)
        {
            
            #region Add Enum to ComboBox
            
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(TabVerticalStyles)))
            {
                mainControl_TabStyle_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < mainControl_TabStyle_ComboBox.Items.Count; i++)
            {
                if (tabVerticalInput.TabStyle == (TabVerticalStyles)Enum.Parse(typeof(TabVerticalStyles), mainControl_TabStyle_ComboBox.Items[i].ToString()))
                {
                    mainControl_TabStyle_ComboBox.SelectedIndex = i;

                }

            }

            #endregion

            mainControl_SlideSpeed_ComboBox.Value = tabVerticalInput.Speed;

        }

        #region ButterScotch

        /// <summary>
        /// Butters the scotch initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void ButterScotchInitialValues(TabVerticalInput tabVerticalInput)
        {
            butterScotchVerticalUserControl.back_0.BackColor = tabVerticalInput.ButterVertBackColors[0];
            butterScotchVerticalUserControl.back_1.BackColor = tabVerticalInput.ButterVertBackColors[1];
            butterScotchVerticalUserControl.back_2.BackColor = tabVerticalInput.ButterVertBackColors[2];
            butterScotchVerticalUserControl.back_3.BackColor = tabVerticalInput.ButterVertBackColors[3];
            butterScotchVerticalUserControl.back_4.BackColor = tabVerticalInput.ButterVertBackColors[4];
            butterScotchVerticalUserControl.back_5.BackColor = tabVerticalInput.ButterVertBackColors[5];

            butterScotchVerticalUserControl.border.BackColor = tabVerticalInput.ButterVertBorderColors[0];

            butterScotchVerticalUserControl.fore_0.BackColor = tabVerticalInput.ButterVertForeColors[0];
            butterScotchVerticalUserControl.fore_1.BackColor = tabVerticalInput.ButterVertForeColors[1];


            butterScotchVerticalUserControl.preview.ButterVertBackColors[0] = tabVerticalInput.ButterVertBackColors[0];
            butterScotchVerticalUserControl.preview.ButterVertBackColors[1] = tabVerticalInput.ButterVertBackColors[1];
            butterScotchVerticalUserControl.preview.ButterVertBackColors[2] = tabVerticalInput.ButterVertBackColors[2];
            butterScotchVerticalUserControl.preview.ButterVertBackColors[3] = tabVerticalInput.ButterVertBackColors[3];
            butterScotchVerticalUserControl.preview.ButterVertBackColors[4] = tabVerticalInput.ButterVertBackColors[4];
            butterScotchVerticalUserControl.preview.ButterVertBackColors[5] = tabVerticalInput.ButterVertBackColors[5];

            butterScotchVerticalUserControl.preview.ButterVertBorderColors[0] = tabVerticalInput.ButterVertBorderColors[0];

            butterScotchVerticalUserControl.preview.ButterVertForeColors[0] = tabVerticalInput.ButterVertForeColors[0];
            butterScotchVerticalUserControl.preview.ButterVertForeColors[1] = tabVerticalInput.ButterVertForeColors[1];

        }

        /// <summary>
        /// Butters the scotch submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void ButterScotchSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.ButterVertBackColors[0] = butterScotchVerticalUserControl.back_0.BackColor;
            tabVerticalInput.ButterVertBackColors[1] = butterScotchVerticalUserControl.back_1.BackColor;
            tabVerticalInput.ButterVertBackColors[2] = butterScotchVerticalUserControl.back_2.BackColor;
            tabVerticalInput.ButterVertBackColors[3] = butterScotchVerticalUserControl.back_3.BackColor;
            tabVerticalInput.ButterVertBackColors[4] = butterScotchVerticalUserControl.back_4.BackColor;
            tabVerticalInput.ButterVertBackColors[5] = butterScotchVerticalUserControl.back_5.BackColor;

            tabVerticalInput.ButterVertBorderColors[0] = butterScotchVerticalUserControl.border.BackColor;

            tabVerticalInput.ButterVertForeColors[0] = butterScotchVerticalUserControl.fore_0.BackColor;
            tabVerticalInput.ButterVertForeColors[1] = butterScotchVerticalUserControl.fore_1.BackColor;

        }

        #endregion

        #region Chrome

        /// <summary>
        /// Chromes the initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void ChromeInitialValues(TabVerticalInput tabVerticalInput)
        {
            chromeUserControl.back_0.BackColor = tabVerticalInput.ChromeBackColor[0];
            chromeUserControl.back_1.BackColor = tabVerticalInput.ChromeBackColor[1];

            chromeUserControl.square.BackColor = tabVerticalInput.SquareColor;

            chromeUserControl.fore_0.BackColor = tabVerticalInput.ChromeForeColors[0];
            chromeUserControl.fore_1.BackColor = tabVerticalInput.ChromeForeColors[1];

            if (tabVerticalInput.ShowOuterBorders)
            {
                chromeUserControl.outerBorder_Yes_RadBtn.Checked = true;
                chromeUserControl.preview.ShowOuterBorders = true;
            }
            else
            {
                chromeUserControl.outerBorder_No_RadBtn.Checked = true;
                chromeUserControl.preview.ShowOuterBorders = false;
            }

            chromeUserControl.preview.ChromeBackColor[0] = tabVerticalInput.ChromeBackColor[0];
            chromeUserControl.preview.ChromeBackColor[1] = tabVerticalInput.ChromeBackColor[1];

            chromeUserControl.preview.SquareColor = tabVerticalInput.SquareColor;

            chromeUserControl.preview.ChromeForeColors[0] = tabVerticalInput.ChromeForeColors[0];
            chromeUserControl.preview.ChromeForeColors[1] = tabVerticalInput.ChromeForeColors[1];


        }

        /// <summary>
        /// Chromes the submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void ChromeSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.ChromeBackColor[0] = chromeUserControl.back_0.BackColor;
            tabVerticalInput.ChromeBackColor[1] = chromeUserControl.back_1.BackColor;

            tabVerticalInput.SquareColor = chromeUserControl.square.BackColor;

            tabVerticalInput.ChromeForeColors[0] = chromeUserControl.fore_0.BackColor;
            tabVerticalInput.ChromeForeColors[1] = chromeUserControl.fore_1.BackColor;

            if (chromeUserControl.outerBorder_Yes_RadBtn.Checked)
            {
                tabVerticalInput.ShowOuterBorders = true;
            }
            else
            {
                tabVerticalInput.ShowOuterBorders = false;
            }
        }

        #endregion

        #region DotnetBar

        /// <summary>
        /// Dotnets the bar initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void DotnetBarInitialValues(TabVerticalInput tabVerticalInput)
        {
            dotnetBarUserControl.back_0.BackColor = tabVerticalInput.DotnetBarBackColors[0];
            dotnetBarUserControl.back_1.BackColor = tabVerticalInput.DotnetBarBackColors[1];
            dotnetBarUserControl.back_2.BackColor = tabVerticalInput.DotnetBarBackColors[2];
            dotnetBarUserControl.back_3.BackColor = tabVerticalInput.DotnetBarBackColors[3];
            dotnetBarUserControl.back_4.BackColor = tabVerticalInput.DotnetBarBackColors[4];
            dotnetBarUserControl.back_5.BackColor = tabVerticalInput.DotnetBarBackColors[5];

            dotnetBarUserControl.border_0.BackColor = tabVerticalInput.DotnetBarBorderColors[0];
            dotnetBarUserControl.border_1.BackColor = tabVerticalInput.DotnetBarBorderColors[1];
            dotnetBarUserControl.border_2.BackColor = tabVerticalInput.DotnetBarBorderColors[2];
            dotnetBarUserControl.border_3.BackColor = tabVerticalInput.DotnetBarBorderColors[3];
            dotnetBarUserControl.border_4.BackColor = tabVerticalInput.DotnetBarBorderColors[4];
            dotnetBarUserControl.border_5.BackColor = tabVerticalInput.DotnetBarBorderColors[5];

            dotnetBarUserControl.blend_0.BackColor = tabVerticalInput.DotnetBarColorBlend[0];
            dotnetBarUserControl.blend_1.BackColor = tabVerticalInput.DotnetBarColorBlend[1];
            dotnetBarUserControl.blend_2.BackColor = tabVerticalInput.DotnetBarColorBlend[2];


            dotnetBarUserControl.fore_0.BackColor = tabVerticalInput.DotnetBarForeColors[0];
            dotnetBarUserControl.fore_1.BackColor = tabVerticalInput.DotnetBarForeColors[1];


            dotnetBarUserControl.preview.DotnetBarBackColors[0] = tabVerticalInput.DotnetBarBackColors[0];
            dotnetBarUserControl.preview.DotnetBarBackColors[1] = tabVerticalInput.DotnetBarBackColors[1];
            dotnetBarUserControl.preview.DotnetBarBackColors[2] = tabVerticalInput.DotnetBarBackColors[2];
            dotnetBarUserControl.preview.DotnetBarBackColors[3] = tabVerticalInput.DotnetBarBackColors[3];
            dotnetBarUserControl.preview.DotnetBarBackColors[4] = tabVerticalInput.DotnetBarBackColors[4];
            dotnetBarUserControl.preview.DotnetBarBackColors[5] = tabVerticalInput.DotnetBarBackColors[5];

            dotnetBarUserControl.preview.DotnetBarBorderColors[0] = tabVerticalInput.DotnetBarBorderColors[0];
            dotnetBarUserControl.preview.DotnetBarBorderColors[1] = tabVerticalInput.DotnetBarBorderColors[1];
            dotnetBarUserControl.preview.DotnetBarBorderColors[2] = tabVerticalInput.DotnetBarBorderColors[2];
            dotnetBarUserControl.preview.DotnetBarBorderColors[3] = tabVerticalInput.DotnetBarBorderColors[3];
            dotnetBarUserControl.preview.DotnetBarBorderColors[4] = tabVerticalInput.DotnetBarBorderColors[4];
            dotnetBarUserControl.preview.DotnetBarBorderColors[5] = tabVerticalInput.DotnetBarBorderColors[5];

            dotnetBarUserControl.preview.DotnetBarColorBlend[0] = tabVerticalInput.DotnetBarColorBlend[0];
            dotnetBarUserControl.preview.DotnetBarColorBlend[1] = tabVerticalInput.DotnetBarColorBlend[1];
            dotnetBarUserControl.preview.DotnetBarColorBlend[2] = tabVerticalInput.DotnetBarColorBlend[2];


            dotnetBarUserControl.preview.DotnetBarForeColors[0] = tabVerticalInput.DotnetBarForeColors[0];
            dotnetBarUserControl.preview.DotnetBarForeColors[1] = tabVerticalInput.DotnetBarForeColors[1];


        }

        /// <summary>
        /// Dotnets the bar submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void DotnetBarSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.DotnetBarBackColors[0] = dotnetBarUserControl.back_0.BackColor;
            tabVerticalInput.DotnetBarBackColors[1] = dotnetBarUserControl.back_1.BackColor;
            tabVerticalInput.DotnetBarBackColors[2] = dotnetBarUserControl.back_2.BackColor;
            tabVerticalInput.DotnetBarBackColors[3] = dotnetBarUserControl.back_3.BackColor;
            tabVerticalInput.DotnetBarBackColors[4] = dotnetBarUserControl.back_4.BackColor;
            tabVerticalInput.DotnetBarBackColors[5] = dotnetBarUserControl.back_5.BackColor;

            tabVerticalInput.DotnetBarBorderColors[0] = dotnetBarUserControl.border_0.BackColor;
            tabVerticalInput.DotnetBarBorderColors[1] = dotnetBarUserControl.border_1.BackColor;
            tabVerticalInput.DotnetBarBorderColors[2] = dotnetBarUserControl.border_2.BackColor;
            tabVerticalInput.DotnetBarBorderColors[3] = dotnetBarUserControl.border_3.BackColor;
            tabVerticalInput.DotnetBarBorderColors[4] = dotnetBarUserControl.border_4.BackColor;
            tabVerticalInput.DotnetBarBorderColors[5] = dotnetBarUserControl.border_5.BackColor;

            tabVerticalInput.DotnetBarColorBlend[0] = dotnetBarUserControl.blend_0.BackColor;
            tabVerticalInput.DotnetBarColorBlend[1] = dotnetBarUserControl.blend_1.BackColor;
            tabVerticalInput.DotnetBarColorBlend[2] = dotnetBarUserControl.blend_2.BackColor;

            tabVerticalInput.DotnetBarForeColors[0] = dotnetBarUserControl.fore_0.BackColor;
            tabVerticalInput.DotnetBarForeColors[1] = dotnetBarUserControl.fore_1.BackColor;
        }

        #endregion

        #region DotnetBarV2

        /// <summary>
        /// Dotnets the bar v2 initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void DotnetBarV2InitialValues(TabVerticalInput tabVerticalInput)
        {
            dotnetBarv2UserControl.back_0.BackColor = tabVerticalInput.DotV2BackColors[0];
            dotnetBarv2UserControl.back_1.BackColor = tabVerticalInput.DotV2BackColors[1];
            dotnetBarv2UserControl.back_2.BackColor = tabVerticalInput.DotV2BackColors[2];
            dotnetBarv2UserControl.back_3.BackColor = tabVerticalInput.DotV2BackColors[3];
            dotnetBarv2UserControl.back_4.BackColor = tabVerticalInput.DotV2BackColors[4];
            dotnetBarv2UserControl.back_5.BackColor = tabVerticalInput.DotV2BackColors[5];
            dotnetBarv2UserControl.back_6.BackColor = tabVerticalInput.DotV2BackColors[6];

            dotnetBarv2UserControl.border_0.BackColor = tabVerticalInput.DotV2BorderColors[0];
            dotnetBarv2UserControl.border_1.BackColor = tabVerticalInput.DotV2BorderColors[1];
            dotnetBarv2UserControl.border_2.BackColor = tabVerticalInput.DotV2BorderColors[2];
            dotnetBarv2UserControl.border_3.BackColor = tabVerticalInput.DotV2BorderColors[3];
            dotnetBarv2UserControl.border_4.BackColor = tabVerticalInput.DotV2BorderColors[4];
            dotnetBarv2UserControl.border_5.BackColor = tabVerticalInput.DotV2BorderColors[5];
            dotnetBarv2UserControl.border_6.BackColor = tabVerticalInput.DotV2BorderColors[6];

            dotnetBarv2UserControl.blend_0.BackColor = tabVerticalInput.DotV2BlendColors[0];
            dotnetBarv2UserControl.blend_1.BackColor = tabVerticalInput.DotV2BlendColors[1];
            dotnetBarv2UserControl.blend_2.BackColor = tabVerticalInput.DotV2BlendColors[2];


            dotnetBarv2UserControl.fore_0.BackColor = tabVerticalInput.DotV2ForeColors[0];
            dotnetBarv2UserControl.fore_1.BackColor = tabVerticalInput.DotV2ForeColors[1];


            dotnetBarv2UserControl.preview.DotV2BackColors[0] = tabVerticalInput.DotV2BackColors[0];
            dotnetBarv2UserControl.preview.DotV2BackColors[1] = tabVerticalInput.DotV2BackColors[1];
            dotnetBarv2UserControl.preview.DotV2BackColors[2] = tabVerticalInput.DotV2BackColors[2];
            dotnetBarv2UserControl.preview.DotV2BackColors[3] = tabVerticalInput.DotV2BackColors[3];
            dotnetBarv2UserControl.preview.DotV2BackColors[4] = tabVerticalInput.DotV2BackColors[4];
            dotnetBarv2UserControl.preview.DotV2BackColors[5] = tabVerticalInput.DotV2BackColors[5];
            dotnetBarv2UserControl.preview.DotV2BackColors[6] = tabVerticalInput.DotV2BackColors[6];

            dotnetBarv2UserControl.preview.DotV2BorderColors[0] = tabVerticalInput.DotV2BorderColors[0];
            dotnetBarv2UserControl.preview.DotV2BorderColors[1] = tabVerticalInput.DotV2BorderColors[1];
            dotnetBarv2UserControl.preview.DotV2BorderColors[2] = tabVerticalInput.DotV2BorderColors[2];
            dotnetBarv2UserControl.preview.DotV2BorderColors[3] = tabVerticalInput.DotV2BorderColors[3];
            dotnetBarv2UserControl.preview.DotV2BorderColors[4] = tabVerticalInput.DotV2BorderColors[4];
            dotnetBarv2UserControl.preview.DotV2BorderColors[5] = tabVerticalInput.DotV2BorderColors[5];
            dotnetBarv2UserControl.preview.DotV2BorderColors[6] = tabVerticalInput.DotV2BorderColors[6];

            dotnetBarv2UserControl.preview.DotV2BlendColors[0] = tabVerticalInput.DotV2BlendColors[0];
            dotnetBarv2UserControl.preview.DotV2BlendColors[1] = tabVerticalInput.DotV2BlendColors[1];
            dotnetBarv2UserControl.preview.DotV2BlendColors[2] = tabVerticalInput.DotV2BlendColors[2];


            dotnetBarv2UserControl.preview.DotV2ForeColors[0] = tabVerticalInput.DotV2ForeColors[0];
            dotnetBarv2UserControl.preview.DotV2ForeColors[1] = tabVerticalInput.DotV2ForeColors[1];


        }

        /// <summary>
        /// Dotnets the bar v2 submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void DotnetBarV2Submit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.DotV2BackColors[0] = dotnetBarv2UserControl.back_0.BackColor;
            tabVerticalInput.DotV2BackColors[1] = dotnetBarv2UserControl.back_1.BackColor;
            tabVerticalInput.DotV2BackColors[2] = dotnetBarv2UserControl.back_2.BackColor;
            tabVerticalInput.DotV2BackColors[3] = dotnetBarv2UserControl.back_3.BackColor;
            tabVerticalInput.DotV2BackColors[4] = dotnetBarv2UserControl.back_4.BackColor;
            tabVerticalInput.DotV2BackColors[5] = dotnetBarv2UserControl.back_5.BackColor;
            tabVerticalInput.DotV2BackColors[6] = dotnetBarv2UserControl.back_6.BackColor;

            tabVerticalInput.DotV2BorderColors[0] = dotnetBarv2UserControl.border_0.BackColor;
            tabVerticalInput.DotV2BorderColors[1] = dotnetBarv2UserControl.border_1.BackColor;
            tabVerticalInput.DotV2BorderColors[2] = dotnetBarv2UserControl.border_2.BackColor;
            tabVerticalInput.DotV2BorderColors[3] = dotnetBarv2UserControl.border_3.BackColor;
            tabVerticalInput.DotV2BorderColors[4] = dotnetBarv2UserControl.border_4.BackColor;
            tabVerticalInput.DotV2BorderColors[5] = dotnetBarv2UserControl.border_5.BackColor;
            tabVerticalInput.DotV2BorderColors[6] = dotnetBarv2UserControl.border_6.BackColor;

            tabVerticalInput.DotV2BlendColors[0] = dotnetBarUserControl.blend_0.BackColor;
            tabVerticalInput.DotV2BlendColors[1] = dotnetBarUserControl.blend_1.BackColor;
            tabVerticalInput.DotV2BlendColors[2] = dotnetBarUserControl.blend_2.BackColor;

            tabVerticalInput.DotV2ForeColors[0] = dotnetBarUserControl.fore_0.BackColor;
            tabVerticalInput.DotV2ForeColors[1] = dotnetBarUserControl.fore_1.BackColor;

        }

        #endregion

        #region EightBall

        /// <summary>
        /// Eights the ball initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void EightBallInitialValues(TabVerticalInput tabVerticalInput)
        {
            eightBallUserControl.back_0.BackColor = tabVerticalInput.EightBallBackColors[0];
            eightBallUserControl.back_1.BackColor = tabVerticalInput.EightBallBackColors[1];
            eightBallUserControl.back_2.BackColor = tabVerticalInput.EightBallBackColors[2];
            eightBallUserControl.back_3.BackColor = tabVerticalInput.EightBallBackColors[3];
            eightBallUserControl.back_4.BackColor = tabVerticalInput.EightBallBackColors[4];
            eightBallUserControl.back_5.BackColor = tabVerticalInput.EightBallBackColors[5];
            eightBallUserControl.back_6.BackColor = tabVerticalInput.EightBallBackColors[6];
            eightBallUserControl.back_7.BackColor = tabVerticalInput.EightBallBackColors[7];

            eightBallUserControl.border_0.BackColor = tabVerticalInput.EightBallBorderColors[0];
            eightBallUserControl.border_1.BackColor = tabVerticalInput.EightBallBorderColors[1];
            eightBallUserControl.border_2.BackColor = tabVerticalInput.EightBallBorderColors[2];
            eightBallUserControl.border_3.BackColor = tabVerticalInput.EightBallBorderColors[3];


            eightBallUserControl.fore_0.BackColor = tabVerticalInput.EightBallForeColors[0];
            eightBallUserControl.fore_1.BackColor = tabVerticalInput.EightBallForeColors[1];


            eightBallUserControl.preview.EightBallBackColors[0] = tabVerticalInput.EightBallBackColors[0];
            eightBallUserControl.preview.EightBallBackColors[1] = tabVerticalInput.EightBallBackColors[1];
            eightBallUserControl.preview.EightBallBackColors[2] = tabVerticalInput.EightBallBackColors[2];
            eightBallUserControl.preview.EightBallBackColors[3] = tabVerticalInput.EightBallBackColors[3];
            eightBallUserControl.preview.EightBallBackColors[4] = tabVerticalInput.EightBallBackColors[4];
            eightBallUserControl.preview.EightBallBackColors[5] = tabVerticalInput.EightBallBackColors[5];
            eightBallUserControl.preview.EightBallBackColors[6] = tabVerticalInput.EightBallBackColors[6];
            eightBallUserControl.preview.EightBallBackColors[7] = tabVerticalInput.EightBallBackColors[7];

            eightBallUserControl.preview.EightBallBorderColors[0] = tabVerticalInput.EightBallBorderColors[0];
            eightBallUserControl.preview.EightBallBorderColors[1] = tabVerticalInput.EightBallBorderColors[1];
            eightBallUserControl.preview.EightBallBorderColors[2] = tabVerticalInput.EightBallBorderColors[2];
            eightBallUserControl.preview.EightBallBorderColors[3] = tabVerticalInput.EightBallBorderColors[3];


            eightBallUserControl.preview.EightBallForeColors[0] = tabVerticalInput.EightBallForeColors[0];
            eightBallUserControl.preview.EightBallForeColors[1] = tabVerticalInput.EightBallForeColors[1];


        }

        /// <summary>
        /// Eights the ball submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void EightBallSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.EightBallBackColors[0] = eightBallUserControl.back_0.BackColor;
            tabVerticalInput.EightBallBackColors[1] = eightBallUserControl.back_1.BackColor;
            tabVerticalInput.EightBallBackColors[2] = eightBallUserControl.back_2.BackColor;
            tabVerticalInput.EightBallBackColors[3] = eightBallUserControl.back_3.BackColor;
            tabVerticalInput.EightBallBackColors[4] = eightBallUserControl.back_4.BackColor;
            tabVerticalInput.EightBallBackColors[5] = eightBallUserControl.back_5.BackColor;
            tabVerticalInput.EightBallBackColors[6] = eightBallUserControl.back_6.BackColor;
            tabVerticalInput.EightBallBackColors[7] = eightBallUserControl.back_7.BackColor;

            tabVerticalInput.EightBallBorderColors[0] = eightBallUserControl.border_0.BackColor;
            tabVerticalInput.EightBallBorderColors[1] = eightBallUserControl.border_1.BackColor;
            tabVerticalInput.EightBallBorderColors[2] = eightBallUserControl.border_2.BackColor;
            tabVerticalInput.EightBallBorderColors[3] = eightBallUserControl.border_3.BackColor;
            
            
            tabVerticalInput.EightBallForeColors[0] = eightBallUserControl.fore_0.BackColor;
            tabVerticalInput.EightBallForeColors[1] = eightBallUserControl.fore_1.BackColor;
        }

        #endregion

        #region Empire

        /// <summary>
        /// Empires the initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void EmpireInitialValues(TabVerticalInput tabVerticalInput)
        {
            empireUserControl.back_0.BackColor = tabVerticalInput.EmpireBackColors[0];
            empireUserControl.back_1.BackColor = tabVerticalInput.EmpireBackColors[1];
            empireUserControl.back_2.BackColor = tabVerticalInput.EmpireBackColors[2];
            empireUserControl.back_3.BackColor = tabVerticalInput.EmpireBackColors[3];
            empireUserControl.back_4.BackColor = tabVerticalInput.EmpireBackColors[4];
            empireUserControl.back_5.BackColor = tabVerticalInput.EmpireBackColors[5];
            empireUserControl.back_6.BackColor = tabVerticalInput.EmpireBackColors[6];
            empireUserControl.back_7.BackColor = tabVerticalInput.EmpireBackColors[7];
            empireUserControl.back_8.BackColor = tabVerticalInput.EmpireBackColors[8];
            empireUserControl.back_9.BackColor = tabVerticalInput.EmpireBackColors[9];
            empireUserControl.back_10.BackColor = tabVerticalInput.EmpireBackColors[10];

            empireUserControl.border_0.BackColor = tabVerticalInput.EmpireBorderColors[0];
            empireUserControl.border_1.BackColor = tabVerticalInput.EmpireBorderColors[1];
            empireUserControl.border_2.BackColor = tabVerticalInput.EmpireBorderColors[2];
            empireUserControl.border_3.BackColor = tabVerticalInput.EmpireBorderColors[3];
            empireUserControl.border_4.BackColor = tabVerticalInput.EmpireBorderColors[4];


            empireUserControl.fore_0.BackColor = tabVerticalInput.EmpireForeColors[0];
            empireUserControl.fore_1.BackColor = tabVerticalInput.EmpireForeColors[1];


            empireUserControl.preview.EmpireBackColors[0] = tabVerticalInput.EmpireBackColors[0];
            empireUserControl.preview.EmpireBackColors[1] = tabVerticalInput.EmpireBackColors[1];
            empireUserControl.preview.EmpireBackColors[2] = tabVerticalInput.EmpireBackColors[2];
            empireUserControl.preview.EmpireBackColors[3] = tabVerticalInput.EmpireBackColors[3];
            empireUserControl.preview.EmpireBackColors[4] = tabVerticalInput.EmpireBackColors[4];
            empireUserControl.preview.EmpireBackColors[5] = tabVerticalInput.EmpireBackColors[5];
            empireUserControl.preview.EmpireBackColors[6] = tabVerticalInput.EmpireBackColors[6];
            empireUserControl.preview.EmpireBackColors[7] = tabVerticalInput.EmpireBackColors[7];
            empireUserControl.preview.EmpireBackColors[8] = tabVerticalInput.EmpireBackColors[8];
            empireUserControl.preview.EmpireBackColors[9] = tabVerticalInput.EmpireBackColors[9];
            empireUserControl.preview.EmpireBackColors[10] = tabVerticalInput.EmpireBackColors[10];

            empireUserControl.preview.EmpireBorderColors[0] = tabVerticalInput.EmpireBorderColors[0];
            empireUserControl.preview.EmpireBorderColors[1] = tabVerticalInput.EmpireBorderColors[1];
            empireUserControl.preview.EmpireBorderColors[2] = tabVerticalInput.EmpireBorderColors[2];
            empireUserControl.preview.EmpireBorderColors[3] = tabVerticalInput.EmpireBorderColors[3];
            empireUserControl.preview.EmpireBorderColors[4] = tabVerticalInput.EmpireBorderColors[4];


            empireUserControl.preview.EmpireForeColors[0] = tabVerticalInput.EmpireForeColors[0];
            empireUserControl.preview.EmpireForeColors[1] = tabVerticalInput.EmpireForeColors[1];


        }

        /// <summary>
        /// Empires the submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void EmpireSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.EmpireBackColors[0] = empireUserControl.back_0.BackColor;
            tabVerticalInput.EmpireBackColors[1] = empireUserControl.back_1.BackColor;
            tabVerticalInput.EmpireBackColors[2] = empireUserControl.back_2.BackColor;
            tabVerticalInput.EmpireBackColors[3] = empireUserControl.back_3.BackColor;
            tabVerticalInput.EmpireBackColors[4] = empireUserControl.back_4.BackColor;
            tabVerticalInput.EmpireBackColors[5] = empireUserControl.back_5.BackColor;
            tabVerticalInput.EmpireBackColors[6] = empireUserControl.back_6.BackColor;
            tabVerticalInput.EmpireBackColors[7] = empireUserControl.back_7.BackColor;
            tabVerticalInput.EmpireBackColors[8] = empireUserControl.back_7.BackColor;
            tabVerticalInput.EmpireBackColors[9] = empireUserControl.back_7.BackColor;
            tabVerticalInput.EmpireBackColors[10] = empireUserControl.back_7.BackColor;

            tabVerticalInput.EmpireBorderColors[0] = empireUserControl.border_0.BackColor;
            tabVerticalInput.EmpireBorderColors[1] = empireUserControl.border_1.BackColor;
            tabVerticalInput.EmpireBorderColors[2] = empireUserControl.border_2.BackColor;
            tabVerticalInput.EmpireBorderColors[3] = empireUserControl.border_3.BackColor;
            tabVerticalInput.EmpireBorderColors[4] = empireUserControl.border_3.BackColor;


            tabVerticalInput.EmpireForeColors[0] = empireUserControl.fore_0.BackColor;
            tabVerticalInput.EmpireForeColors[1] = empireUserControl.fore_1.BackColor;
        }

        #endregion

        #region Facebook

        /// <summary>
        /// Facebooks the initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void FacebookInitialValues(TabVerticalInput tabVerticalInput)
        {
            facebookUserControl.pressed.BackColor = tabVerticalInput.PressedTabColor;

            facebookUserControl.back.BackColor = tabVerticalInput.FaceBookBack;

            facebookUserControl.normal.BackColor = tabVerticalInput.NormalColor;

            facebookUserControl.hover.BackColor = tabVerticalInput.HoverColor;

            facebookUserControl.border.BackColor = tabVerticalInput.FaceBookBorderColor;

            facebookUserControl.fore.BackColor = tabVerticalInput.FaceBookTextColor;



            facebookUserControl.preview.PressedTabColor = tabVerticalInput.PressedTabColor;

            facebookUserControl.preview.FaceBookBack = tabVerticalInput.FaceBookBack;

            facebookUserControl.preview.NormalColor = tabVerticalInput.NormalColor;

            facebookUserControl.preview.HoverColor = tabVerticalInput.HoverColor;

            facebookUserControl.preview.FaceBookBorderColor = tabVerticalInput.FaceBookBorderColor;

            facebookUserControl.preview.FaceBookTextColor = tabVerticalInput.FaceBookTextColor;
            
        }

        /// <summary>
        /// Facebooks the submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void FacebookSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.PressedTabColor = facebookUserControl.pressed.BackColor;

            tabVerticalInput.FaceBookBack = facebookUserControl.back.BackColor;

            tabVerticalInput.NormalColor = facebookUserControl.normal.BackColor;

            tabVerticalInput.HoverColor = facebookUserControl.hover.BackColor;

            tabVerticalInput.FaceBookBorderColor = facebookUserControl.border.BackColor;

            tabVerticalInput.FaceBookTextColor = facebookUserControl.fore.BackColor;
            
        }

        #endregion

        #region Firefox

        /// <summary>
        /// Fires the fox initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void FireFoxInitialValues(TabVerticalInput tabVerticalInput)
        {

            fireFoxMainUserControl.back_0.BackColor = tabVerticalInput.FireFoxBackColors[0];
            fireFoxMainUserControl.back_1.BackColor = tabVerticalInput.FireFoxBackColors[1];
            fireFoxMainUserControl.back_2.BackColor = tabVerticalInput.FireFoxBackColors[2];
            fireFoxMainUserControl.back_3.BackColor = tabVerticalInput.FireFoxBackColors[3];
            fireFoxMainUserControl.back_4.BackColor = tabVerticalInput.FireFoxBackColors[4];
            

            fireFoxMainUserControl.fore_0.BackColor = tabVerticalInput.FireFoxForeColors[0];
            fireFoxMainUserControl.fore_1.BackColor = tabVerticalInput.FireFoxForeColors[1];
            fireFoxMainUserControl.fore_2.BackColor = tabVerticalInput.FireFoxForeColors[1];



            fireFoxMainUserControl.preview.FireFoxBackColors[0] = tabVerticalInput.FireFoxBackColors[0];
            fireFoxMainUserControl.preview.FireFoxBackColors[1] = tabVerticalInput.FireFoxBackColors[1];
            fireFoxMainUserControl.preview.FireFoxBackColors[2] = tabVerticalInput.FireFoxBackColors[2];
            fireFoxMainUserControl.preview.FireFoxBackColors[3] = tabVerticalInput.FireFoxBackColors[3];
            fireFoxMainUserControl.preview.FireFoxBackColors[4] = tabVerticalInput.FireFoxBackColors[4];


            fireFoxMainUserControl.preview.FireFoxForeColors[0] = tabVerticalInput.FireFoxForeColors[0];
            fireFoxMainUserControl.preview.FireFoxForeColors[1] = tabVerticalInput.FireFoxForeColors[1];
            fireFoxMainUserControl.preview.FireFoxForeColors[2] = tabVerticalInput.FireFoxForeColors[1];


        }

        /// <summary>
        /// Fires the fox submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void FireFoxSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.FireFoxBackColors[0] = fireFoxMainUserControl.back_0.BackColor;
            tabVerticalInput.FireFoxBackColors[1] = fireFoxMainUserControl.back_1.BackColor;
            tabVerticalInput.FireFoxBackColors[2] = fireFoxMainUserControl.back_2.BackColor;
            tabVerticalInput.FireFoxBackColors[3] = fireFoxMainUserControl.back_3.BackColor;
            tabVerticalInput.FireFoxBackColors[4] = fireFoxMainUserControl.back_4.BackColor;

            tabVerticalInput.FireFoxForeColors[0] = fireFoxMainUserControl.fore_0.BackColor;
            tabVerticalInput.FireFoxForeColors[1] = fireFoxMainUserControl.fore_1.BackColor;
            tabVerticalInput.FireFoxForeColors[2] = fireFoxMainUserControl.fore_2.BackColor;
        }

        #endregion

        #region Meph

        /// <summary>
        /// Mephes the initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void MephInitialValues(TabVerticalInput tabVerticalInput)
        {

            mephUserControl.back_0.BackColor = tabVerticalInput.MephBackColors[0];
            mephUserControl.back_1.BackColor = tabVerticalInput.MephBackColors[1];
            mephUserControl.back_2.BackColor = tabVerticalInput.MephBackColors[2];
            mephUserControl.back_3.BackColor = tabVerticalInput.MephBackColors[3];
            mephUserControl.back_4.BackColor = tabVerticalInput.MephBackColors[4];


            mephUserControl.border_0.BackColor = tabVerticalInput.MephBorderColors[0];
            mephUserControl.border_1.BackColor = tabVerticalInput.MephBorderColors[1];
            mephUserControl.border_2.BackColor = tabVerticalInput.MephBorderColors[2];
            mephUserControl.border_3.BackColor = tabVerticalInput.MephBorderColors[3];
            mephUserControl.border_4.BackColor = tabVerticalInput.MephBorderColors[4];

            mephUserControl.full_0.BackColor = tabVerticalInput.CFull[0];
            mephUserControl.full_1.BackColor = tabVerticalInput.CFull[1];
            mephUserControl.full_2.BackColor = tabVerticalInput.CFull[2];
            mephUserControl.full_3.BackColor = tabVerticalInput.CFull[3];
            mephUserControl.full_4.BackColor = tabVerticalInput.CFull[4];
            mephUserControl.full_5.BackColor = tabVerticalInput.CFull[5];
            mephUserControl.full_6.BackColor = tabVerticalInput.CFull[6];
            mephUserControl.full_7.BackColor = tabVerticalInput.CFull[7];

            mephUserControl.highlight_0.BackColor = tabVerticalInput.CHighlight[0];
            mephUserControl.highlight_1.BackColor = tabVerticalInput.CHighlight[1];
            mephUserControl.highlight_2.BackColor = tabVerticalInput.CHighlight[2];
            mephUserControl.highlight_3.BackColor = tabVerticalInput.CHighlight[3];
            mephUserControl.highlight_4.BackColor = tabVerticalInput.CHighlight[4];
            mephUserControl.highlight_5.BackColor = tabVerticalInput.CHighlight[5];
            mephUserControl.highlight_6.BackColor = tabVerticalInput.CHighlight[6];
            mephUserControl.highlight_7.BackColor = tabVerticalInput.CHighlight[7];

            mephUserControl.fill_0.BackColor = tabVerticalInput.PageFill[0];
            mephUserControl.fill_1.BackColor = tabVerticalInput.PageFill[1];
            mephUserControl.fill_2.BackColor = tabVerticalInput.PageFill[2];
            mephUserControl.fill_3.BackColor = tabVerticalInput.PageFill[3];
            mephUserControl.fill_4.BackColor = tabVerticalInput.PageFill[4];
            mephUserControl.fill_5.BackColor = tabVerticalInput.PageFill[5];
            mephUserControl.fill_6.BackColor = tabVerticalInput.PageFill[6];
            mephUserControl.fill_7.BackColor = tabVerticalInput.PageFill[7];

            mephUserControl.blend_0.BackColor = tabVerticalInput.MephColorBlend[0];
            mephUserControl.blend_1.BackColor = tabVerticalInput.MephColorBlend[1];
            mephUserControl.blend_2.BackColor = tabVerticalInput.MephColorBlend[2];

            mephUserControl.fore_0.BackColor = tabVerticalInput.MephForeColors[0];
            mephUserControl.fore_1.BackColor = tabVerticalInput.MephForeColors[1];



            mephUserControl.preview.MephBackColors[0] = tabVerticalInput.MephBackColors[0];
            mephUserControl.preview.MephBackColors[1] = tabVerticalInput.MephBackColors[1];
            mephUserControl.preview.MephBackColors[2] = tabVerticalInput.MephBackColors[2];
            mephUserControl.preview.MephBackColors[3] = tabVerticalInput.MephBackColors[3];
            mephUserControl.preview.MephBackColors[4] = tabVerticalInput.MephBackColors[4];


            mephUserControl.preview.MephBorderColors[0] = tabVerticalInput.MephBorderColors[0];
            mephUserControl.preview.MephBorderColors[1] = tabVerticalInput.MephBorderColors[1];
            mephUserControl.preview.MephBorderColors[2] = tabVerticalInput.MephBorderColors[2];
            mephUserControl.preview.MephBorderColors[3] = tabVerticalInput.MephBorderColors[3];
            mephUserControl.preview.MephBorderColors[4] = tabVerticalInput.MephBorderColors[4];

            mephUserControl.preview.CFull[0] = tabVerticalInput.CFull[0];
            mephUserControl.preview.CFull[1] = tabVerticalInput.CFull[1];
            mephUserControl.preview.CFull[2] = tabVerticalInput.CFull[2];
            mephUserControl.preview.CFull[3] = tabVerticalInput.CFull[3];
            mephUserControl.preview.CFull[4] = tabVerticalInput.CFull[4];
            mephUserControl.preview.CFull[5] = tabVerticalInput.CFull[5];
            mephUserControl.preview.CFull[6] = tabVerticalInput.CFull[6];
            mephUserControl.preview.CFull[7] = tabVerticalInput.CFull[7];

            mephUserControl.preview.CHighlight[0] = tabVerticalInput.CHighlight[0];
            mephUserControl.preview.CHighlight[1] = tabVerticalInput.CHighlight[1];
            mephUserControl.preview.CHighlight[2] = tabVerticalInput.CHighlight[2];
            mephUserControl.preview.CHighlight[3] = tabVerticalInput.CHighlight[3];
            mephUserControl.preview.CHighlight[4] = tabVerticalInput.CHighlight[4];
            mephUserControl.preview.CHighlight[5] = tabVerticalInput.CHighlight[5];
            mephUserControl.preview.CHighlight[6] = tabVerticalInput.CHighlight[6];
            mephUserControl.preview.CHighlight[7] = tabVerticalInput.CHighlight[7];

            mephUserControl.preview.PageFill[0] = tabVerticalInput.PageFill[0];
            mephUserControl.preview.PageFill[1] = tabVerticalInput.PageFill[1];
            mephUserControl.preview.PageFill[2] = tabVerticalInput.PageFill[2];
            mephUserControl.preview.PageFill[3] = tabVerticalInput.PageFill[3];
            mephUserControl.preview.PageFill[4] = tabVerticalInput.PageFill[4];
            mephUserControl.preview.PageFill[5] = tabVerticalInput.PageFill[5];
            mephUserControl.preview.PageFill[6] = tabVerticalInput.PageFill[6];
            mephUserControl.preview.PageFill[7] = tabVerticalInput.PageFill[7];

            mephUserControl.preview.MephColorBlend[0] = tabVerticalInput.MephColorBlend[0];
            mephUserControl.preview.MephColorBlend[1] = tabVerticalInput.MephColorBlend[1];
            mephUserControl.preview.MephColorBlend[2] = tabVerticalInput.MephColorBlend[2];

            mephUserControl.preview.MephForeColors[0] = tabVerticalInput.MephForeColors[0];
            mephUserControl.preview.MephForeColors[1] = tabVerticalInput.MephForeColors[1];


        }

        /// <summary>
        /// Mephes the submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void MephSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.MephBackColors[0] = mephUserControl.back_0.BackColor;
            tabVerticalInput.MephBackColors[1] = mephUserControl.back_1.BackColor;
            tabVerticalInput.MephBackColors[2] = mephUserControl.back_2.BackColor;
            tabVerticalInput.MephBackColors[3] = mephUserControl.back_3.BackColor;
            tabVerticalInput.MephBackColors[4] = mephUserControl.back_4.BackColor;

            tabVerticalInput.MephBorderColors[0] = mephUserControl.border_0.BackColor;
            tabVerticalInput.MephBorderColors[1] = mephUserControl.border_1.BackColor;
            tabVerticalInput.MephBorderColors[2] = mephUserControl.border_2.BackColor;
            tabVerticalInput.MephBorderColors[3] = mephUserControl.border_3.BackColor;
            tabVerticalInput.MephBorderColors[4] = mephUserControl.border_4.BackColor;

            tabVerticalInput.CFull[0] = mephUserControl.full_0.BackColor;
            tabVerticalInput.CFull[1] = mephUserControl.full_1.BackColor;
            tabVerticalInput.CFull[2] = mephUserControl.full_2.BackColor;
            tabVerticalInput.CFull[3] = mephUserControl.full_3.BackColor;
            tabVerticalInput.CFull[4] = mephUserControl.full_4.BackColor;
            tabVerticalInput.CFull[5] = mephUserControl.full_5.BackColor;
            tabVerticalInput.CFull[6] = mephUserControl.full_6.BackColor;
            tabVerticalInput.CFull[7] = mephUserControl.full_7.BackColor;

            tabVerticalInput.CHighlight[0] = mephUserControl.highlight_0.BackColor;
            tabVerticalInput.CHighlight[1] = mephUserControl.highlight_1.BackColor;
            tabVerticalInput.CHighlight[2] = mephUserControl.highlight_2.BackColor;
            tabVerticalInput.CHighlight[3] = mephUserControl.highlight_3.BackColor;
            tabVerticalInput.CHighlight[4] = mephUserControl.highlight_4.BackColor;
            tabVerticalInput.CHighlight[5] = mephUserControl.highlight_5.BackColor;
            tabVerticalInput.CHighlight[6] = mephUserControl.highlight_6.BackColor;
            tabVerticalInput.CHighlight[7] = mephUserControl.highlight_7.BackColor;

            tabVerticalInput.PageFill[0] = mephUserControl.fill_0.BackColor;
            tabVerticalInput.PageFill[1] = mephUserControl.fill_1.BackColor;
            tabVerticalInput.PageFill[2] = mephUserControl.fill_2.BackColor;
            tabVerticalInput.PageFill[3] = mephUserControl.fill_3.BackColor;
            tabVerticalInput.PageFill[4] = mephUserControl.fill_4.BackColor;
            tabVerticalInput.PageFill[5] = mephUserControl.fill_5.BackColor;
            tabVerticalInput.PageFill[6] = mephUserControl.fill_6.BackColor;
            tabVerticalInput.PageFill[7] = mephUserControl.fill_7.BackColor;

            tabVerticalInput.MephColorBlend[0] = mephUserControl.blend_0.BackColor;
            tabVerticalInput.MephColorBlend[1] = mephUserControl.blend_1.BackColor;
            tabVerticalInput.MephColorBlend[2] = mephUserControl.blend_2.BackColor;

            tabVerticalInput.MephForeColors[0] = mephUserControl.fore_0.BackColor;
            tabVerticalInput.MephForeColors[1] = mephUserControl.fore_1.BackColor;
        }

        #endregion

        #region NS

        /// <summary>
        /// Nses the initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void NSInitialValues(TabVerticalInput tabVerticalInput)
        {

            nSUserControl.back_0.BackColor = tabVerticalInput.NsBackColors[0];
            nSUserControl.back_1.BackColor = tabVerticalInput.NsBackColors[1];
            nSUserControl.back_2.BackColor = tabVerticalInput.NsBackColors[2];
            nSUserControl.back_3.BackColor = tabVerticalInput.NsBackColors[3];
            nSUserControl.back_4.BackColor = tabVerticalInput.NsBackColors[4];
            nSUserControl.back_5.BackColor = tabVerticalInput.NsBackColors[5];
            nSUserControl.back_6.BackColor = tabVerticalInput.NsBackColors[6];
            nSUserControl.back_7.BackColor = tabVerticalInput.NsBackColors[7];

            nSUserControl.border_0.BackColor = tabVerticalInput.NsBorderColors[0];
            nSUserControl.border_1.BackColor = tabVerticalInput.NsBorderColors[1];
            nSUserControl.border_2.BackColor = tabVerticalInput.NsBorderColors[2];

            nSUserControl.fore_0.BackColor = tabVerticalInput.NsForeColors[0];
            nSUserControl.fore_1.BackColor = tabVerticalInput.NsForeColors[1];



            nSUserControl.preview.NsBackColors[0] = tabVerticalInput.NsBackColors[0];
            nSUserControl.preview.NsBackColors[1] = tabVerticalInput.NsBackColors[1];
            nSUserControl.preview.NsBackColors[2] = tabVerticalInput.NsBackColors[2];
            nSUserControl.preview.NsBackColors[3] = tabVerticalInput.NsBackColors[3];
            nSUserControl.preview.NsBackColors[4] = tabVerticalInput.NsBackColors[4];
            nSUserControl.preview.NsBackColors[5] = tabVerticalInput.NsBackColors[5];
            nSUserControl.preview.NsBackColors[6] = tabVerticalInput.NsBackColors[6];
            nSUserControl.preview.NsBackColors[7] = tabVerticalInput.NsBackColors[7];

            nSUserControl.preview.NsBorderColors[0] = tabVerticalInput.NsBorderColors[0];
            nSUserControl.preview.NsBorderColors[1] = tabVerticalInput.NsBorderColors[1];
            nSUserControl.preview.NsBorderColors[2] = tabVerticalInput.NsBorderColors[2];

            nSUserControl.preview.NsForeColors[0] = tabVerticalInput.NsForeColors[0];
            nSUserControl.preview.NsForeColors[1] = tabVerticalInput.NsForeColors[1];


        }

        /// <summary>
        /// Nses the submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void NsSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.NsBackColors[0] = nSUserControl.back_0.BackColor;
            tabVerticalInput.NsBackColors[1] = nSUserControl.back_1.BackColor;
            tabVerticalInput.NsBackColors[2] = nSUserControl.back_2.BackColor;
            tabVerticalInput.NsBackColors[3] = nSUserControl.back_3.BackColor;
            tabVerticalInput.NsBackColors[4] = nSUserControl.back_4.BackColor;
            tabVerticalInput.NsBackColors[5] = nSUserControl.back_5.BackColor;
            tabVerticalInput.NsBackColors[6] = nSUserControl.back_6.BackColor;
            tabVerticalInput.NsBackColors[7] = nSUserControl.back_7.BackColor;

            tabVerticalInput.NsBorderColors[0] = nSUserControl.border_0.BackColor;
            tabVerticalInput.NsBorderColors[1] = nSUserControl.border_1.BackColor;
            tabVerticalInput.NsBorderColors[2] = nSUserControl.border_2.BackColor;


            tabVerticalInput.NsForeColors[0] = nSUserControl.fore_0.BackColor;
            tabVerticalInput.NsForeColors[1] = nSUserControl.fore_1.BackColor;
            
        }

        #endregion

        #region Redemption

        /// <summary>
        /// Redemptions the initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void RedemptionInitialValues(TabVerticalInput tabVerticalInput)
        {

            redemptionUserControl.back_0.BackColor = tabVerticalInput.RedemptionBackColors[0];
            redemptionUserControl.back_1.BackColor = tabVerticalInput.RedemptionBackColors[1];
            redemptionUserControl.back_2.BackColor = tabVerticalInput.RedemptionBackColors[2];
            redemptionUserControl.back_3.BackColor = tabVerticalInput.RedemptionBackColors[3];
            redemptionUserControl.back_4.BackColor = tabVerticalInput.RedemptionBackColors[4];
            redemptionUserControl.back_5.BackColor = tabVerticalInput.RedemptionBackColors[5];

            redemptionUserControl.border_0.BackColor = tabVerticalInput.RedemptionBorderColors[0];
            redemptionUserControl.border_1.BackColor = tabVerticalInput.RedemptionBorderColors[1];
            redemptionUserControl.border_2.BackColor = tabVerticalInput.RedemptionBorderColors[2];
            redemptionUserControl.border_3.BackColor = tabVerticalInput.RedemptionBorderColors[3];
            redemptionUserControl.border_4.BackColor = tabVerticalInput.RedemptionBorderColors[4];
            redemptionUserControl.border_5.BackColor = tabVerticalInput.RedemptionBorderColors[5];

            redemptionUserControl.gradientPen_0.BackColor = tabVerticalInput.GradientPen[0];
            redemptionUserControl.gradientPen_1.BackColor = tabVerticalInput.GradientPen[1];
            redemptionUserControl.gradientPen_2.BackColor = tabVerticalInput.GradientPen[2];
            redemptionUserControl.gradientPen_3.BackColor = tabVerticalInput.GradientPen[3];
            redemptionUserControl.gradientPen_4.BackColor = tabVerticalInput.GradientPen[4];
            redemptionUserControl.gradientPen_5.BackColor = tabVerticalInput.GradientPen[5];
            
            redemptionUserControl.fore_0.BackColor = tabVerticalInput.RedemptionForeColors[0];
            redemptionUserControl.fore_1.BackColor = tabVerticalInput.RedemptionForeColors[1];

            if (tabVerticalInput.BackgroundNoise)
            {
                redemptionUserControl.backGroundNoise_Yes_RadBtn.Checked = true;
                redemptionUserControl.preview.BackgroundNoise = true;
            }
            else
            {
                redemptionUserControl.backGroundNoise_No_RadBtn.Checked = true;
                redemptionUserControl.preview.BackgroundNoise = false;
            }


            redemptionUserControl.preview.RedemptionBackColors[0] = tabVerticalInput.RedemptionBackColors[0];
            redemptionUserControl.preview.RedemptionBackColors[1] = tabVerticalInput.RedemptionBackColors[1];
            redemptionUserControl.preview.RedemptionBackColors[2] = tabVerticalInput.RedemptionBackColors[2];
            redemptionUserControl.preview.RedemptionBackColors[3] = tabVerticalInput.RedemptionBackColors[3];
            redemptionUserControl.preview.RedemptionBackColors[4] = tabVerticalInput.RedemptionBackColors[4];
            redemptionUserControl.preview.RedemptionBackColors[5] = tabVerticalInput.RedemptionBackColors[5];

            redemptionUserControl.preview.RedemptionBorderColors[0] = tabVerticalInput.RedemptionBorderColors[0];
            redemptionUserControl.preview.RedemptionBorderColors[1] = tabVerticalInput.RedemptionBorderColors[1];
            redemptionUserControl.preview.RedemptionBorderColors[2] = tabVerticalInput.RedemptionBorderColors[2];
            redemptionUserControl.preview.RedemptionBorderColors[3] = tabVerticalInput.RedemptionBorderColors[3];
            redemptionUserControl.preview.RedemptionBorderColors[4] = tabVerticalInput.RedemptionBorderColors[4];
            redemptionUserControl.preview.RedemptionBorderColors[5] = tabVerticalInput.RedemptionBorderColors[5];

            redemptionUserControl.preview.GradientPen[0] = tabVerticalInput.GradientPen[0];
            redemptionUserControl.preview.GradientPen[1] = tabVerticalInput.GradientPen[1];
            redemptionUserControl.preview.GradientPen[2] = tabVerticalInput.GradientPen[2];
            redemptionUserControl.preview.GradientPen[3] = tabVerticalInput.GradientPen[3];
            redemptionUserControl.preview.GradientPen[4] = tabVerticalInput.GradientPen[4];
            redemptionUserControl.preview.GradientPen[5] = tabVerticalInput.GradientPen[5];

            redemptionUserControl.preview.RedemptionForeColors[0] = tabVerticalInput.RedemptionForeColors[0];
            redemptionUserControl.preview.RedemptionForeColors[1] = tabVerticalInput.RedemptionForeColors[1];


        }

        /// <summary>
        /// Redemptions the submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void RedemptionSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.RedemptionBackColors[0] = redemptionUserControl.back_0.BackColor;
            tabVerticalInput.RedemptionBackColors[1] = redemptionUserControl.back_1.BackColor;
            tabVerticalInput.RedemptionBackColors[2] = redemptionUserControl.back_2.BackColor;
            tabVerticalInput.RedemptionBackColors[3] = redemptionUserControl.back_3.BackColor;
            tabVerticalInput.RedemptionBackColors[4] = redemptionUserControl.back_4.BackColor;
            tabVerticalInput.RedemptionBackColors[5] = redemptionUserControl.back_5.BackColor;
            
            tabVerticalInput.RedemptionBorderColors[0] = redemptionUserControl.border_0.BackColor;
            tabVerticalInput.RedemptionBorderColors[1] = redemptionUserControl.border_1.BackColor;
            tabVerticalInput.RedemptionBorderColors[2] = redemptionUserControl.border_2.BackColor;
            tabVerticalInput.RedemptionBorderColors[3] = redemptionUserControl.border_3.BackColor;
            tabVerticalInput.RedemptionBorderColors[4] = redemptionUserControl.border_4.BackColor;
            tabVerticalInput.RedemptionBorderColors[5] = redemptionUserControl.border_5.BackColor;

            tabVerticalInput.GradientPen[0] = redemptionUserControl.gradientPen_0.BackColor;
            tabVerticalInput.GradientPen[1] = redemptionUserControl.gradientPen_1.BackColor;
            tabVerticalInput.GradientPen[2] = redemptionUserControl.gradientPen_2.BackColor;
            tabVerticalInput.GradientPen[3] = redemptionUserControl.gradientPen_3.BackColor;
            tabVerticalInput.GradientPen[4] = redemptionUserControl.gradientPen_4.BackColor;
            tabVerticalInput.GradientPen[5] = redemptionUserControl.gradientPen_5.BackColor;


            tabVerticalInput.RedemptionForeColors[0] = redemptionUserControl.fore_0.BackColor;
            tabVerticalInput.RedemptionForeColors[1] = redemptionUserControl.fore_1.BackColor;

            if (redemptionUserControl.backGroundNoise_Yes_RadBtn.Checked == true)
            {
                tabVerticalInput.BackgroundNoise = true;
            }
            else
            {
                tabVerticalInput.BackgroundNoise = false;
            }

        }

        #endregion

        #region SLC

        /// <summary>
        /// SLCs the initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void SLCInitialValues(TabVerticalInput tabVerticalInput)
        {

            sLCUserControl.back_0.BackColor = tabVerticalInput.SlcBackColors[0];
            sLCUserControl.back_1.BackColor = tabVerticalInput.SlcBackColors[1];
            sLCUserControl.back_2.BackColor = tabVerticalInput.SlcBackColors[2];
            sLCUserControl.back_3.BackColor = tabVerticalInput.SlcBackColors[3];
            sLCUserControl.back_4.BackColor = tabVerticalInput.SlcBackColors[4];
            sLCUserControl.back_5.BackColor = tabVerticalInput.SlcBackColors[5];
            sLCUserControl.back_6.BackColor = tabVerticalInput.SlcBackColors[6];
            sLCUserControl.back_7.BackColor = tabVerticalInput.SlcBackColors[7];
            sLCUserControl.back_8.BackColor = tabVerticalInput.SlcBackColors[8];
            sLCUserControl.back_9.BackColor = tabVerticalInput.SlcBackColors[9];
            sLCUserControl.back_10.BackColor = tabVerticalInput.SlcBackColors[10];
            sLCUserControl.back_11.BackColor = tabVerticalInput.SlcBackColors[11];
            sLCUserControl.back_12.BackColor = tabVerticalInput.SlcBackColors[12];


            sLCUserControl.border_0.BackColor = tabVerticalInput.SlcBorderColors[0];
            sLCUserControl.border_1.BackColor = tabVerticalInput.SlcBorderColors[1];
            sLCUserControl.border_2.BackColor = tabVerticalInput.SlcBorderColors[2];
            sLCUserControl.border_3.BackColor = tabVerticalInput.SlcBorderColors[3];
            sLCUserControl.border_4.BackColor = tabVerticalInput.SlcBorderColors[4];
            sLCUserControl.border_5.BackColor = tabVerticalInput.SlcBorderColors[5];
            sLCUserControl.border_6.BackColor = tabVerticalInput.SlcBorderColors[6];
            sLCUserControl.border_7.BackColor = tabVerticalInput.SlcBorderColors[7];
            sLCUserControl.border_8.BackColor = tabVerticalInput.SlcBorderColors[8];
            sLCUserControl.border_9.BackColor = tabVerticalInput.SlcBorderColors[9];

            sLCUserControl.fore.BackColor = tabVerticalInput.SlcForeColors[0];



            sLCUserControl.preview.SlcBackColors[0] = tabVerticalInput.SlcBackColors[0];
            sLCUserControl.preview.SlcBackColors[1] = tabVerticalInput.SlcBackColors[1];
            sLCUserControl.preview.SlcBackColors[2] = tabVerticalInput.SlcBackColors[2];
            sLCUserControl.preview.SlcBackColors[3] = tabVerticalInput.SlcBackColors[3];
            sLCUserControl.preview.SlcBackColors[4] = tabVerticalInput.SlcBackColors[4];
            sLCUserControl.preview.SlcBackColors[5] = tabVerticalInput.SlcBackColors[5];
            sLCUserControl.preview.SlcBackColors[6] = tabVerticalInput.SlcBackColors[6];
            sLCUserControl.preview.SlcBackColors[7] = tabVerticalInput.SlcBackColors[7];
            sLCUserControl.preview.SlcBackColors[8] = tabVerticalInput.SlcBackColors[8];
            sLCUserControl.preview.SlcBackColors[9] = tabVerticalInput.SlcBackColors[9];
            sLCUserControl.preview.SlcBackColors[10] = tabVerticalInput.SlcBackColors[10];
            sLCUserControl.preview.SlcBackColors[11] = tabVerticalInput.SlcBackColors[11];
            sLCUserControl.preview.SlcBackColors[12] = tabVerticalInput.SlcBackColors[12];


            sLCUserControl.preview.SlcBorderColors[0] = tabVerticalInput.SlcBorderColors[0];
            sLCUserControl.preview.SlcBorderColors[1] = tabVerticalInput.SlcBorderColors[1];
            sLCUserControl.preview.SlcBorderColors[2] = tabVerticalInput.SlcBorderColors[2];
            sLCUserControl.preview.SlcBorderColors[3] = tabVerticalInput.SlcBorderColors[3];
            sLCUserControl.preview.SlcBorderColors[4] = tabVerticalInput.SlcBorderColors[4];
            sLCUserControl.preview.SlcBorderColors[5] = tabVerticalInput.SlcBorderColors[5];
            sLCUserControl.preview.SlcBorderColors[6] = tabVerticalInput.SlcBorderColors[6];
            sLCUserControl.preview.SlcBorderColors[7] = tabVerticalInput.SlcBorderColors[7];
            sLCUserControl.preview.SlcBorderColors[8] = tabVerticalInput.SlcBorderColors[8];
            sLCUserControl.preview.SlcBorderColors[9] = tabVerticalInput.SlcBorderColors[9];

            sLCUserControl.preview.SlcForeColors[0] = tabVerticalInput.SlcForeColors[0];


        }

        /// <summary>
        /// SLCs the submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void SLCSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.SlcBackColors[0] = sLCUserControl.back_0.BackColor;
            tabVerticalInput.SlcBackColors[1] = sLCUserControl.back_1.BackColor;
            tabVerticalInput.SlcBackColors[2] = sLCUserControl.back_2.BackColor;
            tabVerticalInput.SlcBackColors[3] = sLCUserControl.back_3.BackColor;
            tabVerticalInput.SlcBackColors[4] = sLCUserControl.back_4.BackColor;
            tabVerticalInput.SlcBackColors[5] = sLCUserControl.back_5.BackColor;
            tabVerticalInput.SlcBackColors[6] = sLCUserControl.back_6.BackColor;
            tabVerticalInput.SlcBackColors[7] = sLCUserControl.back_7.BackColor;
            tabVerticalInput.SlcBackColors[8] = sLCUserControl.back_7.BackColor;
            tabVerticalInput.SlcBackColors[9] = sLCUserControl.back_7.BackColor;
            tabVerticalInput.SlcBackColors[10] = sLCUserControl.back_7.BackColor;
            tabVerticalInput.SlcBackColors[11] = sLCUserControl.back_7.BackColor;
            tabVerticalInput.SlcBackColors[12] = sLCUserControl.back_7.BackColor;

            tabVerticalInput.SlcBorderColors[0] = sLCUserControl.border_0.BackColor;
            tabVerticalInput.SlcBorderColors[1] = sLCUserControl.border_1.BackColor;
            tabVerticalInput.SlcBorderColors[2] = sLCUserControl.border_2.BackColor;
            tabVerticalInput.SlcBorderColors[3] = sLCUserControl.border_3.BackColor;
            tabVerticalInput.SlcBorderColors[4] = sLCUserControl.border_4.BackColor;
            tabVerticalInput.SlcBorderColors[5] = sLCUserControl.border_5.BackColor;
            tabVerticalInput.SlcBorderColors[6] = sLCUserControl.border_6.BackColor;
            tabVerticalInput.SlcBorderColors[7] = sLCUserControl.border_7.BackColor;
            tabVerticalInput.SlcBorderColors[8] = sLCUserControl.border_8.BackColor;
            tabVerticalInput.SlcBorderColors[9] = sLCUserControl.border_9.BackColor;


            tabVerticalInput.SlcForeColors[0] = sLCUserControl.fore.BackColor;
            
        }

        #endregion

        #region xVisual

        /// <summary>
        /// xes the visual initial values.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void xVisualInitialValues(TabVerticalInput tabVerticalInput)
        {

            xVisualUserControl.back_0.BackColor = tabVerticalInput.XVisualBackColors[0];
            xVisualUserControl.back_1.BackColor = tabVerticalInput.XVisualBackColors[1];
            xVisualUserControl.back_2.BackColor = tabVerticalInput.XVisualBackColors[2];
            xVisualUserControl.back_3.BackColor = tabVerticalInput.XVisualBackColors[3];
            xVisualUserControl.back_4.BackColor = tabVerticalInput.XVisualBackColors[4];
            xVisualUserControl.back_5.BackColor = tabVerticalInput.XVisualBackColors[5];
            xVisualUserControl.back_6.BackColor = tabVerticalInput.XVisualBackColors[6];
            xVisualUserControl.back_7.BackColor = tabVerticalInput.XVisualBackColors[7];

            xVisualUserControl.border_0.BackColor = tabVerticalInput.XVisualBorderColors[0];
            xVisualUserControl.border_1.BackColor = tabVerticalInput.XVisualBorderColors[1];
            xVisualUserControl.border_2.BackColor = tabVerticalInput.XVisualBorderColors[2];
            xVisualUserControl.border_3.BackColor = tabVerticalInput.XVisualBorderColors[3];
            xVisualUserControl.border_4.BackColor = tabVerticalInput.XVisualBorderColors[4];
            xVisualUserControl.border_5.BackColor = tabVerticalInput.XVisualBorderColors[5];
            xVisualUserControl.border_6.BackColor = tabVerticalInput.XVisualBorderColors[6];
            xVisualUserControl.border_7.BackColor = tabVerticalInput.XVisualBorderColors[7];
            xVisualUserControl.border_8.BackColor = tabVerticalInput.XVisualBorderColors[8];
            xVisualUserControl.border_9.BackColor = tabVerticalInput.XVisualBorderColors[9];
            xVisualUserControl.border_10.BackColor = tabVerticalInput.XVisualBorderColors[10];
            xVisualUserControl.border_11.BackColor = tabVerticalInput.XVisualBorderColors[11];
            xVisualUserControl.border_12.BackColor = tabVerticalInput.XVisualBorderColors[12];
            xVisualUserControl.border_13.BackColor = tabVerticalInput.XVisualBorderColors[13];
            xVisualUserControl.border_14.BackColor = tabVerticalInput.XVisualBorderColors[14];
            xVisualUserControl.border_15.BackColor = tabVerticalInput.XVisualBorderColors[15];
            xVisualUserControl.border_16.BackColor = tabVerticalInput.XVisualBorderColors[16];
            xVisualUserControl.border_17.BackColor = tabVerticalInput.XVisualBorderColors[17];
            xVisualUserControl.border_18.BackColor = tabVerticalInput.XVisualBorderColors[18];
            xVisualUserControl.border_19.BackColor = tabVerticalInput.XVisualBorderColors[19];
            xVisualUserControl.border_20.BackColor = tabVerticalInput.XVisualBorderColors[20];


            xVisualUserControl.innerTexture_0.BackColor = tabVerticalInput.InnerTexture[0];
            xVisualUserControl.innerTexture_1.BackColor = tabVerticalInput.InnerTexture[1];
            xVisualUserControl.innerTexture_2.BackColor = tabVerticalInput.InnerTexture[2];

            xVisualUserControl.backgroundTexture_0.BackColor = tabVerticalInput.TabBGTexture[0];
            xVisualUserControl.backgroundTexture_1.BackColor = tabVerticalInput.TabBGTexture[1];
            xVisualUserControl.backgroundTexture_2.BackColor = tabVerticalInput.TabBGTexture[2];

            xVisualUserControl.glow_0.BackColor = tabVerticalInput.GlowColor[0];
            xVisualUserControl.glow_1.BackColor = tabVerticalInput.GlowColor[1];
            xVisualUserControl.glow_2.BackColor = tabVerticalInput.GlowColor[2];

            xVisualUserControl.fore_0.BackColor = tabVerticalInput.XVisualForeColors[0];
            xVisualUserControl.fore_1.BackColor = tabVerticalInput.XVisualForeColors[1];
            xVisualUserControl.fore_2.BackColor = tabVerticalInput.XVisualForeColors[2];





            xVisualUserControl.preview.XVisualBackColors[0] = tabVerticalInput.XVisualBackColors[0];
            xVisualUserControl.preview.XVisualBackColors[1] = tabVerticalInput.XVisualBackColors[1];
            xVisualUserControl.preview.XVisualBackColors[2] = tabVerticalInput.XVisualBackColors[2];
            xVisualUserControl.preview.XVisualBackColors[3] = tabVerticalInput.XVisualBackColors[3];
            xVisualUserControl.preview.XVisualBackColors[4] = tabVerticalInput.XVisualBackColors[4];
            xVisualUserControl.preview.XVisualBackColors[5] = tabVerticalInput.XVisualBackColors[5];
            xVisualUserControl.preview.XVisualBackColors[6] = tabVerticalInput.XVisualBackColors[6];
            xVisualUserControl.preview.XVisualBackColors[7] = tabVerticalInput.XVisualBackColors[7];

            xVisualUserControl.preview.XVisualBorderColors[0] = tabVerticalInput.XVisualBorderColors[0];
            xVisualUserControl.preview.XVisualBorderColors[1] = tabVerticalInput.XVisualBorderColors[1];
            xVisualUserControl.preview.XVisualBorderColors[2] = tabVerticalInput.XVisualBorderColors[2];
            xVisualUserControl.preview.XVisualBorderColors[3] = tabVerticalInput.XVisualBorderColors[3];
            xVisualUserControl.preview.XVisualBorderColors[4] = tabVerticalInput.XVisualBorderColors[4];
            xVisualUserControl.preview.XVisualBorderColors[5] = tabVerticalInput.XVisualBorderColors[5];
            xVisualUserControl.preview.XVisualBorderColors[6] = tabVerticalInput.XVisualBorderColors[6];
            xVisualUserControl.preview.XVisualBorderColors[7] = tabVerticalInput.XVisualBorderColors[7];
            xVisualUserControl.preview.XVisualBorderColors[8] = tabVerticalInput.XVisualBorderColors[8];
            xVisualUserControl.preview.XVisualBorderColors[9] = tabVerticalInput.XVisualBorderColors[9];
            xVisualUserControl.preview.XVisualBorderColors[10] = tabVerticalInput.XVisualBorderColors[10];
            xVisualUserControl.preview.XVisualBorderColors[11] = tabVerticalInput.XVisualBorderColors[11];
            xVisualUserControl.preview.XVisualBorderColors[12] = tabVerticalInput.XVisualBorderColors[12];
            xVisualUserControl.preview.XVisualBorderColors[13] = tabVerticalInput.XVisualBorderColors[13];
            xVisualUserControl.preview.XVisualBorderColors[14] = tabVerticalInput.XVisualBorderColors[14];
            xVisualUserControl.preview.XVisualBorderColors[15] = tabVerticalInput.XVisualBorderColors[15];
            xVisualUserControl.preview.XVisualBorderColors[16] = tabVerticalInput.XVisualBorderColors[16];
            xVisualUserControl.preview.XVisualBorderColors[17] = tabVerticalInput.XVisualBorderColors[17];
            xVisualUserControl.preview.XVisualBorderColors[18] = tabVerticalInput.XVisualBorderColors[18];
            xVisualUserControl.preview.XVisualBorderColors[19] = tabVerticalInput.XVisualBorderColors[19];
            xVisualUserControl.preview.XVisualBorderColors[20] = tabVerticalInput.XVisualBorderColors[20];


            xVisualUserControl.preview.InnerTexture[0] = tabVerticalInput.InnerTexture[0];
            xVisualUserControl.preview.InnerTexture[1] = tabVerticalInput.InnerTexture[1];
            xVisualUserControl.preview.InnerTexture[2] = tabVerticalInput.InnerTexture[2];

            xVisualUserControl.preview.TabBGTexture[0] = tabVerticalInput.TabBGTexture[0];
            xVisualUserControl.preview.TabBGTexture[1] = tabVerticalInput.TabBGTexture[1];
            xVisualUserControl.preview.TabBGTexture[2] = tabVerticalInput.TabBGTexture[2];

            xVisualUserControl.preview.GlowColor[0] = tabVerticalInput.GlowColor[0];
            xVisualUserControl.preview.GlowColor[1] = tabVerticalInput.GlowColor[1];
            xVisualUserControl.preview.GlowColor[2] = tabVerticalInput.GlowColor[2];

            xVisualUserControl.preview.XVisualForeColors[0] = tabVerticalInput.XVisualForeColors[0];
            xVisualUserControl.preview.XVisualForeColors[1] = tabVerticalInput.XVisualForeColors[1];
            xVisualUserControl.preview.XVisualForeColors[2] = tabVerticalInput.XVisualForeColors[2];



        }

        /// <summary>
        /// xes the visual submit.
        /// </summary>
        /// <param name="tabVerticalInput">The tab vertical input.</param>
        private void xVisualSubmit(TabVerticalInput tabVerticalInput)
        {

            #region Main Submit

            tabVerticalInput.TabStyle =
                (TabVerticalStyles)Enum.Parse(typeof
                        (TabVerticalStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabVerticalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabVerticalInput.XVisualBackColors[0] = xVisualUserControl.back_0.BackColor;
            tabVerticalInput.XVisualBackColors[1] = xVisualUserControl.back_1.BackColor;
            tabVerticalInput.XVisualBackColors[2] = xVisualUserControl.back_2.BackColor;
            tabVerticalInput.XVisualBackColors[3] = xVisualUserControl.back_3.BackColor;
            tabVerticalInput.XVisualBackColors[4] = xVisualUserControl.back_4.BackColor;
            tabVerticalInput.XVisualBackColors[5] = xVisualUserControl.back_5.BackColor;
            tabVerticalInput.XVisualBackColors[6] = xVisualUserControl.back_6.BackColor;
            tabVerticalInput.XVisualBackColors[7] = xVisualUserControl.back_7.BackColor;
            
            tabVerticalInput.XVisualBorderColors[0] = xVisualUserControl.border_0.BackColor;
            tabVerticalInput.XVisualBorderColors[1] = xVisualUserControl.border_1.BackColor;
            tabVerticalInput.XVisualBorderColors[2] = xVisualUserControl.border_2.BackColor;
            tabVerticalInput.XVisualBorderColors[3] = xVisualUserControl.border_3.BackColor;
            tabVerticalInput.XVisualBorderColors[4] = xVisualUserControl.border_4.BackColor;
            tabVerticalInput.XVisualBorderColors[5] = xVisualUserControl.border_5.BackColor;
            tabVerticalInput.XVisualBorderColors[6] = xVisualUserControl.border_6.BackColor;
            tabVerticalInput.XVisualBorderColors[7] = xVisualUserControl.border_7.BackColor;
            tabVerticalInput.XVisualBorderColors[8] = xVisualUserControl.border_8.BackColor;
            tabVerticalInput.XVisualBorderColors[9] = xVisualUserControl.border_9.BackColor;
            tabVerticalInput.XVisualBorderColors[10] = xVisualUserControl.border_10.BackColor;
            tabVerticalInput.XVisualBorderColors[11] = xVisualUserControl.border_11.BackColor;
            tabVerticalInput.XVisualBorderColors[12] = xVisualUserControl.border_12.BackColor;
            tabVerticalInput.XVisualBorderColors[13] = xVisualUserControl.border_13.BackColor;
            tabVerticalInput.XVisualBorderColors[14] = xVisualUserControl.border_14.BackColor;
            tabVerticalInput.XVisualBorderColors[15] = xVisualUserControl.border_15.BackColor;
            tabVerticalInput.XVisualBorderColors[16] = xVisualUserControl.border_16.BackColor;
            tabVerticalInput.XVisualBorderColors[17] = xVisualUserControl.border_17.BackColor;
            tabVerticalInput.XVisualBorderColors[18] = xVisualUserControl.border_18.BackColor;
            tabVerticalInput.XVisualBorderColors[19] = xVisualUserControl.border_19.BackColor;
            tabVerticalInput.XVisualBorderColors[20] = xVisualUserControl.border_20.BackColor;

            tabVerticalInput.InnerTexture[0] = xVisualUserControl.innerTexture_0.BackColor;
            tabVerticalInput.InnerTexture[1] = xVisualUserControl.innerTexture_1.BackColor;
            tabVerticalInput.InnerTexture[2] = xVisualUserControl.innerTexture_2.BackColor;

            tabVerticalInput.TabBGTexture[0] = xVisualUserControl.backgroundTexture_0.BackColor;
            tabVerticalInput.TabBGTexture[1] = xVisualUserControl.backgroundTexture_1.BackColor;
            tabVerticalInput.TabBGTexture[2] = xVisualUserControl.backgroundTexture_2.BackColor;

            tabVerticalInput.GlowColor[0] = xVisualUserControl.glow_0.BackColor;
            tabVerticalInput.GlowColor[1] = xVisualUserControl.glow_1.BackColor;
            tabVerticalInput.GlowColor[2] = xVisualUserControl.glow_2.BackColor;

            tabVerticalInput.XVisualForeColors[0] = xVisualUserControl.fore_0.BackColor;
            tabVerticalInput.XVisualForeColors[1] = xVisualUserControl.fore_1.BackColor;
            tabVerticalInput.XVisualForeColors[2] = xVisualUserControl.fore_2.BackColor;

        }

        #endregion
    }
}
