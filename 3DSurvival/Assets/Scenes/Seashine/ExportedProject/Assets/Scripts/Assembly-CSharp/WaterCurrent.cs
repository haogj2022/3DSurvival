using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WaterCurrent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CVerifyObstruction_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaterCurrent _003C_003E4__this;

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
		public _003CVerifyObstruction_003Ed__18(int _003C_003E1__state)
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

	public bool checkObstruction;

	public LayerMask boulderLayer;

	public ParticleSystem streamParticles;

	private ParticleSystem.EmissionModule streamParticlesEmission;

	public List<Rigidbody2D> creaturesInStream;

	private bool streamBlocked;

	private float normalStreamRate;

	private bool emitting;

	public GameObject exitBlocker;

	private bool triggered;

	private Vector3 streamDirection;

	public float streamForce;

	private float curStreamForce;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CVerifyObstruction_003Ed__18))]
	private IEnumerator VerifyObstruction()
	{
		return null;
	}
}
