using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TextureSwapAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSafeStart_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TextureSwapAnimation _003C_003E4__this;

		private int _003Cindex_003E5__2;

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
		public _003CSafeStart_003Ed__8(int _003C_003E1__state)
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
	private InitApp initApp;

	public Renderer thisRenderer;

	public Texture2D[] frames;

	public float framesPerSecond;

	private bool animFinished;

	private int totalFrames;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CSafeStart_003Ed__8))]
	private IEnumerator SafeStart()
	{
		return null;
	}
}
