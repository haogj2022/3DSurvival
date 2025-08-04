using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Toggle")]
[ExecuteInEditMode]
public class UIToggle : UIWidgetContainer
{
	public delegate bool Validate(bool choice);

	public static BetterList<UIToggle> list;

	public static UIToggle current;

	public int group;

	public UIWidget activeSprite;

	public bool invertSpriteState;

	public Animation activeAnimation;

	public Animator animator;

	public UITweener tween;

	public bool startsActive;

	public bool instantTween;

	public bool optionCanBeNone;

	public List<EventDelegate> onChange;

	public Validate validator;

	[SerializeField]
	[HideInInspector]
	private UISprite checkSprite;

	[HideInInspector]
	[SerializeField]
	private Animation checkAnimation;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	private string functionName;

	[SerializeField]
	[HideInInspector]
	private bool startsChecked;

	[NonSerialized]
	private int mIgnoreFrame;

	private bool mIsActive;

	private bool mStarted;

	public bool value
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isColliderEnabled => false;

	[Obsolete("Use 'value' instead")]
	public bool isChecked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static UIToggle GetActiveToggle(int group)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Start()
	{
	}

	public void OnClick()
	{
	}

	public void Set(bool state, bool notify = true)
	{
	}
}
