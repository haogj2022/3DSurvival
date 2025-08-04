using DG.Tweening;
using UnityEngine;

public class FishMouthMovement : MonoBehaviour
{
	[Range(1f, 10f)]
	public float movementDuration;

	[Range(1f, 50f)]
	public float movementAmplitude;

	private Transform jawTransform;

	private Quaternion jawInitialRotation;

	private Tween jawTween;

	private Vector3 movementTargetEuler;

	private bool applicationQuitting;

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
