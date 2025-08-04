using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UILabel))]
[AddComponentMenu("NGUI/Interaction/Typewriter Effect")]
public class TypewriterEffect : MonoBehaviour
{
	private struct FadeEntry
	{
		public int index;

		public string text;

		public float alpha;
	}

	public static TypewriterEffect current;

	[Tooltip("How many characters will be printed per second.")]
	public int charsPerSecond;

	[Tooltip("How long it takes for each character to fade in.")]
	public float fadeInTime;

	[Tooltip("How long to pause when a period is encountered (in seconds).")]
	public float delayOnPeriod;

	[Tooltip("How long to pause when a new line character is encountered (in seconds).")]
	public float delayOnNewLine;

	[Tooltip("If a scroll view is specified, its UpdatePosition() function will be called every time the text is updated.")]
	public UIScrollView scrollView;

	[Tooltip("If set to 'true', the label's dimensions will be that of a fully faded-in content.")]
	public bool keepFullDimensions;

	public List<EventDelegate> onFinished;

	private UILabel mLabel;

	private string mFullText;

	private string mMyText;

	private int mCurrentOffset;

	private float mNextChar;

	private bool mReset;

	private bool mActive;

	private BetterList<FadeEntry> mFade;

	public bool isActive => false;

	public void ResetToBeginning()
	{
	}

	public void Finish()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Update()
	{
	}
}
