using HandyControl.Themes;
using System;
using System.Diagnostics;
using System.Windows.Media;
using terminalix.api.Themes;

namespace terminalix
{
	public partial class MainWindow
	{
		HandyControl.Controls.TextBox outputBox;

		public MainWindow()
		{
			InitializeComponent();

			outputBox = (HandyControl.Controls.TextBox)FindName("Output");

			ThemeSwitcher.SwitchTheme(ThemeManager.Current, Brushes.CornflowerBlue, ApplicationTheme.Dark);
		}

		private void OpenCmd(object sender, System.Windows.RoutedEventArgs e)
		{
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

				process.Start();

				while (!process.StandardOutput.EndOfStream)
				{
					var line = process.StandardOutput.ReadLine();
					Console.WriteLine(line);
				}

				process.WaitForExit();
			}
			catch (Exception err)
			{
				Console.WriteLine(err.Message);
			}
		}
	}
}