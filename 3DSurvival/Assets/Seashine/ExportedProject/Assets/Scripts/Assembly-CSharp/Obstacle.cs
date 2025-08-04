using UnityEngine;

public class Obstacle : MonoBehaviour
{
	private GameManager gameManager;

	public GameObject[] obstacles;

	private int totalObstacles;

	public int difficultyTrigger;

	public float rarity;

	public bool restrictAngle;

	public float minAngle;

	public float maxAngle;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private bool CheckOrientation()
	{
		return false;
	}

	private void OnDisable()
	{
	}
}
