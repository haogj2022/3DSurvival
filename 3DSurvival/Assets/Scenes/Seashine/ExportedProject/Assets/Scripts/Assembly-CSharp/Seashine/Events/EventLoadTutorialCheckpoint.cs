using Pated.Events;
using UnityEngine;

namespace Seashine.Events
{
	public class EventLoadTutorialCheckpoint : GameEvent
	{
		public float CheckpointEnergy { get; private set; }

		public int CheckpointScore { get; private set; }

		public int CheckpointStars { get; private set; }

		public Vector3 CheckpointPosition { get; private set; }

		public Quaternion CheckpointRotation { get; private set; }

		public EventLoadTutorialCheckpoint(float checkpointEnergy, int checkpointScore, int checkpointStars, Vector3 checkpointPosition, Quaternion checkpointRotation)
		{
		}
	}
}
