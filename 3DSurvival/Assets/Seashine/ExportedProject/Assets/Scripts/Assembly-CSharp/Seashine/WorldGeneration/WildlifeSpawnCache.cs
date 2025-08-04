using System.Collections.Generic;
using PathologicalGames;
using Seashine.NPC;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	public class WildlifeSpawnCache
	{
		private Dictionary<int, LifeformConfig> lifeformsByID;

		private Dictionary<Biome, List<LifeformConfig>> motileWildlifeByBiome;

		private Dictionary<Biome, List<LifeformConfig>> sessileWildlifeByBiome;

		private Dictionary<Biome, List<LifeformConfig>> smallSessileWildlifeByBiome;

		private Dictionary<int, int> variants;

		private Dictionary<Biome, Dictionary<int, int>> maxPerBiome;

		private Dictionary<Biome, Dictionary<int, float>> probabilitiesPerBiome;

		private Dictionary<int, string> nameByID;

		private Dictionary<int, int> maxPerChunkPerLifeformId;

		private SpawnPool wildlifeSpawnPool;

		public WildlifeSpawnCache(LifeformConfig[] lifeformSpawnConfigs)
		{
		}

		private void CacheWildlife(LifeformConfig[] lifeformSpawnConfigs)
		{
		}

		private void CacheLifeform(LifeformConfig lifeformConfig, Dictionary<Biome, List<LifeformConfig>> cacheDict)
		{
		}

		internal string GetPoolItemName(int lifeformID)
		{
			return null;
		}

		internal Vector3 GetRandomScaleForLifeform(int lifeformID)
		{
			return default(Vector3);
		}

		public bool MaxedForChunk(int lifeformID, int count)
		{
			return false;
		}

		public Dictionary<Biome, List<int>> GetLocalWildlifeOfType(LifeformSpawnType type, List<Biome> localBiomes, int currentDifficulty, bool zenModeActive)
		{
			return null;
		}

		private bool PassProbability(float probability, SpawnProbabilityDifficultyBehaviour behaviour)
		{
			return false;
		}

		private List<LifeformConfig> GetForBiome(LifeformSpawnType type, Biome biome)
		{
			return null;
		}
	}
}
