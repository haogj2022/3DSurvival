Shader "Seashine/Point Lit/Vertex Color/Distance Switch/ASE VC(XO,YO,ZO,CL)" {
	Properties {
		_ColorA ("Color A", Vector) = (0.3955144,0.6785416,0.8301887,1)
		_ColorB ("Color B", Vector) = (0.5951064,0.3782485,0.6415094,1)
		_Roughness ("Roughness", Range(0.01, 10)) = 1
		_SpecularColor ("Specular Color", Vector) = (1,1,1,1)
		_StartDistance ("StartDistance", Float) = 0
		_EndDistance ("EndDistance", Float) = 1
		_PoseFactor ("PoseFactor", Range(-1, 1)) = 0.1
		_Luminence ("Luminence", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_MatrixMVP;

			struct Vertex_Stage_Input
			{
				float3 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixMVP, float4(input.pos, 1.0));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	//CustomEditor "ASEMaterialInspector"
}