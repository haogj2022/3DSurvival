using System;
using UnityEngine;

namespace Pated.UI
{
	public class NGUISafeArea : Singleton<NGUISafeArea>
	{
		[SerializeField]
		private UIRoot nguiUIRoot;

		private bool isInitialized;

		private UISprite safeZoneSprite;

		private static ScreenOrientation lastOrientation;

		private static Vector2 lastResolution;

		private static Vector2 lastSafeAreaPosition;

		private static Vector2 lastSafeAreaSize;

		public Action<Rect, Vector4, Vector4> onSafeAreaChanged;

		private Vector4 lastSafeAreaMargins;

		public static Action onScreenOrientationChange;

		public static Action onResolutionChange;

		public bool IsInitialized => false;

		public static bool isLandscape { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void Initialize()
		{
		}

		private void Update()
		{
		}

		private void ApplySafeArea()
		{
		}

		private void OrientationChanged()
		{
		}

		private void ResolutionChanged()
		{
		}

		private void SafeAreaChanged()
		{
		}

		private int GetNGUIWidth()
		{
			return 0;
		}

		private int GetNGUIHeight()
		{
			return 0;
		}
	}
}
