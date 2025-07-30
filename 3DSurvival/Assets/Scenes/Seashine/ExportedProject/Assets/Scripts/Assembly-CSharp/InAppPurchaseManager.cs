using UnityEngine.Purchasing;

public class InAppPurchaseManager : Singleton<InAppPurchaseManager>, IStoreListener
{
	public delegate void InAppPurchaseManagerEvent();

	private IStoreController m_StoreController;

	private static IExtensionProvider m_StoreExtensionProvider;

	public InAppPurchaseManagerEvent OnPurchasingInitialized;

	public InAppPurchaseManagerEvent OnStarDoublerPurchased;

	public InAppPurchaseManagerEvent OnStarsPurchased;

	private GameManager gameManager;

	private void Start()
	{
	}

	private void InitializePurchasing()
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error, string? message = null)
	{
	}

	public bool IsInitialized()
	{
		return false;
	}

	public string GetLocalizedPriceString(string productID)
	{
		return null;
	}

	public void BuyProduct(string productId)
	{
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
	{
		return default(PurchaseProcessingResult);
	}

	private void ActivatePurchase(PurchaseEventArgs args)
	{
	}

	public void RestorePurchases()
	{
	}
}
