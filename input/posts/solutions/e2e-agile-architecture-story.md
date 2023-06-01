---
Title: Agile Architecture - A short story
Lead: An explanation of how Agile architecture works and flows.
Description: How does Agile architecture work in practice? This story provides a demonstration.
Tags:
  - Architecture
  - Business
  - Solution
  - Process
Categories:
  - Solution
Draft: true
---

The team worked on a new business application allowing customers to order products online and track their delivery status. The application needed to integrate with several external systems, such as inventory management, payment processing, and shipping providers. The team had to decide how to design the integration layer and what technologies to use.

They decided to use Azure Logic Apps as the integration platform because it offered a low-code solution to handle complex workflows and orchestration. They also decided to use Azure Service Bus as the messaging system because it provided reliable and scalable communication between the application and the external systems. They documented their decision in an ADR document that followed the template from the current web page context. They explained their decision's context, alternatives, consequences, and status. They submitted the ADR document as a pull request to the repository where they stored all their ADRs.

The next day, the architect responsible for reviewing the ADRs saw their pull request and opened it. He read their document and was impressed by their reasoning and clarity. He agreed with their decision and approved the pull request. He also noticed that their decision aligned with a new architectural principle he had been thinking about for a while, "Use cloud-native services whenever possible to reduce complexity and increase agility". He wrote an ADR document proposing this principle as a guideline for future decisions. He followed the same template and explained his proposal's context, decision, alternatives, consequences, and status. He submitted his document as a pull request to the repository where they stored all their architectural principles.

The following week, the architectural review board met to discuss the new architectural principle. The board comprised five executives from different departments: product management, engineering, operations, security, and finance. They reviewed the document and asked questions of the architect. They debated the pros and cons of adopting cloud-native services versus building or buying custom solutions. They considered the principle's impact on cost, performance, reliability, security, and innovation. After a lively discussion, they reached a consensus and approved the principle. The architect merged the pull request and added the principle to their list of architectural principles.

The team were happy to see the new architectural principle validated by the architect and the board. They continued to work on their application using Azure Logic Apps and Azure Service Bus. They also looked for other opportunities to apply cloud-native services in their design. They felt more confident and empowered by having clear and consistent architectural guidance.
