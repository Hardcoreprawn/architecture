---
Title: Secure Configuration
Lead: Correctly configure computers and network devices to reduce vulnerabilities. Only provide the services required to fulfill their role.
Draft: false
Tags:
  - Requirements
  - Security
  - Architecture
Published: 26/04/2023
---
This requirement applies to servers, applications, and cloud services.

> Based on the NCSC.gov.uk 'Cyber Essentials Requirements for Infrastructure, January 2022. Modified to remove end user devices.

## Requirement

Correctly configure computers and network devices to reduce vulnerabilities. Only provide the services required to fulfil their role.

Default configurations are often insecure to make initial access easier. Reconfigure commodity services/devices to ensure security.

Services/Devices can include:

* Default accounts, potentially with additional permissions.
* Weak or known initial account passwords.
* Unnecessary or legacy services, which are easier to exploit.

Turn these off or reconfigure them so they are made secure.

## Acceptance Criteria

* On inspection, third-party components should not have default accounts and passwords enabled.
* Configuration should be backed-up and stored securely to allow for re-verification.
* The design of a system has been reviewed with one or more peers and approved.

## Audience

  1. System designers and implementors.
Organisational management

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

One of the most common ways to access a system is to use a default account or configuration, which has been left unsecured. By ensuring we verify these accounts and their configuration, we can help improve security and minimise breaches.

## Related Principles

* [Security Principles](xref:security-principles)
