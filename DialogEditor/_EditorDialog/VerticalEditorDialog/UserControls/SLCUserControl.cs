// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="SLCUserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class SLCUserControl : UserControl
    {
        public SLCUserControl()
        {
            InitializeComponent();
        }

        private void back_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_0.BackColor = color.Color;
                preview.SlcBackColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_1.BackColor = color.Color;
                preview.SlcBackColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_2.BackColor = color.Color;
                preview.SlcBackColors[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_3.BackColor = color.Color;
                preview.SlcBackColors[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_4.BackColor = color.Color;
                preview.SlcBackColors[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_5.BackColor = color.Color;
                preview.SlcBackColors[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_6_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_6.BackColor = color.Color;
                preview.SlcBackColors[6] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_7_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_7.BackColor = color.Color;
                preview.SlcBackColors[7] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_8_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_8.BackColor = color.Color;
                preview.SlcBackColors[8] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_9_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_9.BackColor = color.Color;
                preview.SlcBackColors[9] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_10_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_10.BackColor = color.Color;
                preview.SlcBackColors[10] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_11_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_11.BackColor = color.Color;
                preview.SlcBackColors[11] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_12_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_12.BackColor = color.Color;
                preview.SlcBackColors[12] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_0.BackColor = color.Color;
                preview.SlcBorderColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_1.BackColor = color.Color;
                preview.SlcBorderColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_2.BackColor = color.Color;
                preview.SlcBorderColors[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_3.BackColor = color.Color;
                preview.SlcBorderColors[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_4.BackColor = color.Color;
                preview.SlcBorderColors[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_5.BackColor = color.Color;
                preview.SlcBorderColors[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_6_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_6.BackColor = color.Color;
                preview.SlcBorderColors[6] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_7_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_7.BackColor = color.Color;
                preview.SlcBorderColors[7] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_8_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_8.BackColor = color.Color;
                preview.SlcBorderColors[8] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_9_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_9.BackColor = color.Color;
                preview.SlcBorderColors[9] = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore.BackColor = color.Color;
                preview.SlcForeColors[0] = color.Color;
                preview.Invalidate();
            }
        }
    }
}
