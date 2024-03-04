Shader "TA_DDY/SimpleShaderTest"
{
    Properties
    {
        [Header(Custom_Config)]
        showColor("ShowColor", Color) = (0,0,0,1)
    }
    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            half4 showColor;

            float4 vert(float4 vertex : POSITION) : SV_POSITION
            {
                return UnityObjectToClipPos(vertex);
            }

            float4 frag() : SV_Target
            {
                return showColor;
            }
            
            ENDCG
        }
    }
    
    Fallback ""
    CustomEditor ""
}
