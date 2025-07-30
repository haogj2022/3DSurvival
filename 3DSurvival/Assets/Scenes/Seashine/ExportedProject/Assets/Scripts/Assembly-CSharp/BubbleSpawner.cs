using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpawnBubbles_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BubbleSpawner _003C_003E4__this;

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
		public _003CSpawnBubbles_003Ed__13(int _003C_003E1__state)
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

	private GameManager gameManager;

	private Transform thisTransform;

	private Transform player;

	private float minInterval;

	private float maxInterval;

	public Transform[] spawnPoints;

	private int totalSps;

	private bool multiSPs;

	[SerializeField]
	private int maxBubbles;

	private int bubbleCount;

	private bool spawn;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnBubbles_003Ed__13))]
	private IEnumerator SpawnBubbles()
	{
		return null;
	}
}
