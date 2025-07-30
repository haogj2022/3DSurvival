using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BoulderSpawner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFollowPlayer_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoulderSpawner _003C_003E4__this;

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
		public _003CFollowPlayer_003Ed__25(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CSpawnBoulders_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoulderSpawner _003C_003E4__this;

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
		public _003CSpawnBoulders_003Ed__27(int _003C_003E1__state)
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

	private GameManager gameManager;

	private Transform player;

	private float minInterval;

	private float maxInterval;

	public Transform[] spawnPoints;

	private int totalSps;

	private bool multiSPs;

	[SerializeField]
	private int maxBoulders;

	private int boulderCount;

	private LayerMask boulderLayer;

	private LayerMask overlapCheckMask;

	public Transform maxHeightHelper;

	public Transform minHeightHelper;

	private float distanceToPlayer;

	private float followInterval;

	private float boulderDetectionRange;

	public bool spawnCrystalBoulders;

	public float crystalRarity;

	private bool playerInArea;

	private bool spawn;

	private Transform lastBoulder;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CFollowPlayer_003Ed__25))]
	private IEnumerator FollowPlayer()
	{
		return null;
	}

	private void MatchHeight()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnBoulders_003Ed__27))]
	private IEnumerator SpawnBoulders()
	{
		return null;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
