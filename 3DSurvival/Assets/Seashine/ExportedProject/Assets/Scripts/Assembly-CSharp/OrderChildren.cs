using System.Collections.Generic;
using UnityEngine;

public class OrderChildren : MonoBehaviour
{
	public bool horizontally;

	public bool vertically;

	public Vector2 spacing;

	public Vector2 offset;

	private Transform thisTransform;

	private List<Transform> activeChildren;

	private void Start()
	{
	}
}
