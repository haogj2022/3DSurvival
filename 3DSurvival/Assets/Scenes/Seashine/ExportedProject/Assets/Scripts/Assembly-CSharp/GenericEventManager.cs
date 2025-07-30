using System;
using System.Collections.Generic;
using UnityEngine;

public class GenericEventManager : MonoBehaviour
{
	private static Dictionary<Type, List<Delegate>> eventDictionary;

	private static string eventSceneName;

	private void Awake()
	{
	}

	private static void CheckSceneMatches()
	{
	}

	public static void AddEventListener<T>(EventCallback<T> listener)
	{
	}

	public static List<Delegate> GetListenersOfEvent<T>()
	{
		return null;
	}

	public static void RemoveEventListener<T>(EventCallback<T> listener)
	{
	}

	public static void RemoveEvent<T>()
	{
	}

	public static void RemoveAllEvents()
	{
	}

	public static void TriggerEvent<T>(T data)
	{
	}
}
