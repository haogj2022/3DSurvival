using UnityEngine;

public class PlayerControlled : MonoBehaviour
{
	private const string AnimIdle = "BreathingIdle";

	private const string AnimForward = "Running";

	private const string AnimBackward = "RunningBackward";

	private const string AnimLeft = "Running";

	private const string AnimRight = "Running";

	private float _moveSpeed;

	private Transform _origTarget;

	private string _currentAnim;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}
}
