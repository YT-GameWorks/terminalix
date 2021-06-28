namespace terminalix.api
{
	[System.Obsolete("Replaced by Logging api", true)]
	public enum ConsoleStateEnum
	{
		SW_HIDE,
		SW_SHOW
	}

	[System.Obsolete("Replaced by Logging api", true)]
	public static class ConsoleState
	{
		[System.Obsolete("Replaced by Logging api", true)]
		public static int GetConsoleState(ConsoleStateEnum console)
		{
			if (console == ConsoleStateEnum.SW_SHOW)
			{
				return 5;
			} else if (console == ConsoleStateEnum.SW_HIDE)
			{
				return 0;
			}

			return -1;
		}
	}
}
