using System;
using Seashine.WorldGeneration;
using UnityEngine;

[Serializable]
public class ChunkVaryingArea
{
	[SerializeField]
	private ChunkVaryingAreaVariant[] areaVariants;

	public ChunkVaryingArea(ChunkVaryingAreaVariant[] variants)
	{
	}

	public ChunkVaryingAreaVariant[] GetAreaVariants()
	{
		return null;
	}

	public ChunkSpawnpoints PickVariant(int currentDifficulty, bool zenModeActive)
	{
		return null;
	}
}
