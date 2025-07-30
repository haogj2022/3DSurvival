using System.Collections.Generic;
using Pated;
using Seashine.NPC;
using UnityEngine;

public class GameDatabase : ScriptableObject
{
	public List<Jellyfish> jellyfishes;

	public List<Ability> abilities;

	[Header("ENCYCLOPEDIA")]
	[SerializeField]
	private LifeformConfig[] lifeforms;

	[Header("KOHATORA")]
	public KohatoraPieceData[] kohatoraPieces;

	public List<KohatoraRecipe> kohatoraRecipes;

	public LifeformConfig[] Lifeforms => null;
}
