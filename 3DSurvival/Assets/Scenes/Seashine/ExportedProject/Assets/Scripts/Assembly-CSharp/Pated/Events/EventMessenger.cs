using System;
using System.Collections.Generic;

namespace Pated.Events
{
	public class EventMessenger : Singleton<EventMessenger>
	{
		public delegate void EventDelegate<T>(T e) where T : GameEvent;

		private readonly Dictionary<Type, Delegate> _delegates;

		protected EventMessenger()
		{
		}

		public void AddListener<T>(EventDelegate<T> listener) where T : GameEvent
		{
		}

		public void RemoveListener<T>(EventDelegate<T> listener) where T : GameEvent
		{
		}

		public void Raise<T>(T e) where T : GameEvent
		{
		}
	}
}
