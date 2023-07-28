using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Circleland4X_Maui_Skia;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
