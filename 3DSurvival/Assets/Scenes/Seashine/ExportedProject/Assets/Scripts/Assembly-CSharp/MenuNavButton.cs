using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MenuNavButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateClose_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MenuNavButton _003C_003E4__this;

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
		public _003CAnimateClose_003Ed__18(int _003C_003E1__state)
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

	public GameObject actualMenu;

	private bool hasActualMenu;

	public GameObject targetMenu;

	public bool animateClose;

	public float toY;

	public bool animateOpen;

	public float fromY;

	public float openDelay;

	public bool activateBlackMask;

	public bool disableBlackMask;

	public bool playSound;

	public string soundName;

	public bool sendMessage;

	public string message;

	public GameObject messageTarget;

	private void Awake()
	{
	}

	private void OnClick()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateClose_003Ed__18))]
	private IEnumerator AnimateClose()
	{
		return null;
	}
}
