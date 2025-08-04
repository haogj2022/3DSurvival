using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIFont : MonoBehaviour, INGUIFont
{
	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Rect mUVRect;

	[SerializeField]
	[HideInInspector]
	private BMFont mFont;

	[SerializeField]
	[HideInInspector]
	private UnityEngine.Object mAtlas;

	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mReplacement;

	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols;

	[SerializeField]
	[HideInInspector]
	private Font mDynamicFont;

	[SerializeField]
	[HideInInspector]
	private int mDynamicFontSize;

	[SerializeField]
	[HideInInspector]
	private FontStyle mDynamicFontStyle;

	[NonSerialized]
	private UISpriteData mSprite;

	[NonSerialized]
	private int mPMA;

	[NonSerialized]
	private int mPacked;

	public NGUIFontType type
	{
		get
		{
			return default(NGUIFontType);
		}
		set
		{
		}
	}

	public BMFont bmFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int texWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int texHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool hasSymbols => false;

	public List<BMSymbol> symbols
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

	public INGUIAtlas symbolAtlas => null;

	public Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("Use premultipliedAlphaShader instead")]
	public bool premultipliedAlpha => false;

	public bool premultipliedAlphaShader => false;

	public bool packedFontShader => false;

	public Texture2D texture => null;

	public Rect uvRect
	{
		get
		{
			return default(Rect);
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

	[Obsolete("Use defaultSize instead")]
	public int size
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int defaultSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int spaceWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public UISpriteData sprite => null;

	public INGUIFont replacement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public INGUIFont finalFont => null;

	public bool isDynamic => false;

	public Font dynamicFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FontStyle dynamicFontStyle
	{
		get
		{
			return default(FontStyle);
		}
		set
		{
		}
	}

	public UISpriteData GetSprite(string spriteName)
	{
		return null;
	}

	private void Trim()
	{
	}

	public bool References(INGUIFont font)
	{
		return false;
	}

	public void MarkAsChanged()
	{
	}

	public void UpdateUVRect()
	{
	}

	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	public BMSymbol MatchSymbol(ref string text, int offset, int textLength)
	{
		return null;
	}

	public BMSymbol AddSymbol(string sequence, string spriteName)
	{
		return null;
	}

	public void RemoveSymbol(string sequence)
	{
	}

	public void RenameSymbol(string before, string after)
	{
	}

	public bool UsesSprite(string s)
	{
		return false;
	}
}
