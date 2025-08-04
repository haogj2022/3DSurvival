using UnityEngine;

public class EchoEyeController : EchoGameObject
{
	public int eyeUvSetSize;

	public float uvPadding;

	public float moveSpeed;

	private Transform _lookAt;

	private int _xSet;

	private int _ySet;

	private int _xSetStart;

	private int _ySetStart;

	private int _xSetEnd;

	private int _ySetEnd;

	private float _AngleX1;

	private float _AngleX2;

	private float _AngleY1;

	private float _AngleY2;

	private float _xLength;

	private float _yLength;

	private float _movePer;

	private float _moveTime;

	private float _moveTimeDest;

	private bool _lookFound;

	private bool _looking;

	private Vector3 _oldPos;

	private void Start()
	{
	}

	public void LookAtTransform(Transform itrans)
	{
	}

	private void LookAt(Vector3 ipos)
	{
	}

	private void Update()
	{
	}
}
