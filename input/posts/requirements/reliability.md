---
Title: Reliability
Lead: Build apps to be resilient
Tags:
  - Architecture
  - Non-Functional Requirements
  - Requirements
  - NFRs
Draft: true
Published: 02/05/2023
---

> reliability, noun, /rɪˌlaɪ.əˈbɪl.ə.ti/. the quality of being able to be trusted or believed because of working or behaving well.

Reliable things do what you expect when you expect them. By ensuring we build reliable software, customers can easily access and use them.

Reliability is one of the non-functional requirements (NFR) that defines the ability of the system to properly perform the required functions under predefined conditions for a certain period. It is commonly expressed through probability percentages predicting chances that the system won’t experience critical failure under normal usage and during the set time

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

Our systems will be available for 99.9% of the year.

## Acceptance Criteria

* Measured over one year, the uptime of the application will exceed 99.9%
* During the first year, this will be extrapolated backwards and reviewed.

## Audience

  1. System designers and software engineers.
  2. IT Professionals and operational engineers.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

TODO:

## Related Principles

* [Ease of Use](xref:ease-of-use)
