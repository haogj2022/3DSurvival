using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using Seashine.GameSaving;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
	[SerializeField]
	private GameManager gameManager;

	private GameSaver gameSaver;

	public bool MustPlayIntroTutorial;

	public bool inTutorial;

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

	private void OnGameOver()
	{
	}

	private void OnGameReset()
	{
	}

	private void ResetTikiLabels()
	{
	}

	private void ActivateSwipeHint()
	{
	}

	public void EndTutorial()
	{
	}

	public void TutorialAllowUseOfStar()
	{
	}
}
