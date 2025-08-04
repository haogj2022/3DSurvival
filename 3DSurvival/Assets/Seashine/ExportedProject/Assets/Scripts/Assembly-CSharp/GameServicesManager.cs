using System;
using Seashine.GameSaving;
using UnityEngine;

public class GameServicesManager : MonoBehaviour
{
	[SerializeField]
	private GameManager gameManager;

	private GameSaver gameSaver;

	[SerializeField]
	private bool debugMode;

	public Action OnPlayerLogInSuccess;

	public Action OnPlayerLogInFailed;

	public Action OnPlayerLogOut;

	private string LEADERBOARD_ID;

	public bool IsPlayerLoggedIn => false;

	private void Start()
	{
	}

	private void InitializeGooglePlayGames()
	{
	}

	public void LogIn()
	{
	}

	public void LogOut()
	{
	}

	private void GooglePlayGamesLogIn()
	{
	}

	private void AppleGameCenterLogIn()
	{
	}

	public void ShowLeaderboard()
	{
	}

	public void ShowAchievements()
	{
	}
}
