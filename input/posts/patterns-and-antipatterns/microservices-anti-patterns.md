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
Draft: true
---

## Anti-Patterns of the microservices architecture

A selection of common mistakes found in the wild.

### Calls in Series

Many microservices architecture failures are the result of not properly understanding the way failure works in distributed systems. To calculate the SLA of multiple systems, you must multiply the availability of each dependent service together.

If a system is built to have an availability of 99.5%, but it relies upon another service, with the same SLA of 99.5%, then the total SLA of that system is 99.0025%. If a third dependency is introduced with the same SLA of 99.5%, then we are down to 98.5%. This quickly adds up and gets exponentially worse.

It's important to use asynchronous calls to prevent this, rather than calls in series. Incorporate a message bus or an event framework, and instead of waiting, your services can remain resilient.

Reference: [AKF Partners: Microservices Anti-Patterns, 2019](https://akfpartners.com/growth-blog/microservice-anti-pattern-calls-in-series-the-xmas-tree-light-anti-pattern)

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

### Overly Chatty

The amount of communication between services must be considered. Services are distributed, so calls between them take time. Overly chatty services are not performant; the latency can kill the performance. Following [SOLID][def1] principles can help here.

[def1]: https://en.wikipedia.org/wiki/SOLID

### Shared Persistence

A monolith typically requires a large shared data store. As organisations redesign to microservices, thoughts around persistence may be overlooked, and traditional patterns followed. When you tie a service and a database together, you affect reliability. There is a recommendation to adopt a 0-1 database per service model.

For many types of computing, such as Azure Functions, or AWS Lambda, databases may be unnecessary. If compute uses documents instead or responds to events or messages, then all the persistence could be encapsulated.

in these cases, avoiding any real persistence helps to improve reliability, by removing unnecessary dependencies.

Reference: [AKF Partners, Microservices Architecture Principle: One or Zero Databases per Service. 2022](https://akfpartners.com/growth-blog/microservice-Architecture-principle-one-or-zero-databases-per-service)

### Entangled Data

When all the services in your application can use database connections to get whatever they need, it becomes harder to unpick and separate them as services scale. The database starts to become a bottleneck, changes slow down as people need to extend things.. the natural next step is to separate the services into individual databases. Except, you have no idea what you need to separate. Congratulations, you have entangled data.

To ensure you can scale as you need to, the data needs to be segregated into clear domains, which are readily identifiable and easy to access.

A successful remedy to this problem can be to restrict inter-domain communication to API calls. By ensuring cross-service database calls are eliminated and contracted, defined borders are put in place, segregation is much easier to manage.

This anti-pattern was seen as such a threat to the growth and agility of Amazon, that Jeff Bezos [threatened to fire anyone who followed it](https://nordicapis.com/the-bezos-api-mandate-amazons-manifesto-for-externalization/).

Reference: [TechTarget.com, 4 microservices antipatterns that ruin migration. 2020](https://www.techtarget.com/searchapparchitecture/tip/4-deadly-microservices-antipatterns-that-ruin-migration#:~:text=In%20an%20entangled%20data%20antipattern%2C%20all%20the%20services,modules%20and%20make%20structural%20changes%20to%20your%20architecture.)

### Improper Versioning

As part of an API strategy, contracted APIs enable a consumer to understand what they get and how they access that data. A mature API model allows a consumer to retrieve the right data and update the right systems, without needing to understand the underlying system. But, when the API changes, the integration will break.

If the API supports clear versioning, then the consumer can stipulate a version and the service can respond. Having a contractual way to manage versioning and deprecation is critical to making resilient services.

Microsoft suggests the following main versioning options:

* URI
* Header
* Query string

With URI-based versioning, the version is in the URI. If omitted the server would default to the most current, supported version.

> GET https://api.service.com/store/v1.1/Products

Header-based versioning encapsulates the version in the HTML header. You would include a custom header in the HTML HEAD tag, such as:

> Api-version: 1.0
> Api-version: 1.1

With Query-string versioning, the version requested is an optional query string:

> GET https://api.service.com/products/Products?api-version=v1.1

These methods are all supported in Azure API Manager.

### References

* [Microsoft.com - API Management](https://learn.microsoft.com/en-us/azure/api-management/api-management-versions)
