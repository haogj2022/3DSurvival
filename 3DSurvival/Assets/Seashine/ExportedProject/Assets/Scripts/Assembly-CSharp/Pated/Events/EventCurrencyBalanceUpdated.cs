namespace Pated.Events
{
	public class EventCurrencyBalanceUpdated : GameEvent
	{
		public int currencyId;

		public int previousBalance;

		public int newBalance;
	}
}
