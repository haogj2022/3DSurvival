namespace Seashine.GameSaving
{
	public class CloudSaver
	{
		public bool IsInitialized;

		private INativeCloudGameSaving nativeCloudGameSaving;

		private bool debugMode;

		public CloudSaver(GameSaver gameSaver, GameDatabase gameDatabase, bool deleteObsoleteCloudData, bool debugMode)
		{
		}

		public void LoadGameFromCloud()
		{
		}

		public void SaveGameToCloud(SavedGame savedGame)
		{
		}

		public string[] GetAllKeysInCloud()
		{
			return null;
		}

		public string GetStringForKey(string key)
		{
			return null;
		}

		public void PrintValueForKey(string key)
		{
		}

		public void SetStringForKey(string key, string value)
		{
		}

		public void DeleteAllCloudData()
		{
		}
	}
}
