// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class PQSProjectionFallback : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                public const string shaderName = "Terrain/PQS/Sphere Projection SURFACE QUAD (Fallback) ";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Saturation, default = 1
                public const string saturationKey = "_saturation";
                public int saturationID { get; private set; }

                // Contrast, default = 1
                public const string contrastKey = "_contrast";
                public int contrastID { get; private set; }

                // Colour Unsaturation (A = Factor), default = (1,1,1,0)
                public const string tintColorKey = "_tintColor";
                public int tintColorID { get; private set; }

                // Near Tiling, default = 1000
                public const string texTilingKey = "_texTiling";
                public int texTilingID { get; private set; }

                // Near Blend, default = 0.5
                public const string texPowerKey = "_texPower";
                public int texPowerID { get; private set; }

                // Far Blend, default = 0.5
                public const string multiPowerKey = "_multiPower";
                public int multiPowerID { get; private set; }

                // NearFar Start, default = 2000
                public const string groundTexStartKey = "_groundTexStart";
                public int groundTexStartID { get; private set; }

                // NearFar Start, default = 10000
                public const string groundTexEndKey = "_groundTexEnd";
                public int groundTexEndID { get; private set; }

                // Multifactor, default = 0.5
                public const string multiFactorKey = "_multiFactor";
                public int multiFactorID { get; private set; }

                // Main Texture, default = "white" {}
                public const string mainTexKey = "_mainTex";
                public int mainTexID { get; private set; }

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
                    saturationID = Shader.PropertyToID(saturationKey);
                    contrastID = Shader.PropertyToID(contrastKey);
                    tintColorID = Shader.PropertyToID(tintColorKey);
                    texTilingID = Shader.PropertyToID(texTilingKey);
                    texPowerID = Shader.PropertyToID(texPowerKey);
                    multiPowerID = Shader.PropertyToID(multiPowerKey);
                    groundTexStartID = Shader.PropertyToID(groundTexStartKey);
                    groundTexEndID = Shader.PropertyToID(groundTexEndKey);
                    multiFactorID = Shader.PropertyToID(multiFactorKey);
                    mainTexID = Shader.PropertyToID(mainTexKey);
                    planetOpacityID = Shader.PropertyToID(planetOpacityKey);
                }
			}

			// Is some random material this material
			public static bool UsesSameShader(Material m)
			{
				return m.shader.name == Properties.shaderName;
			}

            // Saturation, default = 1
            public float saturation
            {
                get { return GetFloat (Properties.Instance.saturationID); }
                set { SetFloat (Properties.Instance.saturationID, value); }
            }

            // Contrast, default = 1
            public float contrast
            {
                get { return GetFloat (Properties.Instance.contrastID); }
                set { SetFloat (Properties.Instance.contrastID, value); }
            }

            // Colour Unsaturation (A = Factor), default = (1,1,1,0)
            public Color tintColor
            {
                get { return GetColor (Properties.Instance.tintColorID); }
                set { SetColor (Properties.Instance.tintColorID, value); }
            }

            // Near Tiling, default = 1000
            public float texTiling
            {
                get { return GetFloat (Properties.Instance.texTilingID); }
                set { SetFloat (Properties.Instance.texTilingID, value); }
            }

            // Near Blend, default = 0.5
            public float texPower
            {
                get { return GetFloat (Properties.Instance.texPowerID); }
                set { SetFloat (Properties.Instance.texPowerID, value); }
            }

            // Far Blend, default = 0.5
            public float multiPower
            {
                get { return GetFloat (Properties.Instance.multiPowerID); }
                set { SetFloat (Properties.Instance.multiPowerID, value); }
            }

            // NearFar Start, default = 2000
            public float groundTexStart
            {
                get { return GetFloat (Properties.Instance.groundTexStartID); }
                set { SetFloat (Properties.Instance.groundTexStartID, value); }
            }

            // NearFar Start, default = 10000
            public float groundTexEnd
            {
                get { return GetFloat (Properties.Instance.groundTexEndID); }
                set { SetFloat (Properties.Instance.groundTexEndID, value); }
            }

            // Multifactor, default = 0.5
            public float multiFactor
            {
                get { return GetFloat (Properties.Instance.multiFactorID); }
                set { SetFloat (Properties.Instance.multiFactorID, value); }
            }

            // Main Texture, default = "white" {}
            public Texture2D mainTex
            {
                get { return GetTexture (Properties.Instance.mainTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.mainTexID, value); }
            }

            public Vector2 mainTexScale
            {
                get { return GetTextureScale (Properties.mainTexKey); }
                set { SetTextureScale (Properties.mainTexKey, value); }
            }

            public Vector2 mainTexOffset
            {
                get { return GetTextureOffset (Properties.mainTexKey); }
                set { SetTextureOffset (Properties.mainTexKey, value); }
            }

            // PlanetOpacity, default = 1
            public float planetOpacity
            {
                get { return GetFloat (Properties.Instance.planetOpacityID); }
                set { SetFloat (Properties.Instance.planetOpacityID, value); }
            }

            public PQSProjectionFallback() : base(Properties.shader)
            {
            }

            public PQSProjectionFallback(string contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public PQSProjectionFallback(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Terrain/PQS/Sphere Projection SURFACE QUAD (Fallback)  shader required");
            }

        }
    }
}
