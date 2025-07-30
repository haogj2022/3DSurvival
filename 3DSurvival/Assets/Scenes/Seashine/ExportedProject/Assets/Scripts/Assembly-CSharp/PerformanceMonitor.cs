using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class PerformanceMonitor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetFPS_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PerformanceMonitor _003C_003E4__this;

		private int _003ClastFrameCount_003E5__2;

		private float _003ClastTime_003E5__3;

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
		public _003CGetFPS_003Ed__33(int _003C_003E1__state)
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

	private GameManager gameManager;

	private GameObject monitoringOutputGO;

	[HideInInspector]
	public ObscuredBool cheater;

	[HideInInspector]
	public string currentChunk;

	[HideInInspector]
	public string lastChunk;

	private float frequency;

	private int minimumFPS;

	private int maximumFPS;

	private List<int> storedFPS;

	private int storedFPSCount;

	private int storedFPSSum;

	private int storedFPSAverage;

	private int curStoredFPS;

	private bool analyticsSent;

	public bool outputMonitoring { get; protected set; }

	public int systemMemorySize { get; protected set; }

	public int FramesPerSec { get; protected set; }

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnNewGame()
	{
	}

	private void SendAverageFPSToAnalytics()
	{
	}

	private void InitPerformanceMonitoring()
	{
	}

	public void ToggleMonitoringOutput()
	{
	}

	[IteratorStateMachine(typeof(_003CGetFPS_003Ed__33))]
	private IEnumerator GetFPS()
	{
		return null;
	}
}
