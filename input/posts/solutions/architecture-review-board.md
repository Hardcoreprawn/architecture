---
Title: Architecture Review Board
Lead: Making sensible decisions and Avoiding the Land of Wait.
Description: A coherent ARB can help an organisation plan and normalise technology decisions. It can also create a situation where nothing happens and work goes to die.
Tags:
  - Architecture
  - Business
Categories:
  - Solution
Draft: true
Published: 2023-05-30T10:55:09.166Z
---

## Synopsis

## Introducing the ARB

An Architecture Review Board (ARB) is a representative group of people, across the organisation who take a central role in governing architectural decisions, which affect the business in a significant way.

The purpose of the ARB is to mitigate risks to the business and to improve strategic planning and awareness, especially around the use of technology and any changes to that.

It is not a Technology Review Board (TRB) and doesn't govern what technology is allowed. It governs the processes for accepting new technologies, and for how processes and principles govern selection.

Nothing an ARB does should be urgent. An ARB may need to determine a new principle/policy in response to an emerging issue, but such instances should be rare.

Lastly, an ARB is going to meet and align, following things like annual updates, strategic updates or quarterly reviews. In a product-led organisation, an ARB is going to outline a strategic runway to ensure technology requirements (enablers) and deliverables are considered and planned following the needs of product development.

> ### Centralised vs Decentralised Decisions
>
> A success ARB wants to encourage decentralised decisions as much as possible. That would be, they need to provide guidance, examples and principles that ensure people on the ground can make good decisions whilst they plan and develop processes, product features and changes. The ARB creates a kind of organisational common sense that reinforces 'how we do things here'.
>
> An unsuccessful ARB controls every decision, which results in an unexpectable level of delay and waiting as the ARB becomes overwhelmed with small and largely inconsiquential decisions.

## Purpose

An ARB is for reviewing and governing architecture. In this context, the ARB will make strategic decisions about the way technology is used within the business, rather than the specifics of which technologies are used.

## Membership

As a cross-organisational group, for an ARB to be successful, it has to have a diverse representation from different areas of the business.

It is not somewhere for architects to meet and talk. All the architects, managers and technologists should not expect to be involved.

That said, it has to be transparent. All the ARB meetings, minutes and outcomes should be published with the broadest possible audience. Anyone should be able to raise an issue or request for change and have the opportunity for it to be considered.

## Format

AN ARB should be made of an odd, prime number of relevant, cross-organisational stakeholders. If the membership is mono-culture (ie too many architects or technologists) then it won't be taken seriously. It needs an odd number so votes work as they should. Prime numbers just help avoid simple divisions and ties. 5 or 7 are good numbers. Beyond this, the group is very large and thus cumbersome.

Its first action should be to review its charter and accept it.

Membership can be flexible, but this should be responsive to events or requirements, not just having a chaotic membership which changes all the time.

Initially, it could be weekly or fortnightly, as there may be a lot of reviews and artefacts to create, in demand to business needs:

* Principles
* Patterns
* Strategic Non-functional Requirements
* Major Developments or Solutions

I deliberately call out developments or solutions. This should only relate to strategic solutions and projects. Most items should be small enough to avoid the ARB and the ARB should encourage local decision-making over trying to centralise decisions. If a decision has to be made centrally, then it should be infrequent and have a broad effect.

The board meeting should follow a standard approach for such a meeting, to ensure people are comfortable and familiar with it. Frameworks such as COBIT can provide some guidance. Here is a suggestion for an initial format:

* The ARB Meets Monthly and also in response to nominated events (PI Planning, annual review, etc.)
* There is a Chairperson who will run and take the lead on ensuring the meeting runs as expected. Ideally, this is the sponsor, but it could be delegated or rotated.
* There is a nominated secretary who takes minutes and actions. This could be rotated, but it must be done properly, so it should be someone capable who will do a good job.
* Start by reviewing previous minutes and actions.
* Raise issues that have been brought forward. Any issues should have been brought with enough notice so that members can review what they have to before the meeting and come up with questions or requests.
* Most decisions should be able to be approved within the meeting. Deferring too many approvals is bad.

The ARB doesn't make the decisions. It provides a framework to review decisions and to guide them proactively, through principles and guidance. If a decision is not being made, because the guidance is not adequate, then an ARB member should be empowered to make it, in consultation with another member, and with a view to including guidance to cover a similar situation.

## Frequency

Once established, a Monthly or Quarterly format should be sufficient to maintain a manageable level of governance.

This would ideally align with ceremonies such as Quarterly Planning, letting the ARB determine whether any specific architectural work is needed, over and above the normal level of involvement, based on upcoming work or projects.

## Outcomes

An ARB should create the following outcomes:

* Requirements for new policies and principles
* Requirements for Strategic Enablers and Capabilities

These items would be created, as necessary, by architects. Acceptance criteria should be a part of any of these, to ensure excessive approval of the outcome is unnecessary.

## Anti-patterns

Here's a selection of ways this can go wrong, or things you can do poorly:

1. Excessive Approvals - If you find every ARB is 'full' of things to approve, then your Policies and Principles are likely irrelevant or too granular.
2. Deferred decisions - If the board makes a lot of deferrals, it would usually be because the information or risks are unclear, and they don't feel safe taking them.
3. Poor reputation - The ARB may be something people dread. In this case, it's likely that the process is excessively onerous, too frequent or that the principles are poorly accepted.
4. Technology Focussed - The ARB shouldn't be discussing the choice of technologies to be used. It should guide the principles and processes that result in those changes. In this case, the ARB may be too low level, resulting in low traction across the business.
