using DG.Tweening;
using UnityEngine;

public class PopStar : MonoBehaviour
{
	private Transform thisTransform;

	private GameManager gameManager;

	public Transform star;

	private float activationTimer;

	private int randomReward;

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

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
