using System.Collections.Generic;
using UnityEngine;

public abstract class AN_ProxyPool
{
	private static Dictionary<string, AndroidJavaObject> pool;

	public static void CallStatic(string className, string methodName, params object[] args)
	{
	}

	public static ReturnType CallStatic<ReturnType>(string className, string methodName, params object[] args)
	{
		return default(ReturnType);
	}
}
