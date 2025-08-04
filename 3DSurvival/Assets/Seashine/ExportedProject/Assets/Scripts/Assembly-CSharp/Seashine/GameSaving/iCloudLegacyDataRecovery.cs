using System.Collections.Generic;

namespace Seashine.GameSaving
{
	public class iCloudLegacyDataRecovery
	{
		public static SavedGame RecoverLegacyICloudSavedData(string[] allKeysInKVS, bool deleteObsoleteKeys, out List<string> obsoleteKeysToDelete, bool debugMode)
		{
			obsoleteKeysToDelete = null;
			return null;
		}

		private static bool IsOldRangarangaKey(string s)
		{
			return false;
		}
	}
}
