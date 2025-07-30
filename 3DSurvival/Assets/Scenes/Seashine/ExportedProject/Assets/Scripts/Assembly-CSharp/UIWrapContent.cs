using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Wrap Content")]
public class UIWrapContent : MonoBehaviour
{
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	public int itemSize;

	public bool cullContent;

	public int minIndex;

	public int maxIndex;

	public bool hideInactive;

	public OnInitializeItem onInitializeItem;

	protected Transform mTrans;

	protected UIPanel mPanel;

	protected UIScrollView mScroll;

	protected bool mHorizontal;

	protected bool mFirstTime;

	protected List<Transform> mChildren;

	protected virtual void Start()
	{
	}

	protected virtual void OnMove(UIPanel panel)
	{
	}

	[ContextMenu("Sort Based on Scroll Movement")]
	public virtual void SortBasedOnScrollMovement()
	{
	}

	[ContextMenu("Sort Alphabetically")]
	public virtual void SortAlphabetically()
	{
	}

	protected bool CacheScrollView()
	{
		return false;
	}

	protected virtual void ResetChildPositions()
	{
	}

	public virtual void WrapContent()
	{
	}

	private void OnValidate()
	{
	}

	protected virtual void UpdateItem(Transform item, int index)
	{
	}
}
