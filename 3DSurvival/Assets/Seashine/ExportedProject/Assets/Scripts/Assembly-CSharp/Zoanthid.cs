using DG.Tweening;
using UnityEngine;

public class Zoanthid : MonoBehaviour
{
	public Transform topPart;

	public Transform lowPart;

	private Tween topTween;

	private Tween lowTween;

	private Vector3 openedAngle;

	private Vector3 closedAngle;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
