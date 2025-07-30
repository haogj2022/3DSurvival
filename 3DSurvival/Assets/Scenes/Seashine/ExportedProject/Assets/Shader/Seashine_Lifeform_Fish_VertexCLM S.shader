Shader "Seashine/Lifeform/Fish/VertexCLM S" {
	Properties {
		_SpecularColor ("Specular Color", Vector) = (1,1,1,1)
		_Roughness ("Roughness", Range(0.1, 10)) = 0.1
		_RotationAmplitude ("Rotation Amplitude", Float) = 0.2
		_WobbleAmplitude ("Wobble Amplitude", Float) = 0.75
		_WobbleFrequency ("Wobble Frequency", Float) = 1
		_TranslationOffset ("Translation Offset", Range(0, 1)) = 0.25
		_TranslationAmplitude ("Translation Amplitude", Float) = 0.035
		[PerRendererData] _Acceleration ("Acceleration", Float) = 1
		[PerRendererData] _TrailY ("TrailY", Float) = 0
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
	Fallback "Diffuse"
}