using System;
using System.Runtime.InteropServices;

namespace terminalix.api
{
	[System.Obsolete("Replaced by Logging api", true)]
	public static class ConsoleManager
	{
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
	}
}
