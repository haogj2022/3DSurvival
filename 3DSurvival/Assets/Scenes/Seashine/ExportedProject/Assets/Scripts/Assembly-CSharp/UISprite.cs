using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite")]
public class UISprite : UIBasicSprite
{
	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mAtlas;

	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	[SerializeField]
	[HideInInspector]
	private bool mFixedAspect;

	[HideInInspector]
	[SerializeField]
	private bool mFillCenter;

	[NonSerialized]
	protected UISpriteData mSprite;

	[NonSerialized]
	private bool mSpriteSet;

	[NonSerialized]
	public bool autoMakePixelPerfect;

	public override Texture mainTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public INGUIAtlas atlas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool fixedAspect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isValid => false;

	[Obsolete("Use 'centerType' instead")]
	public bool fillCenter
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool applyGradient
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Color gradientTop
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color gradientBottom
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public override Vector4 border => default(Vector4);

	protected override Vector4 padding => default(Vector4);

	public override float pixelSize => 0f;

	public override int minWidth => 0;

	public override int minHeight => 0;

	public override Vector4 drawingDimensions => default(Vector4);

	public override bool premultipliedAlpha => false;

	public UISpriteData GetSprite(string spriteName)
	{
		return null;
	}

	public override void MarkAsChanged()
	{
	}

	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
	}
}
