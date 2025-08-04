using UnityEngine;

public class ConstantForce2D : MonoBehaviour
{
	public Transform reference;

	public float force;

	private Vector2 forceDirection;

	private Rigidbody2D thisRigidbody2D;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}
}
