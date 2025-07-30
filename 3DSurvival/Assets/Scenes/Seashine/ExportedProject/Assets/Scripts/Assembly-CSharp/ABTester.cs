using UnityEngine;

public class ABTester : MonoBehaviour
{
	[HideInInspector]
	public bool testerType;

	public bool testGameoverAdBtn;

	public int rewardA;

	public int additionalRewardTimeA;

	public int rewardB;

	public int additionalRewardTimeB;

	[HideInInspector]
	public int additionalGameoverAdCount;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public int gameoverAdBtnReward()
	{
		return 0;
	}
}
