using UnityEngine;

[RequireComponent(typeof(UISprite))]
[AddComponentMenu("NGUI/Examples/UI Cursor")]
public class UICursor : MonoBehaviour
{
	public static UICursor instance;

	public Camera uiCamera;

	private Transform mTrans;

	private UISprite mSprite;

	private INGUIAtlas mAtlas;

	private string mSpriteName;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void Clear()
	{
	}

	public static void Set(INGUIAtlas atlas, string sprite)
	{
	}
}
