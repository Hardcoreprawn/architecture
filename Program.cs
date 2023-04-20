using System;
using Devlead.Statiq.Themes;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

await Bootstrapper
  .Factory
  .CreateDefault(args)
  .AddWeb()
  .RunAsync();