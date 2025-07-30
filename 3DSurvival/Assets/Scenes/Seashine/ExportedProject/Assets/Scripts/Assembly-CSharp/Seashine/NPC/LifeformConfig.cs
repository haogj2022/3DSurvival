using System;
using Seashine.Core;
using Seashine.WorldGeneration;
using UnityEngine;

namespace Seashine.NPC
{
	[Serializable]
	[CreateAssetMenu(fileName = "NewLifeformConfig", menuName = "Seashine/Configuration/Lifeform", order = 2)]
	public class LifeformConfig : ScriptableObject, IDiscoverable
	{
		[Space(10f)]
		[SerializeField]
		private string lifeformName;

		[SerializeField]
		private int uniqueId;

		[SerializeField]
		private LifeformPhylum phylum;

		[Space(10f)]
		[SerializeField]
		private RevelationMethod revelationMethod;

		[SerializeField]
		private int discoveryReward;

		[Tooltip("Used by lifeform packer script during build.")]
		[SerializeField]
		private bool draft;

		[Tooltip("If true, the lifeform is spawned by the builder from a pool. If false, the lifeform is part of spawn scenes.")]
		[SerializeField]
		private bool spawnsDynamically;

		[SerializeField]
		private LifeformSpawnType spawnType;

		[SerializeField]
		private int numberOfVariants;

		[SerializeField]
		private float minimumScale;

		[SerializeField]
		private float maximumScale;

		[SerializeField]
		private LifeformHabitat[] habitats;

		[SerializeField]
		private SpawnProbabilityDifficultyBehaviour probabilityBehaviour;

		[SerializeField]
		private int minimumSpawnDifficulty;

		[SerializeField]
		private int maximumSpawnDifficulty;

		[SerializeField]
		private int maximumSpecimensPerChunk;

		[SerializeField]
		[Space(10f)]
		private float speed;

		[SerializeField]
		private float energeticValue;

		[Space(10f)]
		[Header("Predation")]
		[SerializeField]
		private bool playerIsEdible;

		[SerializeField]
		private LifeformAttitudeTowardsPlayer attitudeTowardsPlayer;

		[SerializeField]
		[Space(5f)]
		private LifeformConfig[] preys;

		[SerializeField]
		private LifeformConfig[] predators;

		[SerializeField]
		[Space(5f)]
		private float visionRange;

		[SerializeField]
		private float reactivity;

		[SerializeField]
		private LifeformDefensiveBehavior defensiveBehavior;

		[SerializeField]
		private float attackDamage;

		[SerializeField]
		private Vector2 timeBetweenAttacks;

		public string Name => null;

		public int Id => 0;

		public LifeformPhylum Phylum => default(LifeformPhylum);

		public RevelationMethod LifeformRevelationMethod => default(RevelationMethod);

		public int DiscoveryReward => 0;

		public bool Draft => false;

		public bool SpawnsDynamically => false;

		public LifeformSpawnType SpawnType => default(LifeformSpawnType);

		public int NumberOfVariants => 0;

		public float MinimumScale => 0f;

		public float MaximumScale => 0f;

		public LifeformHabitat[] Habitats => null;

		public SpawnProbabilityDifficultyBehaviour ProbabilityBehaviour => default(SpawnProbabilityDifficultyBehaviour);

		public int MinimumSpawnDifficulty => 0;

		public int MaximumSpawnDifficulty => 0;

		public int MaximumSpecimensPerChunk => 0;

		public float Speed => 0f;

		public float EnergeticValue => 0f;

		public bool PlayerIsEdible => false;

		public LifeformAttitudeTowardsPlayer AttitudeTowardsPlayer => default(LifeformAttitudeTowardsPlayer);

		public LifeformConfig[] Preys => null;

		public LifeformConfig[] Predators => null;

		public float VisionRange => 0f;

		public float Reactivity => 0f;

		public LifeformDefensiveBehavior DefensiveBehavior => default(LifeformDefensiveBehavior);

		public float AttackDamage => 0f;

		public Vector2 TimeBetweenAttacks => default(Vector2);

		public void SetUniqueId(int uid)
		{
		}

		public void Discover()
		{
		}
	}
}
