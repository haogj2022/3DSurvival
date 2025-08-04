using DG.Tweening;
using UnityEngine;

public class AbilityNavigator : MonoBehaviour
{
	private AbilityManager abilityManager;

	private Ability[] abilities;

	private int totalAbilities;

	private int currentAbility;

	public UISprite upButton;

	public UISprite downButton;

	public Color navButtonOffColor;

	private Vector3 ab2Pos;

	private Vector3 ab3Pos;

	private bool upButtonDisabled;

	private bool downButtonDisabled;

	private Tween abilityPopInTween;

	public GameObject abilityButtonTemplate;

	public AbilityInfo abilityInfo;

	public UILabel balanceLabel;

	private Transform[] abilityButtons;

	private GameObject[] abilityButtonGOs;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Setup()
	{
	}

	private void PlaceButtons()
	{
	}

	private void ShowNextAbility()
	{
	}

	private void ShowPreviousAbility()
	{
	}

	private void DisplayAbilities(bool showingNext)
	{
	}
}
