// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BaseContainerEditorUITypeEditor.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Zeroit.Framework.TabThematic.DialogEditor;

namespace Zeroit.Framework.TabThematic.Controls
{
    /// <summary>
    ///     The <c>UITypeEditor</c> derived class which indicates how a <c>Filler</c>
    ///     object can be edited directly from Visual Studio Designer.
    /// </summary>
    /// <remarks>
    ///     Note that this class is <b>NOT</b> meant to be invoked directly
    /// </remarks>
    /// <summary>
    ///     The <c>UITypeEditor</c> derived class which indicates how a <c>Filler</c>
    ///     object can be edited directly from Visual Studio Designer.
    /// </summary>
    /// <remarks>
    ///     Note that this class is <b>NOT</b> meant to be invoked directly
    /// </remarks>
    public class TabHorizontalEditor : System.Drawing.Design.UITypeEditor
    {
        /// <summary>
        ///     Gets the editor style used by the <c>EditValue</c> method.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <returns><c>UITypeEditorEditStyle.Modal</c></returns>
        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        /// <summary>
        ///     Creates and displays a <c>FillerEditorDialog</c> dialog if <c>value</c> is a <c>Filler</c>.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <param name="provider">An IServiceProvider through which editing services may be obtained.</param>
        /// <param name="value">An instance of <c>Filler</c> being edited.</param>
        /// <returns>The new value of the <c>Filler</c> being edited.</returns>
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context,
            System.IServiceProvider provider,
            object value)
        {
            if (value is TabHorizontalInput)
            {
                TabThematicHorizontalDialog dialog = new TabThematicHorizontalDialog((TabHorizontalInput)value);
                //dialog.Show();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.TabHorizontalInput;
                }
            }
            return value;
        }

        /// <summary>
        ///     Indicates that painting is supported.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information.</param>
        /// <returns><c>true</c>.</returns>
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        ///     Paint a representation of the simple filler (usually in designer).
        /// </summary>
        /// <param name="e">A <c>PaintValueEventArgs</c> that indicates what to paint and where to paint it.</param>
        public override void PaintValue(PaintValueEventArgs e)
        {

            TabStyles tabStyles = ((TabHorizontalInput)e.Value).TabStyle;
            
            switch (tabStyles)
            {
                case TabStyles.Aresio:
                    e.Graphics.DrawString("AR", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.ASC:
                    e.Graphics.DrawString("AS", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.BCEvo:
                    e.Graphics.DrawString("BC", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.Butter:
                    e.Graphics.DrawString("BT", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.CarbonFibre:
                    e.Graphics.DrawString("CF", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.CrystalClear:
                    e.Graphics.DrawString("CC", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.FirefoxSub:
                    e.Graphics.DrawString("FF", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.Flat:
                    e.Graphics.DrawString("FT", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.iTab:
                    e.Graphics.DrawString("IT", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.Login:
                    e.Graphics.DrawString("LN", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.MetroDisk:
                    e.Graphics.DrawString("MD", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.Reactor:
                    e.Graphics.DrawString("RT", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.Simpla:
                    e.Graphics.DrawString("SA", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.Unique:
                    e.Graphics.DrawString("UQ", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
                case TabStyles.VTab:
                    e.Graphics.DrawString("VT", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                        new Point(1, 1));
                    break;
            }
        }
    }
}
