---
Title: Microservices
Lead: Minimise dependencies and promote scalability.
Description: Microservices are a collection of application services that are independently deployable, loosely coupled and organised around business capabilities.
Tags:
  - Architecture
  - Microservices
  - Patterns
Categories: []
Draft: false
Published: 09/05/2023
Image: ../../media/header01.png
---

Microservices are a way to build applications used by some of the biggest sites and systems online, such as Netflix and Amazon. They let systems be updated safely and scale well. But they are complex and require firm principles in place to work correctly.

## Pattern Overview

Microservices architecture is an architectural style that structures an application as a collection of independently deployable services, loosely coupled, organised around business capabilities and owned by a small team. In simple terms, microservices are a specific method of designing software systems to structure a single application as a collection of loosely coupled services.

![Microservices Pattern](/media/microservices-patterns.png)
*A Model of a Monolith to Microservices migration, showing sub-patterns*

This image shows a reference pattern with several optional sub-patterns.

## Benefits of this pattern

* Scale and resilience in each service.
* Safe deployment of updates to individual services.
* Separation of services, allowing changes to be made locally and quickly, with
minimal impact on other services.

## Drawbacks to this pattern

* It can be complex, quickly
* Overwhelming for a small number of teams due to the many components
* The Danger of component sprawl if services are over-specialized

## When to use this pattern

* This pattern is for applications that need to grow, manage their costs and support significant change and experimentation
* When reliability is critical to business, reputation or safety

## When to avoid this pattern

* Because you want to be down with the kids, and you think it's cool
* Because you want to use the 'best' type of technology and work at Google
* For a simple application which doesn't have a high probability of needing
change, addition or integration
* For an application that won't be making lots of changes, with lots of
active users
* For your Blog.

## Approach

Typically, microservices architectures require a good understanding of the business domain model before development can begin. Ensure that services align with specific functions, built in line with the business capabilities. [Conways Law](https://en.wikipedia.org/wiki/Conway's_law) states that any organisation which designs a system will create one that looks like the organisation. Consider this: succeeding will be challenging if your microservices don't align with your business model.

## Assumptions

* Everyone has read[Microservices by James Lewis and Martin Fowler](https://martinfowler.com/articles/microservices.html)
* In choosing this pattern, you ruled out more straightforward options as not being capable.
* You have time and space for teams to find their way; this is hard and will go wrong.

## Related Articles

* [Lewis, J. and Fowler, M. (2014) Microservices, martinfowler.com](https://martinfowler.com/articles/microservices.html)
* [Microservices Anti-Patterns](xref:microservices-anti-patterns)
* [Microsoft - Microservices design](https://learn.microsoft.com/en-us/azure/architecture/microservices/)
* [AKF Partners - Microservices Architecture Principles](https://akfpartners.com/growth-blog/microservice-architecture-principles)
