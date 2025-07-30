using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pated.Events
{
	public class StringEventManager : MonoBehaviour
	{
		private Dictionary<string, Action> eventDictionary;

		private static StringEventManager eventManager;

		public static StringEventManager Instance => null;

		private void Init()
		{
		}

		public static void StartListening(string eventName, Action listener)
		{
		}

		public static void StopListening(string eventName, Action listener)
		{
		}

		public static void TriggerEvent(string eventName)
		{
		}
	}
}
