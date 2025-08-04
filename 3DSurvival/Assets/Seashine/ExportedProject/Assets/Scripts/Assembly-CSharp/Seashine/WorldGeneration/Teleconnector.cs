using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	public class Teleconnector
	{
		private enum LoadState
		{
			Unloaded = 0,
			Loading = 1,
			Loaded = 2,
			Finished = 3
		}

		[CompilerGenerated]
		private sealed class _003CCheckState_003Ed__22 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Teleconnector _003C_003E4__this;

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
			public _003CCheckState_003Ed__22(int _003C_003E1__state)
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
		private sealed class _003CFinishWhenChunkSpawningFinished_003Ed__26 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Teleconnector _003C_003E4__this;

			private Chunk _003CchunkScript_003E5__2;

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
			public _003CFinishWhenChunkSpawningFinished_003Ed__26(int _003C_003E1__state)
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

		private Transform player;

		private ChunkLoader _chunkLoader;

		private GameCamera cameraScript;

		private Vector3 curPos;

		private TweenAlpha maskTween;

		private bool checkConnectorsLoading;

		private int nextPuzzleCounter;

		private AsyncOperation asyncLoadOp;

		private LoadState currentLoadState;

		public GameObject spawnedChunk;

		private bool quitting;

		private static bool sceneActivating;

		private string newChunk;

		private bool triggered;

		private bool settingUp;

		private Tween playerTeleportTween;

		public void StartConnection(GameManager gameManager, ChunkLoader chunkLoader, Transform playerTransform, Vector2 holePosition)
		{
		}

		private void FadeOut()
		{
		}

		private void ClearEverything()
		{
		}

		private void _Load()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckState_003Ed__22))]
		private IEnumerator<float> CheckState()
		{
			return null;
		}

		public bool IsStateFinished()
		{
			return false;
		}

		private void _TrySceneActivation()
		{
		}

		private void SetupSpawnedChunk()
		{
		}

		[IteratorStateMachine(typeof(_003CFinishWhenChunkSpawningFinished_003Ed__26))]
		private IEnumerator<float> FinishWhenChunkSpawningFinished()
		{
			return null;
		}

		private void FadeIn()
		{
		}
	}
}
