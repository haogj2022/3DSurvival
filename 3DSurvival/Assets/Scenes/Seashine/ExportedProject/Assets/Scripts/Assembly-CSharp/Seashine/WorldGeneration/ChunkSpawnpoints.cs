using System;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	[Serializable]
	public class ChunkSpawnpoints
	{
		public SpawnReference[] FixedElements;

		public SpawnReference[] Boulders;

		public SpawnpointStar[] StarSpawnpoints;

		public Vector3[] PreySpawnpoints;

		public SpawnpointBio[] MotileWildlifeSpawnpoints;

		public SpawnpointRotBio[] SessileWildlifeSpawnpoints;

		public SpawnpointRotBio[] SmallSessileWildlifeSpawnpoints;
	}
}
