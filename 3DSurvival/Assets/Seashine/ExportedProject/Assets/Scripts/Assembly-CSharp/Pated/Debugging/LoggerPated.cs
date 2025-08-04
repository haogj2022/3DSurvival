namespace Pated.Debugging
{
	public static class LoggerPated
	{
		public enum Mode
		{
			Disabled = 0,
			Verbose = 1,
			Normal = 2
		}

		public static Mode CurrentMode;

		public static void Log(string message, bool onlyLogInVerboseMode = false)
		{
		}

		public static void LogWarning(string message, bool onlyLogInVerboseMode = false)
		{
		}

		public static void LogError(string message, bool onlyLogInVerboseMode = false)
		{
		}

		private static bool CanLog(bool onlyLogInVerboseMode)
		{
			return false;
		}
	}
}
