using HandyControl.Themes;
using System.Diagnostics;
using System.Windows.Media;
using System;

namespace ui
{
	public partial class MainWindow
	{
		HandyControl.Controls.TextBox outputBox;

		public MainWindow()
		{
			InitializeComponent();

			outputBox = (HandyControl.Controls.TextBox)FindName("Output");

			ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
			ThemeManager.Current.AccentColor = Brushes.CornflowerBlue;
		}

		private void OpenCmd(object sender, System.Windows.RoutedEventArgs e)
		{
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