// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="RedemptionUserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class RedemptionUserControl : UserControl
    {
        public RedemptionUserControl()
        {
            InitializeComponent();
        }

        private void back_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_0.BackColor = color.Color;
                preview.RedemptionBackColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_1.BackColor = color.Color;
                preview.RedemptionBackColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_2.BackColor = color.Color;
                preview.RedemptionBackColors[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_3.BackColor = color.Color;
                preview.RedemptionBackColors[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_4.BackColor = color.Color;
                preview.RedemptionBackColors[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_5.BackColor = color.Color;
                preview.RedemptionBackColors[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore_0.BackColor = color.Color;
                preview.RedemptionForeColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore_1.BackColor = color.Color;
                preview.RedemptionForeColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_0.BackColor = color.Color;
                preview.RedemptionBorderColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_1.BackColor = color.Color;
                preview.RedemptionBorderColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_2.BackColor = color.Color;
                preview.RedemptionBorderColors[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_3.BackColor = color.Color;
                preview.RedemptionBorderColors[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_4.BackColor = color.Color;
                preview.RedemptionBorderColors[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_5.BackColor = color.Color;
                preview.RedemptionBorderColors[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void gradientPen_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                gradientPen_0.BackColor = color.Color;
                preview.GradientPen[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void gradientPen_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                gradientPen_1.BackColor = color.Color;
                preview.GradientPen[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void gradientPen_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                gradientPen_2.BackColor = color.Color;
                preview.GradientPen[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void gradientPen_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                gradientPen_3.BackColor = color.Color;
                preview.GradientPen[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void gradientPen_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                gradientPen_4.BackColor = color.Color;
                preview.GradientPen[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void gradientPen_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                gradientPen_5.BackColor = color.Color;
                preview.GradientPen[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void backGroundNoise_Yes_RadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (backGroundNoise_Yes_RadBtn.Checked == true)
            {
                preview.BackgroundNoise = true;
                preview.Invalidate();
            }
            else
            {
                preview.BackgroundNoise = false;
                preview.Invalidate();
            }
        }
    }
}
