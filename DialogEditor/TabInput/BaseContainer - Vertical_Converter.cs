// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BaseContainer - Vertical_Converter.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Reflection;

namespace Zeroit.Framework.TabThematic.Controls
{
    /// <summary>
    /// Class TabVerticalInputConverter.
    /// </summary>
    /// <seealso cref="System.ComponentModel.TypeConverter" />
    public class TabVerticalInputConverter : TypeConverter
    {

        /// <summary>
        /// Returns whether this converter can convert the object to the specified type, using the specified context.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
        /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(InstanceDescriptor)/* || destinationType == typeof(string)*/)
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        // This code allows the designer to generate the Shape constructor

        /// <summary>
        /// Converts the given value object to the specified type, using the specified context and culture information.
        /// </summary>
        /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
        /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
        /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
        /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
        /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture,
            object value,
            Type destinationType)
        {

            if (destinationType == typeof(string))
            {
                // Display string in designer
                return "(Customize)";
            }


            else if (destinationType == typeof(InstanceDescriptor) && value is TabVerticalInput)
            {
                TabVerticalInput tabHorizontalInput = (TabVerticalInput)value;

                if (tabHorizontalInput.TabStyle == TabVerticalStyles.ButterVertical)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[]
                    {

                                typeof(Color[]),
                                typeof(Color[]),
                                typeof(Color[])



                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {


                                tabHorizontalInput.ButterVertBackColors,
                                tabHorizontalInput.ButterVertBorderColors,
                                tabHorizontalInput.ButterVertForeColors

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.Chrome)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[]
                    {
                        typeof(Color[]),
                        typeof(Color[]),
                        typeof(Color),
                        typeof(bool)

                    });

                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[]
                        {
                            tabHorizontalInput.ChromeBackColor,
                            tabHorizontalInput.ChromeForeColors, //tabHorizontalInput.CustomizableAdvancedSystemSlope,
                            tabHorizontalInput.SquareColor,
                            tabHorizontalInput.DummyBool

                        });
                    }


                }
                
                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.DotBarV2)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[])

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.DotV2BackColors,
                                tabHorizontalInput.DotV2BorderColors,
                                tabHorizontalInput.DotV2ForeColors,
                                tabHorizontalInput.DotV2BlendColors

                            });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.DotBar)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(bool)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.DotnetBarBackColors,
                                tabHorizontalInput.DotnetBarBorderColors,
                                tabHorizontalInput.DotnetBarForeColors,
                                tabHorizontalInput.DotnetBarColorBlend,
                                tabHorizontalInput.DummyBool
                            });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.EightBall)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(bool),
                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.EightBallBackColors,
                                tabHorizontalInput.EightBallBorderColors,
                                tabHorizontalInput.EightBallForeColors,
                                tabHorizontalInput.DummyBool

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.Empire)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {

                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(string)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.EmpireForeColors,
                                tabHorizontalInput.EmpireBorderColors,
                                tabHorizontalInput.EmpireBackColors,
                                tabHorizontalInput.DummyString,

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.Facebook)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {

                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.PressedTabColor,
                                tabHorizontalInput.HoverColor,
                                tabHorizontalInput.NormalColor,
                                tabHorizontalInput.FaceBookBorderColor,
                                tabHorizontalInput.FaceBookTextColor,
                                tabHorizontalInput.FaceBookBack

                        });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.FirefoxMain)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {

                                typeof(Color[]),
                                typeof(Color[])

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                    tabHorizontalInput.FireFoxBackColors,
                                    tabHorizontalInput.FireFoxForeColors

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.Meph)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[])


                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.MephBackColors,
                                tabHorizontalInput.MephBorderColors,
                                tabHorizontalInput.MephForeColors,
                                tabHorizontalInput.MephColorBlend,
                                tabHorizontalInput.CFull,
                                tabHorizontalInput.CHighlight,
                                tabHorizontalInput.PageFill


                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.NS)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(int)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.NsBorderColors,
                                tabHorizontalInput.NsBackColors,
                                tabHorizontalInput.NsForeColors,
                                tabHorizontalInput.DummyInt
                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.Redemption)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(bool),
                            typeof(HorizontalAlignments),

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.RedemptionBackColors,
                                tabHorizontalInput.RedemptionBorderColors,
                                tabHorizontalInput.RedemptionForeColors,
                                tabHorizontalInput.GradientPen,
                                tabHorizontalInput.BackgroundNoise,
                                tabHorizontalInput.TextAlign
                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.SLC)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(long)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.SlcBackColors,
                                tabHorizontalInput.SlcBorderColors,
                                tabHorizontalInput.SlcForeColors,
                                tabHorizontalInput.DummyLong

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabVerticalStyles.xVisual)
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[])

                        });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.InnerTexture,
                                tabHorizontalInput.TabBGTexture,
                                tabHorizontalInput.XVisualBackColors,
                                tabHorizontalInput.XVisualBorderColors,
                                tabHorizontalInput.XVisualForeColors,
                                tabHorizontalInput.GlowColor
                            });
                    }
                }
                
                else
                {
                    ConstructorInfo ctor = typeof(TabVerticalInput).GetConstructor(Type.EmptyTypes);
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, null);
                    }
                }

            }
            
            return base.ConvertTo(context, culture, value, destinationType);

        }

    }

}
