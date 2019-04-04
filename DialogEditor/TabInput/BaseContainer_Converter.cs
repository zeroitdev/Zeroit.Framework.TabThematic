// ***********************************************************************
// Assembly         : Zeroit.Framework.TabThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="BaseContainer_Converter.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Reflection;

namespace Zeroit.Framework.TabThematic.Controls
{
    /// <summary>
    /// Class TabHorizontalConverter.
    /// </summary>
    /// <seealso cref="System.ComponentModel.TypeConverter" />
    public class TabHorizontalConverter : TypeConverter
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


            else if (destinationType == typeof(InstanceDescriptor) && value is TabHorizontalInput)
            {
                TabHorizontalInput tabHorizontalInput = (TabHorizontalInput)value;

                if (tabHorizontalInput.TabStyle == TabStyles.ASC)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[]
                    {

                                typeof(Color[]),
                                typeof(Color[]),
                                typeof(Color[])



                    });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {


                                tabHorizontalInput.AscForeColors,
                                tabHorizontalInput.AscBorderColors,
                                tabHorizontalInput.AscBackColors

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.Aresio)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[]
                    {
                        typeof(Color[]),
                        typeof(Color[]),
                        typeof(Color[]),
                        typeof(bool)

                    });

                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[]
                        {
                            tabHorizontalInput.AresioForeColors,
                            tabHorizontalInput.AresioBorderColors, //tabHorizontalInput.CustomizableAdvancedSystemSlope,
                            tabHorizontalInput.AresioBackColors,
                            tabHorizontalInput.DummyBool

                        });
                    }


                }
                
                else if (tabHorizontalInput.TabStyle == TabStyles.BCEvo)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(int)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.BCEvoForeColors,
                                tabHorizontalInput.BCEvoBorderColors,
                                tabHorizontalInput.BCEvoBackColors,
                                tabHorizontalInput.BorderWidth

                            });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.Butter)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(string),

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.ButForeColors,
                                tabHorizontalInput.ButBackColors,
                                tabHorizontalInput.ButBorderColors,
                                tabHorizontalInput.DummyString,

                            });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.CarbonFibre)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color),
                            typeof(Color),
                            typeof(Color),

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.CarbonBack,
                                tabHorizontalInput.CarbonOuterBorder,
                                tabHorizontalInput.CarbonInnerBorder,
                                
                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.CrystalClear)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {

                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(long)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.CrystalBackColors,
                                tabHorizontalInput.CrystalBorderColors,
                                tabHorizontalInput.CrystalForeColors,
                                tabHorizontalInput.DummyLong,

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.FirefoxSub)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {

                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(float),

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.FireFoxBackColors,
                                tabHorizontalInput.FireFoxBorderColors,
                                tabHorizontalInput.FireFoxForeColors,
                                tabHorizontalInput.DummyFloat
                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.Flat)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {

                                typeof(Color),
                                typeof(Color),
                                typeof(Color),
                                typeof(double)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                    tabHorizontalInput.FlatTabBackColor,
                                    tabHorizontalInput.FlatBaseColor,
                                    tabHorizontalInput.FlatActiveColor,
                                    tabHorizontalInput.DummyFloat,

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.iTab)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(ulong)


                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.ITabBackColors,
                                tabHorizontalInput.ITabBorderColors,
                                tabHorizontalInput.ITabForeColors,
                                tabHorizontalInput.DummyUnlong


                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.Login)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.LoginTextColor,
                                tabHorizontalInput.LoginBackTabColor,
                                tabHorizontalInput.LoginBaseColor,
                                tabHorizontalInput.LoginActiveColor,
                                tabHorizontalInput.LoginBorderColor,
                                tabHorizontalInput.LoginUpLineColor,
                                tabHorizontalInput.LoginHorizontalLineColor


                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.MetroDisk)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.MetroDiskBaseColor,
                                tabHorizontalInput.MetroActiveColor,
                                tabHorizontalInput.MetroBackColor,
                                tabHorizontalInput.MetroInactive,
                                tabHorizontalInput.MetroActive
                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.Reactor)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.ReactForeColors,
                                tabHorizontalInput.ReactBackColors,
                                tabHorizontalInput.ReactBorderColors,
                                tabHorizontalInput.TabBorderColor

                                });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.Simpla)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(byte)

                        });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.MainBackground,
                                tabHorizontalInput.TopBackground,
                                tabHorizontalInput.ActiveTabColor,
                                tabHorizontalInput.DummyByte
                            });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.Unique)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {

                                typeof(Color[]),
                                typeof(Color[]),
                                typeof(Color[]),
                                typeof(sbyte)

                            });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                    tabHorizontalInput.UniqueForeColors,
                                    tabHorizontalInput.UniqueBackColors,
                                    tabHorizontalInput.UniqueBorderColors,
                                    tabHorizontalInput.DummySByte

                        });
                    }
                }

                else if (tabHorizontalInput.TabStyle == TabStyles.VTab)
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(bool),

                        });
                    if (ctor != null)
                    {
                        return new InstanceDescriptor(ctor, new object[] {

                                tabHorizontalInput.VBackColors,
                                tabHorizontalInput.VBorderColors,
                                tabHorizontalInput.DummyBool

                        });
                    }
                }
                
                else
                {
                    ConstructorInfo ctor = typeof(TabHorizontalInput).GetConstructor(Type.EmptyTypes);
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
