---
Title: Firewalls
Lead: To ensure only secure and necessary services can be accessed from the internet
Draft: false
Tags:
  - Requirements
  - Security
  - Architecture
Published: 24/04/2023
---

This guidance applies to Boundary Firewalls, Desktop Computers, laptops, routers, servers, and cloud services.

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

Protect every device and service in our control from unauthorized or unnecessary access with a firewall.

Every device we let access our systems should have relevant security controls to allow us to trust it. For devices we own and manage, this can be met by:

* We only attach devices to a safe network under our control or trust.
* Ensuring devices have adequately configured firewalls. NCSC specifically mentions using included Operating System firewalls on Servers, PCs, and Laptops.

Where a third-party-owned device is accessing our systems, we should:

* Ensure they know they need to use a firewall.
* Contractually oblige them to follow best practices.

We are not responsible for enforcing this. We need to ensure our systems are protected where we can see a risk.

## Acceptance Criteria

* Demonstration of the effective control of inbound network access to the device from a remote host.
* Testing, using a port scanning tool or similar, can demonstrate only necessary, authenticated, secured traffic has access to the device.

## Audience

  1. System designers and implementors.
  2. Organizational management

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

Most attacks occur from outside the network. Ensuring firewalls are in place is a highly effective way to mitigate external threats and chance attacks. Moving to a device-centric (Zero-trust) approach, you can also extend this level of protection to internal threats or transverse attacks.

## Related Principles

* [Security Principles](xref:security-principles)
