﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-30-2018
// ***********************************************************************
// <copyright file="UniqueUserControl.Designer.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.TabThematic.DialogEditor
{
    partial class UniqueUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fore_0 = new System.Windows.Forms.Button();
            this.fore_1 = new System.Windows.Forms.Button();
            this.preview = new Zeroit.Framework.TabThematic.Controls.ZeroitThematicHorizontalTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.border_1 = new System.Windows.Forms.Button();
            this.border_0 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.back_2 = new System.Windows.Forms.Button();
            this.back_3 = new System.Windows.Forms.Button();
            this.back_0 = new System.Windows.Forms.Button();
            this.back_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.ColorDialog();
            this.groupBox2.SuspendLayout();
            this.preview.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox2.Controls.Add(this.fore_0);
            this.groupBox2.Controls.Add(this.fore_1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 70);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fore Colors";
            // 
            // fore_0
            // 
            this.fore_0.BackColor = System.Drawing.Color.DimGray;
            this.fore_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fore_0.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.fore_0.FlatAppearance.BorderSize = 0;
            this.fore_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fore_0.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fore_0.Location = new System.Drawing.Point(8, 24);
            this.fore_0.Name = "fore_0";
            this.fore_0.Size = new System.Drawing.Size(38, 33);
            this.fore_0.TabIndex = 59;
            this.fore_0.UseVisualStyleBackColor = false;
            this.fore_0.Click += new System.EventHandler(this.fore_0_Click);
            // 
            // fore_1
            // 
            this.fore_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.fore_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fore_1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.fore_1.FlatAppearance.BorderSize = 0;
            this.fore_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fore_1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fore_1.Location = new System.Drawing.Point(52, 24);
            this.fore_1.Name = "fore_1";
            this.fore_1.Size = new System.Drawing.Size(38, 33);
            this.fore_1.TabIndex = 60;
            this.fore_1.UseVisualStyleBackColor = false;
            this.fore_1.Click += new System.EventHandler(this.fore_1_Click);
            // 
            // preview
            // 
            this.preview.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.preview.AresioBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))))};
            this.preview.AresioBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(151)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(151)))), ((int)(((byte)(153)))))};
            this.preview.AresioForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))))};
            this.preview.AscBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))))};
            this.preview.AscBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(250))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(140))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(85))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(85))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))))};
            this.preview.AscForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(245))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))))};
            this.preview.BCEvoBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))))};
            this.preview.BCEvoBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.preview.BCEvoForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
            this.preview.BorderWidth = 2;
            this.preview.ButBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(33))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(46))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(83)))), ((int)(((byte)(74)))))};
            this.preview.ButBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            this.preview.ButForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.preview.CarbonBack = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.preview.CarbonInnerBorder = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.preview.CarbonOuterBorder = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.preview.Controls.Add(this.tabPage1);
            this.preview.Controls.Add(this.tabPage2);
            this.preview.CrystalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))))};
            this.preview.CrystalBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))))};
            this.preview.CrystalForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.preview.FireFoxBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray,
        System.Drawing.Color.White};
            this.preview.FireFoxBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0))))),
        System.Drawing.Color.SlateGray};
            this.preview.FireFoxForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))))};
            this.preview.FlatActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.preview.FlatBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.preview.FlatTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.preview.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.preview.ITabBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.preview.ITabBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        System.Drawing.Color.Black};
            this.preview.ITabForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))))};
            this.preview.ItemSize = new System.Drawing.Size(80, 35);
            this.preview.Location = new System.Drawing.Point(284, 36);
            this.preview.LoginActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.preview.LoginBackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.preview.LoginBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.preview.LoginBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.preview.LoginHorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(119)))), ((int)(((byte)(151)))));
            this.preview.LoginTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.preview.LoginUpLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.preview.MainBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.preview.MetroActive = System.Drawing.Color.Silver;
            this.preview.MetroActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.preview.MetroBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.preview.MetroDiskBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.preview.MetroInactive = System.Drawing.Color.DimGray;
            this.preview.Name = "preview";
            this.preview.Padding = new System.Drawing.Point(24, 0);
            this.preview.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            this.preview.ReactBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(78)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(229)))), ((int)(((byte)(98)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))))};
            this.preview.ReactBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))))};
            this.preview.ReactForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.DimGray};
            this.preview.SelectedIndex = 0;
            this.preview.Size = new System.Drawing.Size(278, 273);
            this.preview.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.preview.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.preview.Speed = 10;
            this.preview.TabBorderColor = System.Drawing.Color.White;
            this.preview.TabIndex = 72;
            this.preview.TabStyle = Zeroit.Framework.TabThematic.Controls.TabStyles.Unique;
            this.preview.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.preview.TopBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.preview.UniqueBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(85))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))))};
            this.preview.UniqueBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.preview.UniqueForeColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.preview.VBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.Transparent,
        System.Drawing.Color.Transparent,
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))))};
            this.preview.VBorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21))))),
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))))};
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(270, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(270, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox3.Controls.Add(this.border_1);
            this.groupBox3.Controls.Add(this.border_0);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(182, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 73);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Border";
            // 
            // border_1
            // 
            this.border_1.BackColor = System.Drawing.Color.DimGray;
            this.border_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.border_1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.border_1.FlatAppearance.BorderSize = 0;
            this.border_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.border_1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.border_1.Location = new System.Drawing.Point(44, 27);
            this.border_1.Name = "border_1";
            this.border_1.Size = new System.Drawing.Size(38, 33);
            this.border_1.TabIndex = 60;
            this.border_1.UseVisualStyleBackColor = false;
            this.border_1.Click += new System.EventHandler(this.border_1_Click);
            // 
            // border_0
            // 
            this.border_0.BackColor = System.Drawing.Color.DimGray;
            this.border_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.border_0.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.border_0.FlatAppearance.BorderSize = 0;
            this.border_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.border_0.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.border_0.Location = new System.Drawing.Point(3, 27);
            this.border_0.Name = "border_0";
            this.border_0.Size = new System.Drawing.Size(38, 33);
            this.border_0.TabIndex = 59;
            this.border_0.UseVisualStyleBackColor = false;
            this.border_0.Click += new System.EventHandler(this.border_0_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.back_2);
            this.groupBox1.Controls.Add(this.back_3);
            this.groupBox1.Controls.Add(this.back_0);
            this.groupBox1.Controls.Add(this.back_1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 73);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Back";
            // 
            // back_2
            // 
            this.back_2.BackColor = System.Drawing.Color.DimGray;
            this.back_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_2.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.back_2.FlatAppearance.BorderSize = 0;
            this.back_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.back_2.Location = new System.Drawing.Point(86, 27);
            this.back_2.Name = "back_2";
            this.back_2.Size = new System.Drawing.Size(38, 33);
            this.back_2.TabIndex = 62;
            this.back_2.UseVisualStyleBackColor = false;
            this.back_2.Click += new System.EventHandler(this.back_2_Click);
            // 
            // back_3
            // 
            this.back_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.back_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_3.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.back_3.FlatAppearance.BorderSize = 0;
            this.back_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.back_3.Location = new System.Drawing.Point(127, 27);
            this.back_3.Name = "back_3";
            this.back_3.Size = new System.Drawing.Size(38, 33);
            this.back_3.TabIndex = 63;
            this.back_3.UseVisualStyleBackColor = false;
            this.back_3.Click += new System.EventHandler(this.back_3_Click);
            // 
            // back_0
            // 
            this.back_0.BackColor = System.Drawing.Color.DimGray;
            this.back_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_0.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.back_0.FlatAppearance.BorderSize = 0;
            this.back_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_0.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.back_0.Location = new System.Drawing.Point(4, 27);
            this.back_0.Name = "back_0";
            this.back_0.Size = new System.Drawing.Size(38, 33);
            this.back_0.TabIndex = 59;
            this.back_0.UseVisualStyleBackColor = false;
            this.back_0.Click += new System.EventHandler(this.back_0_Click);
            // 
            // back_1
            // 
            this.back_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.back_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.back_1.FlatAppearance.BorderSize = 0;
            this.back_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.back_1.Location = new System.Drawing.Point(45, 27);
            this.back_1.Name = "back_1";
            this.back_1.Size = new System.Drawing.Size(38, 33);
            this.back_1.TabIndex = 60;
            this.back_1.UseVisualStyleBackColor = false;
            this.back_1.Click += new System.EventHandler(this.back_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "Preview";
            // 
            // UniqueUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "UniqueUserControl";
            this.Size = new System.Drawing.Size(569, 321);
            this.groupBox2.ResumeLayout(false);
            this.preview.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button fore_0;
        public System.Windows.Forms.Button fore_1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button border_0;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button back_2;
        public System.Windows.Forms.Button back_3;
        public System.Windows.Forms.Button back_0;
        public System.Windows.Forms.Button back_1;
        public System.Windows.Forms.Button border_1;
        private System.Windows.Forms.Label label1;
        public Controls.ZeroitThematicHorizontalTab preview;
        public System.Windows.Forms.ColorDialog color;
    }
}
