---
Title: Overview of the Architecture Practice
Author: James Brewster
Published: 06/06/2023
Description: How Architects should work alongside Agile development to enable faster decision-making and reduce risk.
Lead: Function of an agile architecture practice
Draft: False
Categories:
  - Solution
Tags:
  - Architecture
  - Process
  - Solution
---
Software and systems architects provide guidance and governance of a technology organisation by, amongst other things, modelling the organisation, its departments, capabilities, and processes and then mapping technology into them to ensure that the business has a somewhat optimised set environment, which can adapt to its needs and isn't onerous to look after.

Traditional approaches to this take time and go against the agile philosophy to avoid Big Up Front Design BUFD. How best to support developers in an agile world?

The common concept in an agile development organisation is 'Emergent Architecture.' But what does that mean? You follow a model more akin to evolution than planning and interfere if you see things dangerous to the organisation. You use history as a lesson, but accept what happened and don't try to remove it.

## In theory

As development teams self-organize, the architecture role is to support decision-making and ensure good decisions thrive while poor choices don't.

![Architecture Process - BPMN](../../media/architecture-process-bpmn.png)

This concept's core work item is the ADR or Architectural Decision Record.

When a team has to decide something, they create a work item in Azure DevOps (other work trackers are available). This item can outline the problem in short:

> To support US12345, we need to host semi-structured data, which will be used to render a quote on screen.

Whenever the team decides how development will proceed, they write it down in their work system. ADRs are covered in more detail [here](xref:architecture-decision-records).

> In the context of hosting semi-structured quote data
>
> Facing the need to understand different tariffs and quote them together
>
> We decided to host this data as JSON in a document databaseusing MongoDB interfaces hosted on Azure Cosmos.
>
> And against using MongoDB in a seperate Container, as it would require management
>
> or against using CosmosDB, as the interface is being deprecated.
>
> To Acheive US12345, hosting and retreiving semi-structured quote data.
>
> Accepting that there is a cost requirement in using Cosmos DB hosting

The architecture team review and steer ADRs. ADRs are like the tweet format of designs; they encompass small decisions and choices with just enough context and reasoning to explain to a new starter why something happened. A significant benefit is that they can all be queried and exported and used to describe the project thinking over time and why the team made confident choices. The ADR list acts as a log, which someone could examine to trace the project's decisions.

The architecture practice reviews the ADRs and looks for trends and patterns. As certain things come to the fore, the architects write new principles, [patterns](xref:patterns), and [NFRs](xref:nfrs) approved by the ARB to help the teams make future decisions.

The architect group will propose amendments to the organisation's architecture to the ARB, which may require approval, depending on the size and scope of the new principles.

Changes in architecture guidance are applied retrospectively but may result in the creation of new technical debt items. Similar to how the law or regulation works.

## In Practice

![Architecture Process - Sequence](../../media/architecture-process-sequence-diagram.png)

It is up to the development team to decide how to solve problems based on the environment. The environment includes:

* Organisational Strategy
* People & Skills
* Existing technology
* Existing projects
* Corporate Style
* Shared Values

> Paraphrased from [McKinsey & Company (2008) Enduring Ideas: the 7-S Framework, www.mckinsey.com](https://www.mckinsey.com/capabilities/strategy-and-corporate-finance/our-insights/enduring-ideas-the-7-s-framework)

Most people try to make good decisions. Usually, bad decisions are the result of poor communication or poor information. The architecture practice must document meaningful decisions and knowledge to help educate people so the teams can make better decisions.

Using a feedback loop from the teams' decisions and accepting that these won't all be good, we can adjust the team's behaviour through education, exposure, and experience.

### How not to make decisions

* Ignore existing ADRs relating to the subject (Search in DevOps for ADRs or the tech or problem).
* Do not look at the existing guidance:
  * Principles
  * [NFRs](xref:nfrs)
  * Patterns
  * Standards
* Keep the decision secret right up until the last second.
* Do not produce a cost-benefit analysis.
* Write a slide show to confuse matters by overloading everyone with benefits without financial backing or research.

### How to make decisions

* In the open and with the people affected by the decision, including:
  * The people who will look after it
  * The person who has to spend money on it
  * People who will have to make it work
  * (If you cannot name them, then it will be you)
* With a proposal around how it will benefit the company.

When in doubt, seek guidance from your team or an architect. We are here to support you if you require any assistance or advice. We believe in working together and helping each other whenever possible.

## Anti-patterns of architecture

Despite our best efforts, sometimes architects don't get things right. We're sorry, but we're also human, like everyone else. Here's a list of problem archetypes of architects, mainly for fun and giggles.

### Ivory Tower

Too removed from the business of the organisation. They watch from on high and make proclamations while unaware of the plight of the people on the ground. This type of architect seems to create a lot of work, but it's detached from the reality and culture of the business.

### In the trenches

Too focused on their previous role, trench warriors refuse to give up their tactical responsibility and involvement and don't have time or focus for strategy. Sometimes this is because of the current state of the organisation. Sometimes it's because they don't have the exposure to build a picture of a real strategy for the business.

### Overly Academic

Studious and thorough, working through frameworks and quoting luminaries, the academic cannot effectively translate these theories into practical output for the organisation. They talk about possibilities, gold standards, and best practices and sometimes focus on the areas of frameworks which aren't implemented or fully used.

Knowledge and understanding of frameworks are essential, but frameworks are collections of methods that can help. Using strategies to address issues in the business is good sense. Using techniques to address symptomless 'problems' will make no friends.

### Too technical

Often recruited from technical areas, such as IT Operations, the too-technical architect hasn't learned to temper their language to a broader audience. Using too much technical language conversationally can result in getting typecast as another 'techie,' being sidelined from honest discussions and gaining the trust of other parts of the business.

The technical skills are a real boon, though, and help when working with the more technical aspects of the organisation.

### Over-specialized

An architect should have a wide variety of skills and a broad understanding of most areas of their domain. If the field is too large, then specialism is a natural part of that, but an architect should work across as much of the environment as necessary, learning what they can of each part of the organisation.

If an architect only understands IT, they won't be able to effectively talk to Finance Partners or Legal about changes, budgets, or compliance. They may struggle to explain hosting concerns if they only know operations and not development.

Architects often have specialisms, but typically these start to be relinquished after they start becoming architects, moving away from specifics and into broader concepts, so they can better help explain the organisation's mechanics.

## Further Reading

## References
