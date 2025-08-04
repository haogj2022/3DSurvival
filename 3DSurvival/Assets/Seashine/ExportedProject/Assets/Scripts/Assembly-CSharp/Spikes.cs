using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class Spikes : MonoBehaviour
{
	public ObscuredFloat damage;

	public bool knockBack;

	public float knockBackForce;

	private float lastColTime;

	private Jelly playerScript;

	private void OnCollisionEnter2D(Collision2D other)
	{
	}
}
