using HandyControl.Data;
using HandyControl.Themes;
using HandyControl.Tools;
using System;
using System.Windows;

namespace ui
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			UpdateSkin(SkinType.Dark);
		}

		public void UpdateSkin(SkinType skin)
		{
			SharedResourceDictionary.SharedDictionaries.Clear();
			Resources.MergedDictionaries.Add(ResourceHelper.GetSkin(skin));
			Resources.MergedDictionaries.Add(new ResourceDictionary
			{
				Source = new Uri("pack://application:,,,/HandyControl;component/Themes/Theme.xaml")
			});
		}
	}
}
