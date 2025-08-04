using System;
using System.Collections.Generic;

[Serializable]
public class VersionDifficultyMonitoring
{
	public List<JellyfishPerformancePerMinute> JellyfishesPerformancePerMinute;

	private Dictionary<string, JellyfishPerformancePerMinute> performancePerMinuteByJellyfish;

	public void AddNewJellyfishPerformancePerMinute(string jellyfishName, int points, int stars, float durationInSeconds)
	{
	}

	public void SaveToJSON(string filePath)
	{
	}
}
