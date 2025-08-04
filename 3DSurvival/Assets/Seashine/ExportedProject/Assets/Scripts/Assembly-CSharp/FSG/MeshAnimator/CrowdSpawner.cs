using System.Collections.Generic;
using UnityEngine;

namespace FSG.MeshAnimator
{
	public class CrowdSpawner : MonoBehaviour
	{
		private static List<CrowdSpawner> spawners;

		public GameObject[] options;

		public string[] optionsDesc;

		public string[] meshAnimationNames;

		public string[] otherInfo;

		public int sizeOfCrowd;

		public int selectedOption;

		public int maxSize;

		public float radius;

		public float slopeStart;

		public float slopeAmount;

		public Vector2 radiusScaler;

		public Vector3 baseScale;

		public bool randomizeTime;

		public bool showGUI;

		private string fps;

		private int previousFrame;

		private int previousSelection;

		private List<GameObject> spawnedObjects;

		private int guiOffset;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateFPS()
		{
		}

		private void SpawnCrowd()
		{
		}

		private void OnGUI()
		{
		}
	}
}
