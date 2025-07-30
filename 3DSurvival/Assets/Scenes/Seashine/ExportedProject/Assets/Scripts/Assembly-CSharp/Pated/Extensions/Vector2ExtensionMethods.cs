using System.Collections.Generic;
using UnityEngine;

namespace Pated.Extensions
{
	public static class Vector2ExtensionMethods
	{
		public static List<Transform> GetTransformsInRange(this Vector2 position, IEnumerable<Transform> otherTransforms, float range)
		{
			return null;
		}

		public static bool InRangeOf(this Vector2 position, Vector2 otherPosition, float range)
		{
			return false;
		}
	}
}
