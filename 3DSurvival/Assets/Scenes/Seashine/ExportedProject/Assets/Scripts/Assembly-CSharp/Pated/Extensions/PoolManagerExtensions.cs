using System.Collections.Generic;
using PathologicalGames;
using UnityEngine;

namespace Pated.Extensions
{
	public static class PoolManagerExtensions
	{
		public static Transform TrySpawn(this SpawnPool spawnPool, string name)
		{
			return null;
		}

		public static Transform TrySpawn(this SpawnPool spawnPool, string name, Vector3 pos)
		{
			return null;
		}

		public static Transform TrySpawn(this SpawnPool spawnPool, string name, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public static Transform TrySpawn(this SpawnPool spawnPool, string name, Vector3 pos, Quaternion rot, Vector3 scale)
		{
			return null;
		}

		public static Transform TrySpawn(this SpawnPool spawnPool, Transform t)
		{
			return null;
		}

		public static void TrySpawn(this SpawnPool spawnPool, Transform t, Transform parent)
		{
		}

		public static void TrySpawn(this SpawnPool spawnPool, Transform t, Vector3 pos, Quaternion rot)
		{
		}

		public static void TryDespawn(this SpawnPool spawnPool, List<Transform> list)
		{
		}

		public static void DespawnList(this SpawnPool spawnPool, List<Transform> list)
		{
		}

		public static void DespawnInArea(this SpawnPool spawnPool, Rect area)
		{
		}

		public static void DespawnInAreaExcept(this SpawnPool spawnPool, Rect area, HashSet<Transform> exceptions)
		{
		}
	}
}
