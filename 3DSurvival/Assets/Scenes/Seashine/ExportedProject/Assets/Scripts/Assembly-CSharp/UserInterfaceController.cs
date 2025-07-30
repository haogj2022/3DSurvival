using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using Seashine.GameSaving;
using UnityEngine;

public class UserInterfaceController : MonoBehaviour
{
	public enum MenuType
	{
		main = 0,
		inGame = 1,
		pause = 2,
		screenshot = 3,
		gameOver = 4,
		deathScreenshot = 5,
		abilities = 6,
		shop = 7,
		options = 8,
		credits = 9,
		incentive = 10,
		googlePlayConnect = 11,
		encyclopedia = 12,
		jellyfishes = 13,
		revive = 14
	}

	[CompilerGenerated]
	private sealed class _003CDestroyLogo_003Ed__141 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserInterfaceController _003C_003E4__this;

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
		public _003CDestroyLogo_003Ed__141(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CDisplayScore_003Ed__171 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserInterfaceController _003C_003E4__this;

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
		public _003CDisplayScore_003Ed__171(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUpdateReviveCountdownLabel_003Ed__200 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public UserInterfaceController _003C_003E4__this;

		private int _003CremainingSeconds_003E5__2;

		float IEnumerator<float>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0f;
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
		public _003CUpdateReviveCountdownLabel_003Ed__200(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUnlockControlsDelayed_003Ed__223 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserInterfaceController _003C_003E4__this;

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
		public _003CUnlockControlsDelayed_003Ed__223(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAnimateScore_003Ed__232 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserInterfaceController _003C_003E4__this;

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
		public _003CAnimateScore_003Ed__232(int _003C_003E1__state)
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

	[SerializeField]
	private bool debugMode;

	[SerializeField]
	private GameManager gameManager;

	[SerializeField]
	private Localizer localizer;

	[HideInInspector]
	public PGM PGM_Instance;

	private InAppPurchaseManager inAppPurchaseManagerInstance;

	private TutorialManager tutorialManager;

	private GameSaver gameSaver;

	[SerializeField]
	private GameServicesManager gameServicesManager;

	[SerializeField]
	private UIRoot nguiUIRoot;

	private float endGameStars;

	private Vector3 vector3AlmostZero;

	private float windowTweenSpeed;

	[SerializeField]
	private Camera nguiCamera;

	private Vector3 correctedWindowScale;

	[SerializeField]
	private GameObject visibilityReductionMask;

	[Header("GENERAL UI")]
	[Space(20f)]
	public GameObject patedLogo;

	public UIFont fontBridge;

	public UISprite blackMaskSprite;

	private GameObject blackMask;

	private Tween blackMaskTween;

	[HideInInspector]
	public ObscuredBool ControlsLocked;

	[HideInInspector]
	public ObscuredBool UILock;

	[HideInInspector]
	public MenuType activeMenu;

	public MenuType lastMenu;

	[Header("MAIN MENU")]
	public GameObject MainMenu;

	public Transform mainTitle;

	public Transform mainMenuButtons;

	[HideInInspector]
	public Vector3 mainTitleBasePosition;

	private MainMenu mainMenuScript;

	[Header("BALANCE")]
	public GameObject balance;

	public Transform balanceTsfm;

	private Tween balanceTween;

	[Header("JELLYFISH")]
	public GameObject jellyfishWindow;

	private Transform jellyfishWindowTsfm;

	[Header("IN-GAME UI")]
	public GameObject InGamePanel;

	public UISprite energyBar;

	public UISprite energyBarBgrd;

	public UILabel scoreLbl;

	public StarButton starButton;

	public Transform pauseButton;

	public UISprite collectedStar;

	public Transform discoveryNotificationTsfm;

	private TweenScale energyBarTween;

	private GameObject starButtonGO;

	private Transform collectedStarTsfm;

	private GameObject collectedStarGO;

	[Header("PAUSE")]
	public GameObject PausePanel;

	public Transform pauseResumeBtn;

	public GameObject pauseWindowNormalBtns;

	public GameObject tutorialPauseButtons;

	[Header("OPTIONS")]
	public GameObject OptionsWindow;

	private Transform optionsWindowTfm;

	public UISprite optionWindowBgrd;

	public UISlider musicSlider;

	public UISlider sfxSlider;

	public UIToggle androidVibrationToggle;

	private bool musicMuted;

	private bool sfxMuted;

	public GameObject optionsSignIn;

	public GameObject optionsSignInButton;

	public GameObject optionsSignInLoadingIndicator;

	public GameObject optionsServiceButtons;

	[Header("GOOGLE PLAY CONNECT")]
	public GameObject ConnectBtnGPGS;

	public GameObject LoadingIndicatorGPGS;

	public GameObject GooglePlayServicesIcon;

	[Header("REVIVE")]
	public GameObject reviveWindow;

	public Transform reviveWindowTsfm;

	public UILabel reviveCountdownLbl;

	private float reviveExpirationTime;

	[Header("GAMEOVER")]
	public GameObject GameOverPanel;

	public UISprite gameOverWindowBgrd;

	public UILabel GameOverScoreLbl;

	public GameObject bestScoreD;

	public GameObject newHighscoreD;

	public UILabel bestScoreLbl;

	public UILabel starsWonLabel;

	public Transform gameOverScreenshotBtn;

	public GameObject gameoverWatchAdButton;

	public GameObject showReplayBtn;

	private bool hasClickedScreenshotBtn;

	private Tween gameOverStarsTween;

	[HideInInspector]
	public ObscuredBool watchAdBtnEnabled;

	[HideInInspector]
	public ObscuredInt gameoverAdTotal;

	[HideInInspector]
	public ObscuredInt gameoverAdCountdown;

	[Header("RATE POP-UP")]
	public GameObject ratePopUpGO;

	private Transform ratePopUpTsfm;

	private int totalRatePopUps;

	[Header("RESTART INCENTIVE")]
	public GameObject IncentiveWindow;

	public UILabel IncentiveLbl;

	public UILabel IncentiveRewardLbl;

	private float timeBeforeAnswer;

	[HideInInspector]
	public ObscuredFloat adCooldown;

	private int lastIncentiveTime;

	private int incentiveInterval;

	private int hasLikedOnFacebook;

	private int hasFollowedOnTwitter;

	private int selectedIncentive;

	[HideInInspector]
	public ObscuredBool hasWatchedAdIncentive;

	[Header("SHOP")]
	public GameObject ShopWindow;

	private Transform shopWindowTfm;

	public UILabel shopStarsLbl;

	public GameObject restorePurchaseBtn;

	[Header("ABILITIES WINDOW")]
	public GameObject abilitiesWindow;

	private Transform abilitiesWindowTfm;

	public UILabel abilitiesStarsLbl;

	[Header("ENCYCLOPEDIA WINDOW")]
	public GameObject encyclopediaWindow;

	private Transform encyclopediaWindowTfm;

	[Header("SCREENSHOT")]
	public GameObject ScreenshotWidget;

	[HideInInspector]
	public string scoreTextToShare;

	[HideInInspector]
	public string shareScoreText;

	[HideInInspector]
	public string shareHighscoreText;

	[Header("SOCIAL")]
	public UISprite screenshotButtonFrame;

	public GameObject[] screenshotButtonIcons;

	[Header("TUTORIAL")]
	public GameObject SwipeHint;

	public UILabel tutorialDialogLbl;

	private Tween swipeHintScaleTween;

	private GameObject tutorialDialog;

	private Tween tutorialDialogTween;

	[HideInInspector]
	public ObscuredBool tutorialCanUseStar;

	[HideInInspector]
	public ObscuredBool didUseTutorialStar;

	[HideInInspector]
	public ObscuredBool showingTutorialStarDialog;

	public UILabel[] tikiLabels;

	private string rateTTL;

	private string rateText;

	private string yes;

	private string no;

	private string later;

	private int rateInterval;

	private int lastRateTime;

	[HideInInspector]
	public ObscuredBool hasRated;

	[HideInInspector]
	public int gameoverAdBtnState;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void OnStarAdded()
	{
	}

	private void OnNewGame()
	{
	}

	private void OnGameOver()
	{
	}

	private void OnGameRestart()
	{
	}

	private void OnGameReset()
	{
	}

	[IteratorStateMachine(typeof(_003CDestroyLogo_003Ed__141))]
	private IEnumerator DestroyLogo()
	{
		return null;
	}

	public void ShowInGamePanel()
	{
	}

	public void ShowEnergyBar()
	{
	}

	public void ShowScoreLabel()
	{
	}

	public void ShowStarButton()
	{
	}

	private void ActivateInGamePanel()
	{
	}

	private void CloseInGamePanel()
	{
	}

	public void ShowMainMenu()
	{
	}

	public void ShowPause()
	{
	}

	private void HidePauseWindow()
	{
	}

	public void ClosePause()
	{
	}

	private void ResetPauseWindow()
	{
	}

	private void InitOptions()
	{
	}

	public void DisplayOptions()
	{
	}

	public void CloseOptions()
	{
	}

	private void ResetOptionsWindow()
	{
	}

	private void SetMusicVolume()
	{
	}

	private void SetSFXVolume()
	{
	}

	public void PlayTutorialAgain()
	{
	}

	private void SkipTutorial()
	{
	}

	public void ResizeGameOverWindow()
	{
	}

	public void ShowGameOverWindow(bool animateDownward)
	{
	}

	private void OnGameOverWindowDisplayed()
	{
	}

	private void CloseGameOverWindow(bool upward)
	{
	}

	private void ResetGameOverWindow()
	{
	}

	public void HideGameOver(float _to)
	{
	}

	private void DisableGameOverPanel()
	{
	}

	public void AddRewardedStars(float reward, float newBalance)
	{
	}

	private void AnimateGameoverStarLabelValue(float fromValue, float toValue, float delay)
	{
	}

	private void SetGameoverStarLabelValue(float curStars)
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayScore_003Ed__171))]
	private IEnumerator DisplayScore()
	{
		return null;
	}

	private void InitShop()
	{
	}

	public void DisplayShop()
	{
	}

	public void CloseShop()
	{
	}

	private void OnShopWindowClosed()
	{
	}

	private void RefreshShop()
	{
	}

	private void UpdateStarLabel(float curStars)
	{
	}

	public void ShowJellyfishes()
	{
	}

	public void CloseJellyfishes()
	{
	}

	private void ResetJellyfishesWindow()
	{
	}

	public void ShowAbilities()
	{
	}

	public void CloseAbilities()
	{
	}

	private void ResetAbilitiesWindow()
	{
	}

	private void UpdateAbilitiesStarLabel(float curStars)
	{
	}

	public void ShowEncyclopedia()
	{
	}

	public void CloseEncyclopedia()
	{
	}

	private void ResetEncyclopediaWindow()
	{
	}

	public void ShowScreenshotWindow()
	{
	}

	public void CloseScreenshotWindow()
	{
	}

	private void ToggleScreenshotWindow(bool activate)
	{
	}

	private void DisableScreenshotWindow()
	{
	}

	private void InitRatePopUp()
	{
	}

	private void ShowRatePopUp()
	{
	}

	private void CloseRatePopUp()
	{
	}

	private void ResetRatePopUpWindow()
	{
	}

	public void AcceptRatePopUp()
	{
	}

	public void DeclineRatePopUp()
	{
	}

	public void OpenReviveWindow()
	{
	}

	private void StartReviveCountdown()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateReviveCountdownLabel_003Ed__200))]
	private IEnumerator<float> UpdateReviveCountdownLabel()
	{
		return null;
	}

	public void AcceptRevive()
	{
	}

	public void DeclineRevive()
	{
	}

	public void CloseReviveWindow()
	{
	}

	private void ResetReviveWindow()
	{
	}

	private void InitIncentives()
	{
	}

	private bool IncentiveAvailable()
	{
		return false;
	}

	public void OnShowInterstitial()
	{
	}

	public void OnCloseInterstitial()
	{
	}

	public void OnShowRewardedAd()
	{
	}

	public void OnCloseRewardedAd()
	{
	}

	private void DisplayIncentive(int incentiveType)
	{
	}

	public void CloseIncentive()
	{
	}

	private void ResetIncentiveWindow()
	{
	}

	public void DeclineIncentive()
	{
	}

	public void AcceptIncentive()
	{
	}

	public void LogInToGamePlatform()
	{
	}

	private void OnGameServicesLogInSuccess()
	{
	}

	private void OnGameServicesLogInFailed()
	{
	}

	private void OnGameServicesLogOut()
	{
	}

	private void ManageScreenRatio()
	{
	}

	public int GetNGUIWidth()
	{
		return 0;
	}

	public int GetNGUIHeight()
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CUnlockControlsDelayed_003Ed__223))]
	private IEnumerator UnlockControlsDelayed()
	{
		return null;
	}

	private void UnlockUI()
	{
	}

	public void ToggleBlackMask(bool activate)
	{
	}

	public void BlackMaskToBlack()
	{
	}

	public void BlackMaskToBlack(float duration, float delay)
	{
	}

	public void BlackMaskToTransparent()
	{
	}

	private void UpdateBlackMaskOpacity(float _opacity)
	{
	}

	private void DisableBlackMask()
	{
	}

	public void RefreshStarsLabels()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateScore_003Ed__232))]
	private IEnumerator AnimateScore()
	{
		return null;
	}

	public void AddCollectedStar()
	{
	}

	private void UpdateCollectedStarOpacity(float _opacity)
	{
	}

	private void OnCollectedStarAnimComplete()
	{
	}
}
