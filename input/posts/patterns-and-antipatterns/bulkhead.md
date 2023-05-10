---
Title: Bulkhead
Lead: Bulkheads are used on ships to prevent water from a hull breach from flooding the whole ship.
Description: The Bulkhead pattern encourages us to create barriers between services, to prevent disasters from affecting the whole application.
Tags:
  - Architecture
  - Microservices
  - Patterns
Categories:
  - Patterns
Draft: false
Published: 10/05/2023
---

The Bulkhead pattern designs safe operation into applications, to ensure that a single failure cannot cause the loss of the whole application.

There are different approaches to implementing a bulkhead, which all have the same outcome. It depends on how you need to contain the fault. It's easier to explain with some examples.

### Isolating Faults

> Customers are divided over different container hosts, so state and session are spread across more than one physical instance. If the instance is lost, only a subset of customers are affected.

### Limiting Thread Concurrency

> Netflix use a system called Hystrix, which limits the number of concurrent threads to any given system. Effectively, Hysterix figures out when a component starts to reach capacity and limits the upstream threads, to bring the load down.

When designing around the bulkhead pattern, assume that there will be failures somewhere and assume that will have an impact. But try to work to contain and minimise that impact.

To that end:

* Minimise dependencies; share nearly nothing!
* Isolate faults, to limit fallout.

The pattern was popularised in the book, Release It! by M. Nygard.

## References

* [What is Bulkhead Pattern used by Hystrix? (2018) Stack Overflow.](https://stackoverflow.com/questions/30391809/what-is-bulkhead-pattern-used-by-hystrix) Accessed: 10 May 2023
* [Abbot, M. (2019). Microservice Bulkhead Pattern - Dos and Don’ts.](https://akfpartners.com/growth-blog/bulkhead-pattern) Accessed 10 May 2023
* [Nygard, M.T. (2018) Release It! Pragmatic Bookshelf.‌](https://www.oreilly.com/library/view/release-it-2nd/9781680504552/)
* [Bulkhead Pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/bulkhead)
