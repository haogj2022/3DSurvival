using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	private static object _lock;

	private static bool applicationIsQuitting;

	public static T Instance => null;

	public void OnDestroy()
	{
	}
}
