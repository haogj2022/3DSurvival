using UnityEngine;

public class PerspectivePixelPerfect : MonoBehaviour
{
	[Tooltip("Bias is a value above 0 that determines how far offset the object will be from the near clip, in percent (near to far clip)")]
	public float bias;

	[ContextMenu("Execute")]
	private void Start()
	{
	}
}
