---
Title: Security Principles
Published: 2023-05-11T15:11:41.566Z
Lead: Don't assume people will do the right things. Whether by malice or ignorance.
Draft: false
Tags:
  - Architectural Principles
  - Architecture
  - Security
Categories:
  - Principles
---
## Statement

As a business, we want to adopt a Zero-trust approach to our business and use of technology. This model provides the best combination of security and agility for our enterprise.

## Rationale

Zero Trust is a security approach built on three principles:

1. Verify Explicitly
2. Use 'least privilege' access
3. Assume Breach

Let's explore these three points.

### Verify Explicitly

Make use of the tools and data points available to validate that access is being granted to the right person or service, and that they are who they say they are. This should take into account things like:

* Geographic location.
* Device type, health and validity.
* Data Classification and Permissions.

### Use 'Least Privilege' access

Make sure that people and services only have relevant access to their roles; no more or less. For escalated privileges, use concepts like Just-In-Time access to make sure that elevated logons are being approved, logged and cleared. This can also encompass:

* Risk-based policies, that adapt the authentication to the level of risk.
* A 'Four eyes' principle, to make sure access to elevated roles is approved by a second person, reducing the risk of lone insider threat.
* Classify Data and Services according to value and risk and protect them appropriately.

### Assume Breach

Log and monitor access to services and data. Minimise the impact of any breach, by controlling shared resources and accounts. Try to avoid unnecessary dependencies or permissions. This can be done through:

* Adding appropriate monitoring and logging to applications.
* Using single sign-on to ease tracking and logging.
* Using the Bulkhead pattern, to minimise the danger between services and threads.
* Actively monitor and control inputs, to help minimise breaches. Control access points and validate data entry.

## Implications

Adopting a zero-trust security model can benefit us by providing:

* Better visibility into traffic and access patterns, which can result in better-developed and targeted systems.
* An enhanced user experience, typically with faster login times and lower password or account fatigue.
* A reduction in data breaches and an improvement in compliance.
* Reduction in the complexity of infrastructure and an improvement in security posture.

Improperly integrated or configured, this approach could result in:

* Increased complexity and cost, often through having duplicate capabilities or the sprawl of security services and appliances.
* A lack of planning can result in expensive installations and purchases.
* Without a coherent policy around user access, friction can be increased as users fight with additional factors and complex passwords.

## References
