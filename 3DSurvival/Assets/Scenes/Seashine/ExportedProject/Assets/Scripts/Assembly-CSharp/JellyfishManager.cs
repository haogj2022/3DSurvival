using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Seashine.GameSaving;
using UnityEngine;

public class JellyfishManager : MonoBehaviour
{
	[SerializeField]
	private GameDatabase gameDatabase;

	private GameSaver gameSaver;

	[SerializeField]
	private Jelly playerScript;

	private Transform playerTransform;

	public Jellyfish selectedJellyfish;

	private int totalJellyfishes;

	[HideInInspector]
	public List<GameObject> loadedJellyfishes;

	private bool jellyfishLoaded;

	[HideInInspector]
	public List<Jellyfish> displayableJellyfishes;

	private bool jellyfishAlreadyRevealed;

	public event Action<Jellyfish> OnJellyfishUnlocked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void InitJellyfish()
	{
	}

	private bool IsJellyfishAvailable(string jellyfishName)
	{
		return false;
	}

	public string GetSavedJellyfishName()
	{
		return null;
	}

	public Jellyfish GetJellyfishByName(string jellyfishName)
	{
		return null;
	}

	public void SwitchJellyfish(Jellyfish newJellyfish)
	{
	}

	public void SwitchJellyfish(string jellyfishName)
	{
	}

	private void LoadJellyfish(string jellyfishName)
	{
	}

	private void RefreshDisplayableJellyfishes()
	{
	}

	public void UnlockJellyfish(Jellyfish unlockedJellyfish, bool saveToCloud)
	{
	}

	public void RevealSecretJellyfish(Jellyfish revealedJellyfish)
	{
	}

	private void ReportUnlockedJellyfish(Jellyfish unlockedJellyfish)
	{
	}
}
