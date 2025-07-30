using UnityEngine;

[RequireComponent(typeof(UIInput))]
[AddComponentMenu("NGUI/Examples/Chat Input")]
public class ChatInput : MonoBehaviour
{
	public UITextList textList;

	public bool fillWithDummyData;

	private UIInput mInput;

	private void Start()
	{
	}

	public void OnSubmit()
	{
	}
}
