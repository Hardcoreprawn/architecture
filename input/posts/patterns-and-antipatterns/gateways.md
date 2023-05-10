---
Title: Gateways
Lead: Decomposed services need to look all joined up
Description: Once you have decomposed your web services, how do you keep the user experience connected, easy and secure?
Tags:
  - Architecture
  - Microservices
  - Patterns
Categories:
  - Patterns
Draft: false
Published: 09/05/2023-14:39
Image: "../../media/header01.png"
---

Exposing multiple services out of a container cluster can cause issues and complexity as you scale out the number of services. The Gateway pattern uses a proxy to manage several complexities and performance improvements.

The gateway pattern has three main facets, whish are discussed and can be implemented separately, but typically all on the same gateway(s).

## When to Avoid

Don't use this pattern for small sites, or even a handful of services; the overhead will be excessive.

## When to use

Use this pattern when you get into more than a handful of services with multiple teams working across them, with a moderate to large user-base.

### Routing

One way to connect clients to services is direct. A direct client-to-microservice architecture provides the fewest moving parts. However, each service requires a TCP port to connect to. As each service is using a different port, this can start to prove difficult to manage, especially for security-conscious customers, who need to minimise exposure.

![Direct-to-Client Routing. Count those endpoints!](../../media/direct-to-client.png)

This can be even more complex when multiple services start to be available, which offer the same functionality. Which service do I connect to? How do I find the right service? It can be further worsened if different versions of the same service start to be in use, such as A/B testing.

![Gateway-Routing, just one way in or out](../../media/gateway-routing.png)

Gateway Aggregation makes use of a proxy service, in-front of the microservice endpoints, redirecting pages and folders, hiding details of the production layout away from the outside world, so changes can be made and introduced in a lot simpler manner.

[Gateway Routing](https://learn.microsoft.com/en-us/azure/architecture/patterns/gateway-routing)

### Offloading

Using a gateway allows shared services or cross-cutting concerns to be handled in line for multiple services. These can be things like:

* Authentication or authorisation
* SSL Offloading and certificate management
* Network Monitoring and throttling

In some cases, these items might need special skills or segregation of responsibilities. In others, it is more effective to do these things once.

In either case, the use of a gateway to offload functionality mustn't create a dependency between the gateway and any downstream services, or it risks becoming a blocker to development.

[Gateway Offloading](https://learn.microsoft.com/en-us/azure/architecture/patterns/gateway-offloading)

### Aggregation

Gateway aggregation allows a client to minimise unnecessary chatter, especially valuable over the internet or mobile networks, when communicating with a service. By collecting requests and responses and dispatching them in batches, updates and performance can be better managed, whilst the service appears to come from a common host.

Done properly, aggregation allows a server to manage client connections and improve performance.

[Gateway Aggregation](https://learn.microsoft.com/en-us/azure/architecture/patterns/gateway-aggregation)

## References
