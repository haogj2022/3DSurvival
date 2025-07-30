using UnityEngine;

public class CollectibleLight : MonoBehaviour
{
	private GameManager GManager;

	private Transform thisTransform;

	public bool persistent;

	private void Awake()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}
}
