using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayTrackingSpeed_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCamera _003C_003E4__this;

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
		public _003CDelayTrackingSpeed_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CCheckPlayerVelocity_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCamera _003C_003E4__this;

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
		public _003CCheckPlayerVelocity_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003CTeleportCameraPosition_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameCamera _003C_003E4__this;

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
		public _003CTeleportCameraPosition_003Ed__55(int _003C_003E1__state)
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

	[SerializeField]
	private float startFollowDelay;

	private float startFollowTime;

	private PGM PGM;

	private GameManager gameManager;

	private Transform thisTransform;

	private Transform playerTransform;

	private Rigidbody2D playerRigidbody2D;

	public Transform otherTargetTransform;

	private Transform cameraTarget;

	public float xSmooth;

	public float ySmooth;

	public float xFactor;

	public float yFactor;

	public Vector2 xLockedRange;

	public float cameraHeight;

	public float zPosNormal;

	public float zPos916;

	[HideInInspector]
	public float zPos;

	private float xOffset;

	private float yOffset;

	private Vector3 targetPosition;

	private Vector3 tempNewPosition;

	private Vector3 startPosition;

	private Vector3 newSmoothedPosition;

	private bool teleporting;

	private Vector2 velocity;

	private bool playerVelX;

	private bool playerVelY;

	private float xVel;

	private float yVel;

	private Tween rotationTween;

	private Tween zoomTween;

	private Quaternion startRotation;

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

	private void FixedUpdate()
	{
	}

	private void UpdateCameraSmoothedPosition()
	{
	}

	private void OnGameRestart()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayTrackingSpeed_003Ed__40))]
	private IEnumerator DelayTrackingSpeed()
	{
		return null;
	}

	private void UpdateTrackingSpeed(float tSpeed)
	{
	}

	private void UpdateOffset()
	{
	}

	private void UpdateTargetPosition()
	{
	}

	private void ResetRotationTween()
	{
	}

	public void ShakeCamera()
	{
	}

	public void BumpCamera()
	{
	}

	public void VibrateCamera()
	{
	}

	public void Shockwave()
	{
	}

	private void ResetZoomTween()
	{
	}

	public void ZoomOut(float zoomOutAmount)
	{
	}

	public void ZoomIn(float zoomInAmount)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckPlayerVelocity_003Ed__52))]
	private IEnumerator CheckPlayerVelocity()
	{
		return null;
	}

	public void ResetCamera()
	{
	}

	public void TeleportCamera()
	{
	}

	[IteratorStateMachine(typeof(_003CTeleportCameraPosition_003Ed__55))]
	private IEnumerator TeleportCameraPosition()
	{
		return null;
	}
}
