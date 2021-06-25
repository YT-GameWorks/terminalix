namespace terminalix.api
{
	public enum ConsoleStateEnum
	{
		SW_HIDE,
		SW_SHOW
	}

	public static class ConsoleState
	{
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
