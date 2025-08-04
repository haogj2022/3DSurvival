using System.Collections.Generic;
using UnityEngine;

public class ThresholdTrigger : MonoBehaviour
{
	public int threshold;

	public bool repeatable;

	private bool triggered;

	private List<Transform> enteredTransforms;

	[Header("SEND MESSAGE")]
	public GameObject targetObject;

	public bool sendToGameManager;

	public string targetFunction;

	[Header("ENABLE")]
	public GameObject[] disabledGameObjects;

	public Rigidbody2D[] disabledRigidbodies;

	[Header("DISABLE")]
	public GameObject[] enabledGameObjects;

	public Rigidbody2D[] enabledRigidbodies;

	private void OnEnable()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
