using UnityEngine;

public class TestVisualQualityMenu : MonoBehaviour
{
	[Header("SCREENSHOT")]
	public GameDatabase gameDatabase;

	private Camera ScreenshotCamera;

	private Texture2D screenshotTex;

	private Rect screenshotZone;

	private int screenWidth;

	private float screenshotCooldown;

	private int currentWildlifeIndex;

	private Transform currentlyDisplayed;

	private float nextFrame;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ShowNextModel()
	{
	}

	private void Update()
	{
	}

	public void ExitTesting()
	{
	}
}
