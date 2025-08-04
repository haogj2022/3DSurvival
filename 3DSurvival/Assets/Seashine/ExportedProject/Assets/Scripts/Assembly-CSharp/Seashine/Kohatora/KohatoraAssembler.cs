using System.Collections.Generic;
using Pated;
using UnityEngine;

namespace Seashine.Kohatora
{
	public class KohatoraAssembler : MonoBehaviour
	{
		private class KohatoraWidgetData
		{
			public GameObject go;

			public Transform tsfm;

			public KohatoraPieceWidgetData[] pieces;
		}

		private class KohatoraPieceWidgetData
		{
			public GameObject go;

			public Transform tsfm;

			public UISprite sprite;

			public KohatoraPieceWidgetData(GameObject pieceGameObject, Transform pieceTransform, UISprite pieceSprite)
			{
			}
		}

		[SerializeField]
		private GameDatabase gameDatabase;

		[SerializeField]
		private KohatoraManager kohatoraManager;

		[SerializeField]
		private GameObject pieceTemplate;

		[SerializeField]
		private GameObject kohatoraTemplate;

		[SerializeField]
		private GameObject assembledPieceTemplate;

		private Transform assembler;

		private bool[,] assemblerSlots;

		private Transform draggedPiece;

		private Int3 draggedPieceData;

		private Transform[] placedPiecesByTransform;

		private int[] placedPiecesByPieceId;

		private string[] placedPiecesByPieceName;

		private List<Transform> activePieces;

		private List<Transform> piecePool;

		[SerializeField]
		private UISprite inventoryFrame;

		private int pieceInventoryColumns;

		private int pieceInventoryRows;

		private float pieceInventorySpacing;

		private int pieceInventoryRow;

		private Dictionary<Int2, Vector3> inventorySlotPositions;

		private Vector3 inventoryPieceScale;

		private List<Transform> inventoryPieces;

		private List<int> showcasableKohatoraIds;

		private KohatoraWidgetData[] showcaseKohatoraWidgets;

		[Header("KOHATORA POPUP")]
		public GameObject popUp;

		public GameObject titleNew;

		public UISprite popUpCategorySprite;

		public UISprite popUpIllustrationSprite;

		public UILabel popUpDescriptionLabel;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnKohatoraUnlock(KohatoraUnlockType kohatoraType, string kohatoraTarget)
		{
		}

		private void OnDragFinished()
		{
		}

		private void DropPiece(Transform piece, bool fromDrag)
		{
		}

		private bool TryPlacePiece()
		{
			return false;
		}

		private Int2 GetNearestAssemblerSlot(Vector3 fromPosition, float range)
		{
			return default(Int2);
		}

		private Vector3 GetAssemblerlotPosition(int _x, int _y)
		{
			return default(Vector3);
		}

		private bool HasRoom(int pieceId, Int2 slot)
		{
			return false;
		}

		private void RemovePieceFill(Transform piece)
		{
		}

		private void RemovePieceFromAssembler(Transform piece)
		{
		}

		private Int2 AssemblerIndexToSlot(int index)
		{
			return default(Int2);
		}

		private void VerifyRecipe()
		{
		}

		private void CleanAssembler(bool deletePieces)
		{
		}

		private void SetupPieceInventorySlots()
		{
		}

		private void SetupPieceInventory()
		{
		}

		private void SortPieceInventory()
		{
		}

		private bool IsVisibleInventoryPiece(int index)
		{
			return false;
		}

		private Vector3 GetInventoryPositionByIndex(int index)
		{
			return default(Vector3);
		}

		private void SetupKohatoraShowcase()
		{
		}

		private void ShowcaseKohatora(int holderIndex, string kohatoraTarget)
		{
		}

		private void ShowKohatoraPopUp(KohatoraUnlockType kohatoraType, string kohatoraTarget, bool newKohatora)
		{
		}

		public void HideKohatoraPopUp()
		{
		}
	}
}
