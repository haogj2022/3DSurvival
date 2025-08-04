using UnityEngine;

[AddComponentMenu("NGUI/Examples/UI Storage Slot")]
public class UIStorageSlot : UIItemSlot
{
	public UIItemStorage storage;

	public int slot;

	protected override InvGameItem observedItem => null;

	protected override InvGameItem Replace(InvGameItem item)
	{
		return null;
	}
}
