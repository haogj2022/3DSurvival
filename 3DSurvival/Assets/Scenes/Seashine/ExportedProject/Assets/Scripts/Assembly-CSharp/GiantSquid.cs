using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GiantSquid : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMonsterPatrol_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GiantSquid _003C_003E4__this;

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
		public _003CMonsterPatrol_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CAttack_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GiantSquid _003C_003E4__this;

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
		public _003CAttack_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CDelayedDestroy_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GiantSquid _003C_003E4__this;

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
		public _003CDelayedDestroy_003Ed__28(int _003C_003E1__state)
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

	public bool cinematic;

	public Animation anim;

	private GameObject monster;

	public Transform monsterFront;

	public GameObject mouthCollider;

	public int difficultyTrigger;

	public float rarity;

	public bool restrictAngle;

	public float minAngle;

	public float maxAngle;

	private bool escape;

	private bool monsterActivated;

	private bool attacking;

	public float attackInterval;

	private Vector3 newAttackPosition;

	internal LayerMask wallsLayer;

	private bool TargetVisible;

	public ParticleSystem JawParticles;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private bool CheckOrientation()
	{
		return false;
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CMonsterPatrol_003Ed__24))]
	private IEnumerator MonsterPatrol()
	{
		return null;
	}

	private void CheckTarget()
	{
	}

	[IteratorStateMachine(typeof(_003CAttack_003Ed__26))]
	private IEnumerator Attack()
	{
		return null;
	}

	private void Scare()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedDestroy_003Ed__28))]
	private IEnumerator DelayedDestroy()
	{
		return null;
	}
}
