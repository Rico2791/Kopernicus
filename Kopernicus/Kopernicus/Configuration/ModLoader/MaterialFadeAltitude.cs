﻿/**
 * Kopernicus Planetary System Modifier
 * ====================================
 * Created by: BryceSchroeder and Teknoman117 (aka. Nathaniel R. Lewis)
 * Maintained by: Thomas P., NathanKell and KillAshley
 * Additional Content by: Gravitasi, aftokino, KCreator, Padishar, Kragrathea, OvenProofMars, zengei, MrHappyFace, Sigma88
 * ------------------------------------------------------------- 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 * 
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright 2011-2015 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System;
using UnityEngine;

namespace Kopernicus
{
    namespace Configuration
    {
        namespace ModLoader
        {
            [RequireConfigType(ConfigType.Node)]
            public class MaterialFadeAltitude : ModLoader<PQSMod_MaterialFadeAltitude>
            {
                // fadeEnd
                [ParserTarget("fadeEnd")]
                public NumericParser<float> fadeEnd
                {
                    get { return mod.fadeEnd; }
                    set { mod.fadeEnd = value; }
                }

                // fadeStart
                [ParserTarget("fadeStart")]
                public NumericParser<float> fadeStart
                {
                    get { return mod.fadeStart; }
                    set { mod.fadeStart = value; }
                }

                // valueEnd
                [ParserTarget("valueEnd")]
                public NumericParser<float> valueEnd
                {
                    get { return mod.valueEnd; }
                    set { mod.valueEnd = value; }
                }

                // valueStart
                [ParserTarget("valueStart")]
                public NumericParser<float> valueStart
                {
                    get { return mod.valueStart; }
                    set { mod.valueStart = value; }
                }
            }
        }
    }
}

