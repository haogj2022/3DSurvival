using System;
using Seashine.Kohatora;

[Serializable]
public class KohatoraRecipe
{
	public string target;

	public KohatoraUnlockType type;

	public KohatoraPiecePlacement[] recipe;
}
