using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Shadow : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateShadow_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Shadow _003C_003E4__this;

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
		public _003CUpdateShadow_003Ed__10(int _003C_003E1__state)
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

	private GameManager GManager;

	private Transform target;

	private float xOffset;

	public float updateFreq;

	private Vector3 zeroYPos;

	public Transform scaleRef;

	private bool rescale;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void SetShadow()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateShadow_003Ed__10))]
	private IEnumerator UpdateShadow()
	{
		return null;
	}
}
