using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Label")]
[ExecuteInEditMode]
public class UILabel : UIWidget
{
	[DoNotObfuscateNGUI]
	public enum Effect
	{
		None = 0,
		Shadow = 1,
		Outline = 2,
		Outline8 = 3
	}

	[DoNotObfuscateNGUI]
	public enum Overflow
	{
		ShrinkContent = 0,
		ClampContent = 1,
		ResizeFreely = 2,
		ResizeHeight = 3
	}

	[DoNotObfuscateNGUI]
	public enum Crispness
	{
		Never = 0,
		OnDesktop = 1,
		Always = 2
	}

	[DoNotObfuscateNGUI]
	public enum Modifier
	{
		None = 0,
		ToUppercase = 1,
		ToLowercase = 2,
		Custom = 255
	}

	public delegate string ModifierFunc(string s);

	public Crispness keepCrispWhenShrunk;

	[HideInInspector]
	[SerializeField]
	private Font mTrueTypeFont;

	[HideInInspector]
	[SerializeField]
	private UnityEngine.Object mFont;

	[SerializeField]
	[HideInInspector]
	[Multiline(6)]
	private string mText;

	[SerializeField]
	[HideInInspector]
	private int mFontSize;

	[SerializeField]
	[HideInInspector]
	private FontStyle mFontStyle;

	[HideInInspector]
	[SerializeField]
	private NGUIText.Alignment mAlignment;

	[SerializeField]
	[HideInInspector]
	private bool mEncoding;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineCount;

	[HideInInspector]
	[SerializeField]
	private Effect mEffectStyle;

	[SerializeField]
	[HideInInspector]
	private Color mEffectColor;

	[HideInInspector]
	[SerializeField]
	private NGUIText.SymbolStyle mSymbols;

	[HideInInspector]
	[SerializeField]
	private Vector2 mEffectDistance;

	[HideInInspector]
	[SerializeField]
	private Overflow mOverflow;

	[SerializeField]
	[HideInInspector]
	private bool mApplyGradient;

	[HideInInspector]
	[SerializeField]
	private Color mGradientTop;

	[HideInInspector]
	[SerializeField]
	private Color mGradientBottom;

	[SerializeField]
	[HideInInspector]
	private int mSpacingX;

	[HideInInspector]
	[SerializeField]
	private int mSpacingY;

	[HideInInspector]
	[SerializeField]
	private bool mUseFloatSpacing;

	[SerializeField]
	[HideInInspector]
	private float mFloatSpacingX;

	[HideInInspector]
	[SerializeField]
	private float mFloatSpacingY;

	[SerializeField]
	[HideInInspector]
	private bool mOverflowEllipsis;

	[HideInInspector]
	[SerializeField]
	private int mOverflowWidth;

	[SerializeField]
	[HideInInspector]
	private int mOverflowHeight;

	[HideInInspector]
	[SerializeField]
	private Modifier mModifier;

	[SerializeField]
	[HideInInspector]
	private int mSymbolDepth;

	[SerializeField]
	[HideInInspector]
	private bool mShrinkToFit;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineHeight;

	[SerializeField]
	[HideInInspector]
	private float mLineWidth;

	[HideInInspector]
	[SerializeField]
	private bool mMultiline;

	[NonSerialized]
	private UILabelSymbols mLabSym;

	[NonSerialized]
	private Font mActiveTTF;

	[NonSerialized]
	private float mDensity;

	[NonSerialized]
	private bool mShouldBeProcessed;

	[NonSerialized]
	private string mProcessedText;

	[NonSerialized]
	private bool mPremultiply;

	[NonSerialized]
	private Vector2 mCalculatedSize;

	[NonSerialized]
	private float mScale;

	[NonSerialized]
	private int mFinalFontSize;

	[NonSerialized]
	private int mLastWidth;

	[NonSerialized]
	private int mLastHeight;

	public ModifierFunc customModifier;

	private static BetterList<UILabel> mList;

	private static Dictionary<Font, int> mFontUsage;

	[NonSerialized]
	private static BetterList<UIDrawCall> mTempDrawcalls;

	[NonSerialized]
	private static bool mTexRebuildAdded;

	[NonSerialized]
	private static List<Vector3> mTempVerts;

	[NonSerialized]
	private static List<int> mTempIndices;

	public int finalFontSize => 0;

	private bool shouldBeProcessed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override bool isAnchoredHorizontally => false;

	public override bool isAnchoredVertically => false;

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

	[Obsolete("Use UILabel.font instead")]
	public INGUIFont bitmapFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public INGUIFont font
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

	public Font trueTypeFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int defaultFontSize => 0;

	public int fontSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public FontStyle fontStyle
	{
		get
		{
			return default(FontStyle);
		}
		set
		{
		}
	}

	public NGUIText.Alignment alignment
	{
		get
		{
			return default(NGUIText.Alignment);
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

	public int spacingX
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int spacingY
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool useFloatSpacing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float floatSpacingX
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float floatSpacingY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float effectiveSpacingY => 0f;

	public float effectiveSpacingX => 0f;

	public bool overflowEllipsis
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int overflowWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int overflowHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool keepCrisp => false;

	public bool supportEncoding
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public NGUIText.SymbolStyle symbolStyle
	{
		get
		{
			return default(NGUIText.SymbolStyle);
		}
		set
		{
		}
	}

	public Overflow overflowMethod
	{
		get
		{
			return default(Overflow);
		}
		set
		{
		}
	}

	[Obsolete("Use 'width' instead")]
	public int lineWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete("Use 'height' instead")]
	public int lineHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool multiLine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override Vector3[] localCorners => null;

	public override Vector3[] worldCorners => null;

	public override Vector4 drawingDimensions => default(Vector4);

	public int maxLineCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Effect effectStyle
	{
		get
		{
			return default(Effect);
		}
		set
		{
		}
	}

	public Color effectColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Vector2 effectDistance
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public int quadsPerCharacter => 0;

	[Obsolete("Use 'overflowMethod == UILabel.Overflow.ShrinkContent' instead")]
	public bool shrinkToFit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string processedText => null;

	public Vector2 printedSize => default(Vector2);

	public override Vector2 localSize => default(Vector2);

	private bool isValid => false;

	public bool symbolLabel => false;

	public Modifier modifier
	{
		get
		{
			return default(Modifier);
		}
		set
		{
		}
	}

	public override Pivot pivot
	{
		get
		{
			return default(Pivot);
		}
		set
		{
		}
	}

	public int symbolDepth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string printedText => null;

	private bool premultipliedAlphaShader => false;

	private bool packedFontShader => false;

	public bool separateSymbols => false;

	protected override void OnInit()
	{
	}

	private void CreateSymbolLabel()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void SetDirty()
	{
	}

	protected void SetActiveFont(Font fnt)
	{
	}

	private static void OnFontChanged(Font font)
	{
	}

	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	protected override void UpgradeFrom265()
	{
	}

	protected override void OnAnchor()
	{
	}

	private void ProcessAndRequest()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnStart()
	{
	}

	public override void MarkAsChanged()
	{
	}

	public void ProcessText(bool legacyMode = false, bool full = true)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public void AssumeNaturalSize()
	{
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector3 worldPos)
	{
		return 0;
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector2 localPos)
	{
		return 0;
	}

	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		return 0;
	}

	public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
	{
		return 0;
	}

	public string GetWordAtPosition(Vector3 worldPos)
	{
		return null;
	}

	public string GetWordAtPosition(Vector2 localPos)
	{
		return null;
	}

	public string GetWordAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	public string GetUrlAtPosition(Vector3 worldPos)
	{
		return null;
	}

	public string GetUrlAtPosition(Vector2 localPos)
	{
		return null;
	}

	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	public int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		return 0;
	}

	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
	}

	public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
	}

	public void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, List<Vector3> symbolVerts, List<Vector2> symbolUVs, List<Color> symbolCols)
	{
	}

	public Vector2 ApplyOffset(List<Vector3> verts, int start)
	{
		return default(Vector2);
	}

	public void ApplyShadow(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, int start, int end, float x, float y)
	{
	}

	public int CalculateOffsetToFit(string text)
	{
		return 0;
	}

	public void SetCurrentProgress()
	{
	}

	public void SetCurrentPercent()
	{
	}

	public void SetCurrentSelection()
	{
	}

	public bool Wrap(string text, out string final)
	{
		final = null;
		return false;
	}

	public bool Wrap(string text, out string final, int height)
	{
		final = null;
		return false;
	}

	public void UpdateNGUIText()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}
}
