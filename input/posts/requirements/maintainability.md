---
Title: Maintainability
Lead: Build to a common target architecture.
Tags:
  - Architecture
  - Requirements
  - NFRs
Draft: false
Published: 26/04/2023
---

The system should be designed and developed with maintainability in mind. The system should be easy to look after, diagnose and support throughout its lifecycle.

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

* Design and implement the system using a known set of conventions.
* The system is well-documented, and the source code has relevant comments.
* The software has been designed to be modular and reusable.
* Implement approved logging, monitoring and testing tools.
* The deployment follows standard technology hosting patterns.

## Acceptance Criteria

* Designs for the system are reviewed and approved by at least two others.
* Software source code is documented using a known standard or convention.
* Software designs have been inspected for opportunities for reuse and modularity.
* The system must include logging ability.
* An outline design of areas to be monitored on the system should be included.
* The system must have a documented set of test cases.
* The system must be based on an approved hosting pattern and document how the pattern is followed.

## Audience

  1. System designers and software engineers.
  2. IT Professionals and operational engineers.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

This NFR ensures that the system can adapt to changing needs, bugs can be fixed, and support costs can be kept down.

## Related Principles

* [Control Technical Diversity](xref:control-technical-diversity)
* [Interoperability](xref:interoperability)
