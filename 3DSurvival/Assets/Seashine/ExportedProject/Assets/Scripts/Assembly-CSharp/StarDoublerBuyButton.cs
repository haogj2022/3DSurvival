using DG.Tweening;
using UnityEngine;

public class StarDoublerBuyButton : MonoBehaviour
{
	private GameManager gameManager;

	private InAppPurchaseManager inAppPurchaseManager;

	private GameObject gameController;

	public GameObject priceTag;

	public GameObject checkmark;

	public GameObject restorePurchasesBtn;

	private Transform thisTransform;

	private Vector3 refPosition;

	public string ProductID;

	public UILabel PriceLbl;

	private Tween btnTween;

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

	private void OnPurchasingReady()
	{
	}

	private void OnStarDoublerPurchased()
	{
	}

	private void ShowPrice()
	{
	}

	private void OnClick()
	{
	}

	private void ResetTween()
	{
	}

	private void Update()
	{
	}

	private void ShowWarning()
	{
	}
}
