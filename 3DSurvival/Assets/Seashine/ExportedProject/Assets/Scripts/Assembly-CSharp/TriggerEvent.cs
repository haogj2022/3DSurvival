using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
	private GameManager GManager;

	public bool repeatable;

	public bool onlyPlayer;

	private bool triggered;

	public GameObject targetObject;

	public bool sendToGameManager;

	public string targetFunction;

	public GameObject[] objectsToActivate;

	public GameObject[] objectsToDeactivate;

	private int totalObjToAct;

	private int totalObjToDeact;

	private bool hasObjToAct;

	private bool hasObjToDeact;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void SwitchActivation(GameObject[] gos, int totalObjects, bool b)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void Reset()
	{
	}
}
