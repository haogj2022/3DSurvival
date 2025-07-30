using System;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/NGUI Slider")]
[ExecuteInEditMode]
public class UISlider : UIProgressBar
{
	private enum Direction
	{
		Horizontal = 0,
		Vertical = 1,
		Upgraded = 2
	}

	[SerializeField]
	[HideInInspector]
	private Transform foreground;

	[SerializeField]
	[HideInInspector]
	private float rawValue;

	[HideInInspector]
	[SerializeField]
	private Direction direction;

	[HideInInspector]
	[SerializeField]
	protected bool mInverted;

	public bool isColliderEnabled => false;

	[Obsolete("Use 'value' instead")]
	public float sliderValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Obsolete("Use 'fillDirection' instead")]
	public bool inverted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void Upgrade()
	{
	}

	protected override void OnStart()
	{
	}

	protected void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	protected void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	protected void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	protected void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	public override void OnPan(Vector2 delta)
	{
	}
}
