using System;

namespace Seashine.GameSaving
{
	[Serializable]
	public class SavedKohatora
	{
		public string UID;

		public string Type;

		public int UsageType;

		public long UseDate;

		public string UsedBy;

		public SavedKohatora(string uid, string type)
		{
		}

		public SavedKohatora(string uid, string type, int usageType, long useDate, string usedBy)
		{
		}
	}
}
