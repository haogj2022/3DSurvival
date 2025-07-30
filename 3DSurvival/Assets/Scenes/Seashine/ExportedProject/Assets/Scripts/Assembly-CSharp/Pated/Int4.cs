using System;
using UnityEngine;

namespace Pated
{
	[Serializable]
	public struct Int4
	{
		public int x;

		public int y;

		public int z;

		public int w;

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

		public Int4(Vector4 v4)
		{
			x = 0;
			y = 0;
			z = 0;
			w = 0;
		}

		public Int4(int _x, int _y, int _z, int _w)
		{
			x = 0;
			y = 0;
			z = 0;
			w = 0;
		}

		public static bool operator ==(Int4 lhs, Int4 rhs)
		{
			return false;
		}

		public static bool operator !=(Int4 lhs, Int4 rhs)
		{
			return false;
		}

		public static explicit operator Int4(Vector4 ob)
		{
			return default(Int4);
		}

		public static explicit operator Vector3(Int4 ob)
		{
			return default(Vector3);
		}

		public static Int4 operator -(Int4 lhs, Int4 rhs)
		{
			return default(Int4);
		}

		public static Int4 operator +(Int4 lhs, Int4 rhs)
		{
			return default(Int4);
		}

		public static Int4 operator *(Int4 lhs, int rhs)
		{
			return default(Int4);
		}

		public static Int4 operator *(Int4 lhs, float rhs)
		{
			return default(Int4);
		}

		public static Int4 operator *(Int4 lhs, Vector3 rhs)
		{
			return default(Int4);
		}

		public static Int4 operator /(Int4 lhs, float rhs)
		{
			return default(Int4);
		}

		public static int Dot(Int4 lhs, Int4 rhs)
		{
			return 0;
		}

		public Int4 NormalizeTo(int newMagn)
		{
			return default(Int4);
		}

		public static implicit operator string(Int4 ob)
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
