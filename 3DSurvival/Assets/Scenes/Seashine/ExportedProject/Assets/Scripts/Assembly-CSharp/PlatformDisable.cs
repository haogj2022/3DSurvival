using UnityEngine;

public class PlatformDisable : MonoBehaviour
{
	[SerializeField]
	[Header("Disable on")]
	private bool iOS;

	[SerializeField]
	private bool android;

	[SerializeField]
	private bool amazon;

	protected void Awake()
	{
	}
}
