using UnityEngine;

public class AdManager : MonoBehaviour
{
	private GameManager gameManager;

	private PGM PGM_Instance;

	private SecuredTime securedTime;

	public float interstitialInterval;

	[HideInInspector]
	public float lastInterstitialTimer;

	[SerializeField]
	private bool debugMode;

	private bool debugModeMinimized;

	private string debugModeConsoleMessage;

	private bool gameoverRewardedAdComplete;

	public AdRewardType adRewardType;

	public void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	private void LoadAds()
	{
	}

	public void LoadInterstitial()
	{
	}

	public void ShowInterstitial()
	{
	}

	public bool InterstitialReady()
	{
		return false;
	}

	public bool RewardedAdReady()
	{
		return false;
	}

	public void LoadRewardedAd()
	{
	}

	public void ShowRewardedAd()
	{
	}

	private void LogMessage(string message)
	{
	}

	public void OnGUI()
	{
	}
}
