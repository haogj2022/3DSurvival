using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InkReleaser : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpawnAreaTriggers_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InkReleaser _003C_003E4__this;

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
		public _003CSpawnAreaTriggers_003Ed__18(int _003C_003E1__state)
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

	private Fish fishScript;

	public ParticleSystem[] emitters;

	private Transform thisTransform;

	public Transform areaTrigger;

	private Transform lastAreaTriggerSpawned;

	private int totalEmitters;

	public float minimumInterval;

	public float emissionDuration;

	private float inkReleaseTimer;

	private float inkTimer;

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

	private void Update()
	{
	}

	private void OnEscape()
	{
	}

	private void ReleaseInk()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnAreaTriggers_003Ed__18))]
	private IEnumerator SpawnAreaTriggers()
	{
		return null;
	}

	private void SpawnAreaTrigger()
	{
	}
}
