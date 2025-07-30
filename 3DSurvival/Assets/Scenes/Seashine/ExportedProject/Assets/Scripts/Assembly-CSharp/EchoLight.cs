using System;
using UnityEngine;

[ExecuteInEditMode]
public class EchoLight : MonoBehaviour
{
	[NonSerialized]
	public EchoLight next;

	[NonSerialized]
	public EchoLight prev;

	[NonSerialized]
	public Light uLight;

	public EchoLightType type;

	[NonSerialized]
	public float dist;

	[NonSerialized]
	public Transform cachedTransform;

	[NonSerialized]
	public bool lightOn;

	[NonSerialized]
	public bool inList;

	[HideInInspector]
	public int findex;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init()
	{
	}
}
