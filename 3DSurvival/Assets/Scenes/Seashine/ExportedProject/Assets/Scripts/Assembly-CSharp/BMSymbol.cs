using System;
using UnityEngine;

[Serializable]
public class BMSymbol
{
	public string sequence;

	public string spriteName;

	public bool colored;

	public bool pixelPerfect;

	[NonSerialized]
	private UISpriteData mSprite;

	[NonSerialized]
	private bool mIsValid;

	[NonSerialized]
	private int mLength;

	[NonSerialized]
	private int mOffsetX;

	[NonSerialized]
	private int mOffsetY;

	[NonSerialized]
	private int mWidth;

	[NonSerialized]
	private int mHeight;

	[NonSerialized]
	private int mAdvance;

	[NonSerialized]
	private Rect mUV;

	public int length => 0;

	public int offsetX => 0;

	public int offsetY => 0;

	public int width => 0;

	public int height => 0;

	public int paddedHeight => 0;

	public int advance => 0;

	public Rect uvRect => default(Rect);

	public void MarkAsChanged()
	{
	}

	public bool Validate(INGUIAtlas atlas)
	{
		return false;
	}
}
