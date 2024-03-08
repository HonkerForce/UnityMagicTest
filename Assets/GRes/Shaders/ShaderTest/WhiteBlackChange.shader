Shader "TA_DDY/WhiteBlackChange"
{
    Properties
    {
        _Value("Value", Range(0, 1)) = 0.4
    }
    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            float _Value;

            float4 vert (float4 pos : POSITION) : SV_POSITION
            {
                return UnityObjectToClipPos(pos);
            }

            fixed4 frag (float4 pos : SV_POSITION) : SV_Target
            {
                return pow(sin(_Time.y * 5) * 0.5 + 0.5, _Value);
            }
            ENDCG
        }
    }
}
