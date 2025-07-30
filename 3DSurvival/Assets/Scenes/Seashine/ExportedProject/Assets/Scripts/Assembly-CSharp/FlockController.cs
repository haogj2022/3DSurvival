using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FlockController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRandomizePosition_003Ed__27 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public FlockController _003C_003E4__this;

		float IEnumerator<float>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0f;
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
		public _003CRandomizePosition_003Ed__27(int _003C_003E1__state)
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

	[HideInInspector]
	public Transform thisTransform;

	public bool permanentFlock;

	private GameManager GManager;

	private Transform mainCamera;

	public FlockAgent flockCreature;

	private string flockCreatureName;

	public int numberOfAgents;

	public float minSpeed;

	public float maxSpeed;

	public float zPositionMax;

	public float zPositionMin;

	public float minDamping;

	public float maxDamping;

	private Vector3 refPosition;

	public float waypointDistance;

	public float randomPositionTimer;

	public float positionRadius;

	public float waypointRadius;

	public bool childTriggerPos;

	public bool forceChildWaypoints;

	public float forcedRandomDelay;

	private Vector3 newRandomPosition;

	[HideInInspector]
	public FlockAgent[] roamers;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void SpawnAgents()
	{
	}

	[IteratorStateMachine(typeof(_003CRandomizePosition_003Ed__27))]
	private IEnumerator<float> RandomizePosition()
	{
		return null;
	}

	public void SetRandomPosition()
	{
	}
}
