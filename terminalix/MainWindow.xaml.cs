using HandyControl.Themes;
using System;
using System.Diagnostics;
using System.Windows.Media;
using terminalix.api.Themes;
using terminalix.api.Logging;

namespace terminalix
{
	public partial class MainWindow
	{
		HandyControl.Controls.TextBox outputBox;
		Logger logger = new Logger();

		public MainWindow()
		{
			logger.Log(LogTypes.TRACE, "Initialize MainWindow");
			InitializeComponent();

			outputBox = (HandyControl.Controls.TextBox)FindName("Output");

			logger.Log(LogTypes.TRACE, "Switching theme to dark");

			ThemeSwitcher.SwitchTheme(ThemeManager.Current, Brushes.CornflowerBlue, ApplicationTheme.Dark);
		}

		private void OpenCmd(object sender, System.Windows.RoutedEventArgs e)
		{
			logger.Log(LogTypes.TRACE, "Opening cmd...");
			logger.Log(LogTypes.WARN, "This will be deprecated soon!");

			// TODO switch to winpty
			// TODO Make wrapper in api for cmd connection
			try
			{
				var process = new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "cmd.exe",
						RedirectStandardOutput = true,
						UseShellExecute = false,
						CreateNoWindow = true
					}
				};

				logger.Log(LogTypes.TRACE, "Connecting to cmd...");

				process.Start();

				while (!process.StandardOutput.EndOfStream)
				{
					logger.Log(LogTypes.TRACE, "Reading Output from cmd");
					var line = process.StandardOutput.ReadLine();
					Console.WriteLine(line);
				}

				process.WaitForExit();
			}
			catch (Exception err)
			{
				logger.Log(LogTypes.ERROR, "Error while connecting to cmd!", err);
			}
		}
	}
}