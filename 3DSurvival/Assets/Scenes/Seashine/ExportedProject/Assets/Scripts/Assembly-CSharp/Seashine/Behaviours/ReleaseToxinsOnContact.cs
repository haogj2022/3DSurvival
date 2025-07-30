using UnityEngine;

namespace Seashine.Behaviours
{
	[RequireComponent(typeof(Collider2D))]
	public class ReleaseToxinsOnContact : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem[] emitters;

		[SerializeField]
		private Transform toxicArea;

		[SerializeField]
		private Transform head;

		[SerializeField]
		private LayerMask layerMask;

		[SerializeField]
		private float minimumInterval;

		[SerializeField]
		private float emissionDuration;

		[SerializeField]
		private float smoothSpeed;

		private float readyTime;

		private float emissionEndTime;

		private bool emitting;

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

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
		}

		private void Release(bool alreadyEmitting)
		{
		}
	}
}
