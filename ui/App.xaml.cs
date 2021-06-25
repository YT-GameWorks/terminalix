using System.Windows;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System;

namespace terminalix
{
	public partial class App : Application
	{
		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		const int SW_HIDE = 0;
		const int SW_SHOW = 5;


		[DebuggerNonUserCode]
		public void InitializeComponent()
		{

#line 4 "..\..\..\App.xaml"
			this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);

#line default
#line hidden
		}

		[STAThread]
		[DebuggerNonUserCode]
		public static void Main(string[] args)
		{
			var handle = GetConsoleWindow();
#if DEBUG
			ShowWindow(handle, SW_SHOW);
#else
			ShowWindow(handle, SW_HIDE);
#endif
			var app = new App();
			app.InitializeComponent();
			app.Run();
		}
	}

}
