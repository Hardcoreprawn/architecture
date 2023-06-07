---
Title: Performance
Lead: The system must respond within 2 seconds for 95% of all requests.
Tags:
  - Architecture
  - NFRs
  - Requirements
Draft: false
Published: 27/04/2023
---

Performance is one of the essential NFRs that specifies “how well” the “what" must behave. Performance NFRs are used to ensure that a system meets its performance requirements and that it performs as expected under various conditions. Performance NFRs include response time, throughput, resource utilisation, and capacity.

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

* The system must be able to handle 1000 concurrent users.
* The system should respond within 2 seconds for 95% of all requests.
* Any underlying systems should be able to achieve this at no more than 60% utilisation before scaling occurs.

## Acceptance Criteria

* 95% of system responses occur to the user within 2 seconds.
* The system can support over 1,000 concurrent users and maintain the response time.
* Monitoring of infrastructure shows that active nodes are at 60-80% of utilisation during load.

## Audience

  1. System designers and software engineers.
  2. IT Professionals and operational engineers.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

This NFR is crucial because it ensures the application is responsive and performs well under heavy load.

An asynchronous response can take longer if the interactive elements load quickly and explain any delays while preparing the asynchronous answer.

## Related Principles

* [Ease-Of-Use](xref:ease-of-use)
