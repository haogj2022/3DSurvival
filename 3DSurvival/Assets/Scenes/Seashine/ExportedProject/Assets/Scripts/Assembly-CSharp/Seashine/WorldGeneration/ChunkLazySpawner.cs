using System.Collections.Generic;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	public class ChunkLazySpawner
	{
		private Vector3 chunkPosition;

		private ChunkSpawnReferencesQueues spawnQueues;

		private int spawnStep;

		private int maxSpawnPerFrame;

		public List<Transform> spawnedStars;

		private List<Transform> spawnedFixedElements;

		private List<Transform> spawnedSessileWildlife;

		private int starSpawnLimit;

		public ChunkLazySpawner(Vector3 chunkPosition, ChunkSpawnReferencesQueues spawnpointsQueues, int maximumSpawnPerFrame)
		{
		}

		public bool SpawnNext()
		{
			return false;
		}

		public void SpawnAll()
		{
		}

		private bool HasNotFinishedSpawning()
		{
			return false;
		}

		private bool SpawnNextFixedElements()
		{
			return false;
		}

		private bool SpawnNextBoulders()
		{
			return false;
		}

		private bool SpawnNextPrey()
		{
			return false;
		}

		public bool SpawnNextMotileLifeform()
		{
			return false;
		}

		public bool SpawnNextSessileLifeform()
		{
			return false;
		}

		public bool SpawnNextSmallSessileLifeform()
		{
			return false;
		}

		private bool SpawnNextStar()
		{
			return false;
		}

		private Transform Spawn(string poolName, string name, Vector3 spawnpointPosition)
		{
			return null;
		}

		private Transform Spawn(string poolName, SpawnReference spawnReference)
		{
			return null;
		}

		private Transform SpawnAndAddToList(string poolName, SpawnReference spawnReference, List<Transform> spawnedTransformsList)
		{
			return null;
		}

		private Transform SpawnAndAddToList(string poolName, SpawnpointStar starSpawnpoint)
		{
			return null;
		}

		public void SpawnDoor(ChunkState chunkState, SpawnReference[] doorSpawnRefs)
		{
		}

		public void DespawnAll(Rect chunkBoundaries, bool includingWildlife)
		{
		}
	}
}
