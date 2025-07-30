using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadTimeTest : MonoBehaviour
{
	private enum LoadState
	{
		Unloaded = 0,
		Loading = 1,
		Loaded = 2,
		Unloading = 3,
		Active = 4
	}

	[CompilerGenerated]
	private sealed class _003CSetupSpawnedChunk_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneLoadTimeTest _003C_003E4__this;

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
		public _003CSetupSpawnedChunk_003Ed__23(int _003C_003E1__state)
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

	public string testScene_1;

	public string testScene_2;

	private bool loading;

	private float loadingStartTime;

	private float loadTime;

	private AsyncOperation asyncLoadOp;

	private LoadState loadState;

	public GameObject spawnedChunk;

	private bool quitting;

	private static bool sceneActivating;

	private bool settingUp;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode)
	{
	}

	private void LoadScene1()
	{
	}

	private void LoadScene2()
	{
	}

	private void LoadSceneAsync1()
	{
	}

	private void LoadSceneAsync2()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Update()
	{
	}

	private void _Load(string sceneName)
	{
	}

	[IteratorStateMachine(typeof(_003CSetupSpawnedChunk_003Ed__23))]
	private IEnumerator SetupSpawnedChunk()
	{
		return null;
	}

	private void ClearChunk()
	{
	}

	private void _TrySceneActivation()
	{
	}
}
