using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace tic_tac_toe_complex;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
