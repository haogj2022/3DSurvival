using Pated.Events;
using UnityEngine;

public class DespawnEffectOnRestart : MonoBehaviour
{
	private bool applicationQuitting;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void DespawnEffect(EventGameReset e)
	{
	}
}
