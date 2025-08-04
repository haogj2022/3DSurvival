using System;
using System.Collections.Generic;
using Pated.Native.iOS;

namespace Seashine.GameSaving
{
	public class iCloudGameSaving : INativeCloudGameSaving
	{
		private bool debugMode;

		private iCloudKeyValueStorage kvs;

		private List<string> legacyCloudSaveDataKeys;

		private GameDatabase _gameDatabase;

		private bool deleteObsoleteSaveData;

		public Action<SavedGame> SaveGameLoaded { get; set; }

		public bool AutosaveV2InCloudIsLaterVersion { get; private set; }

		public void Initialize(GameDatabase gameDatabase, bool deleteObsoleteData, bool debug)
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

		public void SetStringForKey(string key, string value)
		{
		}

		public void DeleteObsoleteCloudData()
		{
		}

		public void DeleteAllCloudData()
		{
		}

		private void OniCloudKVSDidChangeExternally(List<iCloudData> changedData)
		{
		}
	}
}
