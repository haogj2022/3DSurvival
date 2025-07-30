using DG.Tweening;
using UnityEngine;

public class GameoverWatchAdButton : MonoBehaviour
{
	private GameObject gameManagerGO;

	private GameManager GManager;

	private UserInterfaceController userInterfaceController;

	private ABTester abTester;

	private AdManager adManager;

	private bool clicked;

	[SerializeField]
	private UILabel rewardLbl;

	private int adReward;

	private int adRewardMultiplier;

	public GameObject simpleReward;

	public GameObject doubleReward;

	private Tween popTween;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void SetupButton()
	{
	}

	private void OnClick()
	{
	}

	private void ReportClickToAnalytics()
	{
	}
}
