using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CResetObjects_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Checkpoint _003C_003E4__this;

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
		public _003CResetObjects_003Ed__23(int _003C_003E1__state)
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

	[HideInInspector]
	public Transform thisTransform;

	public bool checkpointTriggered;

	public ObscuredInt savedScore;

	public ObscuredInt savedStars;

	public ObscuredBool hideLifeBar;

	public ObscuredBool hideScore;

	public ObscuredBool hideStarButton;

	public GameObject[] objectsToActivate;

	public GameObject[] objectsToDeactivate;

	public GameObject[] objectsToReset;

	public string messageToSend;

	public GameObject[] objectsToSendMessage;

	private int totalObjToAct;

	private int totalObjToDeact;

	private int totalObjToReset;

	private int totalObjToSendMessage;

	private bool hasObjToAct;

	private bool hasObjToDeact;

	private bool hasObjToReset;

	private bool hasObjToSendMessage;

	private void Awake()
	{
	}

	private void SwitchActivation(GameObject[] gos, int totalObjects, bool b)
	{
	}

	public void LoadCheckpoint()
	{
	}

	[IteratorStateMachine(typeof(_003CResetObjects_003Ed__23))]
	private IEnumerator ResetObjects()
	{
		return null;
	}

	private void SendMessages()
	{
	}
}
