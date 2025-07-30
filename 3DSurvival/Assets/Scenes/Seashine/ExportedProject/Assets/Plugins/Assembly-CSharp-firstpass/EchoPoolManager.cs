using UnityEngine;

public class EchoPoolManager : MonoBehaviour
{
	[HideInInspector]
	public EchoPoolList echoObjectPool;

	public int NumberOfPoolObjects;

	public GameObject GameObjectPrefab;

	private void Awake()
	{
	}
}
