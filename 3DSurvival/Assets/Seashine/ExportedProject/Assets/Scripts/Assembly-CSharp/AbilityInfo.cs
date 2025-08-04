using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using UnityEngine;

public class AbilityInfo : MonoBehaviour
{
	private GameManager gameManager;

	private AbilityManager abilityManager;

	public Ability selectedAbility;

	public UILabel abilityTitle;

	private Transform thisTransform;

	public GameObject abilityNavigator;

	public UISprite iconSprite;

	public UISprite iconBgrd;

	public GameObject unlockButton;

	public UILabel priceLbl;

	public UILabel starBalanceLbl;

	public ObscuredInt currentStarBalance;

	private Tween btnTween;

	private Vector3 unlockBtnStartPos;

	private float warningTime;

	private bool showingWarning;

	public UILabel abilityDescription;

	public ObscuredInt abilityPrice;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnAbilityUnlocked(Ability unlockedAbility)
	{
	}

	private void RefreshInfo()
	{
	}

	private void Close()
	{
	}

	private void UnlockAbility()
	{
	}

	private void Update()
	{
	}

	private void ShowWarning()
	{
	}
}
