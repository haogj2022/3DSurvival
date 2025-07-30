using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Boulder : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAutoDespawn_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Boulder _003C_003E4__this;

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
		public _003CAutoDespawn_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CMakeBubbles_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Boulder _003C_003E4__this;

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
		public _003CMakeBubbles_003Ed__16(int _003C_003E1__state)
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

	private Rigidbody2D thisRigidbody2D;

	private GameManager gameManager;

	private Transform player;

	public ParticleSystem bubbles;

	public bool persistent;

	private string SFX_Collision;

	private float checkInterval;

	private Vector3 localStartPos;

	private Quaternion localStartRot;

	private float sfxUnlockTime;

	private bool despawned;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoDespawn_003Ed__15))]
	private IEnumerator AutoDespawn()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMakeBubbles_003Ed__16))]
	private IEnumerator MakeBubbles()
	{
		return null;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private float GetSqrDistXY(Vector3 a, Vector3 b)
	{
		return 0f;
	}
}
