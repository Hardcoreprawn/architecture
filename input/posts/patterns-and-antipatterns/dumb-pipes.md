---
Title: Dump Pipes
Lead: Microservices communication is a critical aspect of distributed systems. Learn how to design and implement effective communication between microservices
Tags:
  - Architecture
  - Patterns
  - Microservices
Draft: false
Published: 15/05/2023
Slug: dumb-pipes
Categories:
  - Patterns
Description: This page is about designing and implementing effective communication between microservices in a distributed system.
---

As services scale in a microservices architecture, they need to communicate. A communication network is important, to make sure each service can easily talk to the others, but as they scale, it's important to make sure they can grow and continue to communicate.

This pattern uses the principle of 'Smart end-points, dumb pipes'. If the pipes are clever, they need maintenance, everyone has to wait on the team which is responsible for the pipe, which reduces time to market.

If the pipe is dumb, anyone can send a message easily, anyone can consume a message easily. They may need to adjust the format, but that's something they can do within their team.

A truly stupid pipe should handle routing and that's it.

## Illustration

![A diagram showing communications in a Microservices architecture](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/architect-microservice-container-applications/media/communication-in-microservice-architecture/sync-vs-async-patterns-across-microservices.png)
> Anti-patterns and patterns in communication between microservices [from learn.microsoft.com](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/architect-microservice-container-applications/communication-in-microservice-architecture)

## Rationale

Summarizing all of the above, the benefits of smart endpoints and dumb pipes are:

* Lower cost of messaging infrastructure - pushes the cost of goods sold closer to the producer and consumer. Allows messaging infrastructure to scale by the number of messages instead of the computational complexity of messages. License cost is reduced as fewer compute nodes are needed for message transit.
* Organization Scalability – teams aren’t reliant on transforms created by a centralized team.
* Low Latency – because computation is limited, messages are delivered more quickly and predictably to end consumers.
* Capacity and scalability of messaging infrastructure – increased significantly as compute is not part of the scale of the platform.
* Availability of messaging infrastructure – because computing is removed, so is a type of failure. As such, availability increases.

## Assumptions

* Messages will need to be in a defined format, which anyone can reference and understand on their own. An API with a contract is a good way to do this.
* Teams will need to adhere to contracts. These can be changed (issues, etc.), but this should be done properly.

## References

* [Lewis, J. and Fowler, M. (2014) Microservices, martinfowler.com.](https://martinfowler.com/articles/microservices.html.)
* [Architecture Principles: Messaging Systems – Smart End Points, Dumb Pipes | AKF Partners](https://akfpartners.com/growth-blog/architecture-principle-messaging-systems-smart-end-points-dumb-pipes)
* [Smart Endpoints and Dumb Pipes, Nathan Peck](https://nathanpeck.com/microservice-principles-smart-endpoint-dumb-pipe/)
* [Nishanil et al. (2022) Communication in a microservice architecture, learn.microsoft.com.](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/architect-microservice-container-applications/communication-in-microservice-architecture)
