using System.Collections.Generic;
using Seashine.GameSaving;
using Seashine.NPC;
using UnityEngine;

public class Encyclopedia : MonoBehaviour
{
	private GameObject thisGameObject;

	private GameSaver gameSaver;

	[Space(10f)]
	public GameManager gameManager;

	public ExplorationManager explorationManager;

	public GameDatabase gameDatabase;

	[Header("GRID")]
	public GameObject iconTemplate;

	private EncyclopediaEntry[] icons;

	public float yOffset;

	public float horizontalSpacing;

	public float verticalSpacing;

	public int maxColumns;

	public int maxRows;

	private int maxEntriesPerPage;

	private int totalPages;

	private int totalLifeformPages;

	private int totalKohatoraPages;

	private int activePage;

	private string currentSelection;

	public List<string> filteredEntries;

	[Header("UI")]
	[SerializeField]
	private UISprite[] categoryIcons;

	[SerializeField]
	private UISprite[] tabs;

	[Space(5f)]
	public Color hiddenEntryColor;

	[Space(10f)]
	public GameObject pageSwitcher;

	public UILabel currentPageLabel;

	public UILabel totalPagesLabel;

	public UISprite previousPageArrow;

	public UISprite nextPageArrow;

	[SerializeField]
	[Space(15f)]
	[Header("INFOBOX")]
	private GameObject infoBox;

	public UILabel discoveryNameLabel;

	public UILabel discoveryDescriptionLabel;

	public List<LifeformConfig> displayableLifeforms;

	public List<LifeformConfig> displayableSessile;

	[HideInInspector]
	public LegacyEncyclopediaCategory legacyActiveCategory;

	[Header("KOHATORA")]
	[SerializeField]
	private GameObject[] kohatoraInterfaces;

	public KohatoraUnlockButton kohatoraUnlockButton;

	public UISprite displayedKohatora;

	public UISprite displayedKohatoraShadow;

	public UISprite displayedUnlockedAnimal;

	public UISprite displayedUnlockedAnimalShadow;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleOnKohatoraDiscovered()
	{
	}

	private void HandleOnKohatoraUnlock()
	{
	}

	private void ResetTitleAndDescription()
	{
	}

	public void ChangeCategory(LegacyEncyclopediaCategory newCategory)
	{
	}

	private void ChangeCategoryFocus(string categoryName)
	{
	}

	private void ShowPreviousPage()
	{
	}

	private void ShowNextPage()
	{
	}

	public void ShowInfo(LifeformConfig selectedLifeform, Vector3 selectionLocalPosition)
	{
	}

	public void ShowInfo(Animal selectedAnimal, Vector3 selectionLocalPosition)
	{
	}

	public void ShowInfo(AnemoneOrPlant selectedAnemoneOrPlant)
	{
	}

	private void RefreshDisplayableLifeforms()
	{
	}

	private void ShowFaunaPage(int pageIndex)
	{
	}

	private void ShowKohatoraPage(int pageIndex)
	{
	}

	public void ShowKohatoraInfo(string kohatora)
	{
	}

	private void ShowKohatoraInterface(int interfaceIndex)
	{
	}

	private void RefreshPageNavigation(int pageIndex)
	{
	}
}
