using System;
using UnityEngine;

namespace Pated
{
	[Serializable]
	public struct Int2
	{
		public int x;

		public int y;

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

		public Int2(Vector2 position)
		{
			x = 0;
			y = 0;
		}

		public Int2(int _x, int _y)
		{
			x = 0;
			y = 0;
		}

		public static bool operator ==(Int2 lhs, Int2 rhs)
		{
			return false;
		}

		public static bool operator !=(Int2 lhs, Int2 rhs)
		{
			return false;
		}

		public static explicit operator Int2(Vector2 ob)
		{
			return default(Int2);
		}

		public static explicit operator Vector2(Int2 ob)
		{
			return default(Vector2);
		}

		public static Int2 operator -(Int2 lhs, Int2 rhs)
		{
			return default(Int2);
		}

		public static Int2 operator +(Int2 lhs, Int2 rhs)
		{
			return default(Int2);
		}

		public static Int2 operator *(Int2 lhs, int rhs)
		{
			return default(Int2);
		}

		public static Int2 operator *(Int2 lhs, float rhs)
		{
			return default(Int2);
		}

		public static Int2 operator *(Int2 lhs, Vector2 rhs)
		{
			return default(Int2);
		}

		public static Int2 operator /(Int2 lhs, float rhs)
		{
			return default(Int2);
		}

		public static int Dot(Int2 lhs, Int2 rhs)
		{
			return 0;
		}

		public Int2 NormalizeTo(int newMagn)
		{
			return default(Int2);
		}

		public static implicit operator string(Int2 ob)
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
