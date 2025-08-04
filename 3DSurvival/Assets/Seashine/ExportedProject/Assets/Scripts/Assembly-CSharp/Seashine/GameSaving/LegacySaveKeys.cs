using System.Collections.Generic;

namespace Seashine.GameSaving
{
	public static class LegacySaveKeys
	{
		public static readonly HashSet<string> Fauna;

		public static readonly HashSet<string> Flora;

		public static readonly HashSet<string> Jellyfishes;

		public static readonly HashSet<string> Abilities;

		public static readonly Dictionary<string, string> AbilityNamesByID;

		public const string AbilityAntidoteID = "AP";

		public const string AbilityAntiparasiteID = "APa";

		public const string AbilityLightBoostID = "LB";

		public const string AbilityMagnetID = "PM";

		public const string AbilityShockwaveID = "SW";

		public const string AbilitySpeedBoostID = "SB";

		public const string AbilityStunID = "SF";

		public const string AbilitySupersenseID = "SS";

		public const string NEW_RANGARANGA_KEY = "Rangaranga";

		public const string OLD_RANGARANGA_KEY = "RangaRanga";

		public const string BestScore = "BS";

		public const string GamesPlayed = "GP";

		public const string TimePlayed = "TP";

		public const string ThirdAbilitySlotUnlocked = "TASU";

		public const string TUTORIAL_ACTIVE = "TA";

		public const string TUTORIAL_HUMENGANUI = "TutorialHumenganui";
	}
}
