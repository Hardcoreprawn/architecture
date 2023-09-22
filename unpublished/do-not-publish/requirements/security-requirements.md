---
Title: Security Requirements
Lead: Security is a critical concern of any organisation. The requirements will help you baseline security needs and understand the risks in your app.
Published: 24/04/2023
Draft: false
Tags:
  - Architecture
  - Requirements
  - Security
IsPost: true
---

Security controls are critical to developing applications.

> These security controls are written inline with the UK [National Cyber Security Centre (NCSC) Cyber Essentials Plus](https://www.ncsc.gov.uk/cyberessentials/overview) certification.

## Requirements

[Firewalls](xref:firewalls)

The data system must use a firewall to protect all internet connections and prevent unauthorised access to or from private networks.

[Secure configuration](xref:secure-configuration)

The system must implement secure configuration for all devices and software that process, store and transmit data.

[Security Update Management](xref:security-update-management)

The system must control access to data and services using strong authentication and a least privilege principle.

[Anti-malware software](xref:malware-protection)

The data system must use anti-malware software to protect devices and software from malicious code and unauthorised software installation

[Access control](xref:user-access-control)

User accounts are assigned only to individuals and not shared. User accounts only allow access to the applications, computers and networks the user needs to perform their role.

## Acceptance Criteria

* The data system passes a vulnerability scan and a penetration test performed by an NCSC-assured certification body.
* The data system complies with the Cyber Essentials technical controls and requirements.

The system can demonstrate the use of:

* [Firewalls](xref:firewalls)
* [Secure configuration](xref:secure-configuration)
* [Security Update Management](xref:security-update-management)
* [Anti-malware software](xref:malware-protection)
* [Access control](xref:user-access-control)

The system can handle common cyber attacks such as:

* Phishing
* Malware
* Denial-of-service
* Brute-force attacks

Without compromising data security or availability

## Audience

  1. UX and system designers, software engineers.
  2. IT Professionals and operational engineers.
  3. IT Security professionals.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

Adopting this set of NFRs will help:

* Protect systems and users from cyber threats and data breaches that could cause financial, reputational or legal damages.
* Demonstrate the organisation's commitment to cyber security and increase customer trust and confidence.
* Meet requirements for bidding for specific UK Government contracts.
