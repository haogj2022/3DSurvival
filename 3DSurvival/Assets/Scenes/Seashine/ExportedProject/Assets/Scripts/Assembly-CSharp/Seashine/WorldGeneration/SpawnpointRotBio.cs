using System;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	[Serializable]
	public class SpawnpointRotBio : SpawnpointBio
	{
		[field: SerializeField]
		public Quaternion Rotation { get; private set; }

		public SpawnpointRotBio(Vector3 position, Quaternion rotation, Biome biome)
			: base(default(Vector3), default(Biome))
		{
		}
	}
}
