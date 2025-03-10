using System;
using Devlead.Statiq.Themes;
using Statiq.App;
using Statiq.Common;
using Statiq.Lunr; // Ensure this using directive is correct and the package is referenced
using Statiq.Web;
using Microsoft.Extensions.Logging; // Add this using directive for logging

try
{
    await Bootstrapper
      .Factory
      .CreateDefault(args)
      .AddThemeFromUri(new Uri("https://github.com/statiqdev/CleanBlog/archive/main.zip"))
      .AddWeb()
      .RunAsync();
}
catch (Exception ex)
{
    Console.Error.WriteLine($"An error occurred: {ex.Message}");
    Environment.Exit(1);
}

// This will start a local web server and you can view your site in your browser at http://localhost:5080.

// Ensure the Statiq.Lunr package is referenced in your project file (.csproj).