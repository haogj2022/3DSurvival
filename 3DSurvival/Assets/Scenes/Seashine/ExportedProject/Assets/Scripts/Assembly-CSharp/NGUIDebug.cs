using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Debug")]
public class NGUIDebug : MonoBehaviour
{
	private static bool mRayDebug;

	private static List<string> mLines;

	private static NGUIDebug mInstance;

	public static bool debugRaycast
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void CreateInstance()
	{
	}

	private static void LogString(string text)
	{
	}

	public static void Log(params object[] objs)
	{
	}

	public static void Log(string s)
	{
	}

	public static void Clear()
	{
	}

	public static void DrawBounds(Bounds b)
	{
	}

	private void OnGUI()
	{
	}
}
