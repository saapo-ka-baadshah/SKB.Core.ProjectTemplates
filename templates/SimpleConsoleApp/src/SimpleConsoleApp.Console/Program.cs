﻿using JetBrains.Annotations;
using Microsoft.Extensions.Hosting;
using SKB.App.SimpleConsoleApp.Console.Extensions;

namespace SKB.App.SimpleConsoleApp.Console;

/// <summary>
/// Public Start-point for the program
/// </summary>
[PublicAPI]
internal class Program
{
    /// <summary>
    /// Main method to call the SimpleConsoleApp Console program
    /// </summary>
    /// <param name="args">arguments pass through</param>
    private static void Main(string[] args)
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        // Add Configurations
        builder.AddConfigurations();

        // Run the hosted application

        var app = builder.Build();
        app.Run();
    }
}
