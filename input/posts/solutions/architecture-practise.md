---
Title: Overview of the Architecture Practice
Author: James Brewster
Published: 06/06/2023
Lead: Function of an agile architecture practice
Draft: true
Categories:
  - Solution
Tags:
  - Architecture
  - Process
  - Solution
---

Software and sysems architects have typically provided guidance and governance of a tehcnology organisation, by modelling the organisation, its departments, capabilities and processes, and then mapping technology into them, to ensure that the business has a somewhat optimised set environment, which can adapt to its needs and isn't onerous to look after.

This all takes time and it goes against the philosophy of agile, to avoid Big Up Front Design BUFD. How best to support developers in an agile world?

In an agile development organisation, the common concept is 'Emergent Architecture'. But what does that mean? Well, you follow a model more akin to evolution than planning, and interfere if you see things heading for any dead-ends.

## In theory

As development teams self-organise, the architecture role is to support decision making and to make sure good decisions thrive and poor decisions don't.

At the core of this concept, is the ADR, or Architectural Decision Record. Everytime the team make a decision about the how development will proceed, they write it down in their system of work. This is covered in more detail [here](xref:architecture-decision-records).

The architecture team review and steer ADRs. ADRs are like the tweet format of designs, they encompass small decisions and choices with just enough context and reasoning to explain to a new starter why something happened. A major benefit, is that they can all be queried and exported, and used to explaint he thinking over time, and why certain choices were made. This acts as a log, which can be examined to explain the direction a project took.

To help the team make decisions, the Architetcure practice review the ADRs and look for trends and patterns, look for decisions that change often, don't survive or take too long. As certain things come to the fore, these are turned into [principles](xref:principles), [patterns](xref:patterns) and [NFRs](xref:nfrs).

Depending on the type of artefact, these are then reviewed by the ARB or the rest of the architect group and approved, accepted or rejected.

The development teams can use these items to help steer their decisions in future, based on what has worked and not.

## In Practice

## Anti-patterns of agile architecture

## Further Reading

## References
