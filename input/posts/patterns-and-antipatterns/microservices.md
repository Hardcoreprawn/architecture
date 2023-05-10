---
Title: Microservices
Slug: microservices
Lead: Minimise dependencies and promote scalability.
Description: Microservices are a collection of application services that are independently deployable, loosely coupled and organized around business capabilities.
Tags:
  - Architecture
  - Microservices
  - Patterns
Categories:
  - Pattern
Draft: false
Published: 09/05/2023-16:50
Image: "../../media/header01.png"
---

Microservices are a way to build applications and are used by some of the biggest sites and systems online, such as Netflix and Amazon. They let systems be updated safely and scale well. But they are complex and require firm principles in place to work properly.

## Pattern Overview

Microservices architecture is an architectural style that structures an application as a collection of services that are independently deployable, loosely coupled, organized around business capabilities and owned by a small team. In simple terms, microservices are a specific method of designing software systems to structure a single application as a collection of loosely coupled services.

![Microservices Pattern](/media/microservices-patterns.png)
*Model of a Monolith to Microservices migration, showing sub-patterns*

This is a reference pattern, with several optional sub-patterns.

## Benefits of this pattern

* Scale and resilience in each service.
* Safe deployment of updates to individual services.
* Separation of services, allowing changes to be made locally and quickly, with
minimal impact on other services.

## Drawbacks to this pattern

* It can be complex, quickly.
* Overwhelming for a small number of teams, due to a large number of
components.
* The Danger of component sprawl if services are over-specialized.

## When to use this pattern

* This pattern is for applications that need to grow, which need to manage
their costs and support a large degree of change and experimentation.
* When reliability is critical to business, reputation or safety.

## When to avoid this pattern

* Because you want to be down with the kids, and you think it's cool.
* Because you want to use the 'best' type of technology and work at Google.
* For a simple application, which doesn't have a high probability of needing
change, addition or integration.
* For an application that won't be making lots of changes, with lots of
active users.
* For your Blog.

## Approach

Typically, microservices architectures require a good understanding of the business domain model, before development can begin. This ensures that services align with specific functions, which can be built in line with the business. [Conways Law](https://en.wikipedia.org/wiki/Conway's_law) states that any organisation which designs a system will design one that looks like the organisation. This needs to be considered as if your microservices don't align with your business model, it will be very difficult to succeed.

## Assumptions

In choosing this pattern, you ruled out simpler options as not being capable.

* You have time and space for teams to find their way; this is hard and it
will go wrong.

## Related Articles

* [Microservices Anti-Patterns](xref:microservices-anti-patterns)
* [Microsoft - Microservices design](https://learn.microsoft.com/en-us/azure/architecture/microservices/)
* [AKF Partners - Microservices Architecture Principles](https://akfpartners.com/growth-blog/microservice-architecture-principles)
