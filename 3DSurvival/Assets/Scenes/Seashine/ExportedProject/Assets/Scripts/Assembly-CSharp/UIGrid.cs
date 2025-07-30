using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : UIWidgetContainer
{
	public delegate void OnReposition();

	[DoNotObfuscateNGUI]
	public enum Arrangement
	{
		Horizontal = 0,
		Vertical = 1,
		CellSnap = 2
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

	[DoNotObfuscateNGUI]
	public enum Expansion
	{
		Legacy = 0,
		BasedOnPivot = 1
	}

	public Arrangement arrangement;

	public Sorting sorting;

	[Tooltip("Whether the sort order will be inverted")]
	public bool inverted;

	[Tooltip("Final pivot point for the grid's content.")]
	public UIWidget.Pivot pivot;

	[Tooltip("Legacy style expansion positions children to the right and down from the first one. Pivot-based expansion positions children moving away from the pivot instead, and centered if necessary.")]
	public Expansion expansionStyle;

	public int maxPerLine;

	public float cellWidth;

	public float cellHeight;

	[Tooltip("Whether the grid will smoothly animate its children into the correct place.")]
	public bool animateSmoothly;

	[Tooltip("If 'true' and Animate Smoothly is also 'true', will check to see if elements have a TweenAlpha on them. If so, elements will appear in their target position instead of animating from the current position.")]
	public bool animateFadeIn;

	public bool hideInactive;

	public bool keepWithinPanel;

	public OnReposition onReposition;

	public Comparison<Transform> onCustomSort;

	[HideInInspector]
	[SerializeField]
	private bool sorted;

	protected UIPanel mPanel;

	protected bool mInitDone;

	[NonSerialized]
	private List<SpringPosition> mSprings;

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

	public Transform GetChild(int index)
	{
		return null;
	}

	public int GetIndex(Transform trans)
	{
		return 0;
	}

	[Obsolete("Use gameObject.AddChild or transform.parent = gridTransform")]
	public void AddChild(Transform trans)
	{
	}

	[Obsolete("Use gameObject.AddChild or transform.parent = gridTransform")]
	public void AddChild(Transform trans, bool sort)
	{
	}

	public bool RemoveChild(Transform t)
	{
		return false;
	}

	protected virtual void Init()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	private void OnValidate()
	{
	}

	public static int SortByName(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortByNameInv(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortHorizontal(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortHorizontalInv(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortVertical(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortVerticalInv(Transform a, Transform b)
	{
		return 0;
	}

	protected virtual void Sort(List<Transform> list)
	{
	}

	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
	}

	public void ConstrainWithinPanel()
	{
	}

	protected virtual void ResetPosition(List<Transform> list)
	{
	}
}
