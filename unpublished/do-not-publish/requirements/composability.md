---
Title: Composability
Lead: Services that can be combined and reused, composed into different layouts and new applications, provide business agility.
Tags:
  - Architecture
  - NFRs
  - Requirements
Published: 21/04/2023
Draft: false
---
Composability is a non-functional requirement allowing us to configure components together differently. A service should be self-contained and stateless, so the system can be trusted, reused, and integrated as needs evolve.

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

Apps we develop are self-contained and stateless. They can be given context and will return predictable results.

* The system should be designed using a modular approach to create, modify and reuse components across different scenarios and contexts.
* The system should provide clear and consistent interfaces for the components that enable interoperability and integration with other features.
* The system should support the dynamic composition of components at runtime based on the user's needs and preferences.

## Acceptance Criteria

* Given a set of existing components, when a user wants to create a new component, the system should allow the user to select and combine the existing elements.
* Given a component with a defined interface, when a user wants to integrate it with another component or system, the system should provide the necessary information and tools to enable the integration.
* Given a component that is no longer needed, when a user wants to delete it, then the system should remove the component and its dependencies without affecting the functionality of the other components or systems.

## Audience

  1. UX and system designers, software engineers.
  2. IT Professionals and operational engineers.

## Details

* Owner: Andy Sheldon, Chief Technology Officer
* Author: James Brewster, Enterprise Architect

## Rationale

Composability ensures the system can be easily adapted and customised to meet different needs, preferences and scenarios. Composability also enables faster and more efficient development of new features and functionality by reusing components. It allows safer deployment of new features and testing as new features can be gradually introduced and rolled back, depending on the outcome. This enables the business to experiment with its business model and optimise digital services' layout, workflow and function.

## Related Principles

    * [Responsive Change Management](xref:responsive-change-management)
    * [Requirements Based Change](xref:requirements-based-change)
    * [Service Oreintation](xref:service-orientation)

## References

* [Wikipedia - Composability](https://en.wikipedia.org/wiki/Composability)
