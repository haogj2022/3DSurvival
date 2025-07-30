using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TestShadersMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTakeScreenshot_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TestShadersMenu _003C_003E4__this;

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
		public _003CTakeScreenshot_003Ed__9(int _003C_003E1__state)
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

	[Header("SCREENSHOT")]
	private Camera ScreenshotCamera;

	private Texture2D screenshotTex;

	private Rect screenshotZone;

	private int screenWidth;

	private float screenshotCooldown;

	private string systemInfo;

	private void Awake()
	{
	}

	public void ExitShaderTesting()
	{
	}

	public void CaptureScreenshot()
	{
	}

	[IteratorStateMachine(typeof(_003CTakeScreenshot_003Ed__9))]
	private IEnumerator TakeScreenshot()
	{
		return null;
	}
}
