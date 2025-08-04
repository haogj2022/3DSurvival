using Seashine.GameSaving;
using UnityEngine;

public class JellyfishSelector : MonoBehaviour
{
	private GameSaver gameSaver;

	[SerializeField]
	private GameDatabase gameDatabase;

	private GameManager gameManager;

	private JellyfishManager jellyfishManager;

	private int currentIndex;

	private Jellyfish displayedJellyfish;

	private int displayedJellyfishSavedState;

	[SerializeField]
	[Space(10f)]
	private UISprite jellyfishSprite;

	[SerializeField]
	private UILabel nameLabel;

	[Header("NAVIGATION")]
	[SerializeField]
	private UISprite previousJellyfishArrow;

	[SerializeField]
	private UISprite nextJellyfishArrow;

	[SerializeField]
	[Header("CHARACTERISTICS")]
	private UISprite sizeSprite;

	[SerializeField]
	private UISprite speedSprite;

	[SerializeField]
	private UISprite resistanceSprite;

	[SerializeField]
	private UISprite brightnessSprite;

	[SerializeField]
	private UISprite lifetimeSprite;

	private int barMaxWidth;

	private int barMinWidth;

	private int barMargin;

	[SerializeField]
	[Header("UNLOCK BUTTON")]
	private GameObject unlockButton;

	[SerializeField]
	private UILabel unlockPriceLabel;

	[SerializeField]
	[Header("SELECT BUTTON")]
	private GameObject selectButton;

	[SerializeField]
	[Header("BALANCE")]
	private UILabel balanceLabel;

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

	public void ShowPreviousJellyfish()
	{
	}

	public void ShowNextJellyfish()
	{
	}

	private void DisplayJellyfish(int index)
	{
	}

	private void RefreshCharacteristics()
	{
	}

	public void SelectJellyfish()
	{
	}

	public void UnlockJellyfish()
	{
	}

	private void OnJellyfishUnlocked(Jellyfish unlockedJellyfish)
	{
	}

	private void UpdateBalanceLabel(float curStars)
	{
	}

	private void DisplayJellyfishAvailability()
	{
	}

	private void GetSavedJellyfishIndex()
	{
	}
}
