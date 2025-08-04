using UnityEngine;

public class Teleporter : MonoBehaviour
{
	private GameObject gameManagerGO;

	private GameManager gameManager;

	private GameObject player;

	private Jelly playerScript;

	private ParticleSystem pSwimParticles;

	private ParticleSystem pBubbleParticles;

	private ParticleSystem pDustParticles;

	public Transform[] dropPoints;

	private int totalDPs;

	private bool randomize;

	private Transform mainCam;

	private void Awake()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void TeleportParticles(ParticleSystem ps, Vector3 dropPoint)
	{
	}
}
