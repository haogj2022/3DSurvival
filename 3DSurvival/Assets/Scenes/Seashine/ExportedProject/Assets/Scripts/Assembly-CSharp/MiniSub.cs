using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MiniSub : MonoBehaviour
{
	private enum AIState
	{
		idle = 0,
		wandering = 1,
		chasing = 2,
		eaten = 3
	}

	[CompilerGenerated]
	private sealed class _003CIdle_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MiniSub _003C_003E4__this;

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
		public _003CIdle_003Ed__65(int _003C_003E1__state)
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
	private sealed class _003CWander_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MiniSub _003C_003E4__this;

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
		public _003CWander_003Ed__66(int _003C_003E1__state)
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
	private sealed class _003CChase_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MiniSub _003C_003E4__this;

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
		public _003CChase_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003CActivateWhenPlayerClose_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MiniSub _003C_003E4__this;

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
		public _003CActivateWhenPlayerClose_003Ed__69(int _003C_003E1__state)
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
	private sealed class _003CDetectObstacles_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MiniSub _003C_003E4__this;

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
		public _003CDetectObstacles_003Ed__70(int _003C_003E1__state)
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

	public bool debugMode;

	private Transform thisTransform;

	private Rigidbody2D thisRigidbody2D;

	private GameManager GManager;

	public GameObject lightZone;

	public float swimSpeed;

	[Range(0.2f, 0.5f)]
	public float wanderSpeed;

	[Range(0.4f, 0.8f)]
	public float chaseSpeed;

	public Transform subLookTransform;

	public Transform subAnimTransform;

	private Transform player;

	private Vector3 curPlayerPos;

	private float propellerSpeed;

	private Vector3 repulsiveForce;

	public float activationRange;

	private float activationRangeSqr;

	public float visionRange;

	private float curDistSqr;

	private bool activated;

	public LayerMask obstacleLayers;

	public LayerMask collisionLayer;

	private float rayDistance;

	internal LayerMask wallsLayer;

	private Vector3 raycastPosOffset;

	private AIState aiState;

	private bool move;

	private bool stuck;

	private float wanderDirectionTimeOut;

	private bool playerInRange;

	private Transform predatorMouth;

	private Vector3 predatorMouthOffset;

	private float trueVelocity;

	private Vector2 directionVelocity;

	private Vector3 eulerVelocity;

	private float directionSmoothTime;

	private float additionalSmoothFactor;

	private Vector3 targetPosition;

	private Vector3 targetDirection;

	private bool TargetVisible;

	private bool follow;

	private float targetToFOV;

	public bool EnableFollowNodePathFinding;

	public bool DebugShowPath;

	public float DistanceNodeChange;

	public List<Vector3> Follownodes;

	public Transform motors;

	public Transform leftPropeller;

	public Transform rightPropeller;

	public float xSmooth;

	public float ySmooth;

	public Vector2 velocity;

	private Vector3 smoothMotorEuler;

	private Vector3 motorEulerVelocity;

	private Vector2 curRigidbodyVelocity;

	private Vector2 smoothDirection;

	private Vector3 smoothedEuler;

	public ParticleSystem propulsionBubbles;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void PlayerSitRep()
	{
	}

	private void FindPath()
	{
	}

	private bool PickWanderDirection()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CIdle_003Ed__65))]
	private IEnumerator Idle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWander_003Ed__66))]
	private IEnumerator Wander()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChase_003Ed__67))]
	private IEnumerator Chase()
	{
		return null;
	}

	private void TogglePropellers(bool activatePropellers)
	{
	}

	[IteratorStateMachine(typeof(_003CActivateWhenPlayerClose_003Ed__69))]
	private IEnumerator ActivateWhenPlayerClose()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDetectObstacles_003Ed__70))]
	private IEnumerator DetectObstacles()
	{
		return null;
	}

	private float GetSqrDistXY(Vector2 a, Vector2 b)
	{
		return 0f;
	}
}
