namespace Seashine.Core
{
	public interface IDiscoverable
	{
		string Name { get; }

		int Id { get; }

		int DiscoveryReward { get; }

		void Discover();
	}
}
