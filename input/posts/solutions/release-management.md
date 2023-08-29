---
Title: Release Strategy
Lead: Deliver work often and reliably. Make sure to tell your customers!
Description: The entire aim of software development is to create usable features in apps and get them to your customers.
Tags:
  - Architecture
  - Business
  - Solutions
Categories: 
  - Solutions
Draft: False
Published: 01-09-2023
---

## Introduction

Regular releases are important in software development for several reasons. One of the major reasons is that it helps to ensure that critical security patches and fixes are applied. By regularly updating their software, businesses can reduce the risk of data breaches, malware infections, and other security incidents.

It helps to improve the quality, speed, and efficiency of building or updating software by focusing on release management. This is the process of planning, scheduling, and managing a software build through the stages of developing, testing, deploying, and supporting the release. Techniques like Agile development, continuous delivery, DevOps, and release automation have helped optimize release management.

Advocates argue that releasing early and often allows the software development to progress faster, enables the user to help define what the software will become, better conforms to the users’ requirements for the software, and ultimately results in higher quality software.

## Release Models

There are two major release models, and some associated patterns which are important to understand.

### Major/Minor Versions

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

## Current State

Everflow have a release pipeline in place, which allows them to release changes at the end of a development sprint. These releases are tested and integrated to the main production branch.

## Release Types

## Release Standards

## Release Governance

## Proposed Changes
