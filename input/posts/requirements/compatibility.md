---
Title: Compatibility
Description: Build to a common target architecture.
Tags:
  - Architecture
  - Non-Functional Requirements
  - Requirements
  - NFRs
Draft: false
Published: 23/04/2023
---

We make apps that work on things we know, which we know how to look after and can keep safe.

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

The application runs on a Linux-based container, ideally Ubuntu Long Term Support versions, using an x86 architecture. Our preferred development environment is the Microsoft .NET framework.

## Acceptance Criteria

* The software is deployed to a Linux container, compatible with Kubernetes.
* The image should be on our technology register and pulled from our hub.
* The software targets a currently supported version of the .NET framework.

## Audience

  1. System designers and software engineers.
  2. IT Professionals and operational engineers.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

As we design and develop new systems, we should make sure they can run on commodity platforms that we know how to use, and can easily secure.

* Linux containers are robust, low cost and easy to manage. they are the most commonly deployed workload in the world.
* Azure is our preferred hosting environment.
* Our developers predominantly write C# code.

## Related Principles

* [Control Technical Diversity](xref:control-technical-diversity)
* [Interoperability](xref:interoperability)
