using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpecialBotanicaSpawner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelaySpawn_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpecialBotanicaSpawner _003C_003E4__this;

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
		public _003CDelaySpawn_003Ed__10(int _003C_003E1__state)
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

	private Transform thisTransform;

	[SerializeField]
	private Transform[] spawnables;

	[Range(0f, 1f)]
	public float probability;

	[Range(0f, 5f)]
	public float spawnDelay;

	private Transform spawnedBotanica;

	private bool applicationQuitting;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySpawn_003Ed__10))]
	private IEnumerator DelaySpawn()
	{
		return null;
	}
}
