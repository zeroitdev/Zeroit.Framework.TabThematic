// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="LoginUserControl.cs" company="Zeroit Dev Technologies">
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
