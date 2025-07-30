using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FloatingOrigin : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFloatOriginCheck_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FloatingOrigin _003C_003E4__this;

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
		public _003CFloatOriginCheck_003Ed__10(int _003C_003E1__state)
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

	public float startDelay;

	public float verificationInterval;

	public float threshold;

	public float physicsThreshold;

	public float defaultSleepVelocity;

	public float defaultAngularVelocity;

	private Transform player;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CFloatOriginCheck_003Ed__10))]
	private IEnumerator FloatOriginCheck()
	{
		return null;
	}
}
