using Seashine.WorldGeneration;
using UnityEngine;

namespace Seashine.Currency
{
	public class CollectibleStar : MonoBehaviour
	{
		private GameManager gameManager;

		private Transform thisTransform;

		public Chunk parentChunk;

		public ChunkLazySpawner lazySpawner;

		private bool triggered;

		private string FX_Collected;

		private string SFX_Collected;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void CollectStar()
		{
		}
	}
}
