using UnityEngine;

[AddComponentMenu("NGUI/Examples/Equipment")]
public class InvEquipment : MonoBehaviour
{
	private InvGameItem[] mItems;

	private InvAttachmentPoint[] mAttachments;

	public InvGameItem[] equippedItems => null;

	public InvGameItem Replace(InvBaseItem.Slot slot, InvGameItem item)
	{
		return null;
	}

	public InvGameItem Equip(InvGameItem item)
	{
		return null;
	}

	public InvGameItem Unequip(InvGameItem item)
	{
		return null;
	}

	public InvGameItem Unequip(InvBaseItem.Slot slot)
	{
		return null;
	}

	public bool HasEquipped(InvGameItem item)
	{
		return false;
	}

	public bool HasEquipped(InvBaseItem.Slot slot)
	{
		return false;
	}

	public InvGameItem GetItem(InvBaseItem.Slot slot)
	{
		return null;
	}
}
