using System.Collections.Generic;
using UnityEngine;

public class UIGeometry
{
	public delegate void OnCustomWrite(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2);

	public List<Vector3> verts;

	public List<Vector2> uvs;

	public List<Color> cols;

	public OnCustomWrite onCustomWrite;

	private List<Vector3> mRtpVerts;

	private Vector3 mRtpNormal;

	private Vector4 mRtpTan;

	public bool hasVertices => false;

	public bool hasTransformed => false;

	public void Clear()
	{
	}

	public void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals = true)
	{
	}

	public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
	{
	}
}
