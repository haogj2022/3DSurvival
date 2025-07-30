using DG.Tweening;
using Seashine.GameSaving;
using Seashine.NPC;
using UnityEngine;

public class EncyclopediaEntry : MonoBehaviour
{
	private Encyclopedia encyclopedia;

	private GameSaver gameSaver;

	private Transform thisTransform;

	public UISprite iconSprite;

	public UISprite iconSpriteShadow;

	private Vector3 localPosition;

	private Tween popTween;

	public LifeformConfig DisplayedLifeform;

	public string displayedKohatora;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void ResetPopTween()
	{
	}

	public void DoPopTween(float delay)
	{
	}

	private void OnClick()
	{
	}
}
