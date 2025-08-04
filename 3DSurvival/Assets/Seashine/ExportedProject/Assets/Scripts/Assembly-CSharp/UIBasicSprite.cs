using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class UIBasicSprite : UIWidget
{
	[DoNotObfuscateNGUI]
	public enum Type
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
		Advanced = 4
	}

	[DoNotObfuscateNGUI]
	public enum FillDirection
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4
	}

	[DoNotObfuscateNGUI]
	public enum AdvancedType
	{
		Invisible = 0,
		Sliced = 1,
		Tiled = 2
	}

	[DoNotObfuscateNGUI]
	public enum Flip
	{
		Nothing = 0,
		Horizontally = 1,
		Vertically = 2,
		Both = 3
	}

	[SerializeField]
	[HideInInspector]
	protected Type mType;

	[HideInInspector]
	[SerializeField]
	protected FillDirection mFillDirection;

	[SerializeField]
	[HideInInspector]
	[Range(0f, 1f)]
	protected float mFillAmount;

	[SerializeField]
	[HideInInspector]
	protected bool mInvert;

	[SerializeField]
	[HideInInspector]
	protected Flip mFlip;

	[HideInInspector]
	[SerializeField]
	protected bool mApplyGradient;

	[SerializeField]
	[HideInInspector]
	protected Color mGradientTop;

	[HideInInspector]
	[SerializeField]
	protected Color mGradientBottom;

	[NonSerialized]
	protected Rect mInnerUV;

	[NonSerialized]
	protected Rect mOuterUV;

	public AdvancedType centerType;

	public AdvancedType leftType;

	public AdvancedType rightType;

	public AdvancedType bottomType;

	public AdvancedType topType;

	protected static Vector2[] mTempPos;

	protected static Vector2[] mTempUVs;

	public virtual Type type
	{
		get
		{
			return default(Type);
		}
		set
		{
		}
	}

	public Flip flip
	{
		get
		{
			return default(Flip);
		}
		set
		{
		}
	}

	public FillDirection fillDirection
	{
		get
		{
			return default(FillDirection);
		}
		set
		{
		}
	}

	public float fillAmount
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override int minWidth => 0;

	public override int minHeight => 0;

	public bool invert
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool hasBorder => false;

	public virtual bool premultipliedAlpha => false;

	public virtual float pixelSize => 0f;

	protected virtual Vector4 padding => default(Vector4);

	protected Vector4 drawingUVs => default(Vector4);

	protected Color drawingColor => default(Color);

	protected void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, Rect outer, Rect inner)
	{
	}

	protected void SimpleFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
	{
	}

	protected void SlicedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color gc)
	{
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	private void AddVertexColours(List<Color> cols, ref Color color, int x, int y)
	{
	}

	protected void TiledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Color c)
	{
	}

	protected void FilledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
	{
	}

	protected void AdvancedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
	{
	}

	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return false;
	}

	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	private static void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
	}
}
