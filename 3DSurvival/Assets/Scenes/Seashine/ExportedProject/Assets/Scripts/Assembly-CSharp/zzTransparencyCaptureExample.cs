using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class zzTransparencyCaptureExample : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003Ccapture_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public zzTransparencyCaptureExample _003C_003E4__this;

		private Rect _003ClRect_003E5__2;

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
		public _003Ccapture_003Ed__3(int _003C_003E1__state)
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

	public Texture2D capturedImage;

	public Transform cameraTransform;

	private Vector3 lastMousePosition;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003Ccapture_003Ed__3))]
	public IEnumerator capture()
	{
		return null;
	}

	public void Update()
	{
	}

	private void OnGUI()
	{
	}
}
