---
Title: Non-repudiation
Lead: The system shall provide non-repudiation for all transactions.
Description: A mechanism to ensure a party cannot deny the legitimacy of a transaction.
Draft: false
Published: 27/04/2023
Tags:
  - Architecture
  - NFRs
  - Requirements
  - NFRs
---

Where possible, use immutable objects and data which can't be repudiated. Make sure we can trust our systems and our data.

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

The system must provide a mechanism to ensure that a party cannot deny the authenticity of their signature on a document or message.

## Acceptance Criteria

* The system shall provide a digital signature for each transaction.
* The digital signature shall be unique for each transaction.
* The digital signature shall be verified by the recipient of the transaction.

## Audience

  1. System designers and software engineers.
  2. IT Professionals and operational engineers.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

Non-repudiation provides proof of the origin, authenticity, and integrity of data. It assures the sender that the message was delivered, as well as proof of the sender’s identity to the recipient. This way, neither party can deny that a message was sent, received, and processed. Non-repudiation ensures that no party can deny that it sent or received a message via encryption and/or digital signatures or approved some information. It also cannot deny the authenticity of its signature on a document.

## Related Principles

* [Security Principles](xref:security-principles)
* [Ease-Of-Use](xref:ease-of-use)

## References

* Describes non-repudiation as a property that ensures that a party cannot deny the authenticity of their signature on a document or the sending of a message that they originated: <https://www.perforce.com/blog/qac/what-is-iso-25010>
* Lists non-repudiation as one of the key non-functional requirements to be considered in software development. <https://www.boxuk.com/insight/guide-to-non-functional-requirements-types-and-examples/>
