using System;
using System.Collections.Generic;

[Serializable]
public class JellyfishPerformancePerMinute
{
	public string JellyfishName;

	public List<int> PointsPerGame;

	public List<int> StarsPerGame;

	public List<float> DurationPerGame;

	public JellyfishPerformancePerMinute(string jellyfishName, int points, int stars, float durationPerGame)
	{
	}

	public void AddNewValues(int points, int stars, float gameDurationInSeconds)
	{
	}
}
