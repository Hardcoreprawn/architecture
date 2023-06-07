---
Title: Strangler pattern
Slug: strangler-pattern
Lead: Replace refactored code with new microservices to migrate gradually.
Description: This pattern is used to migrate functionality from an older app to a new one.
Tags:
  - Architecture
  - Patterns
  - Microservices
Categories:
  - Patterns
Draft: false
Published: 02/05/2023
---

Use this pattern to migrate functionality from an older app to a new one. This approach is typical for a monolith to a microservices migration; it works for any app.

## Pattern Overview

Replacing a monolithic system is complex and risky. The strangler pattern builds new functionality using modern design patterns alongside the monolith. A proxy integrates the user experience and ensures the aligned application makes sense to end users. Over time the monolith is slowly broken down.

![The Strangler Fig Tree][def2]

[def2]: https://farm4.staticflickr.com/3356/3600794227_4916f9924e_z.jpg

The pattern is named after the Australian Strangler Fig Tree, which roots in the upper branches of another tree and grows down and around the trunk, eventually taking root and ultimately destroying the original host tree.

![Strangler pattern, over time](/media/strangler-pattern-example.png)

The first step shows the monolith. Then a companion service is added behind a shared proxy. The next step adds more services, transitioning over to the new model. The last step shows the monolith being removed, along with the proxy.

## Benefits of this pattern

* A way to scale a solution over multiple dimensions
* Delivers gradual value over time, with lower risk than a rewrite
* Supports and allows for rollback
* Uses versioned APIs to reduce the need for collaboration
* Supports legacy integrations

## Drawbacks to this pattern

* Potential for increased latency because of new service dependencies
* Additional proxy decreases availability through multiplicative failure effect

## When to use this pattern

* Use the strangler for versioning and migration of services
* Use an existing proxy, such as Nginx, as scaffolding during the migration
* Manage the service rules during migration
* Remove rules as no longer needed and decommission the proxy when done

## When to avoid this pattern

* If you have to add a facade, don't add a proxy. It increases the call depth and hits latency poorly
* If latency is a concern, this won't help in the interim

## Approach

You can implement this pattern in two ways:

* Scaling along the service domains
* Scaling between the new and old services

Ideally, both together works well.

* Scaling along the service domains allows new services to be stood-up and integrated.
* Scaling alongside the existing services allows for rollback and A/B testing between the new and old services by sending a portion of calls to the new service.

Scaling along both these axis allows the target state to scale effectively.

## References

* [Martin Folwer - Strangler Fig Application](https://martinfowler.com/bliki/StranglerFigApplication.html)
* [Microsoft - Azure Architecture, Strangler Fig Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/strangler-fig)
* [AKF Partners - Strangler Patterns: Dos and Don'ts](https://akfpartners.com/growth-blog/strangler-pattern-dos-and-donts)
