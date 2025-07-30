using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using GooglePlayGames.BasicApi.SavedGame;

namespace Seashine.GameSaving
{
	public class GPGSGameSaving : INativeCloudGameSaving
	{
		private enum GPGSGameSavingState
		{
			IsLoadingLegacyAutosave = 0,
			IsLoadingAutosaveV2 = 1,
			IsSaving = 2,
			IsIdle = 3
		}

		private bool debugMode;

		private GameDatabase _gameDatabase;

		private bool deleteObsoleteSavedGames;

		private List<SavedGame> loadedSavedGames;

		private int finishedLoading;

		private ISavedGameMetadata legacySaveDataToDelete;

		private SavedGame gameToSave;

		private LegacyGPGSSavedGame legacyGameToSave;

		private GPGSGameSavingState state;

		private bool printOnly;

		private string keyToPrint;

		private BinaryFormatter binaryFormatter;

		public Action<SavedGame> SaveGameLoaded { get; set; }

		public bool AutosaveV2InCloudIsLaterVersion { get; private set; }

		public void Initialize(GameDatabase gameDatabase, bool deleteObsoleteCloudData, bool debug)
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

		private void OnSavedGameSelected(SelectUIStatus status, ISavedGameMetadata game)
		{
		}

		public void SaveTestLegacySavedGame(LegacyGPGSSavedGame testLegacySavedGame)
		{
		}

		public string GetStringForKey(string key)
		{
			return null;
		}

		public void SetStringForKey(string key, string value)
		{
		}

		public void PrintValueForKey(string key)
		{
		}

		public void DeleteObsoleteCloudData()
		{
		}

		public void DeleteAllCloudData()
		{
		}

		private void OpenGPGSSavegame(string savegameName)
		{
		}

		private void OnGPGSSavegameOpened(SavedGameRequestStatus status, ISavedGameMetadata saveData)
		{
		}

		public void OnGPGSSavedGameWritten(SavedGameRequestStatus status, ISavedGameMetadata saveData)
		{
		}

		public void OnGPGSSavedGameRead(SavedGameRequestStatus status, byte[] data)
		{
		}

		private void ProcessLoadedGame(SavedGame savedGame)
		{
		}
	}
}
