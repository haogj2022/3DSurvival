using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace MEC
{
	public class Timing : MonoBehaviour
	{
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			public Segment seg;

			public int i;

			public bool Equals(ProcessIndex other)
			{
				return false;
			}

			public override bool Equals(object other)
			{
				return false;
			}

			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return false;
			}

			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass110_0
		{
			public IEnumerator<float> proc;

			internal IEnumerator<float> _003C_InjectDelay_003Eb__0(IEnumerator<float> _003Cp0_003E, CoroutineHandle _003Cp1_003E)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_InjectDelay_003Ed__110 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public IEnumerator<float> proc;

			public Timing _003C_003E4__this;

			public float delayTime;

			private _003C_003Ec__DisplayClass110_0 _003C_003E8__1;

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
			public _003C_InjectDelay_003Ed__110(int _003C_003E1__state)
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
		private sealed class _003C_StartWhenDone_003Ed__117 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public CoroutineHandle handle;

			public IEnumerator<float> proc;

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
			public _003C_StartWhenDone_003Ed__117(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass121_0
		{
			public IEnumerator<float> pausedProc;

			internal IEnumerator<float> _003C_StartWhenDone_003Eb__0(IEnumerator<float> _003Cp0_003E, CoroutineHandle _003Cp1_003E)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_StartWhenDone_003Ed__121 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public IEnumerator<float> pausedProc;

			public WWW www;

			private _003C_003Ec__DisplayClass121_0 _003C_003E8__1;

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
			public _003C_StartWhenDone_003Ed__121(int _003C_003E1__state)
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
		private sealed class _003C_003Ec__DisplayClass123_0
		{
			public IEnumerator<float> pausedProc;

			internal IEnumerator<float> _003C_StartWhenDone_003Eb__0(IEnumerator<float> _003Cp0_003E, CoroutineHandle _003Cp1_003E)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_StartWhenDone_003Ed__123 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public IEnumerator<float> pausedProc;

			public AsyncOperation operation;

			private _003C_003Ec__DisplayClass123_0 _003C_003E8__1;

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
			public _003C_StartWhenDone_003Ed__123(int _003C_003E1__state)
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
		private sealed class _003C_003Ec__DisplayClass125_0
		{
			public IEnumerator<float> pausedProc;

			internal IEnumerator<float> _003C_StartWhenDone_003Eb__0(IEnumerator<float> _003Cp0_003E, CoroutineHandle _003Cp1_003E)
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_StartWhenDone_003Ed__125 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public IEnumerator<float> pausedProc;

			public CustomYieldInstruction operation;

			private _003C_003Ec__DisplayClass125_0 _003C_003E8__1;

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
			public _003C_StartWhenDone_003Ed__125(int _003C_003E1__state)
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
		private sealed class _003C_DelayedCall_003Ed__132 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float delay;

			public GameObject cancelWith;

			public Action action;

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
			public _003C_DelayedCall_003Ed__132(int _003C_003E1__state)
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
		private sealed class _003C_CallContinuously_003Ed__141 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float period;

			public Action action;

			public float timeframe;

			public Action onDone;

			private double _003CstartTime_003E5__2;

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
			public _003C_CallContinuously_003Ed__141(int _003C_003E1__state)
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
		private sealed class _003C_CallContinuously_003Ed__150<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float period;

			public Action<T> action;

			public T reference;

			public float timeframe;

			public Action<T> onDone;

			private double _003CstartTime_003E5__2;

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
			public _003C_CallContinuously_003Ed__150(int _003C_003E1__state)
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

		[Tooltip("How quickly the SlowUpdate segment ticks.")]
		public float TimeBetweenSlowUpdateCalls;

		[Tooltip("How much data should be sent to the profiler window when it's open.")]
		public DebugInfoType ProfilerDebugAmount;

		[Space(12f)]
		[Tooltip("A count of the number of Update coroutines that are currently running.")]
		public int UpdateCoroutines;

		[Tooltip("A count of the number of FixedUpdate coroutines that are currently running.")]
		public int FixedUpdateCoroutines;

		[Tooltip("A count of the number of LateUpdate coroutines that are currently running.")]
		public int LateUpdateCoroutines;

		[Tooltip("A count of the number of SlowUpdate coroutines that are currently running.")]
		public int SlowUpdateCoroutines;

		[NonSerialized]
		public float localTime;

		[NonSerialized]
		public float deltaTime;

		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		public static readonly float WaitForOneFrame;

		private static bool _tmpBool;

		private static CoroutineHandle _tmpHandle;

		private int _currentUpdateFrame;

		private int _currentLateUpdateFrame;

		private int _currentFixedUpdateFrame;

		private int _currentSlowUpdateFrame;

		private int _nextUpdateProcessSlot;

		private int _nextLateUpdateProcessSlot;

		private int _nextFixedUpdateProcessSlot;

		private int _nextSlowUpdateProcessSlot;

		private int _lastUpdateProcessSlot;

		private int _lastLateUpdateProcessSlot;

		private int _lastFixedUpdateProcessSlot;

		private int _lastSlowUpdateProcessSlot;

		private float _lastUpdateTime;

		private float _lastLateUpdateTime;

		private float _lastFixedUpdateTime;

		private float _lastSlowUpdateTime;

		private float _lastSlowUpdateDeltaTime;

		private ushort _framesSinceUpdate;

		private ushort _expansions;

		private byte _instanceID;

		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		private readonly Dictionary<CoroutineHandle, string> _processTags;

		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		private IEnumerator<float>[] UpdateProcesses;

		private IEnumerator<float>[] LateUpdateProcesses;

		private IEnumerator<float>[] FixedUpdateProcesses;

		private IEnumerator<float>[] SlowUpdateProcesses;

		private bool[] UpdatePaused;

		private bool[] LateUpdatePaused;

		private bool[] FixedUpdatePaused;

		private bool[] SlowUpdatePaused;

		private const ushort FramesUntilMaintenance = 64;

		private const int ProcessArrayChunkSize = 64;

		private const int InitialBufferSizeLarge = 256;

		private const int InitialBufferSizeMedium = 64;

		private const int InitialBufferSizeSmall = 8;

		private static readonly Dictionary<byte, Timing> ActiveInstances;

		private static Timing _instance;

		public static float LocalTime => 0f;

		public static float DeltaTime => 0f;

		public static Thread MainThread { get; private set; }

		public static Timing Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action OnPreExecute
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void RemoveUnused()
		{
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment timing)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment timing, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment timing)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment timing, string tag)
		{
			return default(CoroutineHandle);
		}

		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment timing, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		public static int KillCoroutines()
		{
			return 0;
		}

		public int KillCoroutinesOnInstance()
		{
			return 0;
		}

		public static int KillCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public static int KillCoroutines(string tag)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		public static int PauseCoroutines()
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance()
		{
			return 0;
		}

		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public static int PauseCoroutines(string tag)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		public static int ResumeCoroutines()
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance()
		{
			return 0;
		}

		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public static int ResumeCoroutines(string tag)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		private bool UpdateTimeValues(Segment segment)
		{
			return false;
		}

		private float GetSegmentTime(Segment segment)
		{
			return 0f;
		}

		public void ResetTimeCountOnInstance()
		{
		}

		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		private void AddTag(string tag, CoroutineHandle coindex)
		{
		}

		private void RemoveTag(CoroutineHandle coindex)
		{
		}

		private bool Nullify(ProcessIndex coindex)
		{
			return false;
		}

		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return false;
		}

		private bool SetPause(ProcessIndex coindex, bool newPausedState = true)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003C_InjectDelay_003Ed__110))]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float delayTime)
		{
			return null;
		}

		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		public static float WaitForSeconds(float waitTime)
		{
			return 0f;
		}

		public float WaitForSecondsOnInstance(float waitTime)
		{
			return 0f;
		}

		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return 0f;
		}

		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return 0f;
		}

		private IEnumerator<float> WaitUntilDoneWrapper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_StartWhenDone_003Ed__117))]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return false;
		}

		public static float WaitUntilDone(WWW wwwObject)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003C_StartWhenDone_003Ed__121))]
		private static IEnumerator<float> _StartWhenDone(WWW www, IEnumerator<float> pausedProc)
		{
			return null;
		}

		public static float WaitUntilDone(AsyncOperation operation)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003C_StartWhenDone_003Ed__123))]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003C_StartWhenDone_003Ed__125))]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return false;
		}

		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return false;
		}

		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[IteratorStateMachine(typeof(_003C_DelayedCall_003Ed__132))]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		[IteratorStateMachine(typeof(_003C_CallContinuously_003Ed__141))]
		private IEnumerator<float> _CallContinuously(float timeframe, float period, Action action, Action onDone)
		{
			return null;
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		[IteratorStateMachine(typeof(_003C_CallContinuously_003Ed__150<>))]
		private IEnumerator<float> _CallContinuously<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use KillCoroutine instead.", true)]
		public new void StopCoroutine(string methodName)
		{
		}

		[Obsolete("Unity coroutine function, use KillCoroutine instead.", true)]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Obsolete("Unity coroutine function, use KillCoroutine instead.", true)]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Obsolete("Unity coroutine function, use KillAllCoroutines instead.", true)]
		public new void StopAllCoroutines()
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Obsolete("Just.. no.", true)]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static void print(object message)
		{
		}
	}
}
