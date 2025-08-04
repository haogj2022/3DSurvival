using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Pated.Events;
using UnityEngine;

public class Supersense : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CProcessDetections_003Ed__26 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Supersense _003C_003E4__this;

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
		public _003CProcessDetections_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CDisplayDetections_003Ed__29 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Supersense _003C_003E4__this;

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
		public _003CDisplayDetections_003Ed__29(int _003C_003E1__state)
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

	private Transform thisTransform;

	[SerializeField]
	private GameManager gameManager;

	public float range;

	private float minDistanceSqr;

	public float duration;

	private float endTime;

	public LayerMask supersenseLayerMask;

	public Transform[] hintTransforms;

	public UISprite[] hintSprites;

	private Vector3[] selectedDetections;

	private Collider2D[] detectedColliders;

	private int processIndex;

	private bool supersenseEnabled;

	private int totalSelectedDetections;

	private int smallHintSize;

	private int mediumHintSize;

	private int bigHintSize;

	private List<Vector2> detectedCrystalsDirections;

	private List<Vector2> detectedPlanternsDirections;

	private bool applicationQuitting;

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGameReset(EventGameReset e)
	{
	}

	public void ActivateSupersense()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessDetections_003Ed__26))]
	private IEnumerator<float> ProcessDetections()
	{
		return null;
	}

	private bool ValidateCrystalDetection(Vector2 thisDetectionDirection)
	{
		return false;
	}

	private bool ValidatePlanternDetection(Vector2 thisDetectionDirection)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CDisplayDetections_003Ed__29))]
	private IEnumerator<float> DisplayDetections()
	{
		return null;
	}

	public void DisableSupersense()
	{
	}
}
