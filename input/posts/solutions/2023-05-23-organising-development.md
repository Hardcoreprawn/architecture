---
Title: "Organising Work"
Lead: "How do you structure work?"
Description: "Some words"
Tags: []
Categories: []
Draft: True
Published: 01-01-2001
---
## Work Item Types

Work items in development tend to fall into three broad types, but the names tend to change, depending on the place, process or tools used. The most common types are:

1. Requirements / User Stories / Issues - The smallest unit of work. Intended to be sized so that a team can manage 1+ in the smallest unit of time (usually a sprint), but purely for convenience.
2. Features - Groups of requirements, stories or Issues which can be delivered in time for the next release. Some frameworks use 'Capabilities' as a feature which has to be delivered by more than one team because there is a dependency. This should be avoided, but worth knowing about.
3. Epics / Initiatives / Projects - Big themes or ideas with significant market value, which generally require special investment. Usually made of a load of features. Generally, an Epic is formed as an idea with a significant outcome, explored and tested as a high-level concept, before being broken down into features.

This said the best practice with agile development is to minimise and factor down work as you get closer to development. Try and avoid big projects. The structures above can be helpful for management or executive discussions, especially with larger teams. Just remember that you want to give developers small, well-formed requirements, not vacuous epics.

## Requirements / User Stories / Issues

The smallest unit of work. Requirements are discussed in more depth [here](xref:requirements-checklist).

NASA have a great page on defining a good requirement [here](https://www.nasa.gov/seh/appendix-c-how-to-write-a-good-requirement/).

Requirements need to be Clear, Complete, Compliant and Consistent. They should state assumptions and have clear acceptance criteria. They should express the persona to who the requirement applies, where necessary.

### Loaded terms

In a requirement, you often use loaded words to express importance. These terms are worth managing:

1. Must - Critical to the success of the solution
2. Should - Required for completeness, but optional for testing
3. Could - Optional, but good to have.
4. Won't - Considered and avoided. May require more data to verify.

### Example Requirements

1. The application should load and refresh within 2 seconds. - Whilst we could release or test without this, for scale and production use we feel its critical.
2. The user interface should follow the corporate brand guidance.
3. The application must partition individual broker data. - Without partitioned data, this application won't work or teach us anything.
4. The database could work across one or more cloud providers. - We think there is value in supporting this, but not at the expense of delaying the release.
5. The application won't support internationalisation. - Whilst often a good practice, it can be time-consuming. If we know this app will only be used in English, that time might be better used.

## Features

Features are releasable groups of requirements. It may be a natural collection of things which are needed to make the whole useful or complete. A feature should have a tangible value, which can be tested and expressed. Prioritisation happens at the feature level, with delivery teams structuring the order of requirements into an iteration of work (sprint or whatever).

There's no fixed size, they can be bigger or smaller. If a feature takes multiple sprints to develop that's okay, but it needs to be iterated and testable at each point. The team should be learning about the right way to deliver the feature. There must be some ability to reflect on what went well and what didn't, to make sure there is a culture of improvement.

## Epics / Initiatives / Projects

Agile dislikes large things. Executives love them. Epics/Initiatives/projects exist to allow larger-scale themes and ideas to exist and abstract communication. They are typically used as shorthand when discussing portfolio packages of work, or work which happens across multiple quarters or years.

Depending on the framework, some types (Themes mainly) are very long-lived. Most organisations struggle with this concept and most non-agile execs prefer clear end states for projects.

## Releases

Releases happen when work is done and ready to be given to a customer. It could be an early release to just 1-2 customers for testing purposes. It could be a production release with lots of new features. It depends on the market, the organisation and the process.

Some agile philosophy talks about having smaller releases. This can be good in some situations, but it requires an extensive test framework to guarantee everything works. Philosophies like CI/CD are intended to reduce manual overhead and make sure work can be delivered quickly from developers into a live environment.

Some customers or markets don't like rapid change. In regulated and controlled environments, change can require a whole raft of retraining or recertifying, which can increase the cost of a release for the customer. To that end, release cadence is largely dictated by change tolerance, change fatigue and release maturity.

Whilst some people or places will talk about moving to 'release-on-demand' or having a CI/CD process. It is not essential. It does have benefits, but also overheads.

## Time-To-Value

An important release metric/feature metric is time to value. Understanding how quickly an organisation can get value from its investment in development is critical to success as a Product manager; I would argue that this is a key concern. To improve Time-To-Value:

* Keep features small. As small as you can. Dev/Architecture will add loads of requirements anyway.
* Minimise requirements to -just- the essentials, easier to add more later.
* Articulate requirements clearly and consistently.
* Deliver one feature at a time to minimise work in progress.
