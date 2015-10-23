﻿/**
 * Kopernicus Planetary System Modifier
 * ====================================
 * Created by: BryceSchroeder and Teknoman117 (aka. Nathaniel R. Lewis)
 * Maintained by: Thomas P., NathanKell and KillAshley
 * Additional Content by: Gravitasi, aftokino, KCreator, Padishar, Kragrathea, OvenProofMars, zengei, MrHappyFace
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
            public class VertexSimplexHeightAbsolute : ModLoader, IParserEventSubscriber
            {
                // Actual PQS mod we are loading
                private PQSMod_VertexSimplexHeightAbsolute _mod;

                // The deformity of the simplex terrain
                [ParserTarget("deformity", optional = true)]
                private NumericParser<double> deformity
                {
                    set { _mod.deformity = value.value; }
                }

                // The frequency of the simplex terrain
                [ParserTarget("frequency", optional = true)]
                private NumericParser<double> frequency
                {
                    set { _mod.frequency = value.value; }
                }

                // Octaves of the simplex height
                [ParserTarget("octaves", optional = true)]
                private NumericParser<double> octaves
                {
                    set { _mod.octaves = value.value; }
                }

                // Persistence of the simplex height
                [ParserTarget("persistence", optional = true)]
                private NumericParser<double> persistence
                {
                    set { _mod.persistence = value.value; }
                }

                // The seed of the simplex height
                [ParserTarget("seed", optional = true)]
                private NumericParser<int> seed
                {
                    set { _mod.seed = value.value; }
                }

                void IParserEventSubscriber.Apply(ConfigNode node)
                {

                }

                void IParserEventSubscriber.PostApply(ConfigNode node)
                {

                }

                public VertexSimplexHeightAbsolute()
                {
                    // Create the base mod
                    GameObject modObject = new GameObject("VertexSimplexHeightAbsolute");
                    modObject.transform.parent = Utility.Deactivator;
                    _mod = modObject.AddComponent<PQSMod_VertexSimplexHeightAbsolute> ();
                    base.mod = _mod;
                }

                public VertexSimplexHeightAbsolute(PQSMod template)
                {
                    _mod = template as PQSMod_VertexSimplexHeightAbsolute;
                    _mod.transform.parent = Utility.Deactivator;
                    base.mod = _mod;
                }
            }
        }
    }
}

