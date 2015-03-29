// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class PQSOceanSurfaceQuad : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                public const string shaderName = "Terrain/PQS/Ocean Surface Quad";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Main Color, default = (1,1,1,1)
                public const string colorKey = "_Color";
                public int colorID { get; private set; }

                // Color From Space, default = (1,1,1,1)
                public const string colorFromSpaceKey = "_ColorFromSpace";
                public int colorFromSpaceID { get; private set; }

                // Specular Color, default = (1,1,1,1)
                public const string specColorKey = "_SpecColor";
                public int specColorID { get; private set; }

                // Shininess, default = 0.078125
                public const string shininessKey = "_Shininess";
                public int shininessID { get; private set; }

                // Gloss, default = 0.078125
                public const string glossKey = "_Gloss";
                public int glossID { get; private set; }

                // Tex Tiling, default = 1
                public const string tilingKey = "_tiling";
                public int tilingID { get; private set; }

                // Tex0, default = "white" {}
                public const string waterTexKey = "_WaterTex";
                public int waterTexID { get; private set; }

                // Tex1, default = "white" {}
                public const string waterTex1Key = "_WaterTex1";
                public int waterTex1ID { get; private set; }

                // Normal Tiling, default = 1
                public const string bTilingKey = "_bTiling";
                public int bTilingID { get; private set; }

                // Normalmap0, default = "bump" {}
                public const string bumpMapKey = "_BumpMap";
                public int bumpMapID { get; private set; }

                // Water Movement, default = 1
                public const string displacementKey = "_displacement";
                public int displacementID { get; private set; }

                // Water Freq, default = 1
                public const string dispFreqKey = "_dispFreq";
                public int dispFreqID { get; private set; }

                // Mix, default = 1
                public const string mixKey = "_Mix";
                public int mixID { get; private set; }

                // Opacity, default = 1
                public const string oceanOpacityKey = "_oceanOpacity";
                public int oceanOpacityID { get; private set; }

                // Falloff Power, default = 1
                public const string falloffPowerKey = "_falloffPower";
                public int falloffPowerID { get; private set; }

                // Falloff Exp, default = 2
                public const string falloffExpKey = "_falloffExp";
                public int falloffExpID { get; private set; }

                // AP Fog Color, default = (0,0,1,1)
                public const string fogColorKey = "_fogColor";
                public int fogColorID { get; private set; }

                // AP Height Fall Off, default = 1
                public const string heightFallOffKey = "_heightFallOff";
                public int heightFallOffID { get; private set; }

                // AP Global Density, default = 1
                public const string globalDensityKey = "_globalDensity";
                public int globalDensityID { get; private set; }

                // AP Atmosphere Depth, default = 1
                public const string atmosphereDepthKey = "_atmosphereDepth";
                public int atmosphereDepthID { get; private set; }

                // FogColorRamp, default = "white" {}
                public const string fogColorRampKey = "_fogColorRamp";
                public int fogColorRampID { get; private set; }

                // FadeStart, default = 1
                public const string fadeStartKey = "_fadeStart";
                public int fadeStartID { get; private set; }

                // FadeEnd, default = 1
                public const string fadeEndKey = "_fadeEnd";
                public int fadeEndID { get; private set; }

                // PlanetOpacity, default = 1
                public const string planetOpacityKey = "_PlanetOpacity";
                public int planetOpacityID { get; private set; }

                // Singleton instance
                private static Properties singleton = null;
                public static Properties Instance
                {
                    get
                    {
                        // Construct the singleton if it does not exist
                        if(singleton == null)
                            singleton = new Properties();
            
                        return singleton;
                    }
                }

                private Properties()
                {
                    colorID = Shader.PropertyToID(colorKey);
                    colorFromSpaceID = Shader.PropertyToID(colorFromSpaceKey);
                    specColorID = Shader.PropertyToID(specColorKey);
                    shininessID = Shader.PropertyToID(shininessKey);
                    glossID = Shader.PropertyToID(glossKey);
                    tilingID = Shader.PropertyToID(tilingKey);
                    waterTexID = Shader.PropertyToID(waterTexKey);
                    waterTex1ID = Shader.PropertyToID(waterTex1Key);
                    bTilingID = Shader.PropertyToID(bTilingKey);
                    bumpMapID = Shader.PropertyToID(bumpMapKey);
                    displacementID = Shader.PropertyToID(displacementKey);
                    dispFreqID = Shader.PropertyToID(dispFreqKey);
                    mixID = Shader.PropertyToID(mixKey);
                    oceanOpacityID = Shader.PropertyToID(oceanOpacityKey);
                    falloffPowerID = Shader.PropertyToID(falloffPowerKey);
                    falloffExpID = Shader.PropertyToID(falloffExpKey);
                    fogColorID = Shader.PropertyToID(fogColorKey);
                    heightFallOffID = Shader.PropertyToID(heightFallOffKey);
                    globalDensityID = Shader.PropertyToID(globalDensityKey);
                    atmosphereDepthID = Shader.PropertyToID(atmosphereDepthKey);
                    fogColorRampID = Shader.PropertyToID(fogColorRampKey);
                    fadeStartID = Shader.PropertyToID(fadeStartKey);
                    fadeEndID = Shader.PropertyToID(fadeEndKey);
                    planetOpacityID = Shader.PropertyToID(planetOpacityKey);
                }
			}

			// Is some random material this material
			public static bool UsesSameShader(Material m)
			{
				return m.shader.name == Properties.shaderName;
			}

            // Color From Space, default = (1,1,1,1)
            public Color colorFromSpace
            {
                get { return GetColor (Properties.Instance.colorFromSpaceID); }
                set { SetColor (Properties.Instance.colorFromSpaceID, value); }
            }

            // Specular Color, default = (1,1,1,1)
            public Color specColor
            {
                get { return GetColor (Properties.Instance.specColorID); }
                set { SetColor (Properties.Instance.specColorID, value); }
            }

            // Shininess, default = 0.078125
            public float shininess
            {
                get { return GetFloat (Properties.Instance.shininessID); }
                set { SetFloat (Properties.Instance.shininessID, Mathf.Clamp(value,0.01f,1f)); }
            }

            // Gloss, default = 0.078125
            public float gloss
            {
                get { return GetFloat (Properties.Instance.glossID); }
                set { SetFloat (Properties.Instance.glossID, Mathf.Clamp(value,0.01f,1f)); }
            }

            // Tex Tiling, default = 1
            public float tiling
            {
                get { return GetFloat (Properties.Instance.tilingID); }
                set { SetFloat (Properties.Instance.tilingID, value); }
            }

            // Tex0, default = "white" {}
            public Texture2D waterTex
            {
                get { return GetTexture (Properties.Instance.waterTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.waterTexID, value); }
            }

            public Vector2 waterTexScale
            {
                get { return GetTextureScale (Properties.waterTexKey); }
                set { SetTextureScale (Properties.waterTexKey, value); }
            }

            public Vector2 waterTexOffset
            {
                get { return GetTextureOffset (Properties.waterTexKey); }
                set { SetTextureOffset (Properties.waterTexKey, value); }
            }

            // Tex1, default = "white" {}
            public Texture2D waterTex1
            {
                get { return GetTexture (Properties.Instance.waterTex1ID) as Texture2D; }
                set { SetTexture (Properties.Instance.waterTex1ID, value); }
            }

            public Vector2 waterTex1Scale
            {
                get { return GetTextureScale (Properties.waterTex1Key); }
                set { SetTextureScale (Properties.waterTex1Key, value); }
            }

            public Vector2 waterTex1Offset
            {
                get { return GetTextureOffset (Properties.waterTex1Key); }
                set { SetTextureOffset (Properties.waterTex1Key, value); }
            }

            // Normal Tiling, default = 1
            public float bTiling
            {
                get { return GetFloat (Properties.Instance.bTilingID); }
                set { SetFloat (Properties.Instance.bTilingID, value); }
            }

            // Normalmap0, default = "bump" {}
            public Texture2D bumpMap
            {
                get { return GetTexture (Properties.Instance.bumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.bumpMapID, value); }
            }

            public Vector2 bumpMapScale
            {
                get { return GetTextureScale (Properties.bumpMapKey); }
                set { SetTextureScale (Properties.bumpMapKey, value); }
            }

            public Vector2 bumpMapOffset
            {
                get { return GetTextureOffset (Properties.bumpMapKey); }
                set { SetTextureOffset (Properties.bumpMapKey, value); }
            }

            // Water Movement, default = 1
            public float displacement
            {
                get { return GetFloat (Properties.Instance.displacementID); }
                set { SetFloat (Properties.Instance.displacementID, value); }
            }

            // Water Freq, default = 1
            public float dispFreq
            {
                get { return GetFloat (Properties.Instance.dispFreqID); }
                set { SetFloat (Properties.Instance.dispFreqID, value); }
            }

            // Mix, default = 1
            public float mix
            {
                get { return GetFloat (Properties.Instance.mixID); }
                set { SetFloat (Properties.Instance.mixID, value); }
            }

            // Opacity, default = 1
            public float oceanOpacity
            {
                get { return GetFloat (Properties.Instance.oceanOpacityID); }
                set { SetFloat (Properties.Instance.oceanOpacityID, value); }
            }

            // Falloff Power, default = 1
            public float falloffPower
            {
                get { return GetFloat (Properties.Instance.falloffPowerID); }
                set { SetFloat (Properties.Instance.falloffPowerID, value); }
            }

            // Falloff Exp, default = 2
            public float falloffExp
            {
                get { return GetFloat (Properties.Instance.falloffExpID); }
                set { SetFloat (Properties.Instance.falloffExpID, value); }
            }

            // AP Fog Color, default = (0,0,1,1)
            public Color fogColor
            {
                get { return GetColor (Properties.Instance.fogColorID); }
                set { SetColor (Properties.Instance.fogColorID, value); }
            }

            // AP Height Fall Off, default = 1
            public float heightFallOff
            {
                get { return GetFloat (Properties.Instance.heightFallOffID); }
                set { SetFloat (Properties.Instance.heightFallOffID, value); }
            }

            // AP Global Density, default = 1
            public float globalDensity
            {
                get { return GetFloat (Properties.Instance.globalDensityID); }
                set { SetFloat (Properties.Instance.globalDensityID, value); }
            }

            // AP Atmosphere Depth, default = 1
            public float atmosphereDepth
            {
                get { return GetFloat (Properties.Instance.atmosphereDepthID); }
                set { SetFloat (Properties.Instance.atmosphereDepthID, value); }
            }

            // FogColorRamp, default = "white" {}
            public Texture2D fogColorRamp
            {
                get { return GetTexture (Properties.Instance.fogColorRampID) as Texture2D; }
                set { SetTexture (Properties.Instance.fogColorRampID, value); }
            }

            public Vector2 fogColorRampScale
            {
                get { return GetTextureScale (Properties.fogColorRampKey); }
                set { SetTextureScale (Properties.fogColorRampKey, value); }
            }

            public Vector2 fogColorRampOffset
            {
                get { return GetTextureOffset (Properties.fogColorRampKey); }
                set { SetTextureOffset (Properties.fogColorRampKey, value); }
            }

            // FadeStart, default = 1
            public float fadeStart
            {
                get { return GetFloat (Properties.Instance.fadeStartID); }
                set { SetFloat (Properties.Instance.fadeStartID, value); }
            }

            // FadeEnd, default = 1
            public float fadeEnd
            {
                get { return GetFloat (Properties.Instance.fadeEndID); }
                set { SetFloat (Properties.Instance.fadeEndID, value); }
            }

            // PlanetOpacity, default = 1
            public float planetOpacity
            {
                get { return GetFloat (Properties.Instance.planetOpacityID); }
                set { SetFloat (Properties.Instance.planetOpacityID, value); }
            }

            public PQSOceanSurfaceQuad() : base(Properties.shader)
            {
            }

            public PQSOceanSurfaceQuad(string contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public PQSOceanSurfaceQuad(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Terrain/PQS/Ocean Surface Quad shader required");
            }

        }
    }
}
