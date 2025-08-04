using UnityEngine;

namespace Seashine.GameSaving
{
	public class SaveGameTesting : MonoBehaviour
	{
		[SerializeField]
		private GameDatabase gameDatabase;

		private GameSaver gameSaver;

		private void Start()
		{
		}

		public void DeleteLocalAutosave()
		{
		}

		public void DeleteAllCloudData()
		{
		}

		public void DeleteBothLocalAndCloudData()
		{
		}

		public void CreateLocalTestLegacySaveData()
		{
		}

		public void DeleteLocalTestLegacySaveData()
		{
		}

		public void CreateCloudTestLegacySaveData()
		{
		}

		public void PrintAllKeysInCloud()
		{
		}

		public void PrintLocalAutosaveJSON()
		{
		}

		public void PrintCloudAutosaveJSON()
		{
		}
	}
}
