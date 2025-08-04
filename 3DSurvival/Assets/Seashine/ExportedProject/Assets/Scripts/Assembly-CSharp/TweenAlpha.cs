using System;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Alpha")]
public class TweenAlpha : UITweener
{
	[Range(0f, 1f)]
	public float from;

	[Range(0f, 1f)]
	public float to;

	[Tooltip("If used on a renderer, the material should probably be cleaned up after this script gets destroyed...")]
	public bool autoCleanup;

	[Tooltip("Color to adjust")]
	public string colorProperty;

	[NonSerialized]
	private bool mCached;

	[NonSerialized]
	private UIRect mRect;

	[NonSerialized]
	private Material mShared;

	[NonSerialized]
	private Material mMat;

	[NonSerialized]
	private Light mLight;

	[NonSerialized]
	private SpriteRenderer mSr;

	[NonSerialized]
	private float mBaseIntensity;

	[Obsolete("Use 'value' instead")]
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

	private void OnDestroy()
	{
	}

	private void Cache()
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenAlpha Begin(GameObject go, float duration, float alpha, float delay = 0f)
	{
		return null;
	}

	public override void SetStartToCurrentValue()
	{
	}

	public override void SetEndToCurrentValue()
	{
	}
}
