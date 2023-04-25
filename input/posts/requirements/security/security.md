---
Title: Security
Description: Security is a critical concern of any organisation. The requirements will help you baseline security needs and understand the risks in your app.
Draft: false
Tags:
  - Architecture
  - NFRs
  - Non-Functional Requirements
  - Requirements
  - Security
Published: 2023-04-24T15:13:24.797Z
---

Security controls are critical to developing applications.

> These security controls are written to meet the demands of the UK National [Cyber Security Centre (NCSC) Cyber Essentials Plus](https://www.ncsc.gov.uk/cyberessentials/overview) certification.

## Requirement

* The system must implement secure configuration for all devices and software used to process, store and transmit data.
* The data system must use a firewall to protect all internet connections and prevent unauthorized access to or from private networks.
* The data system must use anti-malware software to protect devices and software from malicious code and unauthorized software installation
* The system must control access to data and services by using strong authentication, and a least privilege principle.
* The system must protect data in transit by using encryption and secure protocols.

## Acceptance Criteria

* The data system passes a vulnerability scan and a penetration test, performed by an NCSC-assured certification body.
* The data system complies with the Cyber Essentials technical controls and requirements.

The system can demonstrate the use of:
* Secure configuration
* Firewall
* Anti-malware software
* Access control
* Data encryption

The system can handle common cyber attacks such as:

* Phishing
* Malware
* Denial-of-service
* Brute-force attacks

Without compromising data security or availability.

## Audience

  1. UX and system designers, software engineers.
  2. IT Professionals and operational engineers.
  3. IT Security professionals.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

Adopting this NFR will help:

* Protect systems and users from cyber threats and data breaches that could cause financial, reputational or legal damages.
* Demonstrate the organisation's commitment to cyber security and increase customer trust and confidence.
* Meet requirements for bidding for certain UK Government contracts.
