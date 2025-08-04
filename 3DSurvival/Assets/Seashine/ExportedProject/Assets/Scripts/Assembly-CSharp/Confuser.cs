using UnityEngine;

public class Confuser : MonoBehaviour
{
	private GameManager GManager;

	public Transform[] Exits;

	private int totalExits;

	public GameObject Door;

	private Vector3 newPosition;

	private bool buildDone;

	public GameObject startPiece;

	public GameObject endPiece;

	public GameObject[] midPieces;

	public int minimumConfusion;

	public bool increaseConfWDif;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void Reset()
	{
	}
}
