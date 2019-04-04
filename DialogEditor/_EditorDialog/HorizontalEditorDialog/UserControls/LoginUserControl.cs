// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="LoginUserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back.BackColor = color.Color;
                preview.LoginBackTabColor = color.Color;
                preview.Invalidate();
            }
        }

        private void baseColor_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                baseColor.BackColor = color.Color;
                preview.LoginBaseColor = color.Color;
                preview.Invalidate();
            }
        }

        private void active_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                active.BackColor = color.Color;
                preview.LoginActiveColor = color.Color;
                preview.Invalidate();
            }
        }

        private void line_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                line_0.BackColor = color.Color;
                preview.LoginHorizontalLineColor = color.Color;
                preview.Invalidate();
            }
        }

        private void line_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                line_1.BackColor = color.Color;
                preview.LoginUpLineColor = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore.BackColor = color.Color;
                preview.LoginTextColor = color.Color;
                preview.Invalidate();
            }
        }

        private void border_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border.BackColor = color.Color;
                preview.LoginBorderColor = color.Color;
                preview.Invalidate();
            }
        }
    }
}
