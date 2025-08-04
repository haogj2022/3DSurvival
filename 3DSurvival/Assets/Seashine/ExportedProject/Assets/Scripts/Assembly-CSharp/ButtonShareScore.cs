using UnityEngine;

public class ButtonShareScore : MonoBehaviour
{
	public enum shareModes
	{
		Intent = 0,
		Facebook = 1,
		Twitter = 2,
		GooglePlus = 3,
		Whatsapp = 4
	}

	private GameManager gameManager;

	private UserInterfaceController userInterfaceController;

	public shareModes shareMode;

	[SerializeField]
	private GameObject shareIconIOS;

	[SerializeField]
	private GameObject shareIconAndroid;

	private bool clicked;

	private string textToShare;

	private Texture2D textureToShare;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnClick()
	{
	}

	public void ShareScore()
	{
	}
}
