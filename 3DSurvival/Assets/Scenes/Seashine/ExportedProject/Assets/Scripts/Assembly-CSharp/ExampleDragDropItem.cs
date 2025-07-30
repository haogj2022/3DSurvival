using UnityEngine;

[AddComponentMenu("NGUI/Examples/Drag and Drop Item (Example)")]
public class ExampleDragDropItem : UIDragDropItem
{
	public GameObject prefab;

	protected override void OnDragDropRelease(GameObject surface)
	{
	}
}
