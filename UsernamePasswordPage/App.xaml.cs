﻿namespace UsernamePasswordPage;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new UsernamePassword();
	}
}
