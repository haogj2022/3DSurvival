using System.Collections.Generic;
using Seashine.NPC;

namespace Seashine.WorldGeneration
{
	public static class LocalWildlifePicker
	{
		public static Queue<SpawnReference> PickLocalWildlife(LifeformSpawnType type, int currentDifficulty, bool zenModeActive, List<SpawnpointBio> spawnpoints, WildlifeSpawnCache spawnCache)
		{
			return null;
		}

		private static int PickRandomLocalLifeformID(List<int> lifeformIDs, WildlifeSpawnCache spawnCache, Dictionary<int, int> spawnedCount)
		{
			return 0;
		}

		public static bool IsAppropriate(this LifeformConfig lifeformConfig, int currentDifficulty, bool zenModeActive)
		{
			return false;
		}

		private static List<Biome> ReadLocalBiomes(List<SpawnpointBio> spawnpoints)
		{
			return null;
		}
	}
}
