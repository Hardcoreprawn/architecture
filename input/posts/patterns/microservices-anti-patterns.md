---
Title: Microservices Anti-patterns
Lead: How not to build microservices
Description: Describes common anti-patterns or easy pitfalls of building a microservices application
Tags:
  - Architecture
  - Microservices
  - Patterns
Categories:
  - Patterns
Draft: False
Published: 10/05/2023
---

## Anti-Patterns of the microservices architecture

A selection of common mistakes found in the wild

### Calls in Series

Many microservices architecture failures result from not correctly understanding how failure works in distributed systems. To calculate the SLA of multiple systems, you must multiply the availability of each dependent service together.

If you build a system to have an availability of 99.5%, but it relies upon another service with the same SLA of 99.5%, then the total SLA of that system is 99.0025%. If you introduce a third dependency with the same SLA of 99.5%, then we are down to 98.5%. Each dependence compounds the previous ones.

Using asynchronous calls to prevent this is essential, rather than calls in series. Incorporate a message bus or an event framework; your services can remain resilient instead of waiting.

Reference: [AKF Partners: Microservices Anti-Patterns, 2019](https://akfpartners.com/growth-blog/microservice-anti-pattern-calls-in-series-the-xmas-tree-light-anti-pattern)

### Distributed Monolith

When you split a monolith, don't let your services become dependent on each
or several other microservices. If changes in services require redeployment or
change in different services, you've built a distributed monolith.

Over-dependency can also manifest in long deployment times, as too many changes must coincide. Sometimes it shows that deployment has to happen in a particular order.

A distributed monolith is a [Big-Ball-Of-Mudd][def2] with network-level latency to
deal with.

[def2]: http://www.laputan.org/mud/mud.html#BigBallOfMud

### Overly Chatty

Consider the amount of communication between services. Services are distributed, so calls between them take measurable time. Overly chatty services are not quick; the latency kills performance. Following [SOLID][def1] principles can help.

[def1]: https://en.wikipedia.org/wiki/SOLID

### Shared Persistence

A monolith typically requires a large shared data store. As organisations redesign to microservices, do not overlook persistence and follow traditional patterns. When you tie a service and a database together, you affect reliability. There is a recommendation to adopt a 0-1 database per service model.

For many types of computing, such as Azure Functions, or AWS Lambda, databases may be unnecessary. If compute uses documents instead or responds to events or messages, then encapsulate user persistence in those.

In these cases, avoiding any real persistence helps to improve reliability by removing unnecessary dependencies.

Reference: [AKF Partners, Microservices Architecture Principle: One or Zero Databases per Service. 2022](https://akfpartners.com/growth-blog/microservice-Architecture-principle-one-or-zero-databases-per-service)

### Entangled Data

When all the services in your application can use database connections to get whatever they need, it becomes harder to unpick and separate them as services scale. The database becomes a bottleneck; changes slow down as people need to extend things. The natural next step is to separate the services into individual databases. Except, you have no idea what you need to separate. Congratulations, you have entangled data.

Data needs to be segregated into clear domains, which are readily identifiable and easy to access, to avoid affecting the ability to scale.

A successful remedy to this problem is restricting inter-domain communication to API calls. By ensuring cross-service database calls are eliminated and contracted, borders are defined, and segregation is much easier to manage.

Amazon saw this anti-pattern as such a threat to its growth and agility that Jeff Bezos [threatened to fire anyone who followed it](https://nordicapis.com/the-bezos-api-mandate-amazons-manifesto-for-externalization/).

Reference: [TechTarget.com, Four microservices antipatterns that ruin migration. 2020](https://www.techtarget.com/searchapparchitecture/tip/4-deadly-microservices-antipatterns-that-ruin-migration#:~:text=In%20an%20entangled%20data%20antipattern%2C%20all%20the%20services,modules%20and%20make%20structural%20changes%20to%20your%20architecture.)

### Improper Versioning

As part of an API strategy, contracted APIs enable consumers to understand what they get and how they access that data. A mature API model allows a consumer to retrieve and update the correct data without needing to understand the underlying system. But, when the API changes, the integration will break.

If the API supports explicit versioning, the consumer can stipulate a version and the service can respond. A contractual way to manage versioning and deprecation is critical to making resilient services.

Microsoft suggests the following main versioning options:

* URI
* Header
* Query string

With URI-based versioning, the version is in the URI.

    GET https://api.service.com/store/v1.1/Products

Header-based versioning encapsulates the version in the HTML header. You would include a custom header in the HTML HEAD tag, such as:

    Api-version: 1.0
    Api-version: 1.1

With Query-string versioning, the version requested is an optional query string:

    GET https://api.service.com/products/Products?api-version=v1.1

 The server would default to the most current, supported version, where the consumer did not provide an exact version number.

These methods are all supported in Azure API Manager.

### References

* [Microsoft.com - API Management](https://learn.microsoft.com/en-us/azure/api-management/api-management-versions)
