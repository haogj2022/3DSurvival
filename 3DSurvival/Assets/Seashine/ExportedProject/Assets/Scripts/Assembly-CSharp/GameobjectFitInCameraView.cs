using UnityEngine;

public class GameobjectFitInCameraView : MonoBehaviour
{
	[SerializeField]
	private Transform scaledTransform;

	[SerializeField]
	private Camera targetCamera;

	[SerializeField]
	[Range(0f, 1f)]
	private float marginInPercentage;

	private void Start()
	{
	}
}
