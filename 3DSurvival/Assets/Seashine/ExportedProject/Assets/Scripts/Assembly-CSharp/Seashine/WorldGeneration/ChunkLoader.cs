using System.Collections.Generic;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	public class ChunkLoader
	{
		private GameManager _gameManager;

		public List<int> UpChunks;

		public List<int> RightChunks;

		public List<int> DownChunks;

		public List<int> LeftChunks;

		public List<int> TeleportChunks;

		private bool checkConnectorsLoading;

		public List<GameObject> ConnectorsLoading;

		public List<GameObject> spawnedChunks;

		public List<GameObject> ActiveChunks;

		[HideInInspector]
		public int curChunkCount;

		private GameObject newChunk;

		private GameObject previousChunk;

		[HideInInspector]
		public string CurrentChunk;

		[HideInInspector]
		public string LastChunk;

		private TutorialManager tutorialManager;

		private EventUnloadChunks cachedEventUnloadChunks;

		public Teleconnector teleconnector { get; private set; }

		public void NewTeleconnector(Vector2 holePosition)
		{
		}

		public ChunkLoader(GameManager gameManager)
		{
		}

		private void Initialize()
		{
		}

		private void ResetBuilder()
		{
		}

		public void LoadStartChunk(bool loadAsync)
		{
		}

		public string GetChunk(int orientation)
		{
			return null;
		}

		public GameObject FindActiveChunk(string chunkName)
		{
			return null;
		}

		public void UnloadChunks(GameObject exceptChunk)
		{
		}
	}
}
