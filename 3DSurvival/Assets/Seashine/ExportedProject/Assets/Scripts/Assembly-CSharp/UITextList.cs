using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Text List")]
public class UITextList : MonoBehaviour
{
	[DoNotObfuscateNGUI]
	public enum Style
	{
		Text = 0,
		Chat = 1
	}

	protected class Paragraph
	{
		public string text;

		public string[] lines;
	}

	public UILabel textLabel;

	public UIProgressBar scrollBar;

	public Style style;

	public int paragraphHistory;

	protected char[] mSeparator;

	protected float mScroll;

	protected int mTotalLines;

	protected int mLastWidth;

	protected int mLastHeight;

	private BetterList<Paragraph> mParagraphs;

	private static Dictionary<string, BetterList<Paragraph>> mHistory;

	protected BetterList<Paragraph> paragraphs => null;

	public int paragraphCount => 0;

	public bool isValid => false;

	public float scrollValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected float lineHeight => 0f;

	protected int scrollHeight => 0;

	public void Clear()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnScroll(float val)
	{
	}

	public void OnDrag(Vector2 delta)
	{
	}

	private void OnScrollBar()
	{
	}

	public void Add(string text)
	{
	}

	protected void Add(string text, bool updateVisible)
	{
	}

	protected void Rebuild()
	{
	}

	protected void UpdateVisibleText()
	{
	}
}
