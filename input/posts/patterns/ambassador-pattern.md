---
Title: Ambassador pattern
Lead: An Ambassador sits between two services and negotiates.
Description: An ambassador is often used to offload or mask client interoperability issues.
Tags:
  - Architecture
  - Microservices
  - Patterns
Categories:
  - Patterns
Draft: False
Published: 10/05/2023
---

An ambassador service is an out-of-process proxy facilitating communication with a distant service. It is colocated on the same host/cluster to improve performance.

## Description

Use the ambassador pattern when an application doesn't provide a necessary service and changing the application is too expensive. Often this is because a third party created the service or is 'of an age'. An ambassador is a specialised sidecar responsible for communicating with an interface for the application.

## Benefits

An ambassador can extend a legacy service with new functionality to function alongside a new architecture.

## Examples

* Adding asynchronous responses to a synchronous legacy process
* To make a REST call to legacy API
* Masking an insecure connection to ensure that the public network is secured
* Integrating a circuit breaker for a partner-hosted service

## Concerns

* Adding an ambassador creates a dependency. Sometimes the ambassador needs to be managed by a separate team, but will then require a release dependency.
* Is the added latency going to be workable with this application?
* Do you want to create a shared ambassador or spawn an instance per client?
* Consider a way to pass context to ease faultfinding.
* Host the ambassador close to the applications to minimise latency.

## When to use

* If you cannot replace or update a legacy or partner service to support necessary functionality, using an ambassador as a wrapper can ensure the service can work well with the rest of the application architecture
* If the type of request/response is insufficient to meet a client's need, such as supporting stronger authentication or encryption, managing latency or aggregating responses to a chatty system

## When to avoid

* This pattern adds latency, so avoid it in a latency-sensitive environment
* A library may be better if only a single language consumes the features
* If network connectivity cannot be adequately optimised

## Approach

Microsoft cites an example of an ambassador which encapsulates:

* Routing
* Circuit Breaker
* Logging

To enable a legacy app to integrate into cloud services and with mobile clients.

[Ambassador Example - learn.microsoft.com](https://learn.microsoft.com/en-us/azure/architecture/patterns/ambassador#example)

## References

* [Sidecar Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/sidecar) - An ambassador is a specialised sidecar.
* [Ambassador Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/ambassador)
