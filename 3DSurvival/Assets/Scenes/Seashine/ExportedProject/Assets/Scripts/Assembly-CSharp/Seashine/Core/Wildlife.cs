using System.Collections.Generic;
using Seashine.NPC;
using Seashine.WorldGeneration;

namespace Seashine.Core
{
	public class Wildlife
	{
		private Dictionary<string, LifeformConfig> lifeformsByName;

		public LifeformConfig[] Lifeforms { get; private set; }

		public WildlifeSpawnCache SpawnCache { get; private set; }

		public Wildlife(LifeformConfig[] lifeformConfigs)
		{
		}

		public LifeformConfig GetLifeform(string lifeformName)
		{
			return null;
		}
	}
}
