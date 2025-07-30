using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class AbilitySlot : MonoBehaviour
{
	private GameManager gameManager;

	private AbilityManager abilityManager;

	private PGM PGM_Instance;

	public bool unlockableSlot;

	public UISprite abilitySprite;

	public ObscuredInt slotNumber;

	public GameObject unlockButton;

	private int totalAbilities;

	private float warningTime;

	private bool showingWarning;

	private int slotPrice;

	public UILabel PriceLbl;

	private Ability selectedAbility;

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

	private void GetSavedAbility()
	{
	}

	private void UpdateIconVisibility(string abilityName)
	{
	}

	private void Update()
	{
	}

	private void OnClick()
	{
	}

	private void LoadNextAbility()
	{
	}

	public void Lock()
	{
	}

	public void OnThirdSlotUnlocked()
	{
	}

	private void DisableUnlockButton()
	{
	}
}
