using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

namespace Seashine.UI
{
	public class TitleActivatorCodesManager : MonoBehaviour
	{
		private string currentInput;

		private const string CODE_ANANAS = "ananas";

		private const string CODE_ASSASSIN = "assassin";

		[SerializeField]
		private BugReportButton bugReportButton;

		public void OnTitleLetterTap(string letter)
		{
		}

		private void CheckForValidCode()
		{
		}

		private void OnSavedGameSelected(SelectUIStatus arg1, ISavedGameMetadata arg2)
		{
		}

		private bool InputIs(string code)
		{
			return false;
		}
	}
}
