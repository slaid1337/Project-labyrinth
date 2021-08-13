Shader "Custom/water"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.0
        _Range("range" , Range(0.0 , 2.0)) = 0.25
        _Speed("speed", Range(0.0 , 10.0)) = 1.0
        _MaskMap("bump" , 2D) = "bump" {}
    }
    SubShader
    {
        Tags {"LIGHTMODE" = "FORWARDBASE" "QUEUE" = "AlphaTest" "IGNOREPROJECTOR" = "true" "SHADOWSUPPORT" = "true" "RenderType" = "TransparentCutout"}
        LOD 100


        Blend SrcAlpha OneMinusSrcAlpha

        CGPROGRAM
        
        #pragma surface surf Standard  alpha:auto

        
        #pragma target 3.0

        sampler2D _MainTex;
        sampler2D _MaskMap;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_MaskMap;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;
        float _Range;
        float _Speed;

        UNITY_INSTANCING_BUFFER_START(Props)

            UNITY_INSTANCING_BUFFER_END(Props)

        



        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            IN.uv_MainTex.x -= _Speed * _Time;
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color ;
            
            o.Albedo = c.rgb;
            c.a = 1;         
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            
            if (_Range >= 0.0f , _Range <= 1.0f)
            {
                o.Alpha = step(IN.uv_MaskMap.x, _Range);
            }
            else if (_Range > 1.0f)
            {
                o.Alpha =  step( _Range - 1.0f,IN.uv_MaskMap.x);
            }
            
        }
        ENDCG
    }
    FallBack "Diffuse"
}
