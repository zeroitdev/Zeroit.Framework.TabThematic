// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FlatUIUserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class FlatUIUserControl : UserControl
    {
        public FlatUIUserControl()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back.BackColor = color.Color;
                preview.FlatTabBackColor = color.Color;
                preview.Invalidate();
            }
        }

        private void baseColor_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                baseColor.BackColor = color.Color;
                preview.FlatBaseColor = color.Color;
                preview.Invalidate();
            }
        }

        private void active_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                active.BackColor = color.Color;
                preview.FlatActiveColor = color.Color;
                preview.Invalidate();
            }
        }
    }
}
