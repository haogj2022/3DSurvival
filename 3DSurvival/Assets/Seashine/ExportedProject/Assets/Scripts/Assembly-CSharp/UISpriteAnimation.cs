using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Sprite Animation")]
[RequireComponent(typeof(UISprite))]
[ExecuteInEditMode]
public class UISpriteAnimation : MonoBehaviour
{
	public int frameIndex;

	[HideInInspector]
	[SerializeField]
	protected int mFPS;

	[SerializeField]
	[HideInInspector]
	protected string mPrefix;

	[SerializeField]
	[HideInInspector]
	protected bool mLoop;

	[SerializeField]
	[HideInInspector]
	protected bool mSnap;

	protected UISprite mSprite;

	protected float mDelta;

	protected bool mActive;

	protected List<string> mSpriteNames;

	public int frames => 0;

	public int framesPerSecond
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string namePrefix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool loop
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isPlaying => false;

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public void RebuildSpriteList()
	{
	}

	public void Play()
	{
	}

	public void Pause()
	{
	}

	public void ResetToBeginning()
	{
	}
}
