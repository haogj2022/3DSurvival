using System;
using UnityEngine;

namespace Seashine.WorldGeneration
{
	[Serializable]
	public class LifeformHabitat
	{
		[SerializeField]
		private Biome biome;

		[Tooltip("1 means 100% chance of being selected in the list of available lifeforms for a chunk's biome if other conditions pass.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float probability;

		[SerializeField]
		private int maximumSpecimens;

		public Biome Biome => default(Biome);

		public float Probability => 0f;

		public int MaximumSpecimens => 0;
	}
}
