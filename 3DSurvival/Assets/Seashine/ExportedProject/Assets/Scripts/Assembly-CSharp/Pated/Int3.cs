using System;
using UnityEngine;

namespace Pated
{
	[Serializable]
	public struct Int3
	{
		public int x;

		public int y;

		public int z;

		public const int Precision = 1000;

		public const float FloatPrecision = 1000f;

		public const float PrecisionFactor = 0.001f;

		public int this[int i] => 0;

		public float magnitude => 0f;

		public int costMagnitude => 0;

		public float worldMagnitude => 0f;

		public float sqrMagnitude => 0f;

		public int unsafeSqrMagnitude => 0;

		[Obsolete("Same implementation as .magnitude")]
		public float safeMagnitude => 0f;

		[Obsolete(".sqrMagnitude is now per default safe (.unsafeSqrMagnitude can be used for unsafe operations)")]
		public float safeSqrMagnitude => 0f;

		public Int3(Vector3 position)
		{
			x = 0;
			y = 0;
			z = 0;
		}

		public Int3(int _x, int _y, int _z)
		{
			x = 0;
			y = 0;
			z = 0;
		}

		public static bool operator ==(Int3 lhs, Int3 rhs)
		{
			return false;
		}

		public static bool operator !=(Int3 lhs, Int3 rhs)
		{
			return false;
		}

		public static explicit operator Int3(Vector3 ob)
		{
			return default(Int3);
		}

		public static explicit operator Vector3(Int3 ob)
		{
			return default(Vector3);
		}

		public static Int3 operator -(Int3 lhs, Int3 rhs)
		{
			return default(Int3);
		}

		public static Int3 operator +(Int3 lhs, Int3 rhs)
		{
			return default(Int3);
		}

		public static Int3 operator *(Int3 lhs, int rhs)
		{
			return default(Int3);
		}

		public static Int3 operator *(Int3 lhs, float rhs)
		{
			return default(Int3);
		}

		public static Int3 operator *(Int3 lhs, Vector3 rhs)
		{
			return default(Int3);
		}

		public static Int3 operator /(Int3 lhs, float rhs)
		{
			return default(Int3);
		}

		public static int Dot(Int3 lhs, Int3 rhs)
		{
			return 0;
		}

		public Int3 NormalizeTo(int newMagn)
		{
			return default(Int3);
		}

		public static implicit operator string(Int3 ob)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
