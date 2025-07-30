using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Seashine.GameSaving;
using UnityEngine;

public class InitApp : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadGame_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private GameSaver _003CgameSaver_003E5__2;

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
		public _003CLoadGame_003Ed__5(int _003C_003E1__state)
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

	private int version;

	private int savedVersion;

	public void Init()
	{
	}

	private void InitGame()
	{
	}

	private void InitUnityAnalytics()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadGame_003Ed__5))]
	private IEnumerator LoadGame()
	{
		return null;
	}

	private void PerformChanges()
	{
	}
}
