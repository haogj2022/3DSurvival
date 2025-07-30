using System;
using System.Collections.Generic;

namespace Seashine.GameSaving
{
	[Serializable]
	public class SavedGame
	{
		public int Version;

		public int Highscore;

		public List<string> UnlockedJellyfishes;

		public List<SavedAbility> Abilities;

		public int UsableAbilitySlots;

		public List<SavedKohatora> Kohatoras;

		public List<string> DiscoveredLifeforms;

		public List<string> Alterations;

		public List<string> Tutorials;

		public List<string> Other;

		[NonSerialized]
		private Dictionary<string, SavedKohatora> kohatorasByID;

		[NonSerialized]
		public Dictionary<string, SavedAbility> abilitiesByName;

		public SavedGame()
		{
		}

		public SavedGame(int highscore, List<string> unlockedJellyfishes, List<SavedKohatora> savedKohatoras, List<SavedAbility> savedAbilities, int usableAbilitySlots, List<string> discoveredLifeforms, List<string> tutorials)
		{
		}

		public bool SaveHighscore(int newHighscore)
		{
			return false;
		}

		public bool SaveUnlockedJellyfish(string jellyfishName)
		{
			return false;
		}

		public bool SaveDiscoveredLifeform(string discoveredLifeformName)
		{
			return false;
		}

		public bool IsLifeformDiscovered(string lifeformName)
		{
			return false;
		}

		public bool SaveAbility(string abilityName, int level, int symbionts)
		{
			return false;
		}

		public bool IsAbilityUnlocked(string abilityName)
		{
			return false;
		}

		public SavedKohatora GetSavedKohatora(string kohatoraID)
		{
			return null;
		}

		public string SaveNewKohatora(string type)
		{
			return null;
		}

		public string SaveNewKohatoraWithUsage(string type, int usageType, string usedBy)
		{
			return null;
		}

		public bool SaveKohatoraUsage(string UID, int usageType, string usedBy)
		{
			return false;
		}

		public bool SaveTutorial(string tutorial)
		{
			return false;
		}

		public bool IsEmpty()
		{
			return false;
		}

		public bool Append(SavedGame savedGameToAppend, GameDatabase gameDatabase, bool debugMode)
		{
			return false;
		}
	}
}
