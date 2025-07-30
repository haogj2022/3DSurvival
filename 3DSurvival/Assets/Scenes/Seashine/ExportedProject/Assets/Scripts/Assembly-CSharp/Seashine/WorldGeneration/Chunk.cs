using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	public class Chunk : MonoBehaviour
	{
		private enum chunkTypes
		{
			Directional = 0,
			Puzzle = 10,
			Start = 20,
			Teleport = 30
		}

		[CompilerGenerated]
		private sealed class _003CGenerateChunk_003Ed__28 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Chunk _003C_003E4__this;

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
			public _003CGenerateChunk_003Ed__28(int _003C_003E1__state)
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

		private bool _initialized;

		private Transform _transform;

		private GameManager _gameManager;

		private ChunkLoader _chunkLoader;

		[SerializeField]
		private chunkTypes chunkType;

		public bool generateReturn;

		public float returnProbability;

		public SpawnReference[] doorElements;

		[SerializeField]
		private Rect chunkBoundaries;

		public int chunkOrientation;

		private List<int> correspondingList;

		private int chunkIndex;

		private Transform returnConnector;

		public Vector2 safeRevivePosition;

		private Vector3 chunkPosition;

		private bool buildDone;

		private ChunkLazySpawner lazySpawner;

		private List<int> localBiomes;

		private List<Transform> spawnedSessileWildlife;

		public ChunkSpawnpoints spawnpoints;

		public ChunkVaryingArea[] varyingAreas;

		public ChunkState State { get; private set; }

		private void OnEnable()
		{
		}

		public void InitializeChunk()
		{
		}

		[IteratorStateMachine(typeof(_003CGenerateChunk_003Ed__28))]
		private IEnumerator<float> GenerateChunk()
		{
			return null;
		}

		private void OnApplicationQuit()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void CacheChunkOrientation()
		{
		}
	}
}
