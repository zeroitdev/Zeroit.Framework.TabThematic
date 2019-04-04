// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="AddUserControlToForm.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.TabThematic.DialogEditor
{
    /// <summary>
    /// Class TabThematicVerticalDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TabThematicVerticalDialog
    {

        /// <summary>
        /// Adds the controls.
        /// </summary>
        private void AddControls()
        {
            butterScotchVerticalUserControl.Visible = false;
            chromeUserControl.Visible = false;
            dotnetBarUserControl.Visible = false;
            dotnetBarv2UserControl.Visible = false;
            eightBallUserControl.Visible = false;
            empireUserControl.Visible = false;
            facebookUserControl.Visible = false;
            fireFoxMainUserControl.Visible = false;
            mephUserControl.Visible = false;
            nSUserControl.Visible = false;
            redemptionUserControl.Visible = false;
            sLCUserControl.Visible = false;
            xVisualUserControl.Visible = false;

        }

        /// <summary>
        /// Butters the scotch add.
        /// </summary>
        private void ButterScotchAdd()
        {
            butterScotchVerticalUserControl.Visible = true;
            butterScotchVerticalUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Chromes the add.
        /// </summary>
        private void ChromeAdd()
        {
            chromeUserControl.Visible = true;
            chromeUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(chromeUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Dotnets the bar add.
        /// </summary>
        private void DotnetBarAdd()
        {
            dotnetBarUserControl.Visible = true;
            dotnetBarUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Dotnets the bar v2 add.
        /// </summary>
        private void DotnetBarV2Add()
        {
            dotnetBarv2UserControl.Visible = true;
            dotnetBarv2UserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Eights the ball add.
        /// </summary>
        private void EightBallAdd()
        {
            eightBallUserControl.Visible = true;
            eightBallUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(eightBallUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Empires the add.
        /// </summary>
        private void EmpireAdd()
        {
            empireUserControl.Visible = true;
            empireUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(empireUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Facebooks the add.
        /// </summary>
        private void FacebookAdd()
        {
            facebookUserControl.Visible = true;
            facebookUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(facebookUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Fires the fox add.
        /// </summary>
        private void FireFoxAdd()
        {
            fireFoxMainUserControl.Visible = true;
            fireFoxMainUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Mephes the add.
        /// </summary>
        private void MephAdd()
        {
            mephUserControl.Visible = true;
            mephUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(mephUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Nses the add.
        /// </summary>
        private void NSAdd()
        {
            nSUserControl.Visible = true;
            nSUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(nSUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// Redemptions the add.
        /// </summary>
        private void RedemptionAdd()
        {
            redemptionUserControl.Visible = true;
            redemptionUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(redemptionUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// SLCs the add.
        /// </summary>
        private void SLCAdd()
        {
            sLCUserControl.Visible = true;
            sLCUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(sLCUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);
            backgroundTheme.Controls.Remove(xVisualUserControl);

        }

        /// <summary>
        /// xes the visual add.
        /// </summary>
        private void xVisualAdd()
        {
            xVisualUserControl.Visible = true;
            xVisualUserControl.Location = new Point(300, 30);

            backgroundTheme.Controls.Add(xVisualUserControl);
            backgroundTheme.Controls.Remove(chromeUserControl);
            backgroundTheme.Controls.Remove(dotnetBarUserControl);
            backgroundTheme.Controls.Remove(dotnetBarv2UserControl);
            backgroundTheme.Controls.Remove(eightBallUserControl);
            backgroundTheme.Controls.Remove(empireUserControl);
            backgroundTheme.Controls.Remove(facebookUserControl);
            backgroundTheme.Controls.Remove(fireFoxMainUserControl);
            backgroundTheme.Controls.Remove(mephUserControl);
            backgroundTheme.Controls.Remove(nSUserControl);
            backgroundTheme.Controls.Remove(redemptionUserControl);
            backgroundTheme.Controls.Remove(sLCUserControl);
            backgroundTheme.Controls.Remove(butterScotchVerticalUserControl);

        }

    }
}
