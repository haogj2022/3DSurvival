using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public static class NGUITools
{
	public delegate void OnInitFunc<T>(T w) where T : UIWidget;

	[NonSerialized]
	private static AudioListener mListener;

	[NonSerialized]
	public static AudioSource audioSource;

	private static bool mLoaded;

	private static float mGlobalVolume;

	private static float mLastTimestamp;

	private static AudioClip mLastClip;

	[NonSerialized]
	private static List<UIWidget> s_widgets;

	private static Dictionary<Type, string> mTypeNames;

	private static Vector3[] mSides;

	public static KeyCode[] keys;

	[NonSerialized]
	private static Dictionary<string, UIWidget> mWidgets;

	[NonSerialized]
	private static UIPanel mRoot;

	[NonSerialized]
	private static GameObject mGo;

	private static ColorSpace mColorSpace;

	public static float soundVolume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static bool fileAccess => false;

	public static string clipboard
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Vector2 screenSize => default(Vector2);

	public static AudioSource PlaySound(AudioClip clip)
	{
		return null;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		return null;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		return null;
	}

	public static int RandomRange(int min, int max)
	{
		return 0;
	}

	public static string GetHierarchy(GameObject obj)
	{
		return null;
	}

	public static T[] FindActive<T>() where T : Component
	{
		return null;
	}

	public static Camera FindCameraForLayer(int layer)
	{
		return null;
	}

	public static void AddWidgetCollider(GameObject go)
	{
	}

	public static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	public static void UpdateWidgetCollider(GameObject go)
	{
	}

	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
	}

	public static void UpdateWidgetCollider(UIWidget w)
	{
	}

	public static void UpdateWidgetCollider(UIWidget w, BoxCollider box)
	{
	}

	public static void UpdateWidgetCollider(UIWidget w, BoxCollider2D box)
	{
	}

	public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
	}

	public static string GetTypeName<T>()
	{
		return null;
	}

	public static string GetTypeName(UnityEngine.Object obj)
	{
		return null;
	}

	public static void RegisterUndo(UnityEngine.Object obj, string name)
	{
	}

	public static void SetDirty(UnityEngine.Object obj, string undoName = "last change")
	{
	}

	public static void CheckForPrefabStage(GameObject gameObject)
	{
	}

	public static GameObject AddChild(GameObject parent)
	{
		return null;
	}

	public static GameObject AddChild(this GameObject parent, int layer)
	{
		return null;
	}

	public static GameObject AddChild(this GameObject parent, bool undo)
	{
		return null;
	}

	public static GameObject AddChild(this GameObject parent, bool undo, int layer)
	{
		return null;
	}

	public static GameObject AddChild(this Transform parent, GameObject prefab)
	{
		return null;
	}

	public static GameObject AddChild(this GameObject parent, GameObject prefab)
	{
		return null;
	}

	public static GameObject AddChild(this GameObject parent, GameObject prefab, int layer)
	{
		return null;
	}

	public static int CalculateRaycastDepth(GameObject go)
	{
		return 0;
	}

	public static int CalculateNextDepth(GameObject go)
	{
		return 0;
	}

	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		return 0;
	}

	public static int AdjustDepth(GameObject go, int adjustment)
	{
		return 0;
	}

	public static void BringForward(GameObject go)
	{
	}

	public static void PushBack(GameObject go)
	{
	}

	public static void NormalizeDepths()
	{
	}

	public static void NormalizeWidgetDepths()
	{
	}

	public static void NormalizeWidgetDepths(GameObject go)
	{
	}

	public static void NormalizeWidgetDepths(UIWidget[] list)
	{
	}

	public static void NormalizePanelDepths()
	{
	}

	public static UIPanel CreateUI(bool advanced3D)
	{
		return null;
	}

	public static UIPanel CreateUI(bool advanced3D, int layer)
	{
		return null;
	}

	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		return null;
	}

	public static void SetChildLayer(this Transform t, int layer)
	{
	}

	public static T AddChild<T>(this GameObject parent) where T : Component
	{
		return null;
	}

	public static T AddChild<T>(this GameObject parent, bool undo) where T : Component
	{
		return null;
	}

	public static T AddWidget<T>(this GameObject go, int depth = int.MaxValue) where T : UIWidget
	{
		return null;
	}

	public static UISprite AddSprite(this GameObject go, INGUIAtlas atlas, string spriteName, int depth = int.MaxValue)
	{
		return null;
	}

	public static GameObject GetRoot(GameObject go)
	{
		return null;
	}

	public static T FindInParents<T>(GameObject go) where T : Component
	{
		return null;
	}

	public static T FindInParents<T>(Transform trans) where T : Component
	{
		return null;
	}

	public static void Destroy(UnityEngine.Object obj)
	{
	}

	public static void DestroyChildren(this Transform t)
	{
	}

	public static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	public static void Broadcast(string funcName)
	{
	}

	public static void Broadcast(string funcName, object param)
	{
	}

	public static bool IsChild(Transform parent, Transform child)
	{
		return false;
	}

	private static void Activate(Transform t)
	{
	}

	private static void Activate(Transform t, bool compatibilityMode)
	{
	}

	private static void Deactivate(Transform t)
	{
	}

	public static void SetActive(GameObject go, bool state)
	{
	}

	public static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	private static void CallCreatePanel(Transform t)
	{
	}

	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	[Obsolete("Use NGUITools.GetActive instead")]
	public static bool IsActive(Behaviour mb)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool GetActive(Behaviour mb)
	{
		return false;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static bool GetActive(GameObject go)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	public static void SetLayer(GameObject go, int layer)
	{
	}

	public static Vector3 Round(Vector3 v)
	{
		return default(Vector3);
	}

	public static void MakePixelPerfect(Transform t)
	{
	}

	public static void FitOnScreen(this Camera cam, Transform t, bool considerInactive = false, bool considerChildren = true)
	{
	}

	public static void FitOnScreen(this Camera cam, Transform transform, Vector3 pos)
	{
	}

	public static void FitOnScreen(this Camera cam, Transform transform, Transform content, Vector3 pos, bool considerInactive = false)
	{
	}

	public static void FitOnScreen(this Camera cam, Transform transform, Transform content, Vector3 pos, out Bounds bounds, bool considerInactive = false)
	{
		bounds = default(Bounds);
	}

	public static bool Save(string fileName, byte[] bytes)
	{
		return false;
	}

	public static byte[] Load(string fileName)
	{
		return null;
	}

	public static Color ApplyPMA(Color c)
	{
		return default(Color);
	}

	public static void MarkParentAsChanged(GameObject go)
	{
	}

	[Obsolete("Use NGUIText.EncodeColor instead")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Obsolete("Use NGUIText.ParseColor instead")]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[Obsolete("Use NGUIText.StripSymbols instead")]
	public static string StripSymbols(string text)
	{
		return null;
	}

	public static T AddMissingComponent<T>(this GameObject go) where T : Component
	{
		return null;
	}

	public static Vector3[] GetSides(this Camera cam)
	{
		return null;
	}

	public static Vector3[] GetSides(this Camera cam, float depth)
	{
		return null;
	}

	public static Vector3[] GetSides(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	public static Vector3[] GetSides(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	public static Vector3[] GetWorldCorners(this Camera cam)
	{
		return null;
	}

	public static Vector3[] GetWorldCorners(this Camera cam, float depth)
	{
		return null;
	}

	public static Vector3[] GetWorldCorners(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	public static Vector3[] GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	public static string GetFuncName(object obj, string method)
	{
		return null;
	}

	public static void Execute<T>(GameObject go, string funcName) where T : Component
	{
	}

	public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
	}

	public static void ImmediatelyCreateDrawCalls(GameObject root)
	{
	}

	public static string KeyToCaption(KeyCode key)
	{
		return null;
	}

	public static KeyCode CaptionToKey(string caption)
	{
		return default(KeyCode);
	}

	public static T Draw<T>(string id, OnInitFunc<T> onInit = null) where T : UIWidget
	{
		return null;
	}

	public static Color GammaToLinearSpace(this Color c)
	{
		return default(Color);
	}

	public static Color LinearToGammaSpace(this Color c)
	{
		return default(Color);
	}

	public static bool CheckIfRelated(INGUIAtlas a, INGUIAtlas b)
	{
		return false;
	}

	public static void Replace(INGUIAtlas before, INGUIAtlas after)
	{
	}

	public static bool CheckIfRelated(INGUIFont a, INGUIFont b)
	{
		return false;
	}
}
