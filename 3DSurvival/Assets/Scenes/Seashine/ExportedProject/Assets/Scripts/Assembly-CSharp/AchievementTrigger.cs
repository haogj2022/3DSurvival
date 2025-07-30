using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AchievementTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckObjects_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AchievementTrigger _003C_003E4__this;

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
		public _003CCheckObjects_003Ed__11(int _003C_003E1__state)
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

	private PGM PGM_Instance;

	public AchievementName achievement;

	public bool incremental;

	public float increment;

	public bool reportToAnalytics;

	public GameObject[] ObjectsToDisable;

	private int totalObjToDisable;

	private bool checkDisabledObjects;

	private bool triggered;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckObjects_003Ed__11))]
	private IEnumerator CheckObjects()
	{
		return null;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void ReportAchievement()
	{
	}

	private void ReportAchievementAnalytics()
	{
	}
}
