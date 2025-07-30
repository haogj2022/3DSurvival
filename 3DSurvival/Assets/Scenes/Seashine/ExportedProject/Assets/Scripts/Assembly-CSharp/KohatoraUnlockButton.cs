using DG.Tweening;
using UnityEngine;

public class KohatoraUnlockButton : MonoBehaviour
{
	private ExplorationManager explorationManager;

	[HideInInspector]
	public string displayedKohatora;

	private int discoveredPiecesCount;

	private int collectedSpecimens;

	[SerializeField]
	private UILabel priceLabel;

	private int unlockPrice;

	private int tempPrice;

	private Transform thisTransform;

	[SerializeField]
	private Transform tab;

	[SerializeField]
	private Transform[] tabDots;

	private int currentDotIndex;

	private Vector3 tabStartPos;

	private Vector3 tabHiddenPos;

	private Tween buttonTween;

	private Tween tabTween;

	private Tween dotTween;

	private Tween priceTween;

	private void Awake()
	{
	}

	public void ButtonPopUp()
	{
	}

	private void TabPopUp()
	{
	}

	private void PopDot()
	{
	}

	private void OnClick()
	{
	}

	private void ResetButton()
	{
	}
}
