---
Title: Scalability
Lead: The system must be able to handle an increasing amount of work.
Description: The system must be able to handle an increasing amount of work without any significant degradation in performance.
Published: 27/04/2023
Draft: false
Tags:
  - Architecture
  - Non-Functional Requirements
  - Requirements
  - NFRs
---

This non-functional requirement is concerned with the ability of the system to handle an increasing amount of work or its potential to be enlarged to accommodate that growth.

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

The system must be able to scale to adequately support the business

## Acceptance Criteria

* The system must be able to handle a minimum of 1000 concurrent users without any significant degradation in performance.
* On demonstration, the system should be able to scale up and down.

## Audience

  1. System designers and software engineers.
  2. IT Professionals and operational engineers.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

Rationale: Scalability is important because it ensures that the system can continue to function effectively as the workload increases.

## Related Principles

* [Ease-Of-Use](xref:ease-of-use)

## More Information

AKF Partners introduced the concept of the scale cube in their 2018 Blog post on scalability. This is a scaling model which encourages design and engineering teams to think about scale in three axis:

* X-Axis, Technical architecture layering. Avoid single points of failure, build out multiple nodes which can serve requests and balance load.
* Y-Axis, Functional Decomposition. Break an application into components (microservices) and keep these different items in swim lanes.
* Z-Axis, Data Partitioning. Separate user data for scale, availability and testing.

![Scale Cube, AKF Partners, 2018](/images/Scale_Cube.png)

Each axis in the cube needs to be able to scale and teams should keep this idea in mind as they design and build systems.

A monolith application is the antithesis of the scale cube. An accurate realisation of this principle would be a Microservices architecture, hosted on a container platform, with a sharded database model.

Scaling a large system is hard, and potentially expensive. Making changes can take too long and the required upgrades can be costly. Using a microservices model with small, stateless services which can scale independently allows each service change to be small, and the underlying costs to grow in smaller steps.

Another difficulty is the complexity of a change. As more developers join a project, typically the project gets slower, not faster! Environment changes take longer, pull requests increase, and meetings take longer. The net effect is that large teams create too many dependencies, increasing development times. [Brooks Law](https://en.wikipedia.org/wiki/Brooks%27s_law)

When systems are large, they become increasingly complex, and in many cases, by this point, there are only 1-2 people who understand the system. This creates additional Single Points of Failure, in those people. It makes change riskier and more likely to require regression testing.

For more information on this model, please refer to the AKF partners site, linked below.

## References

* [The Scalability Cube, Your Guide to Evaluating Scalability][def2]

[def2]: https://akfpartners.com/growth-blog/the-scalability-cube-your-guide-to-evaluating-scalability
