using UnityEngine;

public class Mechanism : MonoBehaviour
{
	public enum Type
	{
		Area = 0,
		Push = 1,
		Slot = 2
	}

	public Type type;

	private bool triggered;

	public bool Triggered { get; protected set; }

	private void Start()
	{
	}

	private void Update()
	{
	}
}
