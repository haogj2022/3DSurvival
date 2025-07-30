using Pated.Events;
using Seashine.WorldGeneration;
using UnityEngine;

public class Egg : MonoBehaviour
{
	[SerializeField]
	private GameObject intactEgg;

	[SerializeField]
	private GameObject brokenEgg;

	[SerializeField]
	private GameObject breakParticleEffect;

	private void Start()
	{
	}

	private void OnGameReset(EventGameReset e)
	{
	}

	private void OnUnloadChunks(EventUnloadChunks e)
	{
	}

	private void ResetEgg()
	{
	}

	public void BreakEgg()
	{
	}

	private void DisableEgg()
	{
	}
}
