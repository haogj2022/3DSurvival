using System;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	[Serializable]
	public class SpawnpointBio : Spawnpoint
	{
		[field: SerializeField]
		public Biome Biome { get; private set; }

		public SpawnpointBio(Vector3 position, Biome biome)
			: base(default(Vector3))
		{
		}
	}
}
