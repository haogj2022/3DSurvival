using System;
using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Interaction/Envelop Content")]
public class EnvelopContent : MonoBehaviour
{
	[Tooltip("The widgets used to determine the content bounds should reside underneath this root object")]
	public Transform targetRoot;

	[Tooltip("Value added to the left border (usually negative)")]
	public int padLeft;

	[Tooltip("Value added to the right border (usually positive)")]
	public int padRight;

	[Tooltip("Value added to the bottom border (usually negative)")]
	public int padBottom;

	[Tooltip("Value added to the top border (usually positive)")]
	public int padTop;

	[Tooltip("Minimum desired width, used only if the value is above 0")]
	public int minWidth;

	[Tooltip("Minimum desired height, used only if the value is above 0")]
	public int minHeight;

	[Tooltip("If true, disabled widgets will be ignored and won't be used for bounds calculations")]
	public bool ignoreDisabled;

	[NonSerialized]
	private bool mStarted;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[ContextMenu("Execute")]
	public void Execute()
	{
	}
}
