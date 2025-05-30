﻿using System.Windows;
using System.Windows.Input;

namespace Smart_Home_App;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	private void Border_MouseDown(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left)
		{
			this.DragMove();
		}
	}

	bool IsMaximized = false;
	private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2)
		{
			if (IsMaximized)
			{
				this.WindowState = WindowState.Normal;
				this.Width = 1080;
				this.Height = 720;
				IsMaximized = false;
			}
			else
			{
				this.WindowState = WindowState.Maximized;
				this.Width = SystemParameters.PrimaryScreenWidth;
				this.Height = SystemParameters.PrimaryScreenHeight;
				IsMaximized = true;
			}
		}
	}
}