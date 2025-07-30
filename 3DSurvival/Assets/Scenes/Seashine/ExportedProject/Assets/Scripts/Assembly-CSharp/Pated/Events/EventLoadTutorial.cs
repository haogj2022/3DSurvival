namespace Pated.Events
{
	public class EventLoadTutorial : GameEvent
	{
		public bool IsPlayerRequest { get; private set; }

		public EventLoadTutorial(bool isPlayerRequest)
		{
		}
	}
}
