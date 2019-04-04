// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="MephUserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class MephUserControl : UserControl
    {
        public MephUserControl()
        {
            InitializeComponent();
        }

        private void back_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_0.BackColor = color.Color;
                preview.MephBackColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_1.BackColor = color.Color;
                preview.MephBackColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_2.BackColor = color.Color;
                preview.MephBackColors[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_3.BackColor = color.Color;
                preview.MephBackColors[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void back_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back_4.BackColor = color.Color;
                preview.MephBackColors[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_0.BackColor = color.Color;
                preview.MephBorderColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_1.BackColor = color.Color;
                preview.MephBorderColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_2.BackColor = color.Color;
                preview.MephBorderColors[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_3.BackColor = color.Color;
                preview.MephBorderColors[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void border_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border_4.BackColor = color.Color;
                preview.MephBorderColors[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore_0.BackColor = color.Color;
                preview.MephForeColors[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore_1.BackColor = color.Color;
                preview.MephForeColors[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void full_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                full_0.BackColor = color.Color;
                preview.CFull[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void full_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                full_1.BackColor = color.Color;
                preview.CFull[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void full_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                full_2.BackColor = color.Color;
                preview.CFull[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void full_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                full_3.BackColor = color.Color;
                preview.CFull[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void full_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                full_4.BackColor = color.Color;
                preview.CFull[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void full_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                full_5.BackColor = color.Color;
                preview.CFull[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void full_6_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                full_6.BackColor = color.Color;
                preview.CFull[6] = color.Color;
                preview.Invalidate();
            }
        }

        private void full_7_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                full_7.BackColor = color.Color;
                preview.CFull[7] = color.Color;
                preview.Invalidate();
            }
        }

        private void highlight_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                highlight_0.BackColor = color.Color;
                preview.CHighlight[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void highlight_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                highlight_1.BackColor = color.Color;
                preview.CHighlight[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void highlight_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                highlight_2.BackColor = color.Color;
                preview.CHighlight[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void highlight_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                highlight_3.BackColor = color.Color;
                preview.CHighlight[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void highlight_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                highlight_4.BackColor = color.Color;
                preview.CHighlight[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void highlight_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                highlight_5.BackColor = color.Color;
                preview.CHighlight[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void highlight_6_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                highlight_6.BackColor = color.Color;
                preview.CHighlight[6] = color.Color;
                preview.Invalidate();
            }
        }

        private void highlight_7_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                highlight_7.BackColor = color.Color;
                preview.CHighlight[7] = color.Color;
                preview.Invalidate();
            }
        }

        private void fill_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fill_0.BackColor = color.Color;
                preview.PageFill[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void fill_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fill_1.BackColor = color.Color;
                preview.PageFill[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void fill_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fill_2.BackColor = color.Color;
                preview.PageFill[2] = color.Color;
                preview.Invalidate();
            }
        }

        private void fill_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fill_3.BackColor = color.Color;
                preview.PageFill[3] = color.Color;
                preview.Invalidate();
            }
        }

        private void fill_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fill_4.BackColor = color.Color;
                preview.PageFill[4] = color.Color;
                preview.Invalidate();
            }
        }

        private void fill_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fill_5.BackColor = color.Color;
                preview.PageFill[5] = color.Color;
                preview.Invalidate();
            }
        }

        private void fill_6_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fill_6.BackColor = color.Color;
                preview.PageFill[6] = color.Color;
                preview.Invalidate();
            }
        }

        private void fill_7_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fill_7.BackColor = color.Color;
                preview.PageFill[7] = color.Color;
                preview.Invalidate();
            }
        }

        private void blend_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                blend_0.BackColor = color.Color;
                preview.MephColorBlend[0] = color.Color;
                preview.Invalidate();
            }
        }

        private void blend_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                blend_1.BackColor = color.Color;
                preview.MephColorBlend[1] = color.Color;
                preview.Invalidate();
            }
        }

        private void blend_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                blend_2.BackColor = color.Color;
                preview.MephColorBlend[2] = color.Color;
                preview.Invalidate();
            }
        }
    }
}
