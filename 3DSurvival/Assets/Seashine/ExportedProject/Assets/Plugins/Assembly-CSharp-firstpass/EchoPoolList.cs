using UnityEngine;

public class EchoPoolList
{
	public EchoGameObject active_last;

	public EchoGameObject active_first;

	public EchoGameObject inactive_first;

	public EchoGameObject inactive_last;

	private GameObject _go1;

	private GameObject _go2;

	private GameObject _go3;

	private GameObject _go4;

	public void AddNewObject(EchoGameObject iec)
	{
	}

	public EchoGameObject Inactive2Active()
	{
		return null;
	}

	public EchoGameObject GetFree()
	{
		return null;
	}

	public void Active2Inactive(EchoGameObject iec)
	{
	}

	public void ReturnPool(EchoGameObject iec)
	{
	}
}
