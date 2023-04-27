---
Title: Scalability
Lead: The system must be able to handle an increasing amount of work.
Description: The system must be able to handle an increasing amount of work without any significant degradation in performance.


Tags:
  - Architecture
  - Non-Functional Requirements
  - Requirements
  - NFRs
Draft: false
Published: 27/04/2023
---

---
This non-functional requirement is concerned with the ability of the system to handle an increasing amount of work or its potential to be enlarged to accommodate that growth.

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

The system must be able to scale horizontally and vertically.

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
