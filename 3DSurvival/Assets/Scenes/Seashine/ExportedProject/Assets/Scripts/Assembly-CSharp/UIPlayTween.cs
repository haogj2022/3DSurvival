using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Play Tween")]
public class UIPlayTween : MonoBehaviour
{
	public static UIPlayTween current;

	public GameObject tweenTarget;

	public int tweenGroup;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public bool resetIfDisabled;

	[Tooltip("If true, Play Tween will reset all associated tweens to their starting state at the very start, before activation triggers")]
	public bool setState;

	[Range(0f, 1f)]
	[Tooltip("Starting factor to assume, 0 being the start and 1 being the end")]
	public float startState;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public bool includeChildren;

	public List<EventDelegate> onFinished;

	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	[SerializeField]
	[HideInInspector]
	private string callWhenFinished;

	private UITweener[] mTweens;

	private bool mStarted;

	private int mActive;

	private bool mActivated;

	public bool isActive => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDragOver()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void CustomHoverListener(GameObject go, bool isOver)
	{
	}

	private void OnDragOut()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	private void OnToggle()
	{
	}

	private void Update()
	{
	}

	[ContextMenu("Stop")]
	public void Stop()
	{
	}

	[ContextMenu("Play")]
	public void Play()
	{
	}

	[ContextMenu("Play in reverse")]
	public void PlayReverse()
	{
	}

	public void Play(bool forward)
	{
	}

	private void OnFinished()
	{
	}
}
