using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScreenshotController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTakeDeathScreenshot_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScreenshotController _003C_003E4__this;

		private float _003CscreenshotProcessTime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CTakeDeathScreenshot_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CApplyDeathScreenshot_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScreenshotController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CApplyDeathScreenshot_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CApplyWatermark_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScreenshotController _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CApplyWatermark_003Ed__29(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private bool debug;

	[SerializeField]
	private GameManager gameManager;

	[Header("SCREENSHOT")]
	public GameObject ScreenshotWidget;

	public UITexture ScreenshotWidgetTexture;

	public UITexture ScreenshotContainer;

	public UITexture WatermarkContainer;

	public UILabel WatermarkScore;

	public Camera ScreenshotCamera;

	private Transform screenshotCameraTsfm;

	public Camera WatermarkCamera;

	[HideInInspector]
	public string scoreTextToShare;

	[HideInInspector]
	public string shareScoreText;

	[HideInInspector]
	public string shareHighscoreText;

	private Texture2D DeathScreenshotTex;

	[HideInInspector]
	public Texture2D WatermarkedTex;

	[HideInInspector]
	public float deathScreenyCooldown;

	private Rect screenshotZone;

	private int screenWidth;

	private int screenshotSize;

	private RenderTexture screenshotRenderTexture;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGameOver()
	{
	}

	private void OnGameReset()
	{
	}

	private void InitScreenshots()
	{
	}

	[IteratorStateMachine(typeof(_003CTakeDeathScreenshot_003Ed__27))]
	public IEnumerator TakeDeathScreenshot()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CApplyDeathScreenshot_003Ed__28))]
	private IEnumerator ApplyDeathScreenshot()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CApplyWatermark_003Ed__29))]
	private IEnumerator ApplyWatermark()
	{
		return null;
	}
}
