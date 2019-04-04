// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="CarbonFibreUserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class CarbonFibreUserControl : UserControl
    {
        public CarbonFibreUserControl()
        {
            InitializeComponent();
        }

        private void innerBorder_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                innerBorder.BackColor = color.Color;
                preview.CarbonInnerBorder = color.Color;
                preview.Invalidate();
            }
        }

        private void outterBorder_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                outterBorder.BackColor = color.Color;
                preview.CarbonOuterBorder = color.Color;
                preview.Invalidate();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back.BackColor = color.Color;
                preview.CarbonBack = color.Color;
                preview.Invalidate();
            }
        }
    }
}
