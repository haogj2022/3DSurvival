using UnityEngine;

public class BorderTeleporter : MonoBehaviour
{
	public enum TeleporterAxis
	{
		Horizontal = 0,
		Vertical = 1,
		Both = 2
	}

	private Vector3 teleporterPosition;

	private BoxCollider2D boxCollider2D;

	private float triggerWidth;

	private float triggerHeight;

	private Vector3 teleportationOffset;

	private GameManager GManager;

	private Transform player;

	public TeleporterAxis teleporterAxis;

	private Transform mainCamera;

	private ParticleSystem.Particle[] parts;

	public LayerMask teleportableAnimals;

	private Collider2D[] nearbyAnimalColliders;

	private int totalNearbyAnimals;

	private Transform animalToTeleport;

	private DynamicBone animalDynamicBone;

	private void Start()
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void TeleportNearbyAnimals(Vector3 playerPosition)
	{
	}

	private void TeleportParticles(Vector3 teleportOffset)
	{
	}
}
