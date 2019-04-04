// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="NSUserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class NSUserControl : UserControl
    {
        public NSUserControl()
        {
            InitializeComponent();
        }

        private void back_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_0.BackColor = color.Color;
                preview.NsBackColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_1.BackColor = color.Color;
                preview.NsBackColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_2.BackColor = color.Color;
                preview.NsBackColors[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_3.BackColor = color.Color;
                preview.NsBackColors[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_4.BackColor = color.Color;
                preview.NsBackColors[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_5.BackColor = color.Color;
                preview.NsBackColors[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_6_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_6.BackColor = color.Color;
                preview.NsBackColors[6] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_7_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_7.BackColor = color.Color;
                preview.NsBackColors[7] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_0.BackColor = color.Color;
                preview.NsBorderColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_1.BackColor = color.Color;
                preview.NsBorderColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_2.BackColor = color.Color;
                preview.NsBorderColors[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore_0.BackColor = color.Color;
                preview.NsForeColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore_1.BackColor = color.Color;
                preview.NsForeColors[1] = color.Color;
                preview.Invalidate();
            }
        }
    }
}
