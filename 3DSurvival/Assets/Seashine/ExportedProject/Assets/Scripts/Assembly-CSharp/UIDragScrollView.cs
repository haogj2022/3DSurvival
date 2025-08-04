using System;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag Scroll View")]
public class UIDragScrollView : MonoBehaviour
{
	public UIScrollView scrollView;

	[SerializeField]
	[HideInInspector]
	private UIScrollView draggablePanel;

	private Transform mTrans;

	private UIScrollView mScroll;

	private bool mAutoFind;

	private bool mStarted;

	[NonSerialized]
	private bool mPressed;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void FindScrollView()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnScroll(float delta)
	{
	}

	public void OnPan(Vector2 delta)
	{
	}
}
