---
title: Performity
description: Ok, its forced. But performance of an application is critical to how well it performs the jobs a user needs to do.
tags:
  - Non-Functional Requirements
  - Requirements
  - NFRs
---

Applications need to perform within the expectations and requirements of a user. Most users will give up on a website if its even a few seconds delayed. On the other hand a responsive site encourages engagement.

* It's important to understand the expected workload of your system and the expected growth. This needs to be a baseline, expected service for a given user.

* Do expect it to be successful, but don’t build in excess fixed resource; that's just wasteful. Make sure performance and scalability are considered together.

* Ignore third party delivery times. You need to either find a service which meets your Requirements or you need to use an adequate pattern to abstract this. You have minimal control of the service, so ensure you protect yourself form it.

Typically, we would look at the 95th percentile of results for these, so you don't have to be 100% perfect, but you should be 95% on target, with an aim to be 100%.
    a. A user login to the system should complete within 1 second.
    b. All pages should render 'on the glass' within 1 second.
The system can support at least 25 concurrent page 'views' per second.
