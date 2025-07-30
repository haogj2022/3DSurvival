using UnityEngine;

namespace ClockStone
{
	[AddComponentMenu("ClockStone/PoolableObject")]
	public class PoolableObject : MonoBehaviour
	{
		[Tooltip("Specifies the maximum number of objects on the pool")]
		public int maxPoolSize;

		[Tooltip("Specifies the number of objects that will be created on the pool at program start (improves speed of later instantiation)")]
		public int preloadCount;

		[Tooltip("If enabled the pool of deactivated objects will surivive a scene change")]
		public bool doNotDestroyOnLoad;

		public bool sendAwakeStartOnDestroyMessage;

		public bool sendPoolableActivateDeactivateMessages;

		public bool useReflectionInsteadOfMessages;

		internal bool _isInPool;

		internal ObjectPoolController.ObjectPool _pool;

		internal int _serialNumber;

		internal int _usageCount;

		internal bool _awakeJustCalledByUnity;

		internal bool _wasInstantiatedByObjectPoolController;

		private bool _justInvokingOnDestroy;

		public bool IsPooledInstance => false;

		protected void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		public int GetSerialNumber()
		{
			return 0;
		}

		public int GetUsageCount()
		{
			return 0;
		}

		public int DeactivateAllPoolableObjectsOfMyKind()
		{
			return 0;
		}

		public bool IsDeactivated()
		{
			return false;
		}

		internal void _PutIntoPool()
		{
		}

		internal void TakeFromPool(Transform parent, bool activateObject)
		{
		}
	}
}
