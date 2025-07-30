using System;
using System.Collections.Generic;

namespace Pated.Events
{
	public class EventManager : Singleton<EventManager>
	{
		public delegate void EventDelegate<T>(T e) where T : GameEvent;

		private delegate void EventDelegate(GameEvent e);

		private Dictionary<Type, EventDelegate> delegates;

		private Dictionary<Delegate, EventDelegate> delegateLookup;

		protected EventManager()
		{
		}

		public static void AddListener<T>(EventDelegate<T> del) where T : GameEvent
		{
		}

		public static void RemoveListener<T>(EventDelegate<T> del) where T : GameEvent
		{
		}

		public static void Raise(GameEvent e)
		{
		}
	}
}
