using System.Collections.Generic;
using UnityEngine;

namespace Pated.Extensions
{
	public static class TransformExtensions
	{
		public static void AddChildren(this Transform transform, GameObject[] children)
		{
		}

		public static void AddChildren(this Transform transform, Component[] children)
		{
		}

		public static List<Transform> GetChildren(this Transform parentTransform)
		{
			return null;
		}

		public static void ResetChildPositions(this Transform transform, bool recursive = false)
		{
		}

		public static void SetChildLayers(this Transform transform, string layerName, bool recursive = false)
		{
		}

		private static void SetChildLayersHelper(Transform transform, int layer, bool recursive)
		{
		}

		public static void SetX(this Transform transform, float x)
		{
		}

		public static void SetY(this Transform transform, float y)
		{
		}

		public static void SetZ(this Transform transform, float z)
		{
		}
	}
}
