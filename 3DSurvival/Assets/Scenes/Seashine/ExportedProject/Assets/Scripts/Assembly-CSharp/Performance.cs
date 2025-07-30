using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Performance : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckPerformance_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Performance _003C_003E4__this;

		private int _003CnbrOfVerifs_003E5__2;

		private int _003Ci_003E5__3;

		private int _003ClastFrameCount_003E5__4;

		private float _003ClastTime_003E5__5;

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
		public _003CCheckPerformance_003Ed__3(int _003C_003E1__state)
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

	private int[] fpsResults;

	private int averageFPS;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckPerformance_003Ed__3))]
	private IEnumerator CheckPerformance()
	{
		return null;
	}
}
