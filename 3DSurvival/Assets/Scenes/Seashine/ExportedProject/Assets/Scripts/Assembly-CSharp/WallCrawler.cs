using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class WallCrawler : MonoBehaviour
{
	private enum AIState
	{
		idle = 0,
		wandering = 1,
		chasing = 2,
		attacking = 3,
		evading = 4,
		stuck = 5,
		leaving = 6,
		eaten = 7,
		dead = 8
	}

	[CompilerGenerated]
	private sealed class _003CScanForPredators_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

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
		public _003CScanForPredators_003Ed__69(int _003C_003E1__state)
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
	private sealed class _003CScanForPreys_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

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
		public _003CScanForPreys_003Ed__70(int _003C_003E1__state)
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
	private sealed class _003CAvoid_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

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
		public _003CAvoid_003Ed__71(int _003C_003E1__state)
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
	private sealed class _003CIdle_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

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
		public _003CIdle_003Ed__74(int _003C_003E1__state)
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
	private sealed class _003CWander_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

		private int _003CstuckCounter_003E5__2;

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
		public _003CWander_003Ed__75(int _003C_003E1__state)
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
	private sealed class _003CChase_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

		private int _003CstuckCounter_003E5__2;

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
		public _003CChase_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CAttack_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

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
		public _003CAttack_003Ed__77(int _003C_003E1__state)
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
	private sealed class _003CEvade_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

		private int _003CstuckCounter_003E5__2;

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
		public _003CEvade_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003CGiveUp_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

		private int _003CgiveUpCounter_003E5__2;

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
		public _003CGiveUp_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CLeave_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WallCrawler _003C_003E4__this;

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
		public _003CLeave_003Ed__80(int _003C_003E1__state)
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

	[Space(10f)]
	public bool debugMode;

	private Transform thisTransform;

	private Rigidbody2D thisRigidbody2D;

	private Transform player;

	[Tooltip("Hunts or not?")]
	[Header("AI")]
	public bool passive;

	public float bodyHalf;

	[Space(10f)]
	[Range(0f, 1f)]
	public float directionSmoothTime;

	private float additionalSmoothFactor;

	private float wanderDirectionTimeOut;

	private Vector2 targetDirection;

	private Vector2 avoidanceOffset;

	public float rotationSpeed;

	private float walkSpeed;

	[Range(0f, 20f)]
	public float wanderSpeed;

	[Range(0f, 30f)]
	public float wanderAnimationSpeed;

	[Range(0f, 30f)]
	public float chaseSpeed;

	[Range(0f, 50f)]
	public float chaseAnimationSpeed;

	[Space(10f)]
	public GameObject mouthCollider;

	public float visionRange;

	private float visionRangeSqr;

	public float attackDistance;

	[Range(0.5f, 5f)]
	public float minTimeBetweenAttacks;

	[Range(1f, 10f)]
	public float maxTimeBetweenAttacks;

	private float lastAttackTime;

	[Header("FOOD CHAIN")]
	public LayerMask predators;

	[Tooltip("If passive is off")]
	public LayerMask preys;

	[Tooltip("Hunts or not?")]
	[Header("COLLISION")]
	public bool contactHurts;

	public ObscuredFloat contactDamage;

	private float lastDamageTime;

	public bool knockBack;

	public float knockBackForce;

	private AIState aiState;

	private bool move;

	private Vector3 curPlayerPos;

	private float curDistSqr;

	private float targetToFOV;

	private bool stuck;

	private Vector3 stuckDirection;

	private Transform detectedPredator;

	private Transform predatorMouth;

	private Vector3 predatorMouthOffset;

	private Vector2 curRigidbodyVelocity;

	private Vector2 smoothDirection;

	private float trueVelocity;

	private Vector2 directionVelocity;

	private bool provoked;

	[Header("PATHFINDING")]
	public LayerMask obstacleLayers;

	[Tooltip("Distance de vérification du CircleCast pour choisir une direction aléatoire pour Wander")]
	public float wanderCastDistance;

	private bool TargetVisible;

	public float turnspeed;

	public bool EnableFollowNodePathFinding;

	public float DistanceNodeChange;

	public List<Vector3> Follownodes;

	[Header("ANIMATION")]
	public Animator animator;

	public Animation thisAnimation;

	private bool usingAnimator;

	[Range(0f, 60f)]
	public float maxEulerX;

	[Range(0f, 60f)]
	public float maxEulerY;

	private bool secondAttack;

	private const float Threshold = 0.001f;

	public Transform jawBone;

	public ParticleSystem swimFlowEffect;

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

	private void ResetStates()
	{
	}

	[IteratorStateMachine(typeof(_003CScanForPredators_003Ed__69))]
	private IEnumerator ScanForPredators()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScanForPreys_003Ed__70))]
	private IEnumerator ScanForPreys()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAvoid_003Ed__71))]
	private IEnumerator Avoid()
	{
		return null;
	}

	private void PlayerSitRep()
	{
	}

	private void FindPath()
	{
	}

	[IteratorStateMachine(typeof(_003CIdle_003Ed__74))]
	private IEnumerator Idle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWander_003Ed__75))]
	private IEnumerator Wander()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChase_003Ed__76))]
	private IEnumerator Chase()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAttack_003Ed__77))]
	private IEnumerator Attack()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEvade_003Ed__78))]
	private IEnumerator Evade()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGiveUp_003Ed__79))]
	private IEnumerator GiveUp()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLeave_003Ed__80))]
	private IEnumerator Leave()
	{
		return null;
	}

	private bool PickWanderDirection()
	{
		return false;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void RespondToPlayerInteraction()
	{
	}

	private void GetEaten(Transform predator)
	{
	}
}
