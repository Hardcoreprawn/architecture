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
Draft: true
Published: 01/01/2002
---

An out-of-process proxy that facilitates communication with a distant service. Colocated, usually in the same host/cluster to improve performance.

## Description

The ambassador pattern is used when a service needs some additional functionality, but it cannot be easily included alongside the main application. Often this is because the service was created by a third party, or is 'of an age'. An ambassador is a specialised sidecar, which is responsible for communicating with a service for the application.

## Benefits

An ambassador can extend a legacy service with new functionality to allow it to function alongside a new architetcure.

## Examples

* Adding asynchronous responses to a legacy synchronous process.
* To make a REST call to legacy API.
* Masking an insecure connection, to ensure that the public network is secured.
* Integrating a circuit breaker for a partner-hosted service.

## Drawbacks

Adding an ambassador often entails creating a dependency. Sometimes the ambassador needs to be managed by a separate team, but will then require a release dependency.

## When to use

* If you have a legacy or partner service which cannot easily be replaced or updated to support necessary functionality, using an ambassador as a wrapper can assist in ensuring the service can work well with the rest of the application architecture.
* When you need to change the type of request/response to meet the need of a client, such as supporting stronger authentication or encryption, managing latency or aggregating responses to a chatty system.

## When to avoid

TODO

## Approach

## Assumptions

## References

* [Sidecar Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/sidecar) - An ambassador is a specialised sidecar.
* [Ambassador Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/ambassador)
