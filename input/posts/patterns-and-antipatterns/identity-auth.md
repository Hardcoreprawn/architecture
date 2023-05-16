---
Title: Identity, Authentication and Authorisation
Lead: How to implement authentication in microservices and web apps
Slug: identity-auth
Tags:
  - Architecture
  - Patterns
  - Microservices
Draft: False
Published: 2023-05-16
Categories:
  - Patterns
Description: Authenticating users in microservices can be fraught with perils...
---

## Pattern Overview

This pattern describes a central authentication model, suitable for a microservices web application. It builds on several other patterns, to provide a scalable way to identify, authenticate and authorise access to resources, data and services.

In this example, a role-based authorization model is being used. Customer policies would be more configurable, but also more complex.

### Illustration

![API Gateway Centralized authentication](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/secure-net-microservices-web-applications/media/index/api-gateway-centralized-authentication.png)
> [Rousos (2023) Securing .NET Microservices and Web Applications, learn.microsoft.com.](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/secure-net-microservices-web-applications/)(Accessed: 16 May 2023).‌

In this instance, a mobile app is shown. But a static site, calling an API, a Single Page Application, or an MVC application would use a similar method. This could use the [Backends-For-Frontends](https://akfpartners.com/growth-blog/backend-for-frontend#:~:text=In%20the%20Backend%20for%20Frontend%20pattern%2C%20a%20service,differ%20from%20a%20traditional%20API%20or%20monolithic%20gateway.) pattern, to offset any differences.

## Benefits of this pattern

* By using the gateway, authentication is offloaded to the gateway and centralised. [Gateways](xref:gateways)
* The gateway issues a signed token, which contains the authorised user's roles, which can be used for the lifespan of the token, reducing chatter. [Microservices Anti-patterns](xref:microservices-anti-patterns)
* The token is long-lived, reducing user frustration. [Ease-of-Use](xref:ease-of-use)
* Once implemented, downstream services simply need to have their role added to the token and respect it.
* Identity management and storage can be offloaded to the customer's preferred vendor, using open standards, Including:
  * Microsoft, Google or Facebook identities, such as Microsoft AzureAD B2C.
  * Microsoft Azure AD identities, using B2B Federation.
  * Any OpenID Connect or OAuth2.0 Identities.

## Drawbacks to this pattern

* It assumes simple role-based authorisation. A more complex policy-based model would require additional depth and complexity in the token, increasing its size and complexity.
* The token is fairly easy to 'crack', so should never be shared outside the network. A separate reference token model is recommended, where the token is used within the cluster, and used by the gateway as a delegated authorisation.
  * The user would have a lean token or reference cookie, which only correlates to the token on the gateway. Think of this model as a delegation model, rather than an authorisation model.
* This creates a dependency on external identity vendors, which can be hard to manage.

## When to use this pattern

* This pattern, together with the [Gateways](xref:gateways), is recommended in most enterprise or B2B microservice models. It is ideal for a containerised application, which needs to minimise cross-talk and have a planned model for authorisation and identity.

## When to avoid this pattern

* This pattern is not suitable for use on unsecured networks. The contents of the token can be used to understand the user and their roles.
  * This pattern still promotes zero-trust, as every service will validate the token, and must trust the issuer and check for tampering.
  * Using a reference token, issued at the gateway to the external user, which does NOT contain any useful information can mitigate this.

## References

* [NordicAPIs - How to control user identity within microservices](https://nordicapis.com/how-to-control-user-identity-within-microservices/)
* [Using JWT to authorize users and protect API routes](https://medium.com/@maison.moa/using-jwt-json-web-tokens-to-authorize-users-and-protect-api-routes-3e04a1453c3e)
* [Make secure .NET Microservices and Web Applications](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/secure-net-microservices-web-applications/)
