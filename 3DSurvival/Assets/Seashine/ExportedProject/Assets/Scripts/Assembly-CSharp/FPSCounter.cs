using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFPS_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSCounter _003C_003E4__this;

		private int _003ClastFrameCount_003E5__2;

		private float _003ClastTime_003E5__3;

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
		public _003CFPS_003Ed__7(int _003C_003E1__state)
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

	public float frequency;

	public UILabel displayLbl;

	public float FramesPerSec { get; protected set; }

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CFPS_003Ed__7))]
	private IEnumerator FPS()
	{
		return null;
	}
}
