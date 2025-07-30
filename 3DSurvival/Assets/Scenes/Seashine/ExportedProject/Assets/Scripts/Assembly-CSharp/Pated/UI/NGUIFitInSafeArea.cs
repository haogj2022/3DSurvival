using UnityEngine;

namespace Pated.UI
{
	public class NGUIFitInSafeArea : MonoBehaviour
	{
		[SerializeField]
		private NGUISafeArea safeArea;

		[SerializeField]
		[Space(10f)]
		private bool fitX;

		[SerializeField]
		private float xMargins;

		[SerializeField]
		private bool fitY;

		[SerializeField]
		private float yMargins;

		private Vector2 widgetInitialBounds;

		private bool boundsInitialized;

		private void Awake()
		{
		}

		private void InitializeBounds()
		{
		}

		private void OnSafeAreaChanged(Rect newSafeArea, Vector4 lastSafeAreaMargins, Vector4 newSafeAreaMargins)
		{
		}
	}
}
