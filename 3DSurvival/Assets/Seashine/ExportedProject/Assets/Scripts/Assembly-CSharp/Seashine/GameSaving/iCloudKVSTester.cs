using System.Collections.Generic;
using Pated.Native.iOS;
using UnityEngine;

namespace Seashine.GameSaving
{
	public class iCloudKVSTester : MonoBehaviour
	{
		private iCloudKeyValueStorage iCloudKeyValueStorage;

		private const string STRING_TEST_KEY = "TestString";

		private const string STRING_TEST_VALUE = "Hello World! κόσμε";

		private void Start()
		{
		}

		public void Initialize()
		{
		}

		public void TestHasKey()
		{
		}

		public void TestDeleteKey()
		{
		}

		public void TestGetAllKeys()
		{
		}

		public void TestGetString()
		{
		}

		public void TestSetString()
		{
		}

		private void OniCloudKVSDidChangeExternally(List<iCloudData> changedData)
		{
		}
	}
}
