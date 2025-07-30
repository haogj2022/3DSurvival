using UnityEngine;

namespace Pated.GameServices
{
	[CreateAssetMenu(fileName = "NewGameServicesConfig", menuName = "Gameservices/Config", order = 2)]
	public class GameServicesConfig : ScriptableObject
	{
		[SerializeField]
		private AndroidGameServicesProvider androidGameServicesPlatform;

		[Header("iOS")]
		[SerializeField]
		private string gameCenterLeaderboardId;

		[SerializeField]
		[Header("Android")]
		private string googlePlayLeaderboardId;

		public AndroidGameServicesProvider AndroidGameServicesPlatform => default(AndroidGameServicesProvider);

		public string LeaderboardId => null;
	}
}
