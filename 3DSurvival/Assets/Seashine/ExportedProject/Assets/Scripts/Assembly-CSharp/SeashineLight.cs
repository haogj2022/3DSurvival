using System;
using UnityEngine;

[ExecuteInEditMode]
public class SeashineLight : MonoBehaviour
{
	[NonSerialized]
	public SeashineLight next;

	[NonSerialized]
	public SeashineLight prev;

	[NonSerialized]
	public Light uLight;

	public SeashineLightType type;

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
