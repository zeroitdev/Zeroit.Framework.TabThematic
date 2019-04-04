// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BaseContainer - VerticalEditorUITypeEditor.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
    public class TabVerticalEditor : System.Drawing.Design.UITypeEditor
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
            if (value is TabVerticalInput)
            {
                TabThematicVerticalDialog dialog = new TabThematicVerticalDialog((TabVerticalInput)value);
                //dialog.Show();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.TabVerticalInput;
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

            if (e.Value is TabVerticalInput)
            {
                TabVerticalStyles tabStyles = ((TabVerticalInput)e.Value).TabStyle;
                Brush br = ((TabVerticalInput)e.Value).GetUITypeEditorBrush(e.Bounds);
                Pen pn = ((TabVerticalInput)e.Value).GetUITypeEditorPen(e.Bounds);

                string T = "";
                Font F = new Font("Segoe UI", 6);
                SizeF TS = e.Graphics.MeasureString(T, F);

                SolidBrush B = new SolidBrush(Color.Cyan);

                if (br != null && pn != null)
                {
                    switch (tabStyles)
                    {
                        case TabVerticalStyles.ButterVertical:
                            e.Graphics.DrawString("BT", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1, 1));
                            break;
                        case TabVerticalStyles.Chrome:
                            T = "CR";
                            e.Graphics.DrawString("CR", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.DotBar:
                            e.Graphics.DrawString("DB", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.DotBarV2:
                            e.Graphics.DrawString("D2", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.EightBall:
                            e.Graphics.DrawString("EB", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.Empire:
                            e.Graphics.DrawString("EM", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.Facebook:
                            e.Graphics.DrawString("FB", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.FirefoxMain:
                            e.Graphics.DrawString("FF", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.Meph:
                            e.Graphics.DrawString("MP", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.NS:
                            e.Graphics.DrawString("NS", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.Redemption:
                            e.Graphics.DrawString("RD", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.SLC:
                            e.Graphics.DrawString("SL", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                        case TabVerticalStyles.xVisual:
                            e.Graphics.DrawString("XV", new Font("Segoe UI", 9), new SolidBrush(Color.Cyan),
                                new Point(1,1));
                            break;
                    }
                }
            }
        }
    }
}