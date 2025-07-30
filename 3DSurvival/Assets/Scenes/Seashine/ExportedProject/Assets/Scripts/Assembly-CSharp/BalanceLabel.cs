using DG.Tweening;
using UnityEngine;

public class BalanceLabel : MonoBehaviour
{
	public enum Type
	{
		Pearls = 0,
		Stars = 1
	}

	[SerializeField]
	private GameManager gameManager;

	public UILabel thisLabel;

	[SerializeField]
	private Type type;

	private Tween labelPunchTween;

	private Tween labelTextTween;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateLabel(int previousCount, int newCount)
	{
	}

	private void AnimateLabel(float curCount)
	{
	}

	private void ResetTweens()
	{
	}
}
