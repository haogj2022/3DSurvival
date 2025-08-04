using UnityEngine;

public class Vahatitipa : MonoBehaviour
{
	[SerializeField]
	private Transform topJaw;

	[SerializeField]
	private Rigidbody2D topJawRigidbody2D;

	[SerializeField]
	private Transform topCollider;

	[SerializeField]
	private Transform bottomJawBone;

	[SerializeField]
	private Rigidbody2D bottomJawRigidbody;

	private Transform bottomJawColliderTransform;

	[SerializeField]
	private float closingForce;

	[SerializeField]
	private float openingForce;

	private bool closing;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
