using System.Collections.Generic;
using UnityEngine;

namespace Pated.Extensions
{
	public static class Vector3Extensions
	{
		public static Vector2 xy(this Vector3 v)
		{
			return default(Vector2);
		}

		public static Vector3 WithX(this Vector3 v, float x)
		{
			return default(Vector3);
		}

		public static Vector3 WithY(this Vector3 v, float y)
		{
			return default(Vector3);
		}

		public static Vector3 WithZ(this Vector3 v, float z)
		{
			return default(Vector3);
		}

		public static Vector2 WithX(this Vector2 v, float x)
		{
			return default(Vector2);
		}

		public static Vector2 WithY(this Vector2 v, float y)
		{
			return default(Vector2);
		}

		public static Vector3 WithZ(this Vector2 v, float z)
		{
			return default(Vector3);
		}

		public static Vector3 NearestPointOnAxis(this Vector3 axisDirection, Vector3 point, bool isNormalized = false)
		{
			return default(Vector3);
		}

		public static Vector3 NearestPointOnLine(this Vector3 lineDirection, Vector3 point, Vector3 pointOnLine, bool isNormalized = false)
		{
			return default(Vector3);
		}

		public static Vector3 GetClosestPosition(this Vector3 position, IEnumerable<Vector3> otherPositions)
		{
			return default(Vector3);
		}

		public static Transform GetClosestTransform(this Vector3 position, IEnumerable<Transform> otherTransforms)
		{
			return null;
		}

		public static List<Transform> GetTransformsInRange(this Vector3 position, IEnumerable<Transform> otherTransforms, float range)
		{
			return null;
		}
	}
}
