---
Title: Using a monorepo for hosting Azure Bicep IaC
Lead: Using a GIT Monorepo to host Azure IaC for a whole organisation
Description: Faced with building lots of projects for a move to the Azure cloud, using Infrastructure as Code (IaC) and a Monorepo seemed daunting, but made sense.
Tags:
    - Application
    - Technical
Categories:
    - Solutions
Draft: true
Published: 2024-09-20T12:03:19.145Z
Author: James Brewster
locale: en-GB
keywords:
    - Azure
    - monorepo
---

# Using an Azure monorepo to host all my IaC templates
When faced with the choice of how to store all the code needed to build an enterprise IaC deployment as you move services to the cloud, there were a lot of options. At first, we started with individual projects. which soon seemed to be spirally out of control. Each project needed to edit a firewall in a different place, or join a different network. The sprawl of module,s and managing how we replicated and updated them quickly became painful.

## What is a monorepo?
You may or may not have heard the term, but a monorepo is simply that. One big repo, for everything thats related. A monorepo becomes quite complex, but thats a lot easier than having many, many individual repo's with all of their overlaps. When you have a team with a wide coverage, then it makes sense to host all their work together. If you split that team later, then you can decide how to segredgate subsets of the repo, if need be.

## Why would you use a Monorepo for IaC?
IaC, Infrastructur eas code, is the term given for (usually) cloud infrastructre, defined in text templates and manipulated into place. Usually through a mix of templates, scripts, definitions and parameters.

Usually, I start by defining the generic things I need, or am likely to need, several of. Things like:
* VMs
* Storage accounts
* Networks
* Databases
These become my modules.

Then I think about how to assemble those into applications or services. These are my definitions. A Definition in BICEP is basically a way of calling all the generic templates, and overlaying the specific configurations. An application might need to join an existing network, require a database, and a linux VM. In a definition I will define the modules and new/basic resources I need:

> module network ... = {
    ...
}
> module database ... = {
    ...
}
> module vm ... = {
    ...
}

Now, my modules might all define specific things, what flavour of linux, whether it has a public IP, what disk or CPU options are allowed, etc. These constraints help me guide development and make sure we're falling into a smaller set of options, without loosing too much flexibility.

When I want to define a new application, I can take either a Template (a 'blank definition) and start from there, or copy an existging, similar definition, and define a new one, suing the existing modules.

## Parameters
Whilst a lot of best practise around IaC does revolve around how you use parameters to make things portable, I have tried to stick to using parameters for environment settings, or for different stages int he dev journey. I know what I want my production results to look like in a lot of cases, and coding those into my definitions is not a difficult thing, and actually makes it easier to compare in future.