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

using UnityEngine;

namespace Kopernicus
{
    namespace OnDemand
    {
        public class PQSMod_OnDemandHandler : PQSMod
        {
            // State
            private bool isLoaded = false;

            // Disabling
            public override void OnSphereInactive()
            {
                // Don't update, if the Injector is still running
                if (Injector.dontUpdate || !isLoaded)
                    return;

                // Enable the maps
                if (OnDemandStorage.DisableBody(sphere.name))
                {
                    isLoaded = false;
                    Debug.Log("[OD] Disabling Body " + base.sphere.name + ": " + isLoaded);
                }
            }

            // Enabling
            public override void OnQuadPreBuild(PQ quad)
            {
                // Don't update, if the Injector is still running
                if (Injector.dontUpdate || isLoaded)
                    return;

                // Enable the maps
                if (OnDemandStorage.EnableBody(sphere.name))
                {
                    isLoaded = true;
                    Debug.Log("[OD] Enabling Body " + base.sphere.name + ": " + isLoaded);
                }
            }
        }
    }
}