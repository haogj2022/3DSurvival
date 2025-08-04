using UnityEngine;

[RequireComponent(typeof(UIWidget))]
public class NGUILocalize : MonoBehaviour
{
	private Localizer localizer;

	private UIWidget widget;

	private UILabel lbl;

	public string key;

	private void Awake()
	{
	}

	public void Localize()
	{
	}
}
