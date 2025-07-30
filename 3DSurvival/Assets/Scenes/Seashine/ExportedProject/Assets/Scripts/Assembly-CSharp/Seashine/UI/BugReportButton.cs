using Seashine.GameSaving;
using UnityEngine;

namespace Seashine.UI
{
	public class BugReportButton : MonoBehaviour
	{
		[SerializeField]
		private GameObject reportButton;

		[SerializeField]
		private GameObject closeButton;

		[SerializeField]
		private GameObject background;

		private bool srDebuggerIsInitiated;

		private bool bugReportPanelOpen;

		private GameSaver gameSaver;

		private bool gameWasAlreadyPaused;

		private void Start()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void ShowBugReportSheet()
		{
		}

		private void OnBugReportClosed(bool success)
		{
		}

		private void LogGeneralInformationOnGameState()
		{
		}

		private void InitializeDebugger()
		{
		}
	}
}
