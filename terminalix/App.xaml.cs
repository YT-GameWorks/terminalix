using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using terminalix.api;

namespace terminalix
{
	public partial class App : Application
	{
		[DebuggerNonUserCode]
		public void InitralizeComponent()
		{

#line 4 "..\..\..\App.xaml"
			this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);

#line default
#line hidden
		}

		[STAThread]
		[DebuggerNonUserCode]
		public static void main(string[] args)
		{
			var handle = ConsoleManager.GetConsoleWindow();
#if DEBUG
			ConsoleManager.ShowWindow(handle, ConsoleState.GetConsoleState(ConsoleStateEnum.SW_SHOW));
#else
			ConsoleManager.ShowWindow(handle, ConsoleState.GetConsoleState(ConsoleStateEnum.SW_HIDE));
#endif
			var app = new App();
			app.InitializeComponent();
			app.Run();
		}
	}

}
