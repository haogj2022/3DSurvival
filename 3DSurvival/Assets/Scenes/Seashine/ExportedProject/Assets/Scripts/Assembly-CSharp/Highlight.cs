using UnityEngine;

public class Highlight : MonoBehaviour
{
	public EchoGameObject ego;

	public Material outlineMat;

	public Color outlineColor;

	public Material overlayMat;

	public Color overlayColor;

	public bool disableAtCollision;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void Disable()
	{
	}
}
