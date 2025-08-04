using System.Collections.Generic;

namespace Pated.Extensions
{
	public static class ListExtensions
	{
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		public static T RandomItem<T>(this IList<T> list)
		{
			return default(T);
		}

		public static T RemoveRandom<T>(this IList<T> list)
		{
			return default(T);
		}

		public static void AddRangeOfDerived<TList, TOther>(this List<TList> list, IEnumerable<TOther> collection) where TOther : TList
		{
		}

		public static bool AddWithoutDuplicates<T>(this IList<T> list, T item)
		{
			return false;
		}
	}
}
