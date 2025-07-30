using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PGM : Singleton<PGM>
{
	public ObscuredBool debugMode;

	public bool TargetAmazon;

	public ObscuredBool IsReward;

	private GameObject gameManagerGO;

	private GameManager GManager;

	public ABTester abTester;

	public bool applicationQuitting;

	public ObscuredBool inGame;

	public ObscuredInt gamesPlayed;

	public int InitLoadingTime;

	private GameObject UIRootGO;

	public ObscuredInt menuRedirection;

	public ObscuredFloat LastBalance;

	public ObscuredInt adPopUpTrigger;

	public ObscuredInt ratePopUpTrigger;

	public ObscuredInt curAdPopUpCount;

	public ObscuredInt curRatePopUpCount;

	public ObscuredBool specialReward;

	public ObscuredString LEADERBOARD_ID;

	public ObscuredString AMAZON_LEADERBOARD_ID;

	protected PGM()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public void SubmitScore(int score)
	{
	}

	private void InitGooglePlay()
	{
	}

	public void InitAmazonGameCircle()
	{
	}

	private void serviceNotReadyHandler(string error)
	{
	}

	private void serviceReadyHandler()
	{
	}

	public void RewardPlayer()
	{
	}

	public void AddGamePlayed()
	{
	}
}
