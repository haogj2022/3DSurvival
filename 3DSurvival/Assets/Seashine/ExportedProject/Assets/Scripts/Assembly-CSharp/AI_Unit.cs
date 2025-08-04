using System;
using FSG.MeshAnimator;
using UnityEngine;

public class AI_Unit : MonoBehaviour
{
	public enum ActionType
	{
		idle = 0,
		move = 1,
		die = 2,
		attack = 3
	}

	[Serializable]
	public struct AIAction
	{
		public ActionType type;

		public MeshAnimationBase[] animations;
	}

	private static int _maxMovingUnits;

	private static int _movingUnits;

	public MeshAnimatorBase meshAnimator;

	public AIAction[] actions;

	public float maxMoveDistance;

	public float moveSpeed;

	private bool _chooseNewAction;

	private AIAction _currentAction;

	private float _actionEndTime;

	private Vector3 _currentPosition;

	private Vector3 _movePosition;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Tick(float time, float deltaTime)
	{
	}

	private void PerformAction(float time, float deltaTime)
	{
	}
}
