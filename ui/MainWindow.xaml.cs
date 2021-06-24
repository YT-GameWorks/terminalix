using HandyControl.Themes;
using System.Windows.Media;

namespace ui
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
			ThemeManager.Current.AccentColor = Brushes.Red;
		}
	}
}
