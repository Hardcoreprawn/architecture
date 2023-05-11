---
Title: Secure Configuration
Lead: Ensure that computers and network devices are properly configured to reduce the level of inherent vulnerabilities and only provide the services required to fulfil their role.
Draft: false
Tags:
  - Non-Functional Requirements
  - Requirements
  - Security
  - Architecture
Published: 26/04/2023
---
This applies to servers, applications and cloud services.

> Based on the NCSC.gov.uk 'Cyber Essentials Requirements for Infrastructure, January 2022. Modified to remove end user devices.

## Requirement

Computers and network devices must be properly configured to reduce the level of inherent vulnerabilities and only provide the services required to fulfil their role.

Default configurations are often insecure, to make initial access easier. We must ensure any commodity services are reconfigured to ensure security.

This can include:

* Default accounts, potentially with additional permissions.
* weak or known initial account passwords.
* Unnecessary or legacy services, which are easier to exploit.

These must be disabled or reconfigured.

## Acceptance Criteria

* On inspection, third-party components should not have common or default accounts and passwords enabled.
* Where possible, configuration should be backed-up and stored securely, to allow for re-verification.
* The configuration of a system has been reviewed with one or more peers and has been approved.

## Audience

  1. System designers and implementors.
  2. Organisational management

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

One of the most common ways to access a system is to use a default account or configuration, which has been left unsecured. By ensuring we verify these accounts and their configuration, we can help improve security and minimise breaches.

## Related Principles

* [Security Principles](xref:security-principles)
