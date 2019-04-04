// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="FacebookUserControl.cs" company="Zeroit Dev Technologies">
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
