using System.Collections.Generic;

namespace Seashine.GameSaving
{
	public class SavedKohatoraConflictResolution
	{
		public static List<SavedKohatora> ResolveConflicts(SavedGame savedGame, SavedGame savedGameToAppend, GameDatabase gameDatabase, bool debugMode)
		{
			return null;
		}

		private static List<SavedKohatora> ResolveUnlocks(SavedKohatoraResolverData resolverData, SavedGame savedGame, SavedGame savedGameToAppend, bool debugMode)
		{
			return null;
		}

		private static void AddUnlockToSaveGame(string unlockable, int unlockType, SavedGame savedGame, bool debugMode)
		{
		}

		private static void RemoveUnlockFromBothSaveGames(string unlockable, int unlockType, SavedGame savedGame, SavedGame savedGameToAppend, bool debugMode)
		{
		}
	}
}
