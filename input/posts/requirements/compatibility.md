---
title: Compatability
description: Ensuring whatever we build has broad compatibility means we build for common target system architecture.
slug: compatibility
tags:
  - Architecture
  - Non-Functional Requirements
  - Requirements
  - NFRs
draft: true
date: 2023-04-24T07:42:26.830Z
---

> Read the [Requirements Check-List](xref:requirements-checklist) article for an introduction to requirements.

## Requirement

The application runs on a Linux-based container, ideally Ubuntu Long Term Support versions, using an x86 architecture. Our preferred development environment is the Microsoft .NET framework.

## Acceptance Criteria

* The software is deployed in a Linux-based container image, compatible with Docker and Kubernetes. The Image should be on our accepted technology register.
* The software targets a currently supported version of the .NET framework.

## Audience

* System designers and software engineers.
* IT Professionals and operational engineers.

## Details

Owner: Chief Technology Officer
Author: James Brewster

## Rationale

As we design and develop new systems, we should make sure they can run on commodity platforms that we know how to use and can easily acquire.

* Linux containers are robust, low cost and easy to manage. they are the most commonly deployed workload in the world.
* Azure is our preferred hosting environment.
* Our developers predominantly write C# code.
* Drives the target deployment system. Too tight and it affects supply and scale. Too restrictive and it becomes harder to grow and support.
* Have a commodity normal environment, which is easy to reproduce.
* Use a readily available architecture, the more commodity the better.
* Host on a 'normal' image. Slowly evolve so everything uses that image.
* Be somewhat specific, but not into the minor versions. Specify minimum versions.
* Stick to using APIs to communicate between services to minimise compatibility issues.
