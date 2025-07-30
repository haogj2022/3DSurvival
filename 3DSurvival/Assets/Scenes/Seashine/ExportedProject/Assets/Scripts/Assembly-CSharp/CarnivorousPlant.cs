using UnityEngine;

public class CarnivorousPlant : MonoBehaviour
{
	private GameManager GManager;

	public bool debugMode;

	public Rigidbody2D leftJaw;

	public Rigidbody2D rightJaw;

	private Transform leftJawTsfm;

	private Transform rightJawTsfm;

	private float difficultyFactor;

	public float jawStrength;

	private float reopenTimer;

	public bool rare;

	private bool playerInside;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
