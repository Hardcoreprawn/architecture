---
Title: User Access Controls
Lead: Ensure user accounts are assigned to authorised individuals and only provide access to the systems required for their role.
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

Access to a business system, or its data, is protected by a centrally managed named user account. The account can be configured to only allow access to the relevant data and processes.

Accounts with special access privileges have an enhanced level of verification through a second factor, such as a verification message to a different, associated device or approval by a second party.

Any account should have more than one named individual present. Owners and administrators need to be able to disable an account, with relevant verification.

## Acceptance Criteria

* Any Authorisation is not performed by the application but by a dedicated authorisation application.
* Applications obey trusted authorisation tokens from that application.
* Tokens only grant access to the relevant data, necessary for the role the user has.
* Roles are granular and can be subdivided where necessary.
* Application and data access is protected, ensuring a second check.
* Special access privileges, such as deleting an account, require a second factor or verification.
* Options for Multi-factor authentication should be present and are strongly recommended.

## Audience

  1. System designers and implementors.
  2. Organisational management

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

Ensuring our customer's data is secure is important. Ensuring they can manage access to that data is important. Giving them a feeling of security and trust is important.

Reflecting our brand values, our commitment to security and our capability to manage data and services for them is important.

## Related Principles

* [Be Suspicious](xref:be-suspicious)
* [Least Privilege](xref:least-privilege)
* [Shift Security Left](xref:shift-security-left)
