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
locale: en-gb
---

## Introduction

Regular releases are important in software development for several reasons. One of the major reasons is that it helps to ensure that critical security patches and fixes are applied. By regularly updating their software, businesses can reduce the risk of data breaches, malware infections, and other security incidents.

It helps to improve the quality, speed, and efficiency of building or updating software by focusing on release management. This is the process of planning, scheduling, and managing a software build through the stages of developing, testing, deploying, and supporting the release. Techniques like Agile development, continuous delivery, DevOps, and release automation have helped optimize release management.

Advocates argue that releasing early and often allows the software development to progress faster, enables the user to help define what the software will become, better conforms to the users’ requirements for the software, and ultimately results in higher quality software.

## Release Models

There are two major release models, and some associated patterns which are important to understand.

### Major/Minor Versions

Also known as Semantic Versioning. Think of a childs drawing of a tree. At the base, you have the trunk and root, then you have one or more branches, with one or more branches coming off. The major branches off the trunk are you major versions, which have a defined, stable interface. The Minor branches off that, the stick to the same defined interfaces. If you change the interface, you need to define a new major branch and potentially plan to remove the previous version.

This version has been used since time immemorial. It is predictable and easy to follow. It can cause issues when you require a customer to tell you what version they have, or when you need a roll a fix out to all your customers.

Semantic versioning is a good standard to follow, but its not very customer friendly. Within your own organisation and service management teams, it works well and allows you to track changes, fixes and releases over time in-line with frameworks such as the Information Technology Infrastructure Library (ITIL).

### Sequential Versioning

Historically, this has been one of the most loosely defined ways to version software. A string of numbers and/or letters would be used to define the version. This would increment based on the compatibility, the quantity of additional code, the alignment of the stars, or whether marketing thought there was a good reason. This model is quite chaotic.

### Versioned Interfaces

One of the issues with versioning and releasing software is when changes break functionality customers have been using and cause them to have to re-integrate, or redo the integration, or prevent a third-party integration from working at all.

API versioning removes part of this issue. By ensuring all public interfaces (ie ones outside the developing team) use a managed API, with a version and a contract (such as Swagger or OpenAPI). The contract is more than a document, it is a structured, machine readable document, which outlines the version, changes and functions of the API.

### Continuous Integration & Continuos Deployment

Often called CI/CD. Traditional Integration is done during the run up to a release, and involves making sure all the different elements of a program, developed across several developers or teams works together. Unsurprisingly, it often didn't and a large period of time would follow, where people tried to get these things talking to each other.

Continuous Integration works by committing changes to a common branch as changes are commited. Developers are encouraged to commit regularly, comment what they changed, test/review the log and then move on the next task.

Typically, teams which use continuous integration have more predictable delivery, as each change is tested ad commited frequently. This results in faster problem resolution, and an avoidance of integration work towards the release deadline.

Continuous Deployment is the processes of pushing an integrated code change into a usable environment, where its functionality can be verified or used. Its quite common to have several branches of code and each of these will possibly need a deployment, where the functionality can be tested holistically.

By combining these two things, we can make sure changes are added to the code base, tested and integrated, and also deployed to an environment for testing, UAT or demonstration.

The primary goals of these two ideas is to reduce risk, and improve feedback to the developer. By testing more often, by deploying ore frequently, more is learnt about the process, it becomes well tested and drilled.

### Release Automation Pipelines

The model for implementing CI/CD is often called a pipeline. In a way, this is a good analogy, as the code flows through the pipeline, with different processes occurring as it moves.

A typical pipeline will provide feedback loops, which report any failures back to the developer. Typically they will start with small, quick tasks; items such as unit or smoke tests, which can be reported on quickly, before moving on to higher risk, harder tests or such.

### Hybrid Models

A lot of the above models can work together, coexisting or complicating as "necessary".

It goes without saying, having a simple model, which is widely used in your organisation is the best answer. Something everyone can understand easily and work with. Most of us are not so lucky to live that, so compromises are often needed.

A good compromise is to use versioned interfaces, over whatever versioning scheme the individual service/application uses. Each team can manage versioning as the product is, possibly with some definition or structure, but externally all communications are done via the versioned API.

This is probably the most pragmatic model. It ensures that teams remain independent and dependencies between services remain low. An API Gateway pattern can help to manage and list these interfaces together, using a developer portal as a catalogue.

This feature was seen as so critical to the future success of a young Seattle based book company, that its CEO offered to fire anyone who disagreed or went against it (Amazon).

## Current State

Everflow have a release pipeline in place, which allows them to release changes at the end of a development sprint. These releases are tested and integrated to the main production branch. Production changes are rolled out at a later date, once the business has agreed to them, and training has been undertaken.

An API Gateway is in use, but there's no unified dev portal. Each contract and API needs to be accessed individually, with minimal ability to list or discover.

### Recommendations

Segregating internal releases from exposed releases is a great idea to help keep the system and customer concerns separate. Ensuring that all programming interfaces are versioned at the API allows for a lot of agility in how issues are resolved and updates made, without breaking the customer experience or causing undue stress.

By separating these concerns, the version management within the service also becomes easier.

In almost all cases, the author would recommend allowing a development team to self-organise a release model which works for them, but would also recommend the company adopt a standard which mostly works for everyone, with some minor variation if necessary.

* Use API versioning for public interfaces. Thats any interface outside of the service, whether used by another internal team or a customer.
* Have a consistent, meaningful, simple version scheme internally to the application, which relates to your code versions.
* Try to follow a sensible normal scheme so your colleagues can follow along easily.

## What about market releases?

Software releases tend to mean different things to different people. A release can be shipping tested, working code to the next person along the pipeline. Who may then run a load of tests and pass it along to the next.

It should mean delivering the developed features to the market.

The author has a very strong opinion on this. Any work which is not in the hands of your customers is 'untested'. You have yet to deliver any value, or any return, until that feature is in use and you have active feedback from users/customers.

To answer this, we introduce the concept of a market release. On a regular cadence, the organisation ships completed features to the market. Regularity is important. Most other businesses try to care as little as possible about your business, generally, you don't want to upset, alarm or confuse them.

These features should have been tested with some real customers, either safe ones, or the ones who asked for it/needed it, before it goes on the general release.This way you can minimise the risks of a 'cold' launch.

This work needs to be celebrated in the market too! make sure your customers know you are doing these things for them. Make sure they have an idea they are coming and you can create some hype/awareness about them, which can segway into training or articles if necessary, so when they arrive, they are anticipated, rather than confusing. This can make sure your competitors know about it, your wider market and analysts know as well.

Change fatigue is a real thing, especially for B2B software. Release as often as you want, but don't 'stress' the customer by making so many changes it affects their ability to use your software to make or save them money.

## Release Types

## Release Standards

## Release Governance

## Proposed Changes
