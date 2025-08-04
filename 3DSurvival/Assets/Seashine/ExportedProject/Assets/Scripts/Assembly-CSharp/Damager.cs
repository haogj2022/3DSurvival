using UnityEngine;

public class Damager : MonoBehaviour
{
	private GameManager GManager;

	private Transform player;

	private Jelly playerScript;

	private Transform thisTransform;

	[SerializeField]
	private float damage;

	[SerializeField]
	private bool knockBack;

	[SerializeField]
	private float knockBackForce;

	private float lastColTime;

	[SerializeField]
	private bool spawnEffect;

	[SerializeField]
	private string effectName;

	[SerializeField]
	private DeathType deathType;

	private void Awake()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}
}
