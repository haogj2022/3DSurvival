using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Seashine.Core;
using Seashine.WorldGeneration;
using UnityEngine;

[RequireComponent(typeof(AdManager))]
[RequireComponent(typeof(PerformanceMonitor))]
[RequireComponent(typeof(AbilityManager))]
[RequireComponent(typeof(Localizer))]
public class GameManager : MonoBehaviour
{
	public delegate void GameEvent();

	[CompilerGenerated]
	private sealed class _003CInGameTimer_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameManager _003C_003E4__this;

		private int _003CtimeToNextMinute_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CInGameTimer_003Ed__106(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static GameManager _instance;

	[HideInInspector]
	public PGM PGM_Instance;

	[HideInInspector]
	public ObscuredBool debugMode;

	[SerializeField]
	private GameDatabase gameDatabase;

	public AdManager adManager;

	public ExplorationManager explorationManager;

	public Localizer localizer;

	public SecuredTime securedTime;

	public UserInterfaceController userInterfaceController;

	public IncentiveManager incentiveManager;

	public ScreenshotController screenshotController;

	public TutorialManager tutorialManager;

	public MusicController musicController;

	[Space(10f)]
	public LayerMask wallLayers;

	[Header("PLAYER")]
	public Jelly PlayerScript;

	public Transform Player;

	public GameObject Egg;

	private bool eggActive;

	[HideInInspector]
	public DeathType causeOfDeath;

	[HideInInspector]
	public Camera mainCamera;

	[HideInInspector]
	public GameCamera mainCameraScript;

	private bool checkConnectorsLoading;

	[HideInInspector]
	public List<GameObject> activeChunks;

	[HideInInspector]
	public int curChunkCount;

	private GameObject newChunk;

	private GameObject previousChunk;

	[HideInInspector]
	public string currentChunk;

	[HideInInspector]
	public string lastChunk;

	[HideInInspector]
	public List<Transform> activeFauna;

	[HideInInspector]
	public List<Transform> activeElements;

	public Transform activeDungeon;

	[HideInInspector]
	public bool bulbFishDiscovered;

	[HideInInspector]
	public ObscuredInt curScore;

	[HideInInspector]
	public ObscuredInt bestScore;

	[HideInInspector]
	public ObscuredInt Difficulty;

	[HideInInspector]
	public ObscuredInt starsCollected;

	[HideInInspector]
	public bool showGameOver;

	[HideInInspector]
	public ObscuredBool gameOver;

	[HideInInspector]
	public ObscuredInt TimePlayed;

	[HideInInspector]
	public ObscuredBool playing;

	[HideInInspector]
	public ObscuredBool hasWatchedAdIncentive;

	[HideInInspector]
	public ObscuredInt sessionGames;

	public Action OnNewGame;

	public GameEvent OnGameOver;

	public GameEvent OnGameRestart;

	public GameEvent OnGameReset;

	public GameEvent OnTeleportation;

	public GameEvent OnRevive;

	public Action<Vector2> OnLoadDungeon;

	public Action OnDungeonDoorTriggered;

	public Action OnEnterDungeon;

	public Action OnExitDungeon;

	public Action OnUnloadDungeon;

	private bool newHighscore;

	public bool gamePaused;

	private int lastIncentiveTime;

	private int hasLikedOnFacebook;

	private int hasFollowedOnTwitter;

	private int selectedIncentive;

	[HideInInspector]
	public ObscuredBool starDoublerEnabled;

	[HideInInspector]
	[Header("BUILDER")]
	public bool waitingForRestart;

	public bool waitingForRestartInterstitial;

	public float restartInterstitialLaunchTime;

	public bool hasReportedNoviceSurvivorAchievement;

	public bool hasReportedVeteranSurvivorAchievement;

	public bool hasReportedEliteSurvivorAchievement;

	public ABTester abTester;

	[HideInInspector]
	public int gameoverAdBtnState;

	private string rateTTL;

	private string rateText;

	private string yes;

	private string no;

	private string later;

	private int lastRateTime;

	[HideInInspector]
	public ObscuredBool hasRated;

	public Vector3 LastSafeRevivePosition;

	public static GameManager Instance => null;

	public bool GameRunning { get; private set; }

	public GameDatabase GameDatabase => null;

	public ChunkLoader ChunkLoader { get; private set; }

	public Wildlife Wildlife { get; private set; }

	public bool ApplicationIsQuittingOrPausing { get; private set; }

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void InitializeCoreSystems()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void StoreAppExitAnalytics()
	{
	}

	private void ReportAppExitAnalytics()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CInGameTimer_003Ed__106))]
	private IEnumerator InGameTimer()
	{
		return null;
	}

	private void ClearUnusedAssets()
	{
	}

	public void Restart()
	{
	}

	public void CheckSafeRestart()
	{
	}

	private void ResetEverything()
	{
	}

	private void InitSocialInterface()
	{
	}

	public void GameOver()
	{
	}

	public void Revive()
	{
	}

	public void GiveStars(ObscuredInt amount)
	{
	}

	public void IncreaseScore()
	{
	}

	public void PauseGame()
	{
	}

	public void ResumeGame()
	{
	}
}
