using System;
using System.Collections.Generic;

[Serializable]
public class BMGlyph
{
	public int index;

	public int x;

	public int y;

	public int width;

	public int height;

	public int offsetX;

	public int offsetY;

	public int advance;

	public int channel;

	public List<int> kerning;

	public int GetKerning(int previousChar)
	{
		return 0;
	}

	public void SetKerning(int previousChar, int amount)
	{
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
