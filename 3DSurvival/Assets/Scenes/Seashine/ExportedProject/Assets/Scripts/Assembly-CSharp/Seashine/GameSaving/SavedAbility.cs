using System;

namespace Seashine.GameSaving
{
	[Serializable]
	public class SavedAbility
	{
		public string Name;

		public int Level;

		public int Symbionts;

		public SavedAbility(string name, int level, int symbionts)
		{
		}
	}
}
