﻿Shader "Diffuse Bump Blending"
{
  Properties
  {
  	  _Color ("Main Color", Color) = (1,1,1,1)
      _Blend ("Blend", Range(0, 1)) = 0.5 
      _MainTex ("EndTex", 2D) = ""
      _Texture2 ("StartTex", 2D) = ""
      _BumpMap ("Bumpmap", 2D) = "bump" {}
  }
 
  SubShader
  {
    Tags { "RenderType" = "Opaque" }
    CGPROGRAM
    #pragma surface surf Lambert
    struct Input
    {
      float2 uv_MainTex;
      float2 uv_BumpMap;
    };
 
    sampler2D _MainTex;
    sampler2D _Texture2;
    sampler2D _BumpMap;
    float _Blend;
    float4 _Color;
 
    void surf (Input IN, inout SurfaceOutput o)
    {
      float3 t1 = tex2D (_MainTex, IN.uv_MainTex).rgb;
      float3 t2 = tex2D (_Texture2, IN.uv_MainTex).rgb;
      o.Albedo = lerp(t1, t2, _Blend) * _Color;
      o.Normal = UnpackNormal (tex2D (_BumpMap, IN.uv_BumpMap));
    }
    ENDCG
  } 
  Fallback "Diffuse"
}