using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PathologicalGames;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpawn_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Spawner _003C_003E4__this;

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
		public _003CSpawn_003Ed__13(int _003C_003E1__state)
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

	public string poolName;

	public string prefabName;

	public bool checkDifficulty;

	public int minDifficulty;

	public int maxDifficulty;

	public float rarity;

	private SpawnPool spawnPool;

	public bool randomSpawnRotationZ;

	private Quaternion spawnRotation;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawn_003Ed__13))]
	private IEnumerator Spawn()
	{
		return null;
	}
}
