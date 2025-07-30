using System;
using System.Collections.Generic;
using UnityEngine;

[HideInInspector]
public class UILabelSymbols : UIWidget
{
	[NonSerialized]
	public UILabel label;

	[NonSerialized]
	public int fillFrame;

	[NonSerialized]
	public List<Vector3> cacheVerts;

	[NonSerialized]
	public List<Vector2> cacheUVs;

	[NonSerialized]
	public List<Color> cacheCols;

	[NonSerialized]
	public List<Vector3> symbolVerts;

	[NonSerialized]
	public List<Vector2> symbolUVs;

	[NonSerialized]
	public List<Color> symbolCols;

	public override bool isSelectable => false;

	public override Material material => null;

	public void ClearCache()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
	}
}
