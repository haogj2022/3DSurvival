using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	public class Connector : MonoBehaviour
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
		private sealed class _003CSetupSpawnedChunk_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Connector _003C_003E4__this;

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
			public _003CSetupSpawnedChunk_003Ed__22(int _003C_003E1__state)
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

		private GameManager _gameManager;

		private ChunkLoader _chunkLoader;

		private Transform _transform;

		private AsyncOperation asyncLoadOp;

		private LoadState loadState;

		public GameObject spawnedChunk;

		private bool quitting;

		private static bool sceneActivating;

		private string newChunk;

		private bool triggered;

		private bool settingUp;

		private Transform spawnedBlocker;

		[SerializeField]
		private bool returnConnector;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void _Load()
		{
		}

		[IteratorStateMachine(typeof(_003CSetupSpawnedChunk_003Ed__22))]
		private IEnumerator SetupSpawnedChunk()
		{
			return null;
		}

		private void ClearChunk()
		{
		}

		private void TrySceneActivation()
		{
		}
	}
}
