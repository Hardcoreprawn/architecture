---
Title: Dumb Pipes
Lead: Microservices communication is a critical aspect of distributed systems. Learn how to design and implement effective communication between microservices.
Tags:
  - Architecture
  - Patterns
  - Microservices
Draft: false
Published: 15/05/2023
Categories:
  - Patterns
Description: This page is about designing and implementing effective communication between microservices in a distributed system.
---

As services scale in a microservices architecture, they need to communicate. A communication network is essential to ensure each service can easily talk to the others. Still, as they scale, you must ensure they can grow and continue communicating.

This pattern uses the principle of 'Smart end-points, dumb pipes'. If the pipes are clever, they need maintenance; everyone has to wait on the team which is responsible for the pipe, which reduces time to market.

If the pipe is dumb, anyone can send a message quickly; anyone can consume a message easily. They may need to adjust the format, but they can do that within the team.

A truly stupid pipe should handle routing, and that's it.

## Illustration

![A diagram showing communications in a Microservices architecture](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/architect-microservice-container-applications/media/communication-in-microservice-architecture/sync-vs-async-patterns-across-microservices.png)
> Anti-patterns and patterns in communication between microservices [from learn.microsoft.com](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/architect-microservice-container-applications/communication-in-microservice-architecture)

## Rationale

Summarising all of the above, the benefits of smart endpoints and dumb pipes are:

* Lower cost of messaging infrastructure - pushes the cost of goods sold closer to the producer and consumer. Allows messaging infrastructure to scale by the number of messages instead of the computational complexity of messages. Less complexity means fewer nodes, which means fewer licenses!
* Organization Scalability – teams aren’t reliant on transforms created by a centralised team.
* Low Latency – because computation is limited, messages are delivered more quickly and predictably to end consumers.
* Capacity and scalability of messaging infrastructure – increased as compute is not part of the platform's scale.
* Availability of messaging infrastructure – reduced compute means reduced chance of failure.

## Assumptions

* Messages must be in a defined format which anyone can reference and understand. An API with a contract is an excellent way to do this.
* Teams will need to adhere to contracts.

## References

* [Lewis, J. and Fowler, M. (2014) Microservices, martinfowler.com.](https://martinfowler.com/articles/microservices.html.)
* [Architecture Principles: Messaging Systems – Smart End Points, Dumb Pipes | AKF Partners](https://akfpartners.com/growth-blog/architecture-principle-messaging-systems-smart-end-points-dumb-pipes)
* [Smart Endpoints and Dumb Pipes, Nathan Peck](https://nathanpeck.com/microservice-principles-smart-endpoint-dumb-pipe/)
* [Nishanil et al. (2022) Communication in a microservice architecture, learn.microsoft.com.](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/architect-microservice-container-applications/communication-in-microservice-architecture)
