---
Title: Microservices
Lead: Microservices architecture is a 'super-pattern', which aims to minimise dependencies and promote scalability across multiple dimensions.
Description: Microservices architecture is an architectural style that structures an application as a collection of services that are independently deployable, loosely coupled, organized around business capabilities and owned by a small team. In simple terms, microservices are a specific method of designing software systems to structure a single application as a collection of loosely coupled services.
Tags:
  - Architecture
  - Microservices
  - Pattern
Categories:
  - Pattern
Published: 01/01/2001
Draft: true
---

## Pattern Overview

Microservices architecture is an architectural style that structures an application as a collection of services that are independently deployable, loosely coupled, organized around business capabilities and owned by a small team. In simple terms, microservices are a specific method of designing software systems to structure a single application as a collection of loosely coupled services.

### Illustration

![microservices-pattern][def-1-msft-img]
*Model of a Monolith to Microservices migration, showing sub-patterns*

This is a reference microservices pattern, showing the possible use of sub-patterns.

## Benefits of this pattern

* Scale and resilience in each service.
Safe deployment of updates to individual services.
* Separation of services, allowing changes to be made locally and quickly, with
minimal impact on other services.
* The ability for several teams to work together on different areas. Can support
regular and frequent changes.

***

## Drawbacks to this pattern

* It can be complex, quickly.
* Overwhelming for a small number of teams, due to a large number of
components.
* The Danger of component sprawl if services are over-specialized.

***

## When to use this pattern

* This pattern is for applications that need to grow, which need to manage
their costs and support a large degree of change and experimentation.
* When reliability is critical to business, reputation or safety.

***

## When to avoid this pattern

* Because you want to be down with the kids, and you think it's cool.
* Because you want to use the 'best' type of technology and work at Google.
* For a simple application, which doesn't have a high probability of needing
change, addition or integration.
* For an application that won't be making lots of changes, with lots of
active users.
* For your Blog.

***

## Assumptions

In choosing this pattern, you ruled out simpler options as not being capable.

* You have time and space for teams to find their way; this is hard and it
will go wrong.

***

## Anti-Patterns of the microservices architecture

### Distributed Monolith

When you split a monolith, don't let your services become dependent on each
or several other microservices. If changes in services require redeployment or
change in other services, you've built a distributed monolith.
Lastly, over-dependency can also manifest in long deployment times, as too many
changes have to occur at once. Sometimes it shows that deployment has to
happen in a particular order.

This is a [Big-Ball-Of-Mud][def2] that also has network-level latencies to
deal with now.

[def2]: http://www.laputan.org/mud/mud.html#BigBallOfMud

***

### Overly Chatty

Another risk is the amount of communication. Services are distributed, so calls
between them take time. Overly chatty services are not performant; the latency
can kill the performance. Following [SOLID][def1] principles can help here.

[def1]: https://en.wikipedia.org/wiki/SOLID

***

### Shared Persistence

A monolith typically requires a large shared data store. Microservices should
each have their own data store, to avoid resource contention. Each store should
be accessible only by the associated service. Any communication needs to be via
the API interfaces.

***

### Heavyweight services

Building too much into each service makes them slow. Build/latency delays kick
in and you are back to building monoliths.

***

### No API Gateway

Data Interfaces need to be identifiable, they need to be managed, and they need
authentication. It has to be something you can find to query.

***

### Entangled Data

Isolate the data inside the application.

***

### Improper Versioning

Build API versions into your URI calls.

***

## Sub-patterns

A successful migration of monolith to microservices will likely use many
different patterns. Some common ones are linked here.

### Ambassador

An Ambassador sits between two services and negotiates. Typically a proxy
service can interpret. An ambassador is often used to offload or mask client
interoperability issues. An ambassador is a specialized sidecar.

[Ambassador Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/ambassador)

***

### Anti-corruption

When two systems don't properly understand each other, an Anti-corruption
layer can be introduced to protect the new architecture.

[Anti-corruption Layer pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/anti-corruption-layer)

***

### Backends for Frontends

Sometimes, it's just quicker to write APIs that deal with specific clients. It
might take more maintenance, but that can be ok.

[Backends for Frontends pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/backends-for-frontends)

***

### Bulkhead

Bulkheads are used on ships to prevent water from a hull breach from flooding
the whole ship. Keep things separate, (like connection pools or hardware)
so a greedy neighbour can't flood the whole ship.

[Bulkhead Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/bulkhead)

***

### Gateways

Using a gateway for your microservices offers several benefits, by making your
collection of services look like a single web server.

#### Aggregation

Clients can connect to a single endpoint to make requests, which are then
forwarded to different microservices. This makes the client connection light
and easy

[Gateway Aggregation](https://learn.microsoft.com/en-us/azure/architecture/patterns/gateway-aggregation)

#### Offloading

The gateway can offload shared functionality, such as authentication, TLS
certificates or issuing Authorisation tokens.

[Gateway Offloading](https://learn.microsoft.com/en-us/azure/architecture/patterns/gateway-offloading)

#### Routing

The service all appears to come from a single domain, so much easier for a
client to manage connections to and from the service, improving security.

[Gateway Routing](https://learn.microsoft.com/en-us/azure/architecture/patterns/gateway-routing)

***

### Sidecar

deploy helper apps into separate containers to encapsulate them, but keep
them close for performance.

[Sidecar Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/sidecar)

***

### Strangler

Refactor over time, by gradually replacing specific services.

[Strangler Pattern](xref:strangler-pattern)

[def-1-msft-img]: ../../media/images/microservices-patterns.png
