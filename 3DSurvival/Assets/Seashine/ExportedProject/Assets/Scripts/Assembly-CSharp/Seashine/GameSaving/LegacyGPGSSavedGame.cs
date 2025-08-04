using System;
using System.Collections.Generic;

namespace Seashine.GameSaving
{
	[Serializable]
	public class LegacyGPGSSavedGame
	{
		public int survivalHighscore;

		public string[] unlockedJellyfishes;

		public string[] unlockedAbilities;

		public bool thirdAbilitySlotUnlocked;

		public string[] discoveredFauna;

		public string[] discoveredFlora;

		public Dictionary<string, int> discoveredKohatora;

		public static byte[] ToBytes(SavedGame data)
		{
			return null;
		}

		public static SavedGame FromBytes(byte[] data)
		{
			return null;
		}
	}
}
