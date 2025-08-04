using UnityEngine;

public class IncentiveManager : MonoBehaviour
{
	[SerializeField]
	private GameManager gameManager;

	[Header("RATE POP-UP")]
	public GameObject ratePopUpGO;

	private Transform ratePopUpTsfm;

	private int totalRatePopUps;

	[Header("RESTART INCENTIVE")]
	public GameObject IncentiveWindow;

	public UILabel IncentiveLbl;

	public UILabel IncentiveRewardLbl;

	private float timeBeforeAnswer;

	private int lastIncentiveTime;

	private int incentiveInterval;

	private int hasLikedOnFacebook;

	private int hasFollowedOnTwitter;

	private int selectedIncentive;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGameOver()
	{
	}

	private void InitializeIncentives()
	{
	}
}
