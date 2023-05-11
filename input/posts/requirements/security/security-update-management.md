---
Title: Security Update Management
Lead: Ensure systems are not vulnerable to known issues and install updates when fixes are available.
Published: 24/04/2023
Draft: false
Tags:
  - Architecture
  - Non-Functional Requirements
  - Requirements
  - Security
---
This applies to servers, applications and cloud services.

> Based on the NCSC.gov.uk 'Cyber Essentials Requirements for Infrastructure, January 2022'. Modified to remove end user devices.

Any software can have bugs and flaws. These are often unknown. But once they are known, it becomes exponentially easier for attackers to exploit them.

Keep libraries, frameworks and apps up to date.

## Requirement

All apps, libraries and systems are licensed and supported. Security updates to these items are made regularly to keep versions within 14 days of the current version.

## Acceptance Criteria

* Software and dependencies are up to date.
* Update mechanisms are in place to allow updates to be made quickly and easily, within 14 days of a release.
* Unsupportable or exploitable apps are removed and replaced.

## Audience

  1. System designers and implementors.
  2. Organisational management

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

We need to ensure our software is secure and trustworthy and that we can use it safely, at scale, for our business.

## Related Principles

* [Security Principles](xref:security-principles)
