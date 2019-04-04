// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SetInitialSubmitValues.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Zeroit.Framework.TabThematic.Controls;

namespace Zeroit.Framework.TabThematic.DialogEditor
{
    /// <summary>
    /// Class TabThematicHorizontalDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TabThematicHorizontalDialog
    {

        /// <summary>
        /// Loads the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void LoadInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            
            #region Add Enum to ComboBox
            
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(TabStyles)))
            {
                mainControl_TabStyle_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < mainControl_TabStyle_ComboBox.Items.Count; i++)
            {
                if (tabHorizontalInput.TabStyle == (TabStyles)Enum.Parse(typeof(TabStyles), mainControl_TabStyle_ComboBox.Items[i].ToString()))
                {
                    mainControl_TabStyle_ComboBox.SelectedIndex = i;

                }

            }

            #endregion

            mainControl_SlideSpeed_ComboBox.Value = tabHorizontalInput.Speed;

        }

        #region ASC

        /// <summary>
        /// Ascs the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void ASCInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            asc.back.BackColor = tabHorizontalInput.AscBackColors[0];

            asc.border_0.BackColor = tabHorizontalInput.AscBorderColors[0];
            asc.border_1.BackColor = tabHorizontalInput.AscBorderColors[1];
            asc.border_2.BackColor = tabHorizontalInput.AscBorderColors[2];
            asc.border_3.BackColor = tabHorizontalInput.AscBorderColors[3];
            asc.border_4.BackColor = tabHorizontalInput.AscBorderColors[4];

            asc.fore_0.BackColor = tabHorizontalInput.AscForeColors[0];
            asc.fore_1.BackColor = tabHorizontalInput.AscForeColors[1];


            asc.preview.AscBackColors[0] = tabHorizontalInput.AscBackColors[0];

            asc.preview.AscBorderColors[0] = tabHorizontalInput.AscBorderColors[0];
            asc.preview.AscBorderColors[1] = tabHorizontalInput.AscBorderColors[1];
            asc.preview.AscBorderColors[2] = tabHorizontalInput.AscBorderColors[2];
            asc.preview.AscBorderColors[3] = tabHorizontalInput.AscBorderColors[3];
            asc.preview.AscBorderColors[4] = tabHorizontalInput.AscBorderColors[4];

            asc.preview.AscForeColors[0] = tabHorizontalInput.AscForeColors[0];
            asc.preview.AscForeColors[1] = tabHorizontalInput.AscForeColors[1];

        }

        /// <summary>
        /// Ascs the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void ASCSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.AscBackColors[0] = asc.back.BackColor;

            tabHorizontalInput.AscBorderColors[0] = asc.border_0.BackColor;
            tabHorizontalInput.AscBorderColors[1] = asc.border_1.BackColor;
            tabHorizontalInput.AscBorderColors[2] = asc.border_2.BackColor;
            tabHorizontalInput.AscBorderColors[3] = asc.border_3.BackColor;
            tabHorizontalInput.AscBorderColors[4] = asc.border_4.BackColor;

            tabHorizontalInput.AscForeColors[0] = asc.fore_0.BackColor;
            tabHorizontalInput.AscForeColors[1] = asc.fore_1.BackColor;
        }

        #endregion

        #region Aresio

        /// <summary>
        /// Aresioes the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void AresioInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            aresioUserControl.back_0.BackColor = tabHorizontalInput.AresioBackColors[0];
            aresioUserControl.back_1.BackColor = tabHorizontalInput.AresioBackColors[1];
            aresioUserControl.back_2.BackColor = tabHorizontalInput.AresioBackColors[2];
            aresioUserControl.back_3.BackColor = tabHorizontalInput.AresioBackColors[3];

            aresioUserControl.border_0.BackColor = tabHorizontalInput.AresioBorderColors[0];
            aresioUserControl.border_1.BackColor = tabHorizontalInput.AresioBorderColors[1];
            aresioUserControl.border_2.BackColor = tabHorizontalInput.AresioBorderColors[2];

            aresioUserControl.fore_0.BackColor = tabHorizontalInput.AresioForeColors[0];
            aresioUserControl.fore_1.BackColor = tabHorizontalInput.AresioForeColors[1];


            aresioUserControl.preview.AresioBackColors[0] = tabHorizontalInput.AresioBackColors[0];
            aresioUserControl.preview.AresioBackColors[1] = tabHorizontalInput.AresioBackColors[1];
            aresioUserControl.preview.AresioBackColors[2] = tabHorizontalInput.AresioBackColors[2];
            aresioUserControl.preview.AresioBackColors[3] = tabHorizontalInput.AresioBackColors[3];

            aresioUserControl.preview.AresioBorderColors[0] = tabHorizontalInput.AresioBorderColors[0];
            aresioUserControl.preview.AresioBorderColors[1] = tabHorizontalInput.AresioBorderColors[1];
            aresioUserControl.preview.AresioBorderColors[2] = tabHorizontalInput.AresioBorderColors[2];

            aresioUserControl.preview.AresioForeColors[0] = tabHorizontalInput.AresioForeColors[0];
            aresioUserControl.preview.AresioForeColors[1] = tabHorizontalInput.AresioForeColors[1];

        }

        /// <summary>
        /// Aresioes the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void AresioSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.AresioBackColors[0] = aresioUserControl.back_0.BackColor;
            tabHorizontalInput.AresioBackColors[1] = aresioUserControl.back_1.BackColor;
            tabHorizontalInput.AresioBackColors[2] = aresioUserControl.back_2.BackColor;
            tabHorizontalInput.AresioBackColors[3] = aresioUserControl.back_3.BackColor;

            tabHorizontalInput.AresioBorderColors[0] = aresioUserControl.border_0.BackColor;
            tabHorizontalInput.AresioBorderColors[1] = aresioUserControl.border_1.BackColor;
            tabHorizontalInput.AresioBorderColors[2] = aresioUserControl.border_2.BackColor;
            
            tabHorizontalInput.AresioForeColors[0] = aresioUserControl.fore_0.BackColor;
            tabHorizontalInput.AresioForeColors[1] = aresioUserControl.fore_1.BackColor;
        }

        #endregion

        #region BCEvo

        /// <summary>
        /// Bcs the evo initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void BCEvoInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            bCEvoUserControl.back_0.BackColor = tabHorizontalInput.BCEvoBackColors[0];
            bCEvoUserControl.back_1.BackColor = tabHorizontalInput.BCEvoBackColors[1];
            bCEvoUserControl.back_2.BackColor = tabHorizontalInput.BCEvoBackColors[2];
            bCEvoUserControl.back_3.BackColor = tabHorizontalInput.BCEvoBackColors[3];
            bCEvoUserControl.back_4.BackColor = tabHorizontalInput.BCEvoBackColors[4];
            bCEvoUserControl.back_5.BackColor = tabHorizontalInput.BCEvoBackColors[5];

            bCEvoUserControl.border_0.BackColor = tabHorizontalInput.BCEvoBorderColors[0];
            bCEvoUserControl.border_1.BackColor = tabHorizontalInput.BCEvoBorderColors[1];

            bCEvoUserControl.fore_0.BackColor = tabHorizontalInput.BCEvoForeColors[0];
            bCEvoUserControl.fore_1.BackColor = tabHorizontalInput.BCEvoForeColors[1];

            bCEvoUserControl.borderWidth_Numeric.Value = tabHorizontalInput.BorderWidth;


            bCEvoUserControl.preview.BCEvoBackColors[0] = tabHorizontalInput.BCEvoBackColors[0];
            bCEvoUserControl.preview.BCEvoBackColors[1] = tabHorizontalInput.BCEvoBackColors[1];
            bCEvoUserControl.preview.BCEvoBackColors[2] = tabHorizontalInput.BCEvoBackColors[2];
            bCEvoUserControl.preview.BCEvoBackColors[3] = tabHorizontalInput.BCEvoBackColors[3];
            bCEvoUserControl.preview.BCEvoBackColors[4] = tabHorizontalInput.BCEvoBackColors[4];
            bCEvoUserControl.preview.BCEvoBackColors[5] = tabHorizontalInput.BCEvoBackColors[5];

            bCEvoUserControl.preview.BCEvoBorderColors[0] = tabHorizontalInput.BCEvoBorderColors[0];
            bCEvoUserControl.preview.BCEvoBorderColors[1] = tabHorizontalInput.BCEvoBorderColors[1];

            bCEvoUserControl.preview.BCEvoForeColors[0] = tabHorizontalInput.BCEvoForeColors[0];
            bCEvoUserControl.preview.BCEvoForeColors[1] = tabHorizontalInput.BCEvoForeColors[1];

            bCEvoUserControl.preview.BorderWidth = tabHorizontalInput.BorderWidth;


        }

        /// <summary>
        /// Bcs the evo submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void BCEvoSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.BCEvoBackColors[0] = bCEvoUserControl.back_0.BackColor;
            tabHorizontalInput.BCEvoBackColors[1] = bCEvoUserControl.back_1.BackColor;
            tabHorizontalInput.BCEvoBackColors[2] = bCEvoUserControl.back_2.BackColor;
            tabHorizontalInput.BCEvoBackColors[3] = bCEvoUserControl.back_3.BackColor;
            tabHorizontalInput.BCEvoBackColors[4] = bCEvoUserControl.back_4.BackColor;
            tabHorizontalInput.BCEvoBackColors[5] = bCEvoUserControl.back_5.BackColor;

            tabHorizontalInput.BCEvoBorderColors[0] = bCEvoUserControl.border_0.BackColor;
            tabHorizontalInput.BCEvoBorderColors[1] = bCEvoUserControl.border_1.BackColor;

            tabHorizontalInput.BCEvoForeColors[0] = bCEvoUserControl.fore_0.BackColor;
            tabHorizontalInput.BCEvoForeColors[1] = bCEvoUserControl.fore_1.BackColor;

            tabHorizontalInput.BorderWidth = (int)bCEvoUserControl.borderWidth_Numeric.Value;


        }

        #endregion

        #region Butter

        /// <summary>
        /// Butters the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void ButterInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            butterScotchUserControl.back_0.BackColor = tabHorizontalInput.ButBackColors[0];
            butterScotchUserControl.back_1.BackColor = tabHorizontalInput.ButBackColors[1];
            butterScotchUserControl.back_2.BackColor = tabHorizontalInput.ButBackColors[2];
            butterScotchUserControl.back_3.BackColor = tabHorizontalInput.ButBackColors[3];
            butterScotchUserControl.back_4.BackColor = tabHorizontalInput.ButBackColors[4];
            butterScotchUserControl.back_5.BackColor = tabHorizontalInput.ButBackColors[5];

            butterScotchUserControl.border.BackColor = tabHorizontalInput.ButBorderColors[0];

            butterScotchUserControl.fore_0.BackColor = tabHorizontalInput.ButForeColors[0];
            butterScotchUserControl.fore_1.BackColor = tabHorizontalInput.ButForeColors[1];


            butterScotchUserControl.preview.ButBackColors[0] = tabHorizontalInput.ButBackColors[0];
            butterScotchUserControl.preview.ButBackColors[1] = tabHorizontalInput.ButBackColors[1];
            butterScotchUserControl.preview.ButBackColors[2] = tabHorizontalInput.ButBackColors[2];
            butterScotchUserControl.preview.ButBackColors[3] = tabHorizontalInput.ButBackColors[3];
            butterScotchUserControl.preview.ButBackColors[4] = tabHorizontalInput.ButBackColors[4];
            butterScotchUserControl.preview.ButBackColors[5] = tabHorizontalInput.ButBackColors[5];

            butterScotchUserControl.preview.ButBorderColors[0] = tabHorizontalInput.ButBorderColors[0];

            butterScotchUserControl.preview.ButForeColors[0] = tabHorizontalInput.ButForeColors[0];
            butterScotchUserControl.preview.ButForeColors[1] = tabHorizontalInput.ButForeColors[1];


        }

        /// <summary>
        /// Butters the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void ButterSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.BCEvoBackColors[0] = bCEvoUserControl.back_0.BackColor;
            tabHorizontalInput.BCEvoBackColors[1] = bCEvoUserControl.back_1.BackColor;
            tabHorizontalInput.BCEvoBackColors[2] = bCEvoUserControl.back_2.BackColor;
            tabHorizontalInput.BCEvoBackColors[3] = bCEvoUserControl.back_3.BackColor;
            tabHorizontalInput.BCEvoBackColors[4] = bCEvoUserControl.back_4.BackColor;
            tabHorizontalInput.BCEvoBackColors[5] = bCEvoUserControl.back_5.BackColor;

            tabHorizontalInput.BCEvoBorderColors[0] = bCEvoUserControl.border_0.BackColor;
            tabHorizontalInput.BCEvoBorderColors[1] = bCEvoUserControl.border_1.BackColor;

            tabHorizontalInput.BCEvoForeColors[0] = bCEvoUserControl.fore_0.BackColor;
            tabHorizontalInput.BCEvoForeColors[1] = bCEvoUserControl.fore_1.BackColor;

            tabHorizontalInput.BorderWidth = (int)bCEvoUserControl.borderWidth_Numeric.Value;


        }

        #endregion

        #region Carbon

        /// <summary>
        /// Carbons the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void CarbonInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            carbonFibreUserControl.back.BackColor = tabHorizontalInput.CarbonBack;

            carbonFibreUserControl.innerBorder.BackColor = tabHorizontalInput.CarbonInnerBorder;

            carbonFibreUserControl.outterBorder.BackColor = tabHorizontalInput.CarbonOuterBorder;


            carbonFibreUserControl.preview.CarbonBack = tabHorizontalInput.CarbonBack;

            carbonFibreUserControl.preview.CarbonInnerBorder = tabHorizontalInput.CarbonInnerBorder;

            carbonFibreUserControl.preview.CarbonOuterBorder = tabHorizontalInput.CarbonOuterBorder;


        }

        /// <summary>
        /// Carbons the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void CarbonSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.CarbonBack = carbonFibreUserControl.back.BackColor;

            tabHorizontalInput.CarbonInnerBorder = carbonFibreUserControl.innerBorder.BackColor;

            tabHorizontalInput.CarbonOuterBorder = carbonFibreUserControl.outterBorder.BackColor;


        }

        #endregion

        #region Crystal

        /// <summary>
        /// Crystals the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void CrystalInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            crystalUserControl.back_0.BackColor = tabHorizontalInput.CrystalBackColors[0];
            crystalUserControl.back_1.BackColor = tabHorizontalInput.CrystalBackColors[1];
            crystalUserControl.back_2.BackColor = tabHorizontalInput.CrystalBackColors[2];
            crystalUserControl.back_3.BackColor = tabHorizontalInput.CrystalBackColors[3];
            crystalUserControl.back_4.BackColor = tabHorizontalInput.CrystalBackColors[4];
            crystalUserControl.back_5.BackColor = tabHorizontalInput.CrystalBackColors[5];
            crystalUserControl.back_6.BackColor = tabHorizontalInput.CrystalBackColors[6];

            crystalUserControl.border_0.BackColor = tabHorizontalInput.CrystalBorderColors[0];
            crystalUserControl.border_1.BackColor = tabHorizontalInput.CrystalBorderColors[1];
            crystalUserControl.border_2.BackColor = tabHorizontalInput.CrystalBorderColors[2];
            crystalUserControl.border_3.BackColor = tabHorizontalInput.CrystalBorderColors[3];
            crystalUserControl.border_4.BackColor = tabHorizontalInput.CrystalBorderColors[4];
            //crystalUserControl.border_5.BackColor = tabHorizontalInput.CrystalBorderColors[5];

            crystalUserControl.fore_0.BackColor = tabHorizontalInput.CrystalForeColors[0];
            crystalUserControl.fore_1.BackColor = tabHorizontalInput.CrystalForeColors[1];
            


            crystalUserControl.preview.CrystalBackColors[0] = tabHorizontalInput.CrystalBackColors[0];
            crystalUserControl.preview.CrystalBackColors[1] = tabHorizontalInput.CrystalBackColors[1];
            crystalUserControl.preview.CrystalBackColors[2] = tabHorizontalInput.CrystalBackColors[2];
            crystalUserControl.preview.CrystalBackColors[3] = tabHorizontalInput.CrystalBackColors[3];
            crystalUserControl.preview.CrystalBackColors[4] = tabHorizontalInput.CrystalBackColors[4];
            crystalUserControl.preview.CrystalBackColors[5] = tabHorizontalInput.CrystalBackColors[5];
            crystalUserControl.preview.CrystalBackColors[6] = tabHorizontalInput.CrystalBackColors[6];

            crystalUserControl.preview.CrystalBorderColors[0] = tabHorizontalInput.CrystalBorderColors[0];
            crystalUserControl.preview.CrystalBorderColors[1] = tabHorizontalInput.CrystalBorderColors[1];
            crystalUserControl.preview.CrystalBorderColors[2] = tabHorizontalInput.CrystalBorderColors[2];
            crystalUserControl.preview.CrystalBorderColors[3] = tabHorizontalInput.CrystalBorderColors[3];
            crystalUserControl.preview.CrystalBorderColors[4] = tabHorizontalInput.CrystalBorderColors[4];
            //crystalUserControl.preview.CrystalBorderColors[5] = tabHorizontalInput.CrystalBorderColors[5];

            crystalUserControl.preview.CrystalForeColors[0] = tabHorizontalInput.CrystalForeColors[0];
            crystalUserControl.preview.CrystalForeColors[1] = tabHorizontalInput.CrystalForeColors[1];



        }

        /// <summary>
        /// Crystals the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void CrystalSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.CrystalBackColors[0] = crystalUserControl.back_0.BackColor;
            tabHorizontalInput.CrystalBackColors[1] = crystalUserControl.back_1.BackColor;
            tabHorizontalInput.CrystalBackColors[2] = crystalUserControl.back_2.BackColor;
            tabHorizontalInput.CrystalBackColors[3] = crystalUserControl.back_3.BackColor;
            tabHorizontalInput.CrystalBackColors[4] = crystalUserControl.back_4.BackColor;
            tabHorizontalInput.CrystalBackColors[5] = crystalUserControl.back_5.BackColor;
            tabHorizontalInput.CrystalBackColors[6] = crystalUserControl.back_6.BackColor;

            tabHorizontalInput.CrystalBorderColors[0] = crystalUserControl.border_0.BackColor;
            tabHorizontalInput.CrystalBorderColors[1] = crystalUserControl.border_1.BackColor;
            tabHorizontalInput.CrystalBorderColors[2] = crystalUserControl.border_2.BackColor;
            tabHorizontalInput.CrystalBorderColors[3] = crystalUserControl.border_3.BackColor;
            tabHorizontalInput.CrystalBorderColors[4] = crystalUserControl.border_4.BackColor;
            //tabHorizontalInput.CrystalBorderColors[5] = crystalUserControl.border_5.BackColor;

            tabHorizontalInput.CrystalForeColors[0] = crystalUserControl.fore_0.BackColor;
            tabHorizontalInput.CrystalForeColors[1] = crystalUserControl.fore_1.BackColor;
        }

        #endregion

        #region FireFox

        /// <summary>
        /// Firefoxes the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void FirefoxInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            fireFoxUserControl.back_0.BackColor = tabHorizontalInput.FireFoxBackColors[0];
            fireFoxUserControl.back_1.BackColor = tabHorizontalInput.FireFoxBackColors[1];
            fireFoxUserControl.back_2.BackColor = tabHorizontalInput.FireFoxBackColors[2];
            fireFoxUserControl.back_3.BackColor = tabHorizontalInput.FireFoxBackColors[3];

            fireFoxUserControl.border_0.BackColor = tabHorizontalInput.FireFoxBorderColors[0];
            fireFoxUserControl.border_1.BackColor = tabHorizontalInput.FireFoxBorderColors[1];

            fireFoxUserControl.fore.BackColor = tabHorizontalInput.FireFoxForeColors[0];



            fireFoxUserControl.preview.FireFoxBackColors[0] = tabHorizontalInput.FireFoxBackColors[0];
            fireFoxUserControl.preview.FireFoxBackColors[1] = tabHorizontalInput.FireFoxBackColors[1];
            fireFoxUserControl.preview.FireFoxBackColors[2] = tabHorizontalInput.FireFoxBackColors[2];
            fireFoxUserControl.preview.FireFoxBackColors[3] = tabHorizontalInput.FireFoxBackColors[3];

            fireFoxUserControl.preview.FireFoxBorderColors[0] = tabHorizontalInput.FireFoxBorderColors[0];
            fireFoxUserControl.preview.FireFoxBorderColors[1] = tabHorizontalInput.FireFoxBorderColors[1];

            fireFoxUserControl.preview.FireFoxForeColors[0] = tabHorizontalInput.FireFoxForeColors[0];


        }

        /// <summary>
        /// Firefoxes the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void FirefoxSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.FireFoxBackColors[0] = fireFoxUserControl.back_0.BackColor;
            tabHorizontalInput.FireFoxBackColors[1] = fireFoxUserControl.back_1.BackColor;
            tabHorizontalInput.FireFoxBackColors[2] = fireFoxUserControl.back_2.BackColor;
            tabHorizontalInput.FireFoxBackColors[3] = fireFoxUserControl.back_3.BackColor;

            tabHorizontalInput.FireFoxBorderColors[0] = fireFoxUserControl.border_0.BackColor;
            tabHorizontalInput.FireFoxBorderColors[1] = fireFoxUserControl.border_1.BackColor;

            tabHorizontalInput.FireFoxForeColors[0] = fireFoxUserControl.fore.BackColor;


        }

        #endregion

        #region FlatUI

        /// <summary>
        /// Flats the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void FlatInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            flatUIUserControl.back.BackColor = tabHorizontalInput.FlatTabBackColor;

            flatUIUserControl.baseColor.BackColor = tabHorizontalInput.FlatBaseColor;

            flatUIUserControl.active.BackColor = tabHorizontalInput.FlatActiveColor;


            flatUIUserControl.preview.FlatTabBackColor = tabHorizontalInput.FlatTabBackColor;

            flatUIUserControl.preview.FlatBaseColor = tabHorizontalInput.FlatBaseColor;

            flatUIUserControl.preview.FlatActiveColor = tabHorizontalInput.FlatActiveColor;


        }

        /// <summary>
        /// Flats the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void FlatSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.FlatTabBackColor = flatUIUserControl.back.BackColor;

            tabHorizontalInput.FlatBaseColor = flatUIUserControl.baseColor.BackColor;

            tabHorizontalInput.FlatActiveColor = flatUIUserControl.active.BackColor;


        }

        #endregion

        #region iTab

        /// <summary>
        /// is the tab initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void iTabInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            iTabUserControl.back_0.BackColor = tabHorizontalInput.ITabBackColors[0];
            iTabUserControl.back_1.BackColor = tabHorizontalInput.ITabBackColors[1];
            iTabUserControl.back_2.BackColor = tabHorizontalInput.ITabBackColors[2];
            iTabUserControl.back_3.BackColor = tabHorizontalInput.ITabBackColors[3];
            iTabUserControl.back_4.BackColor = tabHorizontalInput.ITabBackColors[4];
            iTabUserControl.back_5.BackColor = tabHorizontalInput.ITabBackColors[5];
            iTabUserControl.back_6.BackColor = tabHorizontalInput.ITabBackColors[6];

            iTabUserControl.border_0.BackColor = tabHorizontalInput.ITabBorderColors[0];
            iTabUserControl.border_1.BackColor = tabHorizontalInput.ITabBorderColors[1];
            iTabUserControl.border_2.BackColor = tabHorizontalInput.ITabBorderColors[2];
            iTabUserControl.border_3.BackColor = tabHorizontalInput.ITabBorderColors[3];
            iTabUserControl.border_4.BackColor = tabHorizontalInput.ITabBorderColors[4];

            iTabUserControl.fore_0.BackColor = tabHorizontalInput.ITabForeColors[0];
            iTabUserControl.fore_1.BackColor = tabHorizontalInput.ITabForeColors[1];



            iTabUserControl.preview.ITabBackColors[0] = tabHorizontalInput.ITabBackColors[0];
            iTabUserControl.preview.ITabBackColors[1] = tabHorizontalInput.ITabBackColors[1];
            iTabUserControl.preview.ITabBackColors[2] = tabHorizontalInput.ITabBackColors[2];
            iTabUserControl.preview.ITabBackColors[3] = tabHorizontalInput.ITabBackColors[3];
            iTabUserControl.preview.ITabBackColors[4] = tabHorizontalInput.ITabBackColors[4];
            iTabUserControl.preview.ITabBackColors[5] = tabHorizontalInput.ITabBackColors[5];
            iTabUserControl.preview.ITabBackColors[6] = tabHorizontalInput.ITabBackColors[6];

            iTabUserControl.preview.ITabBorderColors[0] = tabHorizontalInput.ITabBorderColors[0];
            iTabUserControl.preview.ITabBorderColors[1] = tabHorizontalInput.ITabBorderColors[1];
            iTabUserControl.preview.ITabBorderColors[2] = tabHorizontalInput.ITabBorderColors[2];
            iTabUserControl.preview.ITabBorderColors[3] = tabHorizontalInput.ITabBorderColors[3];
            iTabUserControl.preview.ITabBorderColors[4] = tabHorizontalInput.ITabBorderColors[4];

            iTabUserControl.preview.ITabForeColors[0] = tabHorizontalInput.ITabForeColors[0];
            iTabUserControl.preview.ITabForeColors[1] = tabHorizontalInput.ITabForeColors[1];


        }

        /// <summary>
        /// is the tab submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void iTabSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.ITabBackColors[0] = iTabUserControl.back_0.BackColor;
            tabHorizontalInput.ITabBackColors[1] = iTabUserControl.back_1.BackColor;
            tabHorizontalInput.ITabBackColors[2] = iTabUserControl.back_2.BackColor;
            tabHorizontalInput.ITabBackColors[3] = iTabUserControl.back_3.BackColor;
            tabHorizontalInput.ITabBackColors[4] = iTabUserControl.back_4.BackColor;
            tabHorizontalInput.ITabBackColors[5] = iTabUserControl.back_5.BackColor;
            tabHorizontalInput.ITabBackColors[6] = iTabUserControl.back_6.BackColor;

            tabHorizontalInput.ITabBorderColors[0] = iTabUserControl.border_0.BackColor;
            tabHorizontalInput.ITabBorderColors[1] = iTabUserControl.border_1.BackColor;
            tabHorizontalInput.ITabBorderColors[2] = iTabUserControl.border_2.BackColor;
            tabHorizontalInput.ITabBorderColors[3] = iTabUserControl.border_3.BackColor;
            tabHorizontalInput.ITabBorderColors[4] = iTabUserControl.border_4.BackColor;

            tabHorizontalInput.ITabForeColors[0] = iTabUserControl.fore_0.BackColor;
            tabHorizontalInput.ITabForeColors[1] = iTabUserControl.fore_1.BackColor;
        }

        #endregion

        #region Login

        /// <summary>
        /// Logins the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void LoginInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            loginUserControl.back.BackColor = tabHorizontalInput.LoginBackTabColor;

            loginUserControl.baseColor.BackColor = tabHorizontalInput.LoginBaseColor;

            loginUserControl.active.BackColor = tabHorizontalInput.LoginActiveColor;

            
            loginUserControl.line_0.BackColor = tabHorizontalInput.LoginHorizontalLineColor;
            loginUserControl.line_1.BackColor = tabHorizontalInput.LoginUpLineColor;

            loginUserControl.fore.BackColor = tabHorizontalInput.LoginTextColor;

            loginUserControl.border.BackColor = tabHorizontalInput.LoginBorderColor;



            loginUserControl.preview.LoginBackTabColor = tabHorizontalInput.LoginBackTabColor;

            loginUserControl.preview.LoginBaseColor = tabHorizontalInput.LoginBaseColor;

            loginUserControl.preview.LoginActiveColor = tabHorizontalInput.LoginActiveColor;


            loginUserControl.preview.LoginHorizontalLineColor = tabHorizontalInput.LoginHorizontalLineColor;
            loginUserControl.preview.LoginUpLineColor = tabHorizontalInput.LoginUpLineColor;

            loginUserControl.preview.LoginTextColor = tabHorizontalInput.LoginTextColor;

            loginUserControl.preview.LoginBorderColor = tabHorizontalInput.LoginBorderColor;


        }

        /// <summary>
        /// Logins the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void LoginSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.LoginBackTabColor = loginUserControl.back.BackColor;

            tabHorizontalInput.LoginBaseColor = loginUserControl.baseColor.BackColor;

            tabHorizontalInput.LoginActiveColor = loginUserControl.active.BackColor;


            tabHorizontalInput.LoginHorizontalLineColor = loginUserControl.line_0.BackColor;
            tabHorizontalInput.LoginUpLineColor = loginUserControl.line_1.BackColor;

            tabHorizontalInput.LoginTextColor = loginUserControl.fore.BackColor;

            tabHorizontalInput.LoginBorderColor = loginUserControl.border.BackColor;


        }

        #endregion

        #region Metro Disk

        /// <summary>
        /// Metroes the disk initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void MetroDiskInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            metroDiskUserControl.back.BackColor = tabHorizontalInput.MetroBackColor;

            metroDiskUserControl.baseColor.BackColor = tabHorizontalInput.MetroDiskBaseColor;

            metroDiskUserControl.active_0.BackColor = tabHorizontalInput.MetroActive;
            metroDiskUserControl.active_1.BackColor = tabHorizontalInput.MetroActiveColor;

            metroDiskUserControl.inactive.BackColor = tabHorizontalInput.MetroInactive;


            metroDiskUserControl.preview.MetroBackColor = tabHorizontalInput.MetroBackColor;

            metroDiskUserControl.preview.MetroDiskBaseColor = tabHorizontalInput.MetroDiskBaseColor;

            metroDiskUserControl.preview.MetroActive = tabHorizontalInput.MetroActive;
            metroDiskUserControl.preview.MetroActiveColor = tabHorizontalInput.MetroActiveColor;

            metroDiskUserControl.preview.MetroInactive = tabHorizontalInput.MetroInactive;


        }

        /// <summary>
        /// Metroes the disk submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void MetroDiskSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion


            tabHorizontalInput.MetroBackColor = metroDiskUserControl.back.BackColor;

            tabHorizontalInput.MetroDiskBaseColor = metroDiskUserControl.baseColor.BackColor;

            tabHorizontalInput.MetroActive = metroDiskUserControl.active_0.BackColor;
            tabHorizontalInput.MetroActiveColor = metroDiskUserControl.active_1.BackColor;

            tabHorizontalInput.MetroInactive = metroDiskUserControl.inactive.BackColor;

        }

        #endregion

        #region Reactor

        /// <summary>
        /// Reactors the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void ReactorInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            reactorUserControl.back_0.BackColor = tabHorizontalInput.ReactBackColors[0];
            reactorUserControl.back_1.BackColor = tabHorizontalInput.ReactBackColors[1];
            reactorUserControl.back_2.BackColor = tabHorizontalInput.ReactBackColors[2];
            reactorUserControl.back_3.BackColor = tabHorizontalInput.ReactBackColors[3];
            reactorUserControl.back_4.BackColor = tabHorizontalInput.ReactBackColors[4];
            reactorUserControl.back_5.BackColor = tabHorizontalInput.ReactBackColors[5];
            reactorUserControl.back_6.BackColor = tabHorizontalInput.ReactBackColors[6];
            reactorUserControl.back_7.BackColor = tabHorizontalInput.ReactBackColors[7];
            reactorUserControl.back_8.BackColor = tabHorizontalInput.ReactBackColors[8];
            reactorUserControl.back_9.BackColor = tabHorizontalInput.ReactBackColors[9];
            reactorUserControl.back_10.BackColor = tabHorizontalInput.ReactBackColors[10];
            reactorUserControl.back_11.BackColor = tabHorizontalInput.ReactBackColors[11];


            reactorUserControl.border_0.BackColor = tabHorizontalInput.ReactBorderColors[0];
            reactorUserControl.border_1.BackColor = tabHorizontalInput.ReactBorderColors[1];
            reactorUserControl.border_2.BackColor = tabHorizontalInput.ReactBorderColors[2];
            reactorUserControl.border_3.BackColor = tabHorizontalInput.ReactBorderColors[3];
            reactorUserControl.border_4.BackColor = tabHorizontalInput.ReactBorderColors[4];
            reactorUserControl.border_5.BackColor = tabHorizontalInput.ReactBorderColors[5];
            reactorUserControl.border_6.BackColor = tabHorizontalInput.ReactBorderColors[6];
            reactorUserControl.border_7.BackColor = tabHorizontalInput.ReactBorderColors[7];
            reactorUserControl.border_8.BackColor = tabHorizontalInput.ReactBorderColors[8];
            reactorUserControl.border_9.BackColor = tabHorizontalInput.ReactBorderColors[9];
            reactorUserControl.border_10.BackColor = tabHorizontalInput.ReactBorderColors[10];
            reactorUserControl.border_11.BackColor = tabHorizontalInput.ReactBorderColors[11];

            reactorUserControl.fore_0.BackColor = tabHorizontalInput.ReactForeColors[0];
            reactorUserControl.fore_1.BackColor = tabHorizontalInput.ReactForeColors[1];

            reactorUserControl.tabBorder.BackColor = tabHorizontalInput.TabBorderColor;




            reactorUserControl.preview.ReactBackColors[0] = tabHorizontalInput.ReactBackColors[0];
            reactorUserControl.preview.ReactBackColors[1] = tabHorizontalInput.ReactBackColors[1];
            reactorUserControl.preview.ReactBackColors[2] = tabHorizontalInput.ReactBackColors[2];
            reactorUserControl.preview.ReactBackColors[3] = tabHorizontalInput.ReactBackColors[3];
            reactorUserControl.preview.ReactBackColors[4] = tabHorizontalInput.ReactBackColors[4];
            reactorUserControl.preview.ReactBackColors[5] = tabHorizontalInput.ReactBackColors[5];
            reactorUserControl.preview.ReactBackColors[6] = tabHorizontalInput.ReactBackColors[6];
            reactorUserControl.preview.ReactBackColors[7] = tabHorizontalInput.ReactBackColors[7];
            reactorUserControl.preview.ReactBackColors[8] = tabHorizontalInput.ReactBackColors[8];
            reactorUserControl.preview.ReactBackColors[9] = tabHorizontalInput.ReactBackColors[9];
            reactorUserControl.preview.ReactBackColors[10] = tabHorizontalInput.ReactBackColors[10];
            reactorUserControl.preview.ReactBackColors[11] = tabHorizontalInput.ReactBackColors[11];


            reactorUserControl.preview.ReactBorderColors[0] = tabHorizontalInput.ReactBorderColors[0];
            reactorUserControl.preview.ReactBorderColors[1] = tabHorizontalInput.ReactBorderColors[1];
            reactorUserControl.preview.ReactBorderColors[2] = tabHorizontalInput.ReactBorderColors[2];
            reactorUserControl.preview.ReactBorderColors[3] = tabHorizontalInput.ReactBorderColors[3];
            reactorUserControl.preview.ReactBorderColors[4] = tabHorizontalInput.ReactBorderColors[4];
            reactorUserControl.preview.ReactBorderColors[5] = tabHorizontalInput.ReactBorderColors[5];
            reactorUserControl.preview.ReactBorderColors[6] = tabHorizontalInput.ReactBorderColors[6];
            reactorUserControl.preview.ReactBorderColors[7] = tabHorizontalInput.ReactBorderColors[7];
            reactorUserControl.preview.ReactBorderColors[8] = tabHorizontalInput.ReactBorderColors[8];
            reactorUserControl.preview.ReactBorderColors[9] = tabHorizontalInput.ReactBorderColors[9];
            reactorUserControl.preview.ReactBorderColors[10] = tabHorizontalInput.ReactBorderColors[10];
            reactorUserControl.preview.ReactBorderColors[11] = tabHorizontalInput.ReactBorderColors[11];

            reactorUserControl.preview.ReactForeColors[0] = tabHorizontalInput.ReactForeColors[0];
            reactorUserControl.preview.ReactForeColors[1] = tabHorizontalInput.ReactForeColors[1];

            reactorUserControl.preview.TabBorderColor = tabHorizontalInput.TabBorderColor;


        }

        /// <summary>
        /// Reactors the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void ReactorSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion
            
            tabHorizontalInput.ReactBackColors[0] = reactorUserControl.back_0.BackColor;
            tabHorizontalInput.ReactBackColors[1] = reactorUserControl.back_1.BackColor;
            tabHorizontalInput.ReactBackColors[2] = reactorUserControl.back_2.BackColor;
            tabHorizontalInput.ReactBackColors[3] = reactorUserControl.back_3.BackColor;
            tabHorizontalInput.ReactBackColors[4] = reactorUserControl.back_4.BackColor;
            tabHorizontalInput.ReactBackColors[5] = reactorUserControl.back_5.BackColor;
            tabHorizontalInput.ReactBackColors[6] = reactorUserControl.back_6.BackColor;
            tabHorizontalInput.ReactBackColors[7] = reactorUserControl.back_7.BackColor;
            tabHorizontalInput.ReactBackColors[8] = reactorUserControl.back_8.BackColor;
            tabHorizontalInput.ReactBackColors[9] = reactorUserControl.back_9.BackColor;
            tabHorizontalInput.ReactBackColors[10] = reactorUserControl.back_10.BackColor;
            tabHorizontalInput.ReactBackColors[11] = reactorUserControl.back_11.BackColor;

            tabHorizontalInput.ReactBorderColors[0] = reactorUserControl.border_0.BackColor;
            tabHorizontalInput.ReactBorderColors[1] = reactorUserControl.border_1.BackColor;
            tabHorizontalInput.ReactBorderColors[2] = reactorUserControl.border_2.BackColor;
            tabHorizontalInput.ReactBorderColors[3] = reactorUserControl.border_3.BackColor;
            tabHorizontalInput.ReactBorderColors[4] = reactorUserControl.border_4.BackColor;
            tabHorizontalInput.ReactBorderColors[5] = reactorUserControl.border_5.BackColor;
            tabHorizontalInput.ReactBorderColors[6] = reactorUserControl.border_6.BackColor;
            tabHorizontalInput.ReactBorderColors[7] = reactorUserControl.border_7.BackColor;
            tabHorizontalInput.ReactBorderColors[8] = reactorUserControl.border_8.BackColor;
            tabHorizontalInput.ReactBorderColors[9] = reactorUserControl.border_9.BackColor;
            tabHorizontalInput.ReactBorderColors[10] = reactorUserControl.border_10.BackColor;
            tabHorizontalInput.ReactBorderColors[11] = reactorUserControl.border_11.BackColor;

            tabHorizontalInput.ReactForeColors[0] = reactorUserControl.fore_0.BackColor;
            tabHorizontalInput.ReactForeColors[1] = reactorUserControl.fore_1.BackColor;

            tabHorizontalInput.TabBorderColor = reactorUserControl.tabBorder.BackColor;


        }

        #endregion

        #region Simpla

        /// <summary>
        /// Simplas the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void SimplaInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            simplaUserControl.back.BackColor = tabHorizontalInput.MainBackground;

            simplaUserControl.topBack.BackColor = tabHorizontalInput.TopBackground;

            simplaUserControl.active.BackColor = tabHorizontalInput.ActiveTabColor;
            

            simplaUserControl.preview.MainBackground = tabHorizontalInput.MainBackground;

            simplaUserControl.preview.TopBackground = tabHorizontalInput.TopBackground;

            simplaUserControl.preview.ActiveTabColor = tabHorizontalInput.ActiveTabColor;


        }

        /// <summary>
        /// Simplas the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void SimplaSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.MainBackground = simplaUserControl.back.BackColor;

            tabHorizontalInput.TopBackground = simplaUserControl.topBack.BackColor;

            tabHorizontalInput.ActiveTabColor = simplaUserControl.active.BackColor;
            
        }

        #endregion

        #region Unique

        /// <summary>
        /// Uniques the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void UniqueInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            uniqueUserControl.back_0.BackColor = tabHorizontalInput.UniqueBackColors[0];
            uniqueUserControl.back_1.BackColor = tabHorizontalInput.UniqueBackColors[1];
            uniqueUserControl.back_2.BackColor = tabHorizontalInput.UniqueBackColors[2];
            uniqueUserControl.back_3.BackColor = tabHorizontalInput.UniqueBackColors[3];

            uniqueUserControl.border_0.BackColor = tabHorizontalInput.UniqueBorderColors[0];
            uniqueUserControl.border_1.BackColor = tabHorizontalInput.UniqueBorderColors[1];

            uniqueUserControl.fore_0.BackColor = tabHorizontalInput.UniqueForeColors[0];
            uniqueUserControl.fore_1.BackColor = tabHorizontalInput.UniqueForeColors[0];


            uniqueUserControl.preview.UniqueBackColors[0] = tabHorizontalInput.UniqueBackColors[0];
            uniqueUserControl.preview.UniqueBackColors[1] = tabHorizontalInput.UniqueBackColors[1];
            uniqueUserControl.preview.UniqueBackColors[2] = tabHorizontalInput.UniqueBackColors[2];
            uniqueUserControl.preview.UniqueBackColors[3] = tabHorizontalInput.UniqueBackColors[3];

            uniqueUserControl.preview.UniqueBorderColors[0] = tabHorizontalInput.UniqueBorderColors[0];
            uniqueUserControl.preview.UniqueBorderColors[1] = tabHorizontalInput.UniqueBorderColors[1];

            uniqueUserControl.preview.UniqueForeColors[0] = tabHorizontalInput.UniqueForeColors[0];
            uniqueUserControl.preview.UniqueForeColors[1] = tabHorizontalInput.UniqueForeColors[0];


        }

        /// <summary>
        /// Uniques the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void UniqueSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.UniqueBackColors[0] = uniqueUserControl.back_0.BackColor;
            tabHorizontalInput.UniqueBackColors[1] = uniqueUserControl.back_1.BackColor;
            tabHorizontalInput.UniqueBackColors[2] = uniqueUserControl.back_2.BackColor;
            tabHorizontalInput.UniqueBackColors[3] = uniqueUserControl.back_3.BackColor;

            tabHorizontalInput.UniqueBorderColors[0] = uniqueUserControl.border_0.BackColor;
            tabHorizontalInput.UniqueBorderColors[1] = uniqueUserControl.border_1.BackColor;

            tabHorizontalInput.UniqueForeColors[0] = uniqueUserControl.fore_0.BackColor;
            tabHorizontalInput.UniqueForeColors[1] = uniqueUserControl.fore_1.BackColor;
        }

        #endregion

        #region Unique

        /// <summary>
        /// vs the initial values.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void VInitialValues(TabHorizontalInput tabHorizontalInput)
        {
            vUserControl.back_0.BackColor = tabHorizontalInput.VBackColors[0];
            vUserControl.back_1.BackColor = tabHorizontalInput.VBackColors[1];
            vUserControl.back_2.BackColor = tabHorizontalInput.VBackColors[2];
            vUserControl.back_3.BackColor = tabHorizontalInput.VBackColors[3];
            vUserControl.back_4.BackColor = tabHorizontalInput.VBackColors[4];
            vUserControl.back_5.BackColor = tabHorizontalInput.VBackColors[5];
            vUserControl.back_6.BackColor = tabHorizontalInput.VBackColors[6];
            vUserControl.back_7.BackColor = tabHorizontalInput.VBackColors[7];
            vUserControl.back_8.BackColor = tabHorizontalInput.VBackColors[8];

            vUserControl.border_0.BackColor = tabHorizontalInput.VBorderColors[0];
            vUserControl.border_1.BackColor = tabHorizontalInput.VBorderColors[1];
            vUserControl.border_2.BackColor = tabHorizontalInput.VBorderColors[2];
            vUserControl.border_3.BackColor = tabHorizontalInput.VBorderColors[3];
            vUserControl.border_4.BackColor = tabHorizontalInput.VBorderColors[4];
            vUserControl.border_5.BackColor = tabHorizontalInput.VBorderColors[5];


            vUserControl.preview.VBackColors[0] = tabHorizontalInput.VBackColors[0];
            vUserControl.preview.VBackColors[1] = tabHorizontalInput.VBackColors[1];
            vUserControl.preview.VBackColors[2] = tabHorizontalInput.VBackColors[2];
            vUserControl.preview.VBackColors[3] = tabHorizontalInput.VBackColors[3];
            vUserControl.preview.VBackColors[4] = tabHorizontalInput.VBackColors[4];
            vUserControl.preview.VBackColors[5] = tabHorizontalInput.VBackColors[5];
            vUserControl.preview.VBackColors[6] = tabHorizontalInput.VBackColors[6];
            vUserControl.preview.VBackColors[7] = tabHorizontalInput.VBackColors[7];
            vUserControl.preview.VBackColors[8] = tabHorizontalInput.VBackColors[8];

            vUserControl.preview.VBorderColors[0] = tabHorizontalInput.VBorderColors[0];
            vUserControl.preview.VBorderColors[1] = tabHorizontalInput.VBorderColors[1];
            vUserControl.preview.VBorderColors[2] = tabHorizontalInput.VBorderColors[2];
            vUserControl.preview.VBorderColors[3] = tabHorizontalInput.VBorderColors[3];
            vUserControl.preview.VBorderColors[4] = tabHorizontalInput.VBorderColors[4];
            vUserControl.preview.VBorderColors[5] = tabHorizontalInput.VBorderColors[5];


        }

        /// <summary>
        /// vs the submit.
        /// </summary>
        /// <param name="tabHorizontalInput">The tab horizontal input.</param>
        private void VSubmit(TabHorizontalInput tabHorizontalInput)
        {

            #region Main Submit

            tabHorizontalInput.TabStyle =
                (TabStyles)Enum.Parse(typeof
                        (TabStyles),
                    mainControl_TabStyle_ComboBox.SelectedItem.ToString());


            tabHorizontalInput.Speed = (int)mainControl_SlideSpeed_ComboBox.Value;

            #endregion

            tabHorizontalInput.VBackColors[0] = vUserControl.back_0.BackColor;
            tabHorizontalInput.VBackColors[1] = vUserControl.back_1.BackColor;
            tabHorizontalInput.VBackColors[2] = vUserControl.back_2.BackColor;
            tabHorizontalInput.VBackColors[3] = vUserControl.back_3.BackColor;
            tabHorizontalInput.VBackColors[4] = vUserControl.back_4.BackColor;
            tabHorizontalInput.VBackColors[5] = vUserControl.back_5.BackColor;
            tabHorizontalInput.VBackColors[6] = vUserControl.back_6.BackColor;
            tabHorizontalInput.VBackColors[7] = vUserControl.back_7.BackColor;
            tabHorizontalInput.VBackColors[8] = vUserControl.back_8.BackColor;

            tabHorizontalInput.VBorderColors[0] = vUserControl.border_0.BackColor;
            tabHorizontalInput.VBorderColors[1] = vUserControl.border_1.BackColor;
            tabHorizontalInput.VBorderColors[2] = vUserControl.border_2.BackColor;
            tabHorizontalInput.VBorderColors[3] = vUserControl.border_3.BackColor;
            tabHorizontalInput.VBorderColors[4] = vUserControl.border_4.BackColor;
            tabHorizontalInput.VBorderColors[5] = vUserControl.border_5.BackColor;
        }

        #endregion

    }
}
