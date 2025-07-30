using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Table")]
public class UITable : UIWidgetContainer
{
	public delegate void OnReposition();

	[DoNotObfuscateNGUI]
	public enum Direction
	{
		Down = 0,
		Up = 1
	}

	[DoNotObfuscateNGUI]
	public enum Sorting
	{
		None = 0,
		Alphabetic = 1,
		Horizontal = 2,
		Vertical = 3,
		Custom = 4
	}

	public int columns;

	public Direction direction;

	public Sorting sorting;

	[Tooltip("Whether the sort order will be inverted")]
	public bool inverted;

	public UIWidget.Pivot pivot;

	public UIWidget.Pivot cellAlignment;

	public bool hideInactive;

	public bool keepWithinPanel;

	public Vector2 padding;

	public OnReposition onReposition;

	public Comparison<Transform> onCustomSort;

	protected UIPanel mPanel;

	protected bool mInitDone;

	protected bool mReposition;

	public bool repositionNow
	{
		set
		{
		}
	}

	public List<Transform> GetChildList()
	{
		return null;
	}

	protected virtual void Sort(List<Transform> list)
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Init()
	{
	}

	protected virtual void LateUpdate()
	{
	}

	private void OnValidate()
	{
	}

	protected void RepositionVariableSize(List<Transform> children)
	{
	}

	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
	}
}
