using System;
using UnityEngine;

[Serializable]
public class Animal
{
	public string name;

	public bool dynamicSpawn;

	public GameObject prefab;

	public float minimumDepth;

	public float maximumDepth;

	public float minimumSize;

	public float maximumSize;

	public float rarity;

	public bool matchDifficulty;

	public int minimumDifficulty;

	public int maximumDifficulty;

	public int maximumPerChunk;

	public RevelationMethod revelationMethod;

	public int discoveryReward;

	public bool specialDiscoveryMethod;

	public bool biomeArapoa;

	public bool biomeIatuku;

	public bool biomeKore;

	public bool biomeKuiti;

	public bool biomeHoro;

	public bool biomePokapango;

	public bool biomeWahitapu;

	public int[] biomeIds;

	public string ENG_name;

	public string ENG_description;

	public string FR_name;

	public string FR_description;

	public string ES_name;

	public string ES_description;

	public string PT_name;

	public string PT_description;

	public string IT_name;

	public string IT_description;

	public string DE_name;

	public string DE_description;

	public string RU_name;

	public string RU_description;

	public string JP_name;

	public string JP_description;

	public string KR_name;

	public string KR_description;

	public string ZH_name;

	public string ZH_description;
}
