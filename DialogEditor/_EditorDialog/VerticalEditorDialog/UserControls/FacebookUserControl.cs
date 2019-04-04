// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FacebookUserControl.cs" company="Zeroit Dev Technologies">
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
    public partial class FacebookUserControl : UserControl
    {
        public FacebookUserControl()
        {
            InitializeComponent();
        }

        private void pressed_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                pressed.BackColor = color.Color;
                preview.PressedTabColor = color.Color;
                preview.Invalidate();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                back.BackColor = color.Color;
                preview.FaceBookBack = color.Color;
                preview.Invalidate();
            }
        }

        private void normal_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                normal.BackColor = color.Color;
                preview.NormalColor = color.Color;
                preview.Invalidate();
            }
        }

        private void hover_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                hover.BackColor = color.Color;
                preview.HoverColor = color.Color;
                preview.Invalidate();
            }
        }

        private void border_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                border.BackColor = color.Color;
                preview.FaceBookBorderColor = color.Color;
                preview.Invalidate();
            }
        }

        private void fore_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                fore.BackColor = color.Color;
                preview.FaceBookTextColor = color.Color;
                preview.Invalidate();
            }
        }
    }
}
