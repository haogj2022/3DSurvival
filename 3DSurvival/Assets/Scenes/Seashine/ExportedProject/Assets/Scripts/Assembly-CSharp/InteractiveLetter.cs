using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class InteractiveLetter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAppear_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InteractiveLetter _003C_003E4__this;

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
		public _003CAppear_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CDisableCollider_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InteractiveLetter _003C_003E4__this;

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
		public _003CDisableCollider_003Ed__20(int _003C_003E1__state)
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

	public Transform letter;

	private Renderer letterRenderer;

	private Material letterMaterial;

	private Collider2D letterCollider;

	private bool touched;

	public float activationDelay;

	private Tween moveTween;

	public Vector3 animFromPosition;

	private Vector3 offsetFromPosition;

	public Vector3 animFromRotation;

	public float animFromDuration;

	public Color letterColor;

	private float animatedAlpha;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CAppear_003Ed__16))]
	private IEnumerator Appear()
	{
		return null;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void Disappear()
	{
	}

	private void ChangeColor(float animatedAlpha)
	{
	}

	[IteratorStateMachine(typeof(_003CDisableCollider_003Ed__20))]
	private IEnumerator DisableCollider()
	{
		return null;
	}

	private void DisableObject()
	{
	}
}
