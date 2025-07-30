using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class NGUIFont : ScriptableObject, INGUIFont
{
	[Serializable]
	public struct KerningAdjustment
	{
		public int left;

		public int right;

		public int offset;
	}

	[SerializeField]
	[HideInInspector]
	private NGUIFontType mType;

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	private Rect mUVRect;

	[HideInInspector]
	[SerializeField]
	private BMFont mFont;

	[SerializeField]
	[HideInInspector]
	private UnityEngine.Object mAtlas;

	[SerializeField]
	[HideInInspector]
	private UnityEngine.Object mReplacement;

	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mSybolAtlas;

	[HideInInspector]
	[SerializeField]
	private float mSymbolScale;

	[SerializeField]
	[HideInInspector]
	private int mSymbolOffset;

	[SerializeField]
	[HideInInspector]
	private int mSymbolMaxHeight;

	[SerializeField]
	[HideInInspector]
	private bool mSymbolCentered;

	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols;

	[NonSerialized]
	private List<BMSymbol> mEmbeddedSymbols;

	[SerializeField]
	[HideInInspector]
	private Font mDynamicFont;

	[HideInInspector]
	[SerializeField]
	private int mDynamicFontSize;

	[SerializeField]
	[HideInInspector]
	private FontStyle mDynamicFontStyle;

	[HideInInspector]
	[SerializeField]
	private int mSpaceWidth;

	[NonSerialized]
	private UISpriteData mSprite;

	[NonSerialized]
	private int mPMA;

	[NonSerialized]
	private int mPacked;

	[HideInInspector]
	[SerializeField]
	private List<KerningAdjustment> mKerningAdjustments;

	[NonSerialized]
	private Dictionary<uint, short> mKerningCache;

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

	public INGUIAtlas symbolAtlas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public Material symbolMaterial => null;

	[Obsolete("Use premultipliedAlphaShader instead")]
	public bool premultipliedAlpha => false;

	public bool premultipliedAlphaShader => false;

	public bool packedFontShader => false;

	public Texture2D texture => null;

	public Texture2D symbolTexture => null;

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

	public float symbolScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int symbolOffset
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int symbolMaxHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool symbolCentered
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

	public int kerningCount => 0;

	public List<KerningAdjustment> kerningData => null;

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

	public int GetKerning(int previousChar, int currentChar)
	{
		return 0;
	}

	public void SetKerning(List<KerningAdjustment> kerning)
	{
	}

	public void SetKerning(int previousChar, int currentChar, int amount)
	{
	}
}
