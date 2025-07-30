using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class Fish : MonoBehaviour
{
	public delegate void CreatureAction();

	private enum DefensiveBehavior
	{
		Escape = 0,
		Shield = 1
	}

	private enum AIState
	{
		idle = 0,
		wandering = 1,
		stunned = 2,
		chasing = 3,
		attacking = 4,
		eating = 5,
		evading = 6,
		shielding = 7,
		stuck = 8,
		leaving = 9,
		eaten = 10,
		dead = 11
	}

	[CompilerGenerated]
	private sealed class _003CIdle_003Ed__149 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CIdle_003Ed__149(int _003C_003E1__state)
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
	private sealed class _003CWander_003Ed__150 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CWander_003Ed__150(int _003C_003E1__state)
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
	private sealed class _003CGetStunned_003Ed__152 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CGetStunned_003Ed__152(int _003C_003E1__state)
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
	private sealed class _003CChase_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CChase_003Ed__153(int _003C_003E1__state)
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
	private sealed class _003CAttack_003Ed__154 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CAttack_003Ed__154(int _003C_003E1__state)
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
	private sealed class _003CEat_003Ed__155 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CEat_003Ed__155(int _003C_003E1__state)
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
	private sealed class _003CEscape_003Ed__156 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CEscape_003Ed__156(int _003C_003E1__state)
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
	private sealed class _003CShield_003Ed__157 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CShield_003Ed__157(int _003C_003E1__state)
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
	private sealed class _003CGiveUp_003Ed__158 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CGiveUp_003Ed__158(int _003C_003E1__state)
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
	private sealed class _003CLeave_003Ed__159 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CLeave_003Ed__159(int _003C_003E1__state)
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
	private sealed class _003CGetHungry_003Ed__166 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Fish _003C_003E4__this;

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
		public _003CGetHungry_003Ed__166(int _003C_003E1__state)
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

	private ScreenshotController screenshotController;

	[Space(10f)]
	public bool debugMode;

	[Space(10f)]
	public bool persistent;

	private Transform thisTransform;

	private Rigidbody2D thisRigidbody2D;

	[HideInInspector]
	public Transform player;

	[Space(10f)]
	public bool edible;

	[Header("MOVEMENT")]
	private float swimSpeed;

	[Range(0f, 20f)]
	public float wanderSpeed;

	[Range(0f, 30f)]
	public float chaseSpeed;

	[Range(0.001f, 1f)]
	public float stabilisationForce;

	[Range(0f, 1f)]
	public float directionSmoothTime;

	private bool move;

	private bool targetPreyIsPlayer;

	private Vector3 curPlayerPos;

	private bool stuck;

	private Vector3 stuckDirection;

	private Vector2 targetDirection;

	private float wanderDirectionTimeOut;

	private Vector2 curRigidbodyVelocity;

	private Vector2 smoothDirection;

	private Vector2 reversedSmoothDirection;

	private Vector3 smoothedEuler;

	private float trueVelocity;

	private Vector2 directionVelocity;

	private Vector2 reversedDirectionVelocity;

	private Vector3 eulerVelocity;

	private float currentDirectionDamping;

	private float chaseDirectionDamping;

	[Header("AI")]
	public bool passive;

	[Range(1f, 20f)]
	public float visionRange;

	private float visionRangeSqr;

	[Range(-1f, 1f)]
	public float funnelVision;

	public LayerMask predators;

	[SerializeField]
	private DefensiveBehavior defensiveBehavior;

	public LayerMask preys;

	public bool prioritizePlayer;

	[Range(0f, 1f)]
	public float hungerRate;

	private AIState aiState;

	private int playerLayer;

	private bool fat;

	private bool hungry;

	private float hunger;

	private bool hasPredators;

	[Header("ATTACK")]
	public DeathType playerDeathType;

	public Transform mouthPoint;

	public float mouthSize;

	public float attackDistance;

	[Range(0.5f, 5f)]
	public float minTimeBetweenAttacks;

	[Range(1f, 10f)]
	public float maxTimeBetweenAttacks;

	[SerializeField]
	private float playerDamage;

	public float playerKnockBackForce;

	public float eatTime;

	private float lastAttackTime;

	private Transform eatablePrey;

	[Header("ESCAPE")]
	public bool reversedEscape;

	[Header("COLLISION")]
	public bool contactHurts;

	[SerializeField]
	private float contactDamage;

	public bool knockBack;

	public float knockBackForce;

	private float lastDamageTime;

	private Transform predatorMouth;

	private Vector3 predatorMouthOffset;

	[Header("PATHFINDING")]
	public LayerMask obstacleLayers;

	public LayerMask blockerLayers;

	public float collisionDetectionDistance;

	public float DistanceNodeChange;

	[Range(1f, 100f)]
	public float perseverance;

	private List<Vector2> Follownodes;

	private int totalNearbyPredators;

	private int totalDetectedPredators;

	private int totalNearbyPreys;

	private int totalDetectedPreys;

	private List<Transform> detectedPredators;

	private List<Transform> detectedPreys;

	private Vector2 safeEscapeDirection;

	private List<Vector2> safeDirections;

	private Transform targetedPrey;

	private float circlecastRadius;

	private int wallLayer;

	private int fishBlockerLayer;

	[Header("ORIENTATION")]
	public Transform animationTransform;

	[Range(0f, 60f)]
	public float minEulerX;

	[Range(0f, 60f)]
	public float minEulerY;

	[Range(0f, 60f)]
	public float maxEulerX;

	[Range(0f, 60f)]
	public float maxEulerY;

	public float eulerSmoothing;

	private bool usingMinEuler;

	private bool fixedAngle;

	[SerializeField]
	[Header("ANIMATION")]
	private bool useVertexAnimation;

	public Animator animator;

	public Animation thisAnimation;

	[SerializeField]
	private Renderer animationRenderer;

	[SerializeField]
	private bool tailXDamping;

	[SerializeField]
	private bool tailYDamping;

	[Range(0f, 1f)]
	public float idleAnimationSpeed;

	[Range(0f, 30f)]
	public float wanderAnimationSpeed;

	[Range(0f, 50f)]
	public float chaseAnimationSpeed;

	[SerializeField]
	private DynamicBone[] dynamicBones;

	private bool usingAnimator;

	private bool secondAttack;

	private Tween eatenAnim;

	private MaterialPropertyBlock propBlock;

	private float acceleration;

	private float sinWavePeriod;

	private float targetVertexAnimationDepth;

	private float zVelocity;

	private float smoothTime;

	private float targetSpeed;

	private float currentSpeed;

	private float xDamping;

	private float xDampingVelocity;

	private float xDampingSmoothTime;

	private float xDampingMaxEuler;

	private float yDamping;

	private float yDampingVelocity;

	private float yDampingSmoothTime;

	private float yDampingMaxEuler;

	private float motorEulerSmoothing;

	private Sequence attackSequence;

	private float attackState;

	private float attackBoost;

	private float zRotationAmplitude;

	private bool foregroundLifeform;

	[Header("EFFECTS")]
	public ParticleSystem swimFlowEffect;

	public GameObject deathEffect;

	public ParticleSystem stunEffect;

	[Header("MISC")]
	public bool takeScreenshots;

	private Vector3 animatedEuler;

	private float minEulerHorizontalClamp;

	private float minEulerVerticalClamp;

	public event CreatureAction OnEscape
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private bool DetectPredators()
	{
		return false;
	}

	private bool DetectPreys()
	{
		return false;
	}

	private Transform GetClosestDetectedPredator()
	{
		return null;
	}

	private Transform GetClosestDetectedPrey()
	{
		return null;
	}

	private void FindPath()
	{
	}

	[IteratorStateMachine(typeof(_003CIdle_003Ed__149))]
	private IEnumerator Idle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWander_003Ed__150))]
	private IEnumerator Wander()
	{
		return null;
	}

	private void Stun()
	{
	}

	[IteratorStateMachine(typeof(_003CGetStunned_003Ed__152))]
	private IEnumerator GetStunned()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChase_003Ed__153))]
	private IEnumerator Chase()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAttack_003Ed__154))]
	private IEnumerator Attack()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEat_003Ed__155))]
	private IEnumerator Eat()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEscape_003Ed__156))]
	private IEnumerator Escape()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShield_003Ed__157))]
	private IEnumerator Shield()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGiveUp_003Ed__158))]
	private IEnumerator GiveUp()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLeave_003Ed__159))]
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

	private bool FatLineCast2D(Vector3 emitPoint, Vector3 targetPoint, LayerMask castMask)
	{
		return false;
	}

	private bool FatRaycast(Vector2 castDirection, LayerMask castMask)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CGetHungry_003Ed__166))]
	private IEnumerator GetHungry()
	{
		return null;
	}

	public void GetEaten(Transform predator)
	{
	}

	private void Despawn()
	{
	}

	private void GetEatenByGiantMonster(Transform predator)
	{
	}

	private void ResetStates()
	{
	}
}
