using UnityEngine;

namespace Pated.Events
{
	public class EventCurrencyCollected : GameEvent
	{
		public int CurrencyId;

		public int AmountCollected;

		public Vector3 CollectedAtPosition;
	}
}
