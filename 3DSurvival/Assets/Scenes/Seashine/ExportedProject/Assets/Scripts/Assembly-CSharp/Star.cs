using DG.Tweening;
using UnityEngine;

public class Star : MonoBehaviour
{
	private GameManager GManager;

	public GameObject star;

	public float rarity;

	public bool checkDifficulty;

	public bool tutorialStar;

	private Collider2D thisCollider2D;

	private bool triggered;

	private int curDifficulty;

	private Tween topTween;

	private Tween topColTween;

	private Vector3 idleTweenMaxEuler;

	private Vector3 openTweenMaxEuler;

	private string FX_Collected;

	private string SFX_Collected;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void CollectStar()
	{
	}

	private void Reset()
	{
	}
}
