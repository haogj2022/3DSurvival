using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Monster : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CObserve_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Monster _003C_003E4__this;

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
		public _003CObserve_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CAttack_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Monster _003C_003E4__this;

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
		public _003CAttack_003Ed__36(int _003C_003E1__state)
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

	private Transform player;

	private Transform thisTransform;

	public Animation anim;

	private GameObject monster;

	public Transform monsterFront;

	public GameObject mouthCollider;

	private Transform mouthColliderTsfm;

	public Transform mouthCenter;

	public int difficultyTrigger;

	public float rarity;

	private float damping;

	public Transform upperJaw;

	public Transform lowerJaw;

	private GameObject upperJawGO;

	private GameObject lowerJawGO;

	public Transform upperJawRef;

	public Transform lowerJawRef;

	private Vector3 vectorAlmostZero;

	private int difficulty;

	private bool zoneActive;

	private bool triggered;

	private bool playerInside;

	private bool attacking;

	private bool following;

	private float nextAttackInterval;

	private Vector3 newAttackPosition;

	private bool jawsActive;

	public Vector2 velocity;

	public ParticleSystem JawParticles;

	private Transform jawParticlesTsfm;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CObserve_003Ed__35))]
	private IEnumerator Observe()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAttack_003Ed__36))]
	private IEnumerator Attack()
	{
		return null;
	}

	private void Shake()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
