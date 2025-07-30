using UnityEngine;

public class Guide : MonoBehaviour
{
	private int orientation;

	public GameObject connecteur;

	public GameObject deadEnd;

	public bool randomize;

	public float probability;

	public bool allowTeleporter;

	public float teleporterProbability;

	private float limit;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Switch(bool withinLimits)
	{
	}
}
