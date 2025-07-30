using System.Collections.Generic;
using UnityEngine;

namespace FSG.MeshAnimator.ShaderAnimated
{
	[AddComponentMenu("Mesh Animator/GPU Shader Animated")]
	[RequireComponent(typeof(MeshFilter))]
	[ExecuteInEditMode]
	public class ShaderMeshAnimator : MeshAnimatorBase
	{
		private static readonly int _animTimeProp;

		private static readonly int _animInfoProp;

		private static readonly int _animScalarProp;

		private static readonly int _animTexturesProp;

		private static readonly int _animTextureIndexProp;

		private static readonly int _crossfadeAnimInfoProp;

		private static readonly int _crossfadeAnimScalarProp;

		private static readonly int _crossfadeAnimTextureIndexProp;

		private static readonly int _crossfadeStartTimeProp;

		private static readonly int _crossfadeEndTimeProp;

		private static Dictionary<Mesh, int> _meshCount;

		private static List<Material> _materialCacheLookup;

		private static HashSet<Material> _setMaterials;

		private static Dictionary<Mesh, Texture2DArray> _animTextures;

		private int pixelsPerTexture;

		private int textureStartIndex;

		private int textureSizeX;

		private int textureSizeY;

		private MaterialPropertyBlock materialPropertyBlock;

		private Vector4 propertyBlockData;

		private Vector4 timeBlockData;

		public ShaderMeshAnimation defaultMeshAnimation;

		public ShaderMeshAnimation[] meshAnimations;

		private static Vector4 _shaderTime => default(Vector4);

		public override IMeshAnimation defaultAnimation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override IMeshAnimation[] animations => null;

		protected override void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}

		protected override bool DisplayFrame(int previousFrame)
		{
			return false;
		}

		protected override void OnAnimationCompleted(bool stopUpdate)
		{
		}

		protected override void OnCurrentAnimationChanged(IMeshAnimation meshAnimation)
		{
		}

		public override void Play(string animationName, float normalizedTime = -1f)
		{
		}

		public override void Play(int index)
		{
		}

		public override void Play()
		{
		}

		public override void Pause()
		{
		}

		public override void RestartAnim()
		{
		}

		public override void Crossfade(int index, float speed)
		{
		}

		public override void PrepopulateCrossfadePool(int count)
		{
		}

		public override void SetTime(float time, bool instantUpdate = false)
		{
		}

		public override void SetTimeNormalized(float time, bool instantUpdate = false)
		{
		}

		public override void SetAnimations(IMeshAnimation[] meshAnimations)
		{
		}

		public override void StoreAdditionalMeshData(Mesh mesh)
		{
		}

		private void RefreshTimeData()
		{
		}

		private void SetupTextureData()
		{
		}

		private void CreatePropertyBlock()
		{
		}

		private int CacheKey()
		{
			return 0;
		}
	}
}
