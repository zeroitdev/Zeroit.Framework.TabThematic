// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MetroDiskUserControl.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Zeroit.Framework.TabThematic.DialogEditor
{
    [ToolboxItem(false)]
    public partial class MetroDiskUserControl : UserControl
    {
        public MetroDiskUserControl()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back.BackColor = color.Color;
                preview.MetroBackColor = color.Color;
                preview.Invalidate();
            }
        }

        private void baseColor_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                baseColor.BackColor = color.Color;
                preview.MetroDiskBaseColor = color.Color;
                preview.Invalidate();
            }
        }

        private void active_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                active_0.BackColor = color.Color;
                preview.MetroActive = color.Color;
                preview.Invalidate();
            }
        }

        private void active_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                active_1.BackColor = color.Color;
                preview.MetroActiveColor = color.Color;
                preview.Invalidate();
            }
        }

        private void inactive_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                inactive.BackColor = color.Color;
                preview.MetroInactive = color.Color;
                preview.Invalidate();
            }
        }
    }
}
