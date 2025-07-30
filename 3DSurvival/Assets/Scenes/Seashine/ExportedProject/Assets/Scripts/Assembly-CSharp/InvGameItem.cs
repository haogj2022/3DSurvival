using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InvGameItem
{
	public enum Quality
	{
		Broken = 0,
		Cursed = 1,
		Damaged = 2,
		Worn = 3,
		Sturdy = 4,
		Polished = 5,
		Improved = 6,
		Crafted = 7,
		Superior = 8,
		Enchanted = 9,
		Epic = 10,
		Legendary = 11,
		_LastDoNotUse = 12
	}

	[SerializeField]
	private int mBaseItemID;

	public Quality quality;

	public int itemLevel;

	private InvBaseItem mBaseItem;

	public int baseItemID => 0;

	public InvBaseItem baseItem => null;

	public string name => null;

	public float statMultiplier => 0f;

	public Color color => default(Color);

	public InvGameItem(int id)
	{
	}

	public InvGameItem(int id, InvBaseItem bi)
	{
	}

	public List<InvStat> CalculateStats()
	{
		return null;
	}
}
