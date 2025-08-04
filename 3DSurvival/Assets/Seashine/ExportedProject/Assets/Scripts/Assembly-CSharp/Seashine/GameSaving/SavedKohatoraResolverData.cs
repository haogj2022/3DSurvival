using System.Collections.Generic;

namespace Seashine.GameSaving
{
	public class SavedKohatoraResolverData
	{
		private Dictionary<string, int> maxOfTypeInCurrentAppVersion;

		private HashSet<string> unlockablesInCurrentAppVersion;

		public Dictionary<string, KohatoraRecipe> KohatoraRecipeByUnlockable { get; private set; }

		public List<string> UnusedPieces { get; private set; }

		public Dictionary<string, string> TypeByPiece { get; private set; }

		public Dictionary<string, List<string>> UnusedPiecesByType { get; private set; }

		public List<SavedKohatoraUnlockToSolve> UnlocksToSolve { get; private set; }

		public Dictionary<string, SavedKohatoraUnlockToSolve> UnlocksToSolveByUnlockable { get; private set; }

		public SavedKohatoraResolverData(GameDatabase gameDatabase)
		{
		}

		public void Append(SavedGame savedGame)
		{
		}

		private void RemoveUnlockableFromSavedGame(SavedGame savedGame, SavedKohatora piece)
		{
		}
	}
}
