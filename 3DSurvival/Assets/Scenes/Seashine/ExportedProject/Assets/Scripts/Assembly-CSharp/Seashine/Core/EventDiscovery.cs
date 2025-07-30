using Pated.Events;

namespace Seashine.Core
{
	public class EventDiscovery : GameEvent
	{
		public readonly IDiscoverable Discovery;

		public EventDiscovery(IDiscoverable discovery)
		{
		}
	}
}
