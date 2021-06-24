using HandyControl.Themes;
using HandyControl.Controls;
using System.Diagnostics;
using System.IO;
using System.Windows.Media;
using System.Windows.Controls;
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
			Process cmd = new Process();

			cmd.StartInfo.FileName = "cmd.exe";
			cmd.Start();
			StreamReader output = null;
			try
			{
				output = cmd.StandardOutput;
			}
			catch (InvalidOperationException err)
			{
				Console.WriteLine(err);
			}

			if(outputBox is HandyControl.Controls.TextBox)
			{
				outputBox.Text = output.ReadLine();
			}
			
		}
	}
}