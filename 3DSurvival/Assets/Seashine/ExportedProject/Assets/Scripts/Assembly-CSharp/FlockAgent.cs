using UnityEngine;

public class FlockAgent : MonoBehaviour
{
	private Transform thisTransform;

	[HideInInspector]
	public FlockController spawner;

	[HideInInspector]
	public Vector3 wayPoint;

	public float speed;

	[HideInInspector]
	public float stuckCounter;

	[HideInInspector]
	public float damping;

	[HideInInspector]
	public bool flatFlyDown;

	private int lerpCounter;

	public float targetSpeed;

	[HideInInspector]
	public bool move;

	private float waypointChangeDistanceSqr;

	private bool triggerControllerPositionChange;

	private Quaternion lookRotation;

	private float directionChangeTimout;

	private bool waitingWaypointChange;

	private float waypointChangeDelay;

	private Vector3 updatedPosition;

	private float lerpedSpeed;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void ForceWaypointChange()
	{
	}

	private void ChangeWaypoint()
	{
	}

	private void PickNewWaypoint()
	{
	}
}
