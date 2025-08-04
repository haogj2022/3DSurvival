using UnityEngine;

[AddComponentMenu("NGUI/Examples/Lag Rotation")]
public class LagRotation : MonoBehaviour
{
	public float speed;

	public bool ignoreTimeScale;

	private Transform mTrans;

	private Quaternion mRelative;

	private Quaternion mAbsolute;

	public void OnRepositionEnd()
	{
	}

	private void Interpolate(float delta)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
