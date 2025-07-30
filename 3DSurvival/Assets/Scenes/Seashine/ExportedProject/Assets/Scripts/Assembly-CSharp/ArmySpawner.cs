using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ArmySpawner : MonoBehaviour
{
	[Serializable]
	public struct Unit
	{
		public GameObject prefab;

		public int count;

		public float delay;

		public bool loop;
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArmySpawner _003C_003E4__this;

		private Vector3 _003Ccenter_003E5__2;

		private int _003Ci_003E5__3;

		private int _003Cj_003E5__4;

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
		public _003CStart_003Ed__5(int _003C_003E1__state)
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

	private static Dictionary<int, Stack<GameObject>> _pool;

	public Vector2 spawnSize;

	public Vector3 sizeMult;

	public Unit[] units;

	[IteratorStateMachine(typeof(_003CStart_003Ed__5))]
	private IEnumerator Start()
	{
		return null;
	}

	private GameObject LoadFromPool(Unit unit)
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}
}
