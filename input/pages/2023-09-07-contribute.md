---
NavBarTitle: Contribute
Title: Contribute to Open-EA
Lead: Instructions for commenting, editing and adding your content to the repo.
Description: Instructions and guidance for editing and adding pages to the Open-EA repository.
Tags:
  - Solutions
Categories: []
Draft: false
Published: 2023-09-07T08:49:31.449Z
Author: "James Brewster"
locale: "en-GB"
---

## How to contribute to Open-EA

Thank you for your interest in contributing to Open-EA.

Open-EA uses Github as a source repository and as such can be accessed on my personal Github account[https://github.com/Hardcoreprawn/architecture](https://github.com/Hardcoreprawn/architecture).

All the content is written in Markdown and uses Frontmatter CMS to define the pages.

## Content Structure

The content all exists in the /input/ folder, split into pages and posts.

Pages are structural, the navbar links and such. They have minimal change.

Posts are effectively just blog posts on topics of interest. I've split them into four loose categories:

* Patterns - Models for systems. Theoretical.
* Principles - Guidelines to help people make decisions and set the tone.
* Requirements - Things you have to do. The elements of problems.
* Solutions - Ways to fix problems. Practical.

I'm open to creating more, but this seemed a good place to start.

## CI/CD

Approved changes use Github actions to publish the site to an Azure Static Website. I have had the whole thing working with Azure DevOps as well, but GitHub is easier and offers better public collaboration.

One of the actions which is run is a dotnet build of the Statiq.Web site. This rather excellent thing uses document pipelines to structure the frontmatter and content together and create the output html files. I am a rather large fan of Statiq.

## Tools

I use VS Code to edit content. I've started to set up a dev container to make maintaining the environment easy, but so far I've only covered the very basics.

I've found the following extensions helpful:

* Grammarly (paid)
* CSpell (free)
* markdownlint
* Front Matter CMS

As I get time, I'll improve integration and instructions, so please bear with me.

-JB
