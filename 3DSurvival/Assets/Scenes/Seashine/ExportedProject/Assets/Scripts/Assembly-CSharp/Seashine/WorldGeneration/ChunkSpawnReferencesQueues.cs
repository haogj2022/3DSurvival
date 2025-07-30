using System.Collections.Generic;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	public class ChunkSpawnReferencesQueues
	{
		public Queue<SpawnReference> FixedElements;

		public Queue<SpawnReference> Boulders;

		public Queue<SpawnpointStar> StarSpawnpoints;

		public Queue<Vector3> PreySpawnpoints;

		public Queue<SpawnReference> MotileWildlife;

		public Queue<SpawnReference> SessileWildlife;

		public Queue<SpawnReference> SmallSessileWildlife;
	}
}
