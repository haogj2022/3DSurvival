using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ResetTransforms : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAutoDisable_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResetTransforms _003C_003E4__this;

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
		public _003CAutoDisable_003Ed__13(int _003C_003E1__state)
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

	public Transform[] transforms;

	public bool resetPositions;

	public bool resetRotations;

	private int totalTransforms;

	private Vector3[] startPositions;

	private Quaternion[] startRotations;

	public float autoDisableTimer;

	public string spawnPool;

	private bool applicationQuitting;

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoDisable_003Ed__13))]
	private IEnumerator AutoDisable()
	{
		return null;
	}
}
