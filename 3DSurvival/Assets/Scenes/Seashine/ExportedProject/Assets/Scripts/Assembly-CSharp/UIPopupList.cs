using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Popup List")]
public class UIPopupList : UIWidgetContainer
{
	[DoNotObfuscateNGUI]
	public enum Position
	{
		Auto = 0,
		Above = 1,
		Below = 2
	}

	[DoNotObfuscateNGUI]
	public enum Selection
	{
		OnPress = 0,
		OnClick = 1
	}

	[DoNotObfuscateNGUI]
	public enum OpenOn
	{
		ClickOrTap = 0,
		RightClick = 1,
		DoubleClick = 2,
		Manual = 3
	}

	public delegate void LegacyEvent(string val);

	[CompilerGenerated]
	private sealed class _003CUpdateTweenPosition_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		private TweenPosition _003Ctp_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateTweenPosition_003Ed__95(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCloseIfUnselected_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPopupList _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCloseIfUnselected_003Ed__112(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static UIPopupList current;

	protected static GameObject mChild;

	protected static float mFadeOutComplete;

	private const float animSpeed = 0.15f;

	public UnityEngine.Object atlas;

	public UnityEngine.Object bitmapFont;

	public Font trueTypeFont;

	public int fontSize;

	public FontStyle fontStyle;

	public string backgroundSprite;

	public string highlightSprite;

	public Sprite background2DSprite;

	public Sprite highlight2DSprite;

	public Position position;

	public Selection selection;

	public NGUIText.Alignment alignment;

	public List<string> items;

	public List<object> itemData;

	public List<Action> itemCallbacks;

	public Vector2 padding;

	public Color textColor;

	public Color backgroundColor;

	public Color highlightColor;

	public bool isAnimated;

	public bool isLocalized;

	public UILabel.Modifier textModifier;

	public bool separatePanel;

	public int overlap;

	public OpenOn openOn;

	public List<EventDelegate> onChange;

	[SerializeField]
	[HideInInspector]
	protected string mSelectedItem;

	[SerializeField]
	[HideInInspector]
	protected UIPanel mPanel;

	[SerializeField]
	[HideInInspector]
	protected UIBasicSprite mBackground;

	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite mHighlight;

	[HideInInspector]
	[SerializeField]
	protected UILabel mHighlightedLabel;

	[SerializeField]
	[HideInInspector]
	protected List<UILabel> mLabelList;

	[SerializeField]
	[HideInInspector]
	protected float mBgBorder;

	[Tooltip("Whether the selection will be persistent even after the popup list is closed. By default the selection is cleared when the popup is closed so that the same selection can be chosen again the next time the popup list is opened. If enabled, the selection will persist, but selecting the same choice in succession will not result in the onChange notification being triggered more than once.")]
	public bool keepValue;

	[NonSerialized]
	protected GameObject mSelection;

	[NonSerialized]
	protected int mOpenFrame;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	private string functionName;

	[HideInInspector]
	[SerializeField]
	private float textScale;

	[SerializeField]
	[HideInInspector]
	private UILabel textLabel;

	[NonSerialized]
	public Vector3 startingPosition;

	private LegacyEvent mLegacyEvent;

	[NonSerialized]
	protected bool mExecuting;

	[NonSerialized]
	protected bool mStarted;

	protected bool mTweening;

	public GameObject source;

	public INGUIFont font
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("Use EventDelegate.Add(popup.onChange, YourCallback) instead, and UIPopupList.current.value to determine the state")]
	public LegacyEvent onSelectionChange
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool isOpen => false;

	public virtual string value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual object data => null;

	public Action callback => null;

	public bool isColliderEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected bool isValid => false;

	protected int activeFontSize => 0;

	protected float activeFontScale => 0f;

	protected float fitScale => 0f;

	public void Set(string value, bool notify = true)
	{
	}

	public virtual void Clear()
	{
	}

	public virtual void AddItem(string text)
	{
	}

	public virtual void AddItem(string text, Action del)
	{
	}

	public virtual void AddItem(string text, object data, Action del = null)
	{
	}

	public virtual void RemoveItem(string text)
	{
	}

	public virtual void RemoveItemByData(object data)
	{
	}

	protected void TriggerCallbacks()
	{
	}

	protected virtual void OnEnable()
	{
	}

	public virtual void Start()
	{
	}

	protected virtual void OnLocalize()
	{
	}

	protected virtual void Highlight(UILabel lbl, bool instant)
	{
	}

	protected virtual Vector3 GetHighlightPosition()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(_003CUpdateTweenPosition_003Ed__95))]
	protected virtual IEnumerator UpdateTweenPosition()
	{
		return null;
	}

	protected virtual void OnItemHover(GameObject go, bool isOver)
	{
	}

	protected virtual void OnItemPress(GameObject go, bool isPressed)
	{
	}

	protected virtual void OnItemClick(GameObject go)
	{
	}

	private void Select(UILabel lbl, bool instant)
	{
	}

	protected virtual void OnNavigate(KeyCode key)
	{
	}

	protected virtual void OnKey(KeyCode key)
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnSelect(bool isSelected)
	{
	}

	public static void Close()
	{
	}

	public virtual void CloseSelf()
	{
	}

	protected virtual void AnimateColor(UIWidget widget)
	{
	}

	protected virtual void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	protected virtual void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	protected void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	protected virtual void OnClick()
	{
	}

	protected virtual void OnDoubleClick()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseIfUnselected_003Ed__112))]
	private IEnumerator CloseIfUnselected()
	{
		return null;
	}

	public virtual void Show()
	{
	}
}
