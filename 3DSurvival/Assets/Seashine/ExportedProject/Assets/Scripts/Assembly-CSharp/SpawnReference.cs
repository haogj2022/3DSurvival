using System;
using UnityEngine;

[Serializable]
public class SpawnReference
{
	public string name;

	public Vector3 position;

	public Quaternion rotation;

	public Vector3 scale;

	public SpawnReference(string _name, Vector3 _scale)
	{
	}

	public SpawnReference(string _name, Vector3 _position, Quaternion _rotation)
	{
	}

	public SpawnReference(string _name, Vector3 _position, Vector3 _scale)
	{
	}

	public SpawnReference(string _name, Vector3 _position, Quaternion _rotation, Vector3 _scale)
	{
	}
}
