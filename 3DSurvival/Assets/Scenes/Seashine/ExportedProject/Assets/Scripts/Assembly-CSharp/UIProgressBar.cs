using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Progress Bar")]
public class UIProgressBar : UIWidgetContainer
{
	[DoNotObfuscateNGUI]
	public enum FillDirection
	{
		LeftToRight = 0,
		RightToLeft = 1,
		BottomToTop = 2,
		TopToBottom = 3
	}

	public delegate void OnDragFinished();

	public static UIProgressBar current;

	public OnDragFinished onDragFinished;

	public Transform thumb;

	[SerializeField]
	[HideInInspector]
	protected UIWidget mBG;

	[HideInInspector]
	[SerializeField]
	protected UIWidget mFG;

	[HideInInspector]
	[SerializeField]
	protected float mValue;

	[HideInInspector]
	[SerializeField]
	protected FillDirection mFill;

	[NonSerialized]
	protected bool mStarted;

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected bool mIsDirty;

	[NonSerialized]
	protected Camera mCam;

	[NonSerialized]
	protected float mOffset;

	public int numberOfSteps;

	public List<EventDelegate> onChange;

	public Transform cachedTransform => null;

	public Camera cachedCamera => null;

	public UIWidget foregroundWidget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIWidget backgroundWidget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FillDirection fillDirection
	{
		get
		{
			return default(FillDirection);
		}
		set
		{
		}
	}

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected bool isHorizontal => false;

	protected bool isInverted => false;

	public bool Set(float val, bool notify = true)
	{
		return false;
	}

	protected void OnEnable()
	{
	}

	public void Start()
	{
	}

	protected virtual void Upgrade()
	{
	}

	protected virtual void OnStart()
	{
	}

	protected void Update()
	{
	}

	protected void OnValidate()
	{
	}

	protected float ScreenToValue(Vector2 screenPos)
	{
		return 0f;
	}

	protected virtual float LocalToValue(Vector2 localPos)
	{
		return 0f;
	}

	public virtual void ForceUpdate()
	{
	}

	protected void SetThumbPosition(Vector3 worldPos)
	{
	}

	public virtual void OnPan(Vector2 delta)
	{
	}
}
