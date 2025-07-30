using DG.Tweening;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	public Transform ArrowPicto;

	private Vector3 startPos;

	private float startValue;

	private Tween arrowTween;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
