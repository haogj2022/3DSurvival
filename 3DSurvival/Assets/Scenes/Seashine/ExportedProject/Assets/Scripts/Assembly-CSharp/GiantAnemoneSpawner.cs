using Seashine.GameSaving;
using UnityEngine;

public class GiantAnemoneSpawner : MonoBehaviour
{
	private GameSaver gameSaver;

	private Transform spawnedAnemone;

	[Range(0f, 1f)]
	public float probability;

	public GameObject tutorialTiki;

	private bool applicationQuitting;

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
