using UnityEngine;

public class Rarity : MonoBehaviour
{
	private GameManager GManager;

	public GameObject targetObject;

	public int minDifficulty;

	public int maxDifficulty;

	public float rarity;

	private bool unlimitedDif;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}
}
