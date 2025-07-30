using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
	private enum TutorialTriggerAction
	{
		none = 0,
		allowUseOfStar = 1,
		endTutorial = 2
	}

	private enum UITriggerAction
	{
		none = 0,
		showEnergyBar = 1,
		showScore = 2
	}

	private GameManager gameManager;

	private TutorialManager tutorialManager;

	private UserInterfaceController userInterfaceController;

	public bool repeatable;

	public bool onlyPlayer;

	[SerializeField]
	private TutorialTriggerAction tutorialTriggerAction;

	[SerializeField]
	private UITriggerAction uiTriggerAction;

	private bool triggered;

	public GameObject targetObject;

	public bool sendToGameManager;

	public string targetFunction;

	public GameObject[] objectsToActivate;

	public GameObject[] objectsToDeactivate;

	private int totalObjToAct;

	private int totalObjToDeact;

	private bool hasObjToAct;

	private bool hasObjToDeact;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void SwitchActivation(GameObject[] gos, int totalObjects, bool b)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void ResetTrigger()
	{
	}
}
