using HandyControl.Themes;
using System.Windows.Media;

namespace terminalix.api.Themes
{
	public static class ThemeSwitcher
	{
		public static void SwitchTheme(ThemeManager themeManager, Brush brush, ApplicationTheme theme)
		{
			themeManager.ApplicationTheme = theme;
			themeManager.AccentColor = brush;
		}

		public static ApplicationTheme GetTheme(ThemeManager themeManager)
		{
			return (ApplicationTheme)themeManager.ApplicationTheme;
		}

		public static Brush GetAccentColor(ThemeManager themeManager)
		{
			return themeManager.AccentColor;
		}
	}
}
