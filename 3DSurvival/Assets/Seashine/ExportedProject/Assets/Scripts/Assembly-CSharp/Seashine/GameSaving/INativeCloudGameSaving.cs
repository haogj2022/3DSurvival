using System;

namespace Seashine.GameSaving
{
	public interface INativeCloudGameSaving
	{
		bool AutosaveV2InCloudIsLaterVersion { get; }

		Action<SavedGame> SaveGameLoaded { get; set; }

		void Initialize(GameDatabase gameDatabase, bool deleteObsoleteCloudData, bool debug);

		void LoadGameFromCloud();

		void SaveGameToCloud(SavedGame savedGame);

		string[] GetAllKeysInCloud();

		string GetStringForKey(string key);

		void SetStringForKey(string key, string value);

		void DeleteObsoleteCloudData();

		void DeleteAllCloudData();
	}
}
