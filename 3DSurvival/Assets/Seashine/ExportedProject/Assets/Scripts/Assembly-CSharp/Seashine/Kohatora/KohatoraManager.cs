using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Pated;
using UnityEngine;

namespace Seashine.Kohatora
{
	public class KohatoraManager : MonoBehaviour
	{
		[SerializeField]
		private GameDatabase gameDatabase;

		[SerializeField]
		private ExplorationManager explorationManager;

		public List<string> assembledKohatoras;

		public Dictionary<string, Int3> piecesCount;

		public List<int> hiddenPieces;

		private Dictionary<int, KohatoraRecipe> kohatoraRecipesByTarget;

		public event Action<KohatoraUnlockType, string> OnKohatoraUnlocked
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

		private void Start()
		{
		}

		private void KohatoraSetup()
		{
		}

		public void UnlockKohatora(KohatoraUnlockType kohatoraType, string kohatoraTarget)
		{
		}

		private void CacheRecipes()
		{
		}

		public Int2 GetPieceSize(int pieceId)
		{
			return default(Int2);
		}
	}
}
