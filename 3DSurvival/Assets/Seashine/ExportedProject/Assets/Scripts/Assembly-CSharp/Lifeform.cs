using System;

[Serializable]
public class Lifeform
{
	public string name;

	public int SUID;

	public WildlifeCategory category;

	public int foodChainLevel;

	public bool dynamicSpawn;

	public bool attached;

	public int variants;

	public float minimumSize;

	public float maximumSize;

	public float rarity;

	public bool matchDifficulty;

	public int minimumDifficulty;

	public int maximumDifficulty;

	public int maximumPerChunk;

	public RevelationMethod revelationMethod;

	public int discoveryReward;

	public bool specialDiscoveryMethod;

	public int[] biomeIds;
}
