using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class AnglerFish : MonoBehaviour
{
	private enum AIState
	{
		sleeping = 0,
		lethargic = 1,
		idle = 2,
		wandering = 3,
		chasing = 4,
		attacking = 5,
		escaping = 6,
		stuck = 7,
		eaten = 8,
		dead = 9
	}

	[CompilerGenerated]
	private sealed class _003CSleep_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnglerFish _003C_003E4__this;

		private int _003CwakeUpCounter_003E5__2;

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
		public _003CSleep_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CLethargic_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnglerFish _003C_003E4__this;

		private int _003ClethargicTimer_003E5__2;

		private int _003ClethargicTime_003E5__3;

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
		public _003CLethargic_003Ed__77(int _003C_003E1__state)
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
	private sealed class _003CIdle_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnglerFish _003C_003E4__this;

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
		public _003CIdle_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003CWander_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnglerFish _003C_003E4__this;

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
		public _003CWander_003Ed__79(int _003C_003E1__state)
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
	private sealed class _003CChase_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnglerFish _003C_003E4__this;

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
		public _003CChase_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003CAttack_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnglerFish _003C_003E4__this;

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
		public _003CAttack_003Ed__81(int _003C_003E1__state)
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
	private sealed class _003CEscape_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnglerFish _003C_003E4__this;

		private int _003CstuckCounter_003E5__2;

		private Transform _003CclosestDetectedPredator_003E5__3;

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
		public _003CEscape_003Ed__82(int _003C_003E1__state)
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
	private sealed class _003CGiveUp_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnglerFish _003C_003E4__this;

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
		public _003CGiveUp_003Ed__83(int _003C_003E1__state)
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

	[Space(10f)]
	public bool debugMode;

	[Space(10f)]
	public bool persistent;

	public bool startAsleep;

	private Transform thisTransform;

	private Rigidbody2D thisRigidbody2D;

	private Transform player;

	[Header("MOVEMENT")]
	public Transform animationTransform;

	public float swimSpeed;

	[Range(0f, 20f)]
	public float wanderSpeed;

	[Range(0f, 30f)]
	public float chaseSpeed;

	public float rotationSpeed;

	[Range(0f, 1f)]
	public float directionSmoothTime;

	private Vector3 localStartPosition;

	private Quaternion startAnimLocalRot;

	private Vector2 startDirection;

	private float smoothedSwimSpeed;

	private float smoothedSwimSpeedVel;

	private bool move;

	private Vector2 targetDirection;

	private float wanderDirectionTimeOut;

	private Vector2 curRigidbodyVelocity;

	private Vector2 smoothDirection;

	private Vector3 smoothedEuler;

	private float trueVelocity;

	private Vector2 directionVelocity;

	private Vector3 eulerVelocity;

	private float currentDirectionDamping;

	[Header("AI")]
	public float visionRange;

	public LayerMask predators;

	private AIState aiState;

	private Vector2 curPlayerPos;

	private float playerDistSqr;

	private float targetToFOV;

	private Vector3 stuckDirection;

	private int totalNearbyPredators;

	private int totalDetectedPredators;

	private List<Transform> detectedPredators;

	private Vector2 safeEscapeDirection;

	private List<Vector2> safeDirections;

	private int playerLayer;

	private int wallLayer;

	private Transform detectedPredator;

	private Transform predatorMouth;

	private Vector3 predatorMouthOffset;

	private float screenshotCooldown;

	[Header("ATTACK")]
	public Transform mouthPoint;

	public float mouthSize;

	public float attackDistance;

	[Range(0.5f, 5f)]
	public float minTimeBetweenAttacks;

	[Range(1f, 10f)]
	public float maxTimeBetweenAttacks;

	private ObscuredFloat playerDamage;

	private float lastAttackTime;

	[Header("PATHFINDING")]
	public LayerMask obstacleLayers;

	public float collisionDetectionDistance;

	public float DistanceNodeChange;

	private bool playerVisible;

	private List<Vector2> Follownodes;

	private float castRadius;

	private int fishBlockerLayer;

	[Header("ANIMATION")]
	public Animation thisAnimation;

	[Range(0f, 40f)]
	public float maxEulerX;

	[Range(0f, 40f)]
	public float maxEulerY;

	private bool secondAttack;

	[Header("EFFECTS")]
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

	private bool FatRaycast(Vector2 castDirection, LayerMask castMask)
	{
		return false;
	}

	private bool FatLineCast2D(Vector3 emitPoint, Vector3 targetPoint, LayerMask castMask)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CSleep_003Ed__76))]
	private IEnumerator Sleep()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLethargic_003Ed__77))]
	private IEnumerator Lethargic()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIdle_003Ed__78))]
	private IEnumerator Idle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWander_003Ed__79))]
	private IEnumerator Wander()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChase_003Ed__80))]
	private IEnumerator Chase()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAttack_003Ed__81))]
	private IEnumerator Attack()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEscape_003Ed__82))]
	private IEnumerator Escape()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGiveUp_003Ed__83))]
	private IEnumerator GiveUp()
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

	private void ResetStates()
	{
	}
}
