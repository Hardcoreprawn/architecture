﻿using System;
using Devlead.Statiq.Themes;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

await Bootstrapper
  .Factory
  .CreateDefault(args)
  .AddThemeFromUri(new Uri("https://github.com/statiqdev/CleanBlog/zipball/master"))
  .AddWeb()
  .RunAsync();