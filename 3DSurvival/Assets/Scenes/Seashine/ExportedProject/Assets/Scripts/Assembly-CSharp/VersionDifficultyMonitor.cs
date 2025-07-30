using UnityEngine;

public class VersionDifficultyMonitor : MonoBehaviour
{
	private GameManager gameManager;

	[SerializeField]
	private JellyfishManager jellyfishManager;

	private string fileName;

	private string filePath;

	private VersionDifficultyMonitoring versionDifficultyMonitoring;

	private int starCountAtNewGame;

	private float newGameStartTime;

	private void Start()
	{
	}

	private void OnNewGame()
	{
	}

	private void OnGameOver()
	{
	}

	public void ResetMonitoring()
	{
	}

	public void LoadFromFile()
	{
	}

	public void SaveNewPointsAndStarsPerMinute(string jellyfishName, int points, int stars, float durationInSeconds)
	{
	}

	public void PrintVersionDifficultyMonitoring()
	{
	}
}
