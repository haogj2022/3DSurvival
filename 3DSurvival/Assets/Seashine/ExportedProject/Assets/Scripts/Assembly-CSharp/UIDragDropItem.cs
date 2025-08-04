using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag and Drop Item")]
public class UIDragDropItem : MonoBehaviour
{
	[DoNotObfuscateNGUI]
	public enum Restriction
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		PressAndHold = 3
	}

	[Tooltip("What kind of restriction is applied to the drag & drop logic before dragging is made possible.")]
	public Restriction restriction;

	[Tooltip("By default, dragging only happens while holding the mouse button / touch. If desired, you can opt to use a click-based approach instead. Note that this only works with a mouse.")]
	public bool clickToDrag;

	[Tooltip("Whether a copy of the item will be dragged instead of the item itself.")]
	public bool cloneOnDrag;

	[Tooltip("Whether this drag and drop item can be interacted with. If not, only tooltips will work.")]
	public bool interactable;

	[HideInInspector]
	[Tooltip("How long the user has to press on an item before the drag action activates.")]
	public float pressAndHoldDelay;

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected Transform mParent;

	[NonSerialized]
	protected Collider mCollider;

	[NonSerialized]
	protected Collider2D mCollider2D;

	[NonSerialized]
	protected UIButton mButton;

	[NonSerialized]
	protected UIRoot mRoot;

	[NonSerialized]
	protected UIGrid mGrid;

	[NonSerialized]
	protected UITable mTable;

	[NonSerialized]
	protected float mDragStartTime;

	[NonSerialized]
	protected UIDragScrollView mDragScrollView;

	[NonSerialized]
	protected bool mPressed;

	[NonSerialized]
	protected bool mDragging;

	[NonSerialized]
	protected UICamera.MouseOrTouch mTouch;

	[NonSerialized]
	public static List<UIDragDropItem> draggedItems;

	[NonSerialized]
	private static int mIgnoreClick;

	public static bool IsDragged(GameObject go)
	{
		return false;
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnPress(bool isPressed)
	{
	}

	protected virtual void OnClick()
	{
	}

	protected void OnGlobalPress(GameObject go, bool state)
	{
	}

	protected void OnGlobalClick(GameObject go)
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void OnDragStart()
	{
	}

	public virtual UIDragDropItem StartDragging()
	{
		return null;
	}

	protected virtual void OnClone(GameObject original)
	{
	}

	protected virtual void OnDrag(Vector2 delta)
	{
	}

	protected virtual void OnDragEnd()
	{
	}

	public void StopDragging(GameObject go = null)
	{
	}

	protected virtual void OnDragDropStart()
	{
	}

	protected virtual void OnDragDropMove(Vector2 delta)
	{
	}

	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}

	protected virtual void DestroySelf()
	{
	}

	protected virtual void OnDragDropEnd(GameObject surface)
	{
	}

	protected void EnableDragScrollView()
	{
	}

	protected void OnApplicationFocus(bool focus)
	{
	}
}
