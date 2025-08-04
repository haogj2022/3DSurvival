using UnityEngine;

namespace Seashine.Behaviours
{
	[RequireComponent(typeof(Collider2D))]
	public class ReleaseToxins : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem[] emitters;

		[SerializeField]
		private Transform toxicZonePrefab;

		[SerializeField]
		private LayerMask layerMask;

		[SerializeField]
		private float minimumInterval;

		[SerializeField]
		private float emissionDuration;

		private float readyTime;

		private float emissionEndTime;

		private Transform spawnedToxicZone;

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

		private void Update()
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void Release()
		{
		}

		private void SpawnToxicZone()
		{
		}

		private void DespawnToxicZone()
		{
		}
	}
}
