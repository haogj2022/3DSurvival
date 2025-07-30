using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HighQualitySwitcher : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRandomizeScoreAndDifficulty_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HighQualitySwitcher _003C_003E4__this;

		private GameManager _003CGManager_003E5__2;

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
		public _003CRandomizeScoreAndDifficulty_003Ed__9(int _003C_003E1__state)
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

	public bool disableAudio;

	public bool hideUI;

	public GameObject uiToDisable;

	public bool randomizeScore;

	public bool highDifficulty;

	public bool changeCameraDistance;

	public float cameraDistance;

	private Transform mainCamera;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CRandomizeScoreAndDifficulty_003Ed__9))]
	private IEnumerator RandomizeScoreAndDifficulty()
	{
		return null;
	}
}
