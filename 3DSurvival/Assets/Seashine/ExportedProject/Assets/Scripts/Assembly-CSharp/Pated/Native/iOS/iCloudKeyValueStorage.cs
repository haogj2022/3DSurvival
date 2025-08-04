using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pated.Native.iOS
{
	public class iCloudKeyValueStorage
	{
		private bool debugMode;

		public event Action<string> OnICloudBoolReceivedAction
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<iCloudData> OnICloudDataReceivedAction
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<List<iCloudData>> OnICloudStoreDidChangeExternally
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public iCloudKeyValueStorage(bool debugMode)
		{
		}

		public void Initialize()
		{
		}

		public void Synchronize()
		{
		}

		public string[] GetAllKeys()
		{
			return null;
		}

		public bool HasKey(string key)
		{
			return false;
		}

		public void DeleteKey(string key)
		{
		}

		public bool GetBool(string key)
		{
			return false;
		}

		public void SetBool(string key, bool value)
		{
		}

		public string GetString(string key)
		{
			return null;
		}

		public void SetString(string key, string value)
		{
		}

		public void SetObject(string key, object obj)
		{
		}

		private void OnCloudDataChanged(string data)
		{
		}

		private void OnBoolIsTrue(string _key)
		{
		}

		private void OnCloudData(string array)
		{
		}

		private void OnCloudDataEmpty(string array)
		{
		}
	}
}
