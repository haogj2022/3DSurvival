using DG.Tweening;
using UnityEngine;

public class AbilityButton : MonoBehaviour
{
	private GameManager gameManager;

	private AbilityManager abilityManager;

	private Localizer localizer;

	private PGM PGM;

	[HideInInspector]
	public Ability ability;

	private bool initiated;

	private Transform thisTransform;

	private Vector3 refPosition;

	public AbilityInfo abilityInfo;

	public UILabel abilityNameLbl;

	private string lowerCaseName;

	private string localizedTitle;

	public UISprite iconSprite;

	public UISprite iconBgrd;

	public GameObject priceTag;

	public UILabel priceLbl;

	public GameObject checkmark;

	private bool abilityUnlocked;

	private int currentStarBalance;

	private Tween btnTween;

	public UILabel balanceLabel;

	private float warningTime;

	private bool showingWarning;

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

	private void Start()
	{
	}

	private void OnClick()
	{
	}

	private void ActivateCorrectButton()
	{
	}

	private void Update()
	{
	}

	private void ShowWarning()
	{
	}
}
