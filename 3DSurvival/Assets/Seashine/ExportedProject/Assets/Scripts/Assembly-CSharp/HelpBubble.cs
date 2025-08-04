using DG.Tweening;
using UnityEngine;

public class HelpBubble : MonoBehaviour
{
	private Transform thisTransform;

	[SerializeField]
	private Localizer localizer;

	[SerializeField]
	private GameObject helpBlackMask;

	private UISprite highlightSprite;

	[SerializeField]
	private Transform bubbleTransform;

	[SerializeField]
	private UILabel bubbleLabel;

	private Tween spriteTween;

	private Tween bubbleTween;

	private void Awake()
	{
	}

	private void SetupBubble()
	{
	}

	public void ShowHelpBubble(string helpKey, UISprite sourceSprite)
	{
	}

	public void HideHelpBubble()
	{
	}

	private void OpenBubble()
	{
	}

	private void DisableBubble()
	{
	}

	private void ClearBubbleTween()
	{
	}

	private void ClearSpriteTween()
	{
	}
}
