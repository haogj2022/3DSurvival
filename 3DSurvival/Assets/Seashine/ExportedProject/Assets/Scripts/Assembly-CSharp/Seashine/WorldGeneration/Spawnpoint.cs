using System;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	[Serializable]
	public class Spawnpoint
	{
		[field: SerializeField]
		public Vector3 Position { get; private set; }

		public Spawnpoint(Vector3 position)
		{
		}
	}
}
