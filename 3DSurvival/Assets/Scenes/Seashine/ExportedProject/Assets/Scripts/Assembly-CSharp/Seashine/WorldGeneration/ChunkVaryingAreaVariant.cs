using System;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	[Serializable]
	public class ChunkVaryingAreaVariant
	{
		[SerializeField]
		private bool useDifficulty;

		[SerializeField]
		private bool useZen;

		[SerializeField]
		private int minDifficulty;

		[SerializeField]
		private int maxDifficulty;

		[SerializeField]
		private ChunkSpawnpoints spawnableGroup;

		public ChunkSpawnpoints SpawnableGroup => null;

		public ChunkVaryingAreaVariant(string gameobjectName, ChunkSpawnpoints spawnableGroup)
		{
		}

		private bool ParseDifficultyRange(string name, out int minDif, out int maxDif)
		{
			minDif = default(int);
			maxDif = default(int);
			return false;
		}

		private bool IsZen(string name)
		{
			return false;
		}

		public bool CheckCondition(int currentDifficulty, bool zenModeActive)
		{
			return false;
		}

		private bool CheckZen(bool zenModeActive)
		{
			return false;
		}

		private bool CheckDifficulty(int currentDifficulty)
		{
			return false;
		}
	}
}
