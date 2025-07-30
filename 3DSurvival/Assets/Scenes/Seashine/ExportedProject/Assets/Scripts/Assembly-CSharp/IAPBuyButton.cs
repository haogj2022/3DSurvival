using DG.Tweening;
using UnityEngine;

public class IAPBuyButton : MonoBehaviour
{
	private PGM PGM;

	private GameManager gameManager;

	private InAppPurchaseManager inAppPurchaseManager;

	private GameObject gameController;

	private Transform thisTransform;

	private Vector3 refPosition;

	public string ProductID;

	public UILabel PriceLbl;

	public int NumberOfStars;

	public UILabel CurStarsLbl;

	private bool productDisabled;

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

	private void ShowPrice()
	{
	}

	private void OnStarAdded()
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
