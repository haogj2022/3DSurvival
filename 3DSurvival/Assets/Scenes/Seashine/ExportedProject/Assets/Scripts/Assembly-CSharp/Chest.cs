using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Chest : MonoBehaviour
{
	private GameManager gameManager;

	public Transform top;

	public Transform topCollider;

	private GameObject topColliderGO;

	private Vector3 topColStartLocPos;

	public Transform spawnPoint;

	private Quaternion spawnRotation;

	public ParticleSystem idleBubbles;

	private List<Transform> spawnedCollectibles;

	private bool triggered;

	private int curDifficulty;

	private Tween topTween;

	private Tween topColTween;

	private Vector3 idleTweenMaxEuler;

	private Vector3 openTweenMaxEuler;

	private string FX_Open;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void OpenChest()
	{
	}

	private void DoLottery()
	{
	}

	private void ResetTopTween()
	{
	}

	private void ResetTopCollider()
	{
	}

	private void DisableTopCollider()
	{
	}
}
