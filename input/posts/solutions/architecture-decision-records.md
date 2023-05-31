---
Title: "Architecture Decision Records"
Lead: "ADRs can help you keep up to date with recording decisions."
Description: "No one reads big documents. ADRs are a way to capture significant decisions so people can find them in future."
Tags: []
Categories: []
Draft: false
Published: 2023-05-30T14:46:52.024Z
---
## Introduction

Architectural decision records (ADRs) are documents that capture an important architectural decision made along with its context and consequences. They are used to record the project’s architectural thinking and decisions for further reference and to help new team members understand the rationale behind the design choices.

ADRs typically follow a template that includes the title, context, decision, status, consequences, and alternatives of the decision.

ADRs are stored in a folder or a wiki page that is close to the code repository or other stakeholders. ADRs can be created, reviewed, and updated using tools such as Azure DevOps.

## Process

Here is a process for creating Architectural Decision Records (ADRs) in Azure DevOps:

* Define a template for documenting ADRs that includes the following sections: title, context, decision, status, consequences, and alternatives¹.
* Create a folder in the Azure DevOps repository to store the ADRs. The folder name can be "adr" or "docs/adr" or something similar³.
* For each architectural decision that needs to be made, create a new feature in the Azure DevOps backlog and mark it as technical. In the feature description, explain the decision and alternatives, and link to any relevant resources¹.
* Assign the feature to one of the software engineering teams based on their expertise and availability. The team should review the feature and propose a solution using an ADR document. The document should follow the template and be stored in the ADR folder¹.
* Submit the ADR document as a pull request and request feedback from the other teams and stakeholders. The pull request should also include any code changes that implement the decision¹.
* Review the feedback and update the ADR document and code changes accordingly. If there are any conflicts or disagreements, resolve them through discussion and consensus⁴.
* Merge the pull request and mark the feature as done. The ADR document should have a status of accepted or rejected depending on the outcome of the review¹⁴.
* Keep track of the ADRs in a decision log that lists all the ADRs by their title, status, and date. The decision log can be a simple text file or a table on a wiki page³⁵.
* Review the ADRs periodically and update them if necessary. If an ADR becomes obsolete or superseded by another decision, change its status accordingly and link to the new ADR³⁴.

This process can help you record your architectural and technical decisions for further reference and have the new team members up to date from day one¹.

Source: Conversation with Bing, 31/05/2023

1. [Architecture Decision Records (ADR) With Azure DevOps.](https://medium.com/nerd-for-tech/architecture-decision-records-adr-with-azure-devops-3f0c9edeb85b) Accessed 31/05/2023.
2. [joelparkerhenderson/architecture-decision-record - GitHub.](https://github.com/joelparkerhenderson/architecture-decision-record) Accessed 31/05/2023.
3. [AWS Publishes Guide to Architecture Decision Records - InfoQ.](https://www.infoq.com/news/2022/06/aws-adr-guide/) Accessed 31/05/2023.
4. [Getting Started with Architecture Decision Records - SlideShare.](https://www.slideshare.net/mkeeling5000/)getting-started-with-architecture-decision-records Accessed 31/05/2023.
5. [Architectural decision guides - Cloud Adoption Framework.](https://learn.microsoft.com/en-us/azure/cloud-adoption-framework/decision-guides/) Accessed 31/05/2023.

## Additional References

* [ADR GitHub Organisation // GitHub](https://adr.github.io/)
* [ADR with DevOps || Medium](https://medium.com/nerd-for-tech/architecture-decision-records-adr-with-azure-devops-3f0c9edeb85b)
* [ADR Examples \\ GitHub](https://github.com/joelparkerhenderson/architecture-decision-record/tree/main/examples)
