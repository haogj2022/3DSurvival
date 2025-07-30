using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class MouseOrbitImproved : MonoBehaviour
{
	public Transform target;

	public float scrollMult;

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public float yMinLimit;

	public float yMaxLimit;

	public float distanceMin;

	public float distanceMax;

	private PlayerControlled controlled;

	private float x;

	private float y;

	private bool locked;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
