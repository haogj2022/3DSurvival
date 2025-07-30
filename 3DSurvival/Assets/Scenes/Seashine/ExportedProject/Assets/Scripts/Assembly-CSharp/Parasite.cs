using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using UnityEngine;

public class Parasite : MonoBehaviour
{
	public enum ScaleSpeedMethod
	{
		smallerFaster = 0,
		biggerFaster = 1
	}

	private enum AIState
	{
		idle = 0,
		wandering = 1,
		chasing = 2,
		parasiting = 3,
		dizzy = 4,
		evading = 5,
		leaving = 6,
		eaten = 7,
		dead = 8
	}

	[CompilerGenerated]
	private sealed class _003CIdle_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Parasite _003C_003E4__this;

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
		public _003CIdle_003Ed__102(int _003C_003E1__state)
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
	private sealed class _003CWander_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Parasite _003C_003E4__this;

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
		public _003CWander_003Ed__103(int _003C_003E1__state)
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
	private sealed class _003CChase_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Parasite _003C_003E4__this;

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
		public _003CChase_003Ed__104(int _003C_003E1__state)
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
	private sealed class _003CEscape_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Parasite _003C_003E4__this;

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
		public _003CEscape_003Ed__105(int _003C_003E1__state)
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
	private sealed class _003CRegainConsciousness_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Parasite _003C_003E4__this;

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
		public _003CRegainConsciousness_003Ed__107(int _003C_003E1__state)
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

	[Space(10f)]
	public bool persistent;

	private Transform thisTransform;

	private Rigidbody2D thisRigidbody2D;

	private Collider2D thisCollider2D;

	[HideInInspector]
	public Transform player;

	private Jelly playerScript;

	private Transform playerHood;

	[Header("MOVEMENT")]
	[Range(0f, 20f)]
	public float wanderSpeed;

	private float instanceWanderSpeed;

	[Range(0f, 30f)]
	public float chaseSpeed;

	private float instanceChaseSpeed;

	private float swimSpeed;

	public bool scaleSpeed;

	[Range(0f, 5f)]
	public float scaleSpeedPower;

	private float scaleSpeedFactor;

	public ScaleSpeedMethod scaleSpeedMethod;

	[Range(0f, 1f)]
	public float speedRandomness;

	private float thisParasiteSpeedRandomness;

	[Range(0f, 1f)]
	public float directionSmoothTime;

	private bool move;

	private Vector3 curPlayerPos;

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
	public float visionRange;

	private float visionRangeSqr;

	[Range(-1f, 1f)]
	public float funnelVision;

	public LayerMask predators;

	private AIState aiState;

	private bool hasPredators;

	private bool playerDetected;

	private Vector3 attachPoint;

	[Header("ESCAPE")]
	public bool reversedEscape;

	[Header("COLLISION")]
	public bool contactHurts;

	public ObscuredFloat contactDamage;

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

	private List<Transform> detectedPredators;

	private Vector2 safeEscapeDirection;

	private List<Vector2> safeDirections;

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

	[Header("ANIMATION")]
	public Animator animator;

	public Animation thisAnimation;

	[Range(0f, 1f)]
	public float idleAnimationSpeed;

	[Range(0f, 30f)]
	public float wanderAnimationSpeed;

	private float instanceWanderAnimationSpeed;

	[Range(0f, 50f)]
	public float chaseAnimationSpeed;

	private float instanceChaseAnimationSpeed;

	[SerializeField]
	private DynamicBone[] dynamicBones;

	private bool usingAnimator;

	private bool secondAttack;

	private Tween eatenAnim;

	[Header("EFFECTS")]
	public ParticleSystem swimFlowEffect;

	public GameObject deathEffect;

	public ParticleSystem parasitingEffect;

	public ParticleSystem dizzyEffect;

	public ParticleSystem stunEffect;

	[Header("MISC")]
	public bool takeScreenshots;

	private Vector3 animatedEuler;

	private float minEulerHorizontalClamp;

	private float minEulerVerticalClamp;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void SetSpeeds()
	{
	}

	private void FixedUpdate()
	{
	}

	private bool DetectPlayer()
	{
		return false;
	}

	private bool DetectPredators()
	{
		return false;
	}

	private Transform GetClosestDetectedPredator()
	{
		return null;
	}

	private void FindPath()
	{
	}

	[IteratorStateMachine(typeof(_003CIdle_003Ed__102))]
	private IEnumerator Idle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWander_003Ed__103))]
	private IEnumerator Wander()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChase_003Ed__104))]
	private IEnumerator Chase()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEscape_003Ed__105))]
	private IEnumerator Escape()
	{
		return null;
	}

	public void Detach(bool isGameReset)
	{
	}

	[IteratorStateMachine(typeof(_003CRegainConsciousness_003Ed__107))]
	private IEnumerator RegainConsciousness()
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

	private bool FatLineCast2D(Vector3 emitPoint, Vector3 targetPoint, LayerMask castMask)
	{
		return false;
	}

	private bool FatRaycast(Vector2 castDirection, LayerMask castMask)
	{
		return false;
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
