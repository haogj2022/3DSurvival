using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using UnityEngine;

public class StarButton : MonoBehaviour
{
	private GameManager gameManager;

	private UserInterfaceController userInterfaceController;

	public Jelly playerScript;

	public UILabel starsLbl;

	public UISprite starSprite;

	private GameObject starGO;

	private Transform starTsfm;

	private Tween starTween;

	private Tween emphasiseTween;

	public UISprite timerSprite;

	private GameObject timerGO;

	private Transform timerTsfm;

	private Vector3 vector3AlmostZero;

	private Vector3 vector3Emphasise;

	public Color labelNormalColor;

	public Color labelZeroColor;

	private bool isNaughtyBoy;

	private float reloadTime;

	private float reloaded;

	public ObscuredBool timerActive;

	private bool emphasise;

	private bool starAnimFinished;

	private string starUsedFX;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void OnDoubleTap()
	{
	}

	public void OnClick()
	{
	}

	private void SetLabelColor()
	{
	}

	private void UseOneSpark()
	{
	}

	public void ResetTimer()
	{
	}

	private void ToggleTimer(bool display)
	{
	}

	private void ShowStarIcon()
	{
	}

	private void OnStarAnimFinished()
	{
	}

	private void ResetStarTween()
	{
	}

	private void ResetEmphasiseTween()
	{
	}

	public void AddStars(string newAmoutOfStars)
	{
	}
}
