using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GenericButton : MonoBehaviour
{
	public static GenericButton current;

	private Transform thisTransform;

	public bool playSFX;

	public bool animateClick;

	public float punchForce;

	private Vector3 targetPunchScale;

	private Tween clickTween;

	public List<EventDelegate> onClick;

	private void Awake()
	{
	}

	public void OnClick()
	{
	}

	private void TweenClick()
	{
	}

	private void ClearClickTween()
	{
	}
}
