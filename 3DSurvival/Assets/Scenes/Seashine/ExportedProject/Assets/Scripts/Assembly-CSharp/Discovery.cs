using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Seashine.NPC;
using UnityEngine;

public class Discovery : MonoBehaviour
{
	public enum DiscoveryMethod
	{
		FixedBeacon = 10,
		MovingBeacon = 20,
		Self = 30
	}

	[CompilerGenerated]
	private sealed class _003CUpdateBeaconPosition_003Ed__19 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Discovery _003C_003E4__this;

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
		public _003CUpdateBeaconPosition_003Ed__19(int _003C_003E1__state)
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

	public GameDatabase gameDatabase;

	public LifeformConfig selectedLifeform;

	public DiscoveryMethod discoveryMethod;

	public float beaconRepositionInterval;

	public LegacyEncyclopediaCategory legacyDiscoveryCategory;

	private bool initiated;

	private Transform thisTransform;

	private GameManager gameManager;

	private ExplorationManager explorationManager;

	private bool discovered;

	private Transform spawnedBeacon;

	private Rigidbody2D thisRigidbody2D;

	private CircleCollider2D thisCircleCollider2D;

	private DiscoveryBeacon beaconScript;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateBeaconPosition_003Ed__19))]
	private IEnumerator<float> UpdateBeaconPosition()
	{
		return null;
	}

	private void RefreshDiscoveryStatus()
	{
	}

	private void SpawnDiscoveryBeacon()
	{
	}

	public void DisableDiscovery()
	{
	}
}
