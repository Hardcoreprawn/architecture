---
Title: Release Strategy
Lead: Deliver work often and reliably.
Description: The entire aim of software development is to create usable features in apps and get them to your customers.
Tags:
  - Architecture
  - Business
  - Solutions
Categories: 
  - Solutions
Draft: False
Published: 29-08-2023
locale: en-GB
---

## Introduction

Regular releases are important in software development for several reasons. One of the major reasons is that it helps to ensure that critical security patches and fixes are applied. By regularly updating their software, businesses can reduce the risk of data breaches, malware infections, and other security incidents.

It helps to improve the quality, speed, and efficiency of building or updating software by focusing on release management. This is the process of planning, scheduling, and managing a software build through the stages of developing, testing, deploying, and supporting the release. Techniques like Agile development, continuous delivery, DevOps, and release automation have helped optimize release management.

Advocates argue that releasing early and often allows the software development to progress faster, enables the user to help define what the software will become, better conforms to the users’ requirements for the software, and ultimately results in higher quality software. 

## Software Development Models

There are several common Software Development Lifecycle (SDLC) models, terms and some patterns that we should discuss before we start looking at how to plan, develop and release software.

* Waterfall Model: A linear, sequential approach to software development that follows a series of steps in a specific order. Each phase must be completed before the next one can begin. This model is best suited for projects with well-defined requirements and where changes are unlikely to occur frequently.
* V-Model: This model is similar to the waterfall model, but it emphasizes testing at each stage of development. The V-model is useful for projects where quality control is a top priority.
* Agile Model: This model emphasizes flexibility and collaboration between developers and stakeholders. It involves breaking down the project into smaller, more manageable chunks called sprints, which are completed in short cycles. The most popular forms are Scrum, Extreme Programming and Kanban.
* DevOps model: This model emphasizes collaboration between development and operations teams to improve the speed and quality of software delivery. It involves automating the entire software delivery process, from development to deployment.
* Continuous Delivery model: This model focuses on delivering software in small increments, with each increment being tested and released as soon as it’s ready.

![Popular SDLC Models](https://www.scnsoft.com/blog-pictures/custom-software-development/8-software-development-models.png)
[ScienceSoft](https://www.scnsoft.com/blog/software-development-models) lists some others as well. It's worth a read.

>Based on their research, they also state that the average cost and quality of waterfall projects are worse, with double the total cost of ownership (TCO) over five years, significantly more defects delivered and a higher initial cost.

That aside, each of these models has a place, it's not necessarily a ladder or race to the *best* option. 

* Continuous delivery has been very successful for large web platforms, but it may simply not be necessary or possible for smaller teams or less dynamic systems. 
* The V-Model is great for Aerospace development and other high-safety environments, where things just can't go wrong.
* Kanban (the simplest agile model) works well when there is little roadmap, and the backlog is thin.
* Waterfall is the 'best' option for a client who knows what they want and wants to lock in what they spend upfront. If someone is this certain they know the score, let them be. Take their money and meet their requirements.

Using any of these models requires management buy-in and understanding, as detailed requirements up-front can present a hurdle to teams trying to work in agile, and it can mire the team in development hell.

An important thing to remember with any framework is the axiom 'If in doubt, leave it out!'. This simple rhyme will save you from trying to shoehorn fixes for problems you don't have, onto your business.

## Versioning

How do you keep track of revisions and versions? That is what we'll try to tackle next.

### Semantic Versioning

Semantic versioning uses a structured number system, such as 1.2.3

The first number is the Major release, the second a minor release and the third a sub-minor release.

Think of a simple drawing of a tree. At the base, you have the trunk and root, and then you have one or more branches, with one or more branches coming off of that. The major branches of the trunk are your major versions, which have a defined, stable interface. The Minor branches off that, use the same defined interfaces. If you change the interface, you need to define a new major branch and potentially plan to remove the previous version.

This approach has been used since time immemorial. It is predictable and easy to follow. It can cause issues when you have customers on older versions or when you need a roll a fix out to all your customers, and they have a mix of versions, and you have to test against all of them...

Semantic versioning is a good standard to follow, but it's not very customer-friendly. Within your own organisation and service management teams, it works well and allows you to track changes, fixes and releases over time in line with frameworks such as the Information Technology Infrastructure Library (ITIL).

### Sequential Versioning

Historically, this has been one of the most loosely defined ways to version software. A string of numbers and/or letters would be used to define the version. This would increment based on the compatibility, the quantity of additional code, the alignment of the stars, or whether marketing thought there was a good reason. This model is quite chaotic.

### Versioned Interfaces

One of the issues with versioning and releasing software is when changes break functionality customers have been using and cause them to have to re-integrate, redo the integration, or prevent a third-party integration from working at all.

API versioning removes part of this issue. Ensuring all public interfaces (i.e. ones outside the developing team) use a managed API, with a version and a contract (such as Swagger or OpenAPI). The contract is more than a document, it is a structured, machine-readable document, which outlines the version, changes and functions of the API.

## Relevant Patterns and other models

The following patterns and models don't necessarily categorise as well, but they are all part of the big picture of releasing products.

### Continuous Integration & Continuous Deployment

Often called CI/CD. Traditional Integration is done during the run-up to a release and involves making sure all the different elements of a program, developed across several developers or teams work together. Unsurprisingly, it often doesn't and much confusion and delay follow as people try to get these things talking to each other.

Continuous Integration works by committing changes to a common branch as changes are committed. Developers are encouraged to commit regularly, comment on what they changed, test/review the log and then move on to the next task.

Typically, teams that use continuous integration have more predictable delivery, as each change is tested and committed frequently. This results in faster problem resolution, and an avoidance of integration work towards the release deadline.

Continuous Deployment is the process of pushing an integrated code change into a usable environment, where its functionality can be verified or used. It's quite common to have several branches of code and each of these will possibly need a deployment, where the functionality can be tested holistically.

By combining these two things, we can make sure changes are added to the code base, tested and integrated, and deployed to an environment for testing, UAT or demonstration.

The primary goals of these ideas are: 

1. To reduce risk
2. improve feedback to the developer. 

By testing more often and by deploying more frequently, more is learnt about the process, so it becomes well-tested and more reliable.

### Release Automation Pipelines

The model for implementing CI/CD is often called a pipeline. In a way, this is a good analogy, as the code flows through the pipeline, with different processes occurring as it moves.

A typical pipeline will provide feedback loops, which report any failures back to the developer. Typically they will start with small, quick tasks; items such as unit or smoke tests, which can be reported on quickly, before moving on to higher risk, harder tests or such.

### Hybrid Models

Many above models can work together, coexisting, complementing or complicating as necessary. Having a simple model, which is widely used in your organisation is the best answer. Something everyone can understand easily and work with. Most of us are not so lucky, so compromises are often needed.

A good compromise is to use versioned interfaces, over whatever versioning scheme the individual service/application uses. Each development product has its versioning scheme. New products should follow a defined model, as they are based on a common Software Lifecycle. Older products or acquired products won't have that luxury, so pragmatism should win over trying to fit everything together.

This is probably the most pragmatic model. It ensures that teams remain independent and dependencies between services remain low. An API Gateway pattern can help to manage and list these interfaces together, using a developer portal as a catalogue.

>This feature was seen as so critical to the future success of a young Seattle-based book company, that its CEO offered to fire anyone who disagreed or went against it (Amazon). [https://nordicapis.com/the-bezos-api-mandate-amazons-manifesto-for-externalization](The Bezos API Mandate)

### Recommendations

Segregating internal releases from exposed releases is a great idea to help keep the system and customer concerns separate. Ensuring that all programming interfaces are versioned **at the API** allows for a lot of agility in how issues are resolved and updates made, without breaking the customer experience or causing undue stress.

By separating these concerns, version management within the service also becomes easier.

In almost all cases, the author would recommend allowing a development team to self-organise a release model that works for them, but would also recommend the company adopt a standard that can work for ~80% of cases, with some minor variation if necessary.

* Use API versioning for public interfaces. That's an interface outside of the service, whether used by another internal team or a customer.
* Have a consistent, meaningful, simple version scheme internally to the application, which relates to your code versions.
* Try to follow a sensible normal scheme so your colleagues can follow along easily.

## What about market releases?

Software releases tend to mean different things to different people.

* To a developer, a release could be done when the change is committed to the source code repository.
* To a tester, it could be done when the tests are completed successfully.
* To an Infrastructure engineer, it could be done when loaded and running.
* To the business, it's when the market reacts to the feature and there is a change in dynamics (more sales, better reviews, etc.)

The author has a very strong opinion on this. Any work which is not in the hands of your customers is 'untested'. You have yet to deliver any value, or any return until that feature is in use and you have active feedback from users/customers.

To answer this, we introduce the concept of a market release. On a regular cadence, the organisation ships completed features to the market. Regularity is important. Most other businesses try to care as little as possible about your business, generally, you don't want to upset, alarm or confuse them.

These features should have been tested with some real customers, either safe ones, or the ones who asked for it/needed it, before it goes on the general release. This way you can minimise the risks of a 'cold' launch.

This work needs to be celebrated in the market too! Make sure your customers know you are doing these things for them. Make sure they have an idea they are coming and you can create some hype/awareness about them, which can segway into training or articles if necessary, so when they arrive, they are anticipated, rather than confusing. This can make sure your competitors know about it, and your wider market and analysts know as well.

Change fatigue is a real thing, especially for B2B software. Release as often as you want, but don't 'stress' the customer by making so many changes it affects their ability to use your software to make or save them money.

## Separating Releases from Releases

Depending on the SDLC model in use, a release can mean wildly different things. Releasing code at the end of an iteration can mean passing it to a testing team. Or it can mean committing to the main branch of source code.

But in a product sense, release means when it hits the market.

So, let's separate the two items to stop conflation.

* Updates are code changes made every iteration, tested and integrated, fitting the delivery teams' 'definition of done'.
* Releases are bundles of updates we make available to the market, which a business can periodically deliver in a planned and managed fashion, with appropriate fanfare.

What does this mean for Software as a Service type applications? Well, we should release the updates as soon as we can. But we want to use feature flagging to hide them from view. At some point, we want to enable the feature for a group of users.

This creates a new release model the 'channels' approach. Widely used by Microsoft, amongst others. Each development branch that leaves testing goes through groups of users with varying risk appetites and update frequency:

1. First Channel users are typically internal as the expectation is the features may not work as expected. These can receive releases monthly or faster.
2. Second Channel users are early adopters who are testing the feature in production use. Typically these get new releases every two or three months.
3. Production Channel users are on a reasonably well-tested and stable version, with a reasonably low wait on new features and changes. 
4. (Optional) Long-Term Support (LTS) Channel users are on a stable version, which has been through the above stages.

The above can work with as few as two channels, or as many as five or more. The above channels are all hosted on the production platform; they are all treated and run as production systems. You may limit the number of customers you allow on earlier channels, to ensure you can support them appropriately. You might also 'hide' the LTS option unless it's for larger or problematic customers.

Microsoft has experimented with several release channel frequencies since they started using the model, and for most platforms, it tends to be regular updates to security and such, with semi-annual 'releases' of new features, on the Production channel. Some of their products have as many as six channels, which may get bi-weekly, or monthly updates. Where LTS Channels exist, they often only get annual feature releases, with monthly patches and updates, to minimise any disruption.

The important point here is to separate the dependency between software release and market release. We know software releases are more stable and lower cost when they are released quickly and when development teams can focus, test and deliver in small batches. It's been proven since the 1960s. But we also know that launching a feature requires timing and control to make sure it lands correctly.

## Release Standards

Having release standards in place simplifies the task of releasing software. Ensuring software has passed a certain threshold for quality is good for everyone to understand.

> A friend who works in automotive engineering once told me that a car company was unhappy with prototypes made in a new engineering plant, as they were too high quality and as such, would be too expensive or skilled to make sustainably.

This threshold depends on the business, but an organisation should typically capture release standards and have them blanket apply to all releases, with an option for a waiver, if the standard is irrelevant or overly onerous.

Non-functional requirements are one way to manage release standards, which makes use of an existing idea in the business. Having an adaptable list of these available and described in a testable way allows for automated testing and simplifies the release process.

## Release Governance

Having bifurcated our releases and defined a set of standards that can be used to define something as 'ready', we should have a simpler time governing releases.

Each of our types has a similar, but different path to get to its audience. The governance process for each path should differ, based on the risk and severity of the release types.

### Governance for Updates

Updates are lower-risk changes. Defining that a given release will only contain updates (i.e. no breaking UI changes or major market features) means the delivery team can use a lighter-weight version of the release process, which looks to automate as much as possible and to deliver working, tested code into production. This allows dependencies, fixes and patches to arrive swiftly and be tested en masse.

### Governance for Releases

Market Releases are higher risk/higher reward affairs. Because of this, we need to make sure they arrive promptly, safely and well-advertised. There should be few surprises, only an amount of expectation, and hopefully delight.

These larger items would require more extensive UAT and single/limited customer releases. As the delivery is done through feature flags in the production environment, the stability would have been tested; several could have been delivered in updates months ago, but the use experience doesn't have to change until the market is ready, willing and ready to pay for it.

## Proposed Changes

## References

Shiklo, B. (2019) 8 Software Development Models: Sliced, Diced and Organized in Charts, Scnsoft.com. ScienceSoft. Available at: https://www.scnsoft.com/blog/software-development-models.

‌Nordic APIs. (2021). The Bezos API Mandate: Amazon’s Manifesto For Externalization | Nordic APIs |. [online] Available at: https://nordicapis.com/the-bezos-api-mandate-amazons-manifesto-for-externalization/.