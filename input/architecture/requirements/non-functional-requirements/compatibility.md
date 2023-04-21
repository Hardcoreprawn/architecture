---
title: Compatability
description: Ensuring whatever we build has broad compatibility means we build for common target system architecture.
slug: compatability
---
* Drives the target deployment system. Too tight and it affects supply and scale. Too restrictive and it becomes harder to grow and support.
* Have a commodity normal environment, which is easy to reproduce.
* Use a readily available architecture, the more commodity the better.
* Host on a 'normal' image. Slowly evolve so everything uses that image.
* Be somewhat specific, but not into the versions. Specify minimum versions.
* Stick to using APIs to communicate between services to minimise compatibility issues.
a. We use Ubuntu (LTS) with dotnet >3.0, on an amd64 architecture.
i. Exceptions are fine when necessary.
b. Example: Compatibility requirements - IBM Documentation
