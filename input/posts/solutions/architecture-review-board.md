---
Title: Architecture Review Board
Lead: Making sensible decisions and Avoiding the Land of Wait.
Description: A coherent ARB can help organisations plan and normalise technology decisions. It can also create a situation where nothing happens, and work goes to die.
Tags:
  - Architecture
  - Business
Categories:
  - Solution
Draft: False
Published: 30/05/2023
---
## Synopsis

A frequent perception of ARBs from Agile teams is poor and that they delay decisions and delivery. Properly implemented, an ARB allows an organisation to be more open and transparent and can empower local decision-making within a team or POD.

## Introducing the ARB

> ### The Agile ARB
>
> I asked ChatGPT to write a story about an [Agile ARB](xref:the-agile-arb) and its pretty good!

An Architecture Review Board (ARB) is a representative group of people across the organisation who take a central role in governing architectural decisions which affect the business significantly.

The ARB aims to mitigate risks to the business and improve strategic planning and awareness, especially around the use of technology and any changes to that. It does this by making it easier for front-line teams to make decisions and simplifying the overall organisation over time to keep cost and complexity at bay. An ARB does not dictate solutions. It provides a constrained space to support fast decision-making.

It is not a Technology Review Board (TRB) and doesn't govern what technology is allowed. It regulates the processes for selecting new technologies, methods, and principles.

Nothing an ARB does should be urgent. An ARB may need to determine a new principle/policy in response to an emerging issue, but such instances should be rare. The ARB should not be too slow or be unable to react quickly, but most things it needs to deal with should be at a level where the business can take some time to think about them.

Lastly, an ARB will meet and align following annual updates, strategic updates, or quarterly reviews. In a product-led organisation, an ARB will outline a strategic runway to ensure technology requirements (enablers) and deliverables are considered and planned following product development needs.

> ### Centralised vs Decentralised Decisions
>
> A successful ARB wants to encourage decentralised decisions as much as possible. That would be, they need to provide guidance, examples and principles that ensure people on the ground can make good decisions whilst they plan and develop processes, product features and changes.
>
>The ARB creates a kind of organisational common sense that reinforces the right way to do things, in-line with company culture and values.
>
> As we all know, [Culture eats Strategy for Breakfast](https://www.thealternativeboard.com/blog/culture-eats-strategy), right?
>
> An unsuccessful ARB controls every decision, which results in an unacceptable level of delay as the ARB becomes overwhelmed with small and largely inconsiquential decisions.

## Purpose

An ARB is for reviewing and governing architecture. In this context, the ARB will make strategic decisions about how to use technology in the business rather than the specifics of what technologies to use.

## Membership

An ARB is a handful of relevant, cross-organizational people. Too mono-culture, and it won't be taken seriously(i.e., too many architects or technologists). Too big, and it won't make any decisions. As a cross-organizational group, it must have a diverse representation from different business areas.

It is not somewhere for architects to meet and talk. All the architects, managers, and technologists should not expect to be involved. They might watch or present in exceptional circumstances or gain exposure by acting as a proxy.

That said, it has to be transparent. Publish all the ARB meetings, minutes, and outcomes to the broadest possible audience. Anyone should be able to raise an issue or request a change to the ARB.

## Format

Its first action should be to review its charter and accept it.

Membership can be flexible, but this should be responsive to events or requirements, not just having a chaotic membership that constantly changes.

Initially, it could be weekly or fortnightly, as there may be a lot of reviews and artefacts to create, in demand to business needs:

* Principles
* Patterns
* Strategic Non-functional Requirements
* Major Developments or Solutions

ARB reviews should only relate to strategic solutions and projects. Most items should be small enough to avoid the ARB, and the ARB should encourage local decision-making over trying to centralise decisions. Centralised decisions should be infrequent and far-reaching.

The board meeting should follow a standard approach for such a meeting to ensure people are comfortable and familiar with it. Frameworks such as COBIT can provide some guidance. Here is a suggestion for an initial format:

* The ARB Meets Monthly and in response to nominated events (PI Planning, annual review, etc.)
* There is a Chairperson who will run and take the lead on ensuring the meeting runs as expected. Ideally, this is the sponsor, but it could be delegated or rotated.
* There is a nominated secretary who takes minutes and actions. Rotate the role, or bring someone in who needs more exposure to the ARB and strategic decision-making. It should be someone capable who will do a good job.
* Start by reviewing previous minutes and actions.
* Review any proposals or actions. Any issues should have been relayed with enough notice so that members could review what they have to before the meeting and come up with questions or requests.
* Most decisions should be able to be approved within the meeting. Deferring too many approvals is terrible.

The ARB doesn't make the decisions. It provides a framework to review and guide them proactively through principles and guidance. Suppose a decision is not being made because there is inadequate direction. In that case, an ARB member should consult with another member and include advice to cover a similar future situation.

## Frequency

Once established, a Monthly or Quarterly format should be sufficient to maintain a manageable level of governance.

ARB Meetings ideally align with any other ceremonies, such as Quarterly Planning or strategic planning, letting the ARB determine whether any specific architectural work is needed, over and above the expected level of involvement, based on upcoming work or projects.

## Outcomes

An ARB should create the following outcomes:

* Requirements for new policies and principles
* Requirements for Strategic Enablers and Capabilities

Typically, work from the ARB would go to the Architecture team to define, complete, or at least manage. Acceptance criteria should be a part of any of these to ensure excessive approval of the outcome is unnecessary.

## Anti-patterns

Here's a selection of ways this can go wrong or things you can do poorly:

1. Excessive Approvals - If you find every ARB is 'full' of things to approve, then your Policies and Principles are likely irrelevant or too granular.
2. Deferred decisions - If the board makes a lot of deferrals, it would usually be because the information or risks are unclear, and they don't feel safe taking them.
3. Poor reputation - The ARB may be something people dread. In this case, it's likely that the process is excessively onerous, too frequent, or that the principles are poorly accepted.
4. Technology Focussed - The ARB shouldn't discuss the choice of technology. It should guide the principles and processes that result in those changes. In this case, the ARB may be too tactical, resulting in low traction across the business.
